using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Globalization;


namespace ClientProject
{
    public partial class ClientForm : Form
    {
        private TcpClient klient;
        private BinaryWriter pisanie;
        private BinaryReader czytanie;
        private string serwerIP = "127.0.0.1";
        private bool polaczeniaAktywne;
        private string ActiveTask = "";

        public ClientForm()
        {
            InitializeComponent();
        }

        delegate void SetTextCallBack(string tekst);
        delegate void SetScrollCallBack();

        private void SetText(string tekst)
        {
            if (listBoxTasks.InvokeRequired)
            {
                SetTextCallBack f = new SetTextCallBack(SetText);
                this.Invoke(f, new object[] { tekst });
            }
            else
            {
                this.listBoxTasks.Items.Add(tekst);
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (polaczeniaAktywne == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Jesteś już zalogowany!!!");
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (polaczeniaAktywne == false)
            {
                MessageBox.Show("Jesteś już zalogowany!!!");
            }
            else
            {
                polaczeniaAktywne = false;
                if (klient != null)
                {
                    pisanie.Write("99;" + textBoxLogin.Text + ";" + textBoxPassword.Text);
                    klient.Close();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                klient = new TcpClient(serwerIP, (int)numericUpDownPort.Value);
                NetworkStream ns = klient.GetStream();
                czytanie = new BinaryReader(ns);
                pisanie = new BinaryWriter(ns);
                Thread.Sleep(500);
                pisanie.Write("1;"+textBoxLogin.Text+";"+textBoxPassword.Text);
                MessageBox.Show("Autoryzacja ...");
                polaczeniaAktywne = true;
                backgroundWorker2.RunWorkerAsync();
            }
            catch
            {
                MessageBox.Show("Nie można nawiązać połączenia");
                polaczeniaAktywne = false;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBox.Show("Autoryzacja zakończona");
            string wiadomosc;
            try
            {
                while ((wiadomosc = czytanie.ReadString()).Substring(0,3) != "99;" + textBoxLogin.Text + ";" + textBoxPassword.Text)
                {
                    pisanie.Write(wiadomosc);
                }
                MessageBox.Show("Połączenie przerwane");
                polaczeniaAktywne = false;
                klient.Close();
            }
            catch
            {
                MessageBox.Show("Połączenie z serwerem zostało przerwane");
                polaczeniaAktywne = false;
                klient.Close();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var culture = new CultureInfo("pl-PL");

            if (polaczeniaAktywne)
            {
                if (listBoxTasks.SelectedItem.ToString() == ActiveTask)
                {

                }
                else if (ActiveTask == "")
                {
                    pisanie.Write("2;" + listBoxTasks.SelectedItem + ";" + DateTime.Now.ToString(culture));
                    ActiveTask = listBoxTasks.SelectedItem.ToString();
                }
                else if (ActiveTask.Length > 1 )
                {
                    pisanie.Write("3;" + ActiveTask + ";" + DateTime.Now.ToString(culture));
                    pisanie.Write("2;" + listBoxTasks.SelectedItem + ";" + DateTime.Now.ToString(culture));
                    ActiveTask = listBoxTasks.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Dodaj i wybier zadanie");
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            var culture = new CultureInfo("pl-PL");

            if (polaczeniaAktywne)
            {
                if (ActiveTask.Length > 1)
                {
                    pisanie.Write("3;" + ActiveTask + ";" + DateTime.Now.ToString(culture));
                    ActiveTask = "";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTask.Text.Length > 1)
            {
                SetText(textBoxTask.Text);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem.ToString().Length > 1)
            {
                listBoxTasks.SelectedItem = "";
            }
            else
            {
                MessageBox.Show("Zaznacz zadanie do usunięcia");
            }
        }
    }
}
