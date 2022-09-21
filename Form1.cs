using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using ID003ProtocolManager;
using System.Drawing.Printing;

namespace CurrenyUSD
{
    public partial class Form1 : Form
    {
        Thread comThread;
        SerialPort Port;
        ID003CommandCreater ComDll = new ID003CommandCreater();
        byte[] buffer = new byte[255];
        byte[] status = new byte[255];

        bool Active;
        int length;

        string fileLoc = @"D:\sample3.txt";

        private delegate void SetTextBox(byte[] text);

        double amount;

        public Form1()
        {
            InitializeComponent();
            Text = "ID003 Basic Driver " + Application.ProductVersion;
            Port = new SerialPort("COM3", 9600, Parity.Even, 8, StopBits.One);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Active = true;
            Port.Open();
            comThread = new Thread(Poll);
            comThread.Start(); 
        }

        public void pollaction()
        {
            Active = true;
            Port.Open();
            comThread = new Thread(Poll);
            comThread.Start();
        }

        public void data_received(object sender, SerialDataReceivedEventArgs e)
        {

            int bytes;

            Thread.Sleep(20);
            bytes = Port.BytesToRead;
            byte[] dat = new byte[bytes];
            Port.Read(dat, 0, bytes);
            try
            {
                Thread.Sleep(10);
                this.BeginInvoke(new SetTextBox(si_DataReceived), new object[] { dat });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void si_DataReceived(byte[] data)
        {
            string dat = "";


        }
        /// </summary>

        private void Poll()
        {




            Actions.init(buffer, length, ComDll, Port);
            while (Active)
            {

                ComDll.StatusRequest(buffer);
                length = (int)buffer[1];
                Port.Write(buffer, 0, length);
                Port.Read(status, 0, 255);
                System.Threading.Thread.Sleep(100);
                switch (status[2])
                {

                    case 0x40:
                        this.Invoke((MethodInvoker)delegate
                        {



                        });
                        break;
                    case 0x11:
                        this.Invoke((MethodInvoker)delegate
                        {


                        });
                        break;
                    case 0x1A:
                        this.Invoke((MethodInvoker)delegate
                        {



                        });
                        break;
                    case 0x13:
                        Actions.Accept(buffer, length, ComDll, Port);

                        switch (status[3])
                        {
                            case 0x61:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.10.00";
                                    Global.addvalue = 1;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "$." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();



                                    Global.amount1 = Global.amount1 + 1;
                                    // label22.Text = Convert.ToString(Global.amount1);

                                });
                                break;
                            case 0x62:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.20.00";
                                    Global.addvalue = 2;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "$." + Global.total + ".00";


                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount2 = Global.amount2 + 1;
                                    //label23.Text = Convert.ToString(Global.amount2);
                                    //did not try. no any 2$
                                });
                                break;
                            case 0x63:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    // label1.Text = "Rs.50.00";
                                    //did not try. no any 5$
                                    Global.addvalue = 5;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "$." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount3 = Global.amount3 + 1;
                                    //label24.Text = Convert.ToString(Global.amount3);
                                });
                                break;
                            case 0x64:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.100.00";
                                    Global.addvalue = 10;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "$." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount4 = Global.amount4 + 1;
                                    //  label25.Text = Convert.ToString(Global.amount4);
                                });
                                break;
                            case 0x65:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.100.00";
                                    Global.addvalue = 20;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "$." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount4 = Global.amount4 + 1;
                                    //  label25.Text = Convert.ToString(Global.amount4);
                                });
                                break;
                            case 0x66:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.500.00";
                                    Global.addvalue = 50;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "$." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount5 = Global.amount5 + 1;
                                    //label26.Text = Convert.ToString(Global.amount5);
                                });
                                break;
                            case 0x67:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    // label1.Text = "Rs.1000.00";
                                    Global.addvalue = 100;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "$." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount6 = Global.amount6 + 1;
                                    //label27.Text = Convert.ToString(Global.amount6);
                                });
                                break;
                            case 0x68:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.2000.00";
                                    Global.addvalue = 2000;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "Rs." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount7 = Global.amount7 + 1;
                                    //label28.Text = Convert.ToString(Global.amount7);
                                });
                                break;
                            case 0x69:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    // label1.Text = "Rs.5000.00";
                                    Global.addvalue = 5000;
                                    Global.total = Global.total + Global.addvalue;
                                    lblUSD.Text = "Rs." + Global.total + ".00";

                                    amount = Global.total * 150;
                                    lblLKR.Text = amount.ToString();

                                    Global.amount8 = Global.amount8 + 1;
                                    //label29.Text = Convert.ToString(Global.amount8);
                                });
                                break;
                            // lblLKR.Text = status[3].ToString();
                        }
                        break;
                    case 0x17:
                        this.Invoke((MethodInvoker)delegate
                        {

                            Global.Ramount = Global.Ramount + 1;



                        });
                        break;
                    case 0x43:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x44:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x45:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x46:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x47:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x48:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x49:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x4A:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;

                }


            }
        }
        private Font TimesNewRoman10Font;

        private void lblLKR_Click(object sender, EventArgs e)
        {

        }

        private void btnClosd_Click(object sender, EventArgs e)
        {
            Port.Close();
            this.Hide();
            FrmHome frmh = new FrmHome();
            frmh.Show();
        }

        private void btnRupees_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cashe Despensor Error", "Sorry");
        }
    }
}
