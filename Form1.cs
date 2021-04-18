using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace FibonacciSecuence
{
    public partial class Form1 : Form
    {
        //Variables
        string Output;
        string question;

        int Times;

        double 
            a,
            b,
            c;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AskTimes();
        }

        private void AskTimes()
        {
            Output = string.Empty;
            Times = 0;

            a = 0;
            b = 1;

            question = Interaction.InputBox("Importante leer esto!\n\n¿Hasta cuando va a parar la secuencia?\n(Se recomienda menos de 100 veces)", "Atención");
            DoSecuence();
        }

        private void DoSecuence()
        {
            try
            {
                Times = (Int32.Parse(question));

                Output = "0 1 ";

                for(int i = 0; i <= Times; i++)
                {
                    c = a;
                    a = b;
                    b = c + a;

                    Output += b.ToString() + " ";
                }

                MessageBox.Show("Resultado\n\n" + Output, "Salida",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Excepción no permitida\n\n" + error.Message + "\n" + error.HResult, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AskTimes();
            }
            
        }
    }
}
