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
            Felderpruefen(); // Prüfen ob alle Felder ausgefüllt sind
        }

        #region Button Berechnung
        private void btn1Berechnen_Click(object sender, EventArgs e)
        {
            // Initialisieren der Werte
            float Spulendurchmesser = 0;
            float Spulenlaenge = 0;
            float Windungsanzahl = 0;
            float Ergebnis = 0;
            float WindungsanzahlZumQuadrat = 0;
            float SpulendurchmesserZumQuadrat = 0;
            

            #region Berechnung
            try
            {
                Spulendurchmesser = float.Parse(tb1Spulendurchmesser.Text); // Wert umwandlen
                Spulenlaenge = float.Parse(tb2Spulenlaenge.Text); // Wert umwandlen
                Windungsanzahl = float.Parse(tb3Windungsanzahl.Text); // Wert umwandlen

                // Berechnung der Windungsanzahl zum Quadrat
                WindungsanzahlZumQuadrat = float.Parse(tb3Windungsanzahl.Text) * float.Parse(tb3Windungsanzahl.Text);
                
                // Berechnung Spulendurchmesser zum Quadrat 
                SpulendurchmesserZumQuadrat = float.Parse(tb1Spulendurchmesser.Text) * float.Parse(tb1Spulendurchmesser.Text);
                
                //Berechnen des Ergebnis
                Ergebnis = (WindungsanzahlZumQuadrat * (SpulendurchmesserZumQuadrat / Spulenlaenge))/1000;
                
                // schreiben des Wertes in die Textbox
                tb4Ergebnis.Text = Ergebnis.ToString();

            }
            catch (Exception ex)
            {
                // wenn ein Fehler auftritt
                string Fehlermeldung = ex.Message; // in ex steht die Meldung drin
                MessageBox.Show(Fehlermeldung + "\n\noder es fehlende Daten in den Feldern.","\n\nKein gültiger Wert eingetragen.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

        }
        #endregion

        #region Felder prüfen
        private void Felderpruefen() {

            
            if (tb1Spulendurchmesser.Text.Length == 0)
            {
                btn1Berechnen.Visible = false; // blendet den Button Berechnen aus
            }

            else if (tb2Spulenlaenge.Text.Length == 0)
            {
                btn1Berechnen.Visible = false; // blendet den Button Berechnen aus
            }

            else if (tb3Windungsanzahl.Text.Length == 0)

            {
                btn1Berechnen.Visible = false; // blendet den Button Berechnen aus
            }
            else
            {
                btn1Berechnen.Visible = true; // wenn alle Felder ausgefüllt sind den Button wieder einblenden
            }
            
        }
        #endregion

        private void tb1Spulendurchmesser_TextChanged(object sender, EventArgs e)
        {
            Felderpruefen(); // prüft ob die Felder ausgefüllt sind
        }
        private void tb2Spulenlaenge_TextChanged(object sender, EventArgs e)
        {
            Felderpruefen();  // prüft ob die Felder ausgefüllt sind
        }
        private void tb3Windungsanzahl_TextChanged(object sender, EventArgs e)
        {
            Felderpruefen(); // prüft ob die Felder ausgefüllt sind
        }
        private void tb4Ergebnis_TextChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName;
        }

        #region Hilfe Button
        private void button1_Click(object sender, EventArgs e) // Hilfebutton
        {
            Spulenberechnung.AboutBox1 MyAboutBox = new Spulenberechnung.AboutBox1();
            MyAboutBox.ShowDialog();
        }
        #endregion

    }
}
