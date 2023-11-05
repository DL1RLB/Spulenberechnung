using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Spulenberechnung
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Felderpruefen();
        }
        
        private void btn1Berechnen_Click(object sender, EventArgs e)
        {
            
            float Spulendurchmesser = 0;
            float Spulenlaenge = 0;
            float Windungsanzahl = 0;
            float Ergebnis = 0;
            float WindungsanzahlZumQuadrat = 0;
            float SpulendurchmesserZumQuadrat = 0;
            

            #region Berechnung
            try
            {
                Spulendurchmesser = float.Parse(tb1Spulendurchmesser.Text);
                Spulenlaenge = float.Parse(tb2Spulenlaenge.Text);
                Windungsanzahl = float.Parse(tb3Windungsanzahl.Text);

                WindungsanzahlZumQuadrat = float.Parse(tb3Windungsanzahl.Text) * float.Parse(tb3Windungsanzahl.Text);
                SpulendurchmesserZumQuadrat = float.Parse(tb1Spulendurchmesser.Text) * float.Parse(tb1Spulendurchmesser.Text);
                Ergebnis = (WindungsanzahlZumQuadrat * (SpulendurchmesserZumQuadrat / Spulenlaenge))/1000;
                tb4Ergebnis.Text = Ergebnis.ToString();
            }
            catch (Exception ex)
            {
                string Fehlermeldung = ex.Message; // in ex steht die Meldung drin
                MessageBox.Show(Fehlermeldung + "\n\noder es fehlende Daten in den Feldern.","\n\nKein gültiger Wert eingetragen.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

        }
        private void Felderpruefen() {

            //if (String.IsNullOrEmpty(tb1Spulendurchmesser.Text) && String.IsNullOrEmpty(tb2Spulenlaenge.Text) && String.IsNullOrEmpty(tb3Windungsanzahl.Text))

            if (tb1Spulendurchmesser.Text.Length == 0)
            {
                btn1Berechnen.Visible = false;
            }

            else if (tb2Spulenlaenge.Text.Length == 0)
            {
                btn1Berechnen.Visible = false;
            }

            else if (tb3Windungsanzahl.Text.Length == 0)

            {
                btn1Berechnen.Visible = false;
            }
            else
            {
                btn1Berechnen.Visible = true;
            }
            
        }

        private void tb1Spulendurchmesser_TextChanged(object sender, EventArgs e)
        {
            Felderpruefen();
        }
        private void tb2Spulenlaenge_TextChanged(object sender, EventArgs e)
        {
            Felderpruefen();   
        }
        private void tb3Windungsanzahl_TextChanged(object sender, EventArgs e)
        {
            Felderpruefen();
        }
        private void tb4Ergebnis_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Text = Application.CompanyName + " " + Application.ProductName + " " + Application.ProductVersion;
            Text = Application.ProductName;
        }
        private void button1_Click(object sender, EventArgs e) // Hilfebutton
        {
            Spulenberechnung.AboutBox1 MyAboutBox = new Spulenberechnung.AboutBox1();
            MyAboutBox.ShowDialog();
            
        }

        
    }
}
