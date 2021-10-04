using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_DekkerPeterson
{
    public partial class Form1 : Form
    {
        delegate void delegadoOne(int valor1);
        delegate void delegadoTwo();
        int turnoBolean;
        bool flag0 = false;
        bool flag1 = false;
        public string idProcess1, idProcess2;
        public int timeoutP1, timeoutP2, option, timeoutMiliseconds1, timeoutMiliseconds2, iterations = 20;
        Random randomNumber = new Random();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            idProcess1 = txtIdP1.Text;
            idProcess2 = txtIdP2.Text;

            timeoutP1 = Int32.Parse(txtTimeoutP1.Text);
            timeoutP2 = Int32.Parse(txtTimeoutP2.Text);

            timeoutMiliseconds1 = timeoutP1;
            timeoutMiliseconds2 = timeoutP2;

            option = cmbOption.SelectedIndex;
            switch (option)
            {
                case 0:
                    txtSetData.Text = "ALGORITMO DE DEKKER -- VERSION 1";
                    Thread h1 = new Thread(new ThreadStart(AtenderDekker1Proceso1));
                    Thread h2 = new Thread(new ThreadStart(AtenderDekker2Proceso2));
                    //Se eliminan hilos
                    h1.Start();
                    h2.Start();
                    creacion_txt("Version_1_Algoritmo_Dekker");
                    break;

                case 1:
                    txtSetData.Text = "ALGORITMO DE DEKKER -- VERSION 2";
                    flag0 = false;
                    flag1 = false;
                    Thread h3 = new Thread(new ThreadStart(AtDekker2Proceso1));
                    Thread h4 = new Thread(new ThreadStart(AtDekker2Proceso2));
                    h3.Start();
                    h4.Start();
                    creacion_txt("Version_2_Algoritmo_Dekker");
                    break;

                case 2:
                    txtSetData.Text = "ALGORITMO DE DEKKER -- VERSION 3";
                    flag0 = false;
                    flag1 = false;
                    Thread h5 = new Thread(new ThreadStart(versionDekker3Proceso0));
                    Thread h6 = new Thread(new ThreadStart(versionDekker3Proceso1));
                    h5.Start();
                    h6.Start();
                    creacion_txt("Version_3_Algoritmo_Dekker");
                    break;

                case 3:
                    txtSetData.Text = "ALGORITMO DE DEKKER  -- VERSION 4";
                    flag0 = false;
                    flag1 = false;
                    Thread h7 = new Thread(new ThreadStart(version4DekkerProceso0));
                    Thread h8 = new Thread(new ThreadStart(version4DekkerProceso1));
                    h7.Start();
                    h8.Start();
                    creacion_txt("Version_4_Algoritmo_Dekker");
                    break;

                case 4:
                    txtSetData.Text = "ALGORITMO DE DEKKER -- VERSION 5";
                    flag0 = false;
                    flag1 = false;
                    turnoBolean = 0;
                    Thread h9 = new Thread(new ThreadStart(version5DekkerProceso0));
                    Thread h10 = new Thread(new ThreadStart(version5DekkerProceso1));
                    h9.Start();
                    h10.Start();
                    creacion_txt("Version_5_Algoritmo_Dekker");
                    break;

                case 5:
                    txtSetData.Text = "PETERSON";
                    flag0 = false;
                    flag1 = false;
                    Thread h11 = new Thread(new ThreadStart(algoritmo_peterson_P1));
                    Thread h12 = new Thread(new ThreadStart(algoritmo_peterson_P2));
                    h11.Start();
                    h12.Start();
                    creacion_txt("Version_Algoritmo_Peterson");
                    break;
            }

        }

        public void creacion_txt(string value)
        {
            StreamWriter myTxt = new StreamWriter($"{value}.txt");
            string path = $"{value}.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    myTxt.WriteLine("Estudiante: Arody Alvarado");
                    myTxt.WriteLine("Carne: 0900-19-2210");
                }
            }
            myTxt.Close();
        }
        public void escribir_TXT(string txt, string value)
        {
            StreamWriter myTxt = new StreamWriter($"{value}.txt");
            myTxt.WriteLine(txt);
            myTxt.Close();
        }
        #region version1Dekker
        public void AtenderDekker1Proceso1()
        {
            for (int i = 0; i < iterations; i++)
            {
                while (turnoBolean != 0)
                {
                    /* esperar */
                }

                //Sección Critica
                delegadoOne MD = new delegadoOne(Version1Actualizar1);
                this.Invoke(MD, new object[] { i });
                escribir_TXT(txtSetData.Text, "Version_1_Algoritmo_Dekker");
                Thread.Sleep(timeoutMiliseconds1);
                turnoBolean = 1;
            }
        }
        public void Version1Actualizar1(int valor)
        {
            
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();
            //hora = GetTimestamp(DateTime.Now);

            txtSetData.Text = txtSetData.Text + " - " + hora + "  ---- Atendiendo Proceso: " + idProcess1 + "  No: " + valor + " ----" + "\r\n";
        }
 
        public void AtenderDekker2Proceso2()
        {
            for (int i = 0; i < iterations; i++)
            {
                while (turnoBolean != 1)
                {
                    /* esperar */
                }

                //Sección Critica
                delegadoOne MD = new delegadoOne(Version1Actualizar2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(timeoutMiliseconds2);
                turnoBolean = 0;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void Version1Actualizar2(int valor)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + " - " + hora + "  ---- Atendiendo Proceso: " + idProcess2 + "  No: " + valor + " ----" + "\r\n";
       
        }

        #endregion

        #region version2Dekker
        public void AtDekker2Proceso1()
        {
            for (int i = 0; i < iterations; i++)
            {
                while (flag1)
                {
                    /* esperar */
                }
                flag0 = true;

                //Sección Critica
                delegadoOne MD = new delegadoOne(version2Proceso1);
                this.Invoke(MD, new object[] { i });
                escribir_TXT(txtSetData.Text, "Version_2_Algoritmo_Dekker");
                Thread.Sleep(timeoutMiliseconds1);

                flag0 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version2Proceso1(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso: " + idProcess1 + "  No: " + value + " *****" + "\r\n";
        }

        public void AtDekker2Proceso2()
        {
            //Seccion Entrada
            for (int i = 0; i < iterations; i++)
            {
                while (flag0)
                {
                    /* esperar */
                }
                flag1 = true;

                //Sección Critica
                delegadoOne MD = new delegadoOne(version2Proceso2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(timeoutMiliseconds2);
                //Seccion Salida
                flag1 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version2Proceso2(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso: " + idProcess2 + " No:  " + value + " *****" + "\r\n";
        }

        #endregion

        #region Version3Dekker
        public void versionDekker3Proceso0()
        {
            for (int i = 0; i < iterations; i++)
            {
                flag0 = true;
                while (flag1)
                {
                    /* esperar */
                }
            delegadoOne MD = new delegadoOne(version3Proceso0);
                this.Invoke(MD, new object[] { i });
                escribir_TXT(txtSetData.Text, "Version_3_Algoritmo_Dekker");
                Thread.Sleep(timeoutMiliseconds1);
                flag0 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version3Proceso0(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + "\n" + $"**** {hora}  -  ---- Atendiendo proceso: " + idProcess1 + " No:  " + value + " *****" + "\r\n";

        }
        public void versionDekker3Proceso1()
        {
            for (int i = 0; i < iterations; i++)
            {
                flag1 = true;
                while (flag0)
                {
                    /* esperar */
                }
                delegadoOne MD = new delegadoOne(version3Proceso1);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(timeoutMiliseconds2);
                flag1 = false;

                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version3Proceso1(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso " + idProcess2 + " No:  " + value + " *****" + "\r\n";
        }

        #endregion

        #region Version4dekker
        public void version4DekkerProceso0()
        {

            int nRandom = randomNumber.Next(1, 16);
            for (int i = 0; i < iterations; i++)
            {
                flag0 = true;
                while (flag1)
                {
                    flag0 = false;
                    //Espera un momento aleatorio
                    for (int b = 0; b < nRandom; b++)
                    {
                        //Simulando procesos..
                    }
                    flag0 = true;
                    if (i + 1 == iterations)
                    {
                        Thread.Sleep(Timeout.Infinite);
                    }
                };
                //Seccion critica
                delegadoOne MD = new delegadoOne(version4Proceso0);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(timeoutMiliseconds1);
                escribir_TXT(txtSetData.Text, "Version_4_Algoritmo_Dekker");
                flag0 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version4Proceso0(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso: " + idProcess1 + " No:  " + value + " *****" + "\r\n";
        }

        public void version4DekkerProceso1()
        {
            int numberR1 = randomNumber.Next(1, 16);
            for (int i = 0; i < iterations; i++)
            {
                flag1 = true;
                while (flag0)
                {
                    flag1 = false;
                    //Espera un momento aleatorio
                    for (int a = 0; a < numberR1; a++)
                    {
                        //Simulando procesos..
                    }
                    flag1 = true;
                    if (i + 1 == iterations)
                    {
                        Thread.Sleep(Timeout.Infinite);
                    }
                };
                //Seccion critica
                delegadoOne MD = new delegadoOne(version4Proceso1);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(timeoutMiliseconds2);
                flag1 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version4Proceso1(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso: " + idProcess2 + " No:  " + value + " *****" + "\r\n";
        }
        #endregion

        #region Version5Dekker
        public void version5DekkerProceso0()
        {
            for (int i = 0; i < iterations; i++)
            {
                flag0 = true;
                while (flag1)
                {
                    flag0 = false;
                    while (turnoBolean != 0)
                    {
                    }
                    flag0 = true;
                };
                //Seccion critica
                delegadoOne MD = new delegadoOne(version5Proceso1);
                this.Invoke(MD, new object[] { i });
                escribir_TXT(txtSetData.Text, "Version_5_Algoritmo_Dekker");
                Thread.Sleep(timeoutMiliseconds1);
                turnoBolean = 1;
                flag0 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version5Proceso1(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso: " + idProcess1 + " No:  " + value + " *****" + "\r\n";
        }

        public void version5DekkerProceso1()
        {
            for (int i = 0; i < iterations; i++)
            {
                flag1 = true;
                while (flag0)
                {
                    flag1 = false;
                    while (turnoBolean != 1)
                    {
                    }
                    flag1 = true;
                }
                //Seccion critica
                delegadoOne MD = new delegadoOne(version5Proceso2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(timeoutMiliseconds2);

                turnoBolean = 0;
                flag1 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void version5Proceso2(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso: " + idProcess2 + " No:  " + value + " *****" + "\r\n";
        }
        #endregion

        #region Algoritmo_Peterson
        public void algoritmo_peterson_P1()
        {
            for (int i = 0; i < iterations; i++)
            {
                flag0 = true;
                turnoBolean = 1;
                while (flag1 && turnoBolean == 1) { };
                //Seccion critica
                delegadoOne MD = new delegadoOne(PettersonProceso1);
                this.Invoke(MD, new object[] { i });
                escribir_TXT(txtSetData.Text, "Version_Algoritmo_Peterson");
                Thread.Sleep(timeoutMiliseconds1);

                flag0 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }



        public void PettersonProceso1(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso " + idProcess1 + " No:  " + value + " *****" + "\r\n";
        }
        public void algoritmo_peterson_P2()
        {
            for (int i = 0; i < iterations; i++)
            {
                flag1 = true;
                turnoBolean = 0;
                while (flag0 && turnoBolean == 0) { };
                //Seccion critica
                delegadoOne MD = new delegadoOne(PettersonProceso2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(timeoutMiliseconds2);

                flag1 = false;
                if (i + 1 == iterations)
                {
                    Thread.Sleep(Timeout.Infinite);
                }
            }
        }
        public void PettersonProceso2(int value)
        {
            DateTime localDate = DateTime.Now;
            string hora = localDate.ToString();

            txtSetData.Text = txtSetData.Text + $"**** {hora}  -  ---- Atendiendo proceso " + idProcess2 + " No:  " + value + " *****" + "\r\n";
        }
        #endregion
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIdP1.Text = "";
            txtIdP2.Text = "";
            txtTimeoutP1.Text = "";
            txtTimeoutP2.Text = "";
            txtSetData.Text = "";
        }
    }
}
