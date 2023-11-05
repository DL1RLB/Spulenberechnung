namespace Spulenberechnung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb1Spulendurchmesser = new System.Windows.Forms.TextBox();
            this.tb2Spulenlaenge = new System.Windows.Forms.TextBox();
            this.tb3Windungsanzahl = new System.Windows.Forms.TextBox();
            this.tb4Ergebnis = new System.Windows.Forms.TextBox();
            this.btn1Berechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1Spulendurchmesser
            // 
            this.tb1Spulendurchmesser.AcceptsReturn = true;
            this.tb1Spulendurchmesser.Location = new System.Drawing.Point(12, 12);
            this.tb1Spulendurchmesser.Name = "tb1Spulendurchmesser";
            this.tb1Spulendurchmesser.Size = new System.Drawing.Size(100, 20);
            this.tb1Spulendurchmesser.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tb1Spulendurchmesser, "Durchmesser in Millimeter.");
            this.tb1Spulendurchmesser.TextChanged += new System.EventHandler(this.tb1Spulendurchmesser_TextChanged);
            // 
            // tb2Spulenlaenge
            // 
            this.tb2Spulenlaenge.Location = new System.Drawing.Point(12, 38);
            this.tb2Spulenlaenge.Name = "tb2Spulenlaenge";
            this.tb2Spulenlaenge.Size = new System.Drawing.Size(100, 20);
            this.tb2Spulenlaenge.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tb2Spulenlaenge, "Länge der Spule in Millimeter");
            this.tb2Spulenlaenge.TextChanged += new System.EventHandler(this.tb1Spulendurchmesser_TextChanged);
            // 
            // tb3Windungsanzahl
            // 
            this.tb3Windungsanzahl.Location = new System.Drawing.Point(12, 64);
            this.tb3Windungsanzahl.Name = "tb3Windungsanzahl";
            this.tb3Windungsanzahl.Size = new System.Drawing.Size(100, 20);
            this.tb3Windungsanzahl.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tb3Windungsanzahl, "Die Anzahl der vollen Windungen n² .");
            this.tb3Windungsanzahl.TextChanged += new System.EventHandler(this.tb1Spulendurchmesser_TextChanged);
            // 
            // tb4Ergebnis
            // 
            this.tb4Ergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4Ergebnis.ForeColor = System.Drawing.Color.Maroon;
            this.tb4Ergebnis.Location = new System.Drawing.Point(12, 90);
            this.tb4Ergebnis.Name = "tb4Ergebnis";
            this.tb4Ergebnis.Size = new System.Drawing.Size(100, 26);
            this.tb4Ergebnis.TabIndex = 3;
            this.tb4Ergebnis.TextChanged += new System.EventHandler(this.tb4Ergebnis_TextChanged);
            this.tb4Ergebnis.Enter += new System.EventHandler(this.btn1Berechnen_Click);
            // 
            // btn1Berechnen
            // 
            this.btn1Berechnen.Location = new System.Drawing.Point(294, 87);
            this.btn1Berechnen.Name = "btn1Berechnen";
            this.btn1Berechnen.Size = new System.Drawing.Size(75, 23);
            this.btn1Berechnen.TabIndex = 4;
            this.btn1Berechnen.Text = "Berechnen";
            this.btn1Berechnen.UseVisualStyleBackColor = true;
            this.btn1Berechnen.Click += new System.EventHandler(this.btn1Berechnen_Click);
            this.btn1Berechnen.Enter += new System.EventHandler(this.btn1Berechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Durchmesser (mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Länge (mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Windungen (Anzahl)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "µH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Spulenberechnung.Properties.Resources.bast953;
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 61);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "?";
            this.toolTip1.SetToolTip(this.button1, "Hilfebutton");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(429, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1Berechnen);
            this.Controls.Add(this.tb4Ergebnis);
            this.Controls.Add(this.tb3Windungsanzahl);
            this.Controls.Add(this.tb2Spulenlaenge);
            this.Controls.Add(this.tb1Spulendurchmesser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spulenberechnung";
            this.toolTip1.SetToolTip(this, "Tool zum Berechnen von Spule von Lutz Bär DL1RLB.");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.btn1Berechnen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1Spulendurchmesser;
        private System.Windows.Forms.TextBox tb2Spulenlaenge;
        private System.Windows.Forms.TextBox tb3Windungsanzahl;
        private System.Windows.Forms.TextBox tb4Ergebnis;
        private System.Windows.Forms.Button btn1Berechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

