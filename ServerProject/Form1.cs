using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Data.SqlClient;

namespace ServerProject
{
    public partial class ServerForm : Form
    {
        private TcpListener serwer = null;
        private TcpClient klient = null;
        private string adresIP = "127.0.0.1";
        private BinaryReader czytanie = null;
        private BinaryWriter pisanie = null;
        private bool polaczenieAktywne = false;
        private string _connectionString = "Data Source=LAP020\\sqlexpress; Database=ProgZaaw; User ID=sa; Password=1z2x3cVBN%";

        public ServerForm()
        {
            InitializeComponent();
            IPHostEntry adresyIP = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress pozycja in adresyIP.AddressList)
                comboBoxAddress.Items.Add(pozycja.ToString());
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (polaczenieAktywne == false)
            {
                polaczenieAktywne = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                polaczenieAktywne = false;
                if (klient != null)
                    klient.Close();
                serwer.Stop();
                backgroundWorker1.CancelAsync();
                if (backgroundWorker2.IsBusy)
                    backgroundWorker2.CancelAsync();
            }
        }

        delegate void SetTextCallBack(string tekst);
        delegate void SetScrollCallBack();

        private void SetText(string tekst)
        {
            if (listBoxConnections.InvokeRequired)
            {
                SetTextCallBack f = new SetTextCallBack(SetText);
                this.Invoke(f, new object[] { tekst });
            }
            else
            {
                this.listBoxConnections.Items.Add(tekst);
            }
        }

        private void comboBoxAddress_TextChanged(object sender, EventArgs e)
        {
            adresIP = comboBoxAddress.Text;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            IPAddress serwerIP;
            try
            {
                serwerIP = IPAddress.Parse(adresIP);
            }
            catch
            {
                MessageBox.Show("Błędny adres IP");
                polaczenieAktywne = false;
                return;
            }
            serwer = new TcpListener(serwerIP, (int)numericUpDownPort.Value);
            try
            {
                string wiadomosc = "";
                serwer.Start();
                SetText("Oczekuje na połączenie ...");
                klient = serwer.AcceptTcpClient();
                NetworkStream ns = klient.GetStream();
                SetText("Klient próbuje się połączyć");
                czytanie = new BinaryReader(ns);
                pisanie = new BinaryWriter(ns);
                if ((wiadomosc = czytanie.ReadString()).Substring(0,2) == "1;")
                {
                    SetText("Klient połączony");

                    string sub1, sub2, sub3;
                    int separator1 = 0, separator2 = 0, temporary = 0, index = 0;

                    foreach (char i in wiadomosc)
                    {
                        if (i == ';')
                        {
                            if (temporary == 0)
                            {
                                separator1 = index;
                                temporary++;
                            }
                            else if (temporary == 1)
                            {
                                separator2 = index;
                                break;
                            }
                        }
                        index++;
                    }

                    sub1 = wiadomosc.Substring(0, separator1);
                    //MessageBox.Show(sub1 + "separator1 = " + separator1);
                    sub2 = wiadomosc.Substring(separator1 + 1, separator2 - (separator1 + 1) );
                    // MessageBox.Show(sub2 + " " + (separator1 + 1) + " " + (separator2 - (separator1 + 1)));
                    //MessageBox.Show((separator2) + " " + ((wiadomosc.Length - 1) - separator2));
                    sub3 = wiadomosc.Substring(separator2, ((wiadomosc.Length - 1) - separator2));
                    //MessageBox.Show(sub3 + " " + separator2 + " " + ((wiadomosc.Length - 1) - separator2));

                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        String query = "INSERT INTO dbo.RCP (user) VALUES (@user)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            MessageBox.Show(sub1);
                            command.Parameters.AddWithValue("@user", sub2);

                            connection.Open();
                            int result = command.ExecuteNonQuery();
                            MessageBox.Show(command.ToString());
                            // Error
                            if (result < 0)
                                MessageBox.Show("Error inserting data into Database!");
                        }
                    }

                    SetText(wiadomosc);
                    backgroundWorker2.RunWorkerAsync();
                }
                else
                {
                    SetText(wiadomosc);
                    SetText("Klient nie wykonał wymaganej autoryzacji. Połączenie przerwane");
                    klient.Close();
                    serwer.Stop();
                    polaczenieAktywne = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                SetText("Połączenie zostało przerwane");
                polaczenieAktywne = false;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string wiadomosc = "";
            try
            {
                while ((wiadomosc = czytanie.ReadString()).Substring(0,3) != "99;")
                {
                    SetText(wiadomosc);
                }
                klient.Close();
                serwer.Stop();
                SetText(wiadomosc);
                SetText("Połączenie zostało przerwane przez klienta");
            }
            catch
            {
                SetText("Klient rozłączony");
                polaczenieAktywne = false;
                klient.Close();
                serwer.Stop();
            }
        }
    }
}
