namespace Fahrpan
{
    partial class Fahrplan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Ausgabe = new System.Windows.Forms.ListView();
            this.nachtxt = new System.Windows.Forms.ComboBox();
            this.KarteNach = new System.Windows.Forms.Button();
            this.KarteVon = new System.Windows.Forms.Button();
            this.Vontxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fehlermeldung = new System.Windows.Forms.Label();
            this.Suchen = new System.Windows.Forms.Button();
            this.Kalender = new System.Windows.Forms.DateTimePicker();
            this.Nachlbl = new System.Windows.Forms.Label();
            this.Vonlbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Los = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Station = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2087, 842);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Ausgabe);
            this.tabPage1.Controls.Add(this.nachtxt);
            this.tabPage1.Controls.Add(this.KarteNach);
            this.tabPage1.Controls.Add(this.KarteVon);
            this.tabPage1.Controls.Add(this.Vontxt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Fehlermeldung);
            this.tabPage1.Controls.Add(this.Suchen);
            this.tabPage1.Controls.Add(this.Kalender);
            this.tabPage1.Controls.Add(this.Nachlbl);
            this.tabPage1.Controls.Add(this.Vonlbl);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2071, 795);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fahrplan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ausgabe
            // 
            this.Ausgabe.Location = new System.Drawing.Point(664, 115);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.Size = new System.Drawing.Size(629, 537);
            this.Ausgabe.TabIndex = 33;
            this.Ausgabe.UseCompatibleStateImageBehavior = false;
            this.Ausgabe.View = System.Windows.Forms.View.Details;
            this.Ausgabe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ausgabe_MouseClick);
            // 
            // nachtxt
            // 
            this.nachtxt.FormattingEnabled = true;
            this.nachtxt.Location = new System.Drawing.Point(158, 302);
            this.nachtxt.Name = "nachtxt";
            this.nachtxt.Size = new System.Drawing.Size(178, 33);
            this.nachtxt.TabIndex = 32;
            // 
            // KarteNach
            // 
            this.KarteNach.Location = new System.Drawing.Point(158, 365);
            this.KarteNach.Name = "KarteNach";
            this.KarteNach.Size = new System.Drawing.Size(178, 39);
            this.KarteNach.TabIndex = 25;
            this.KarteNach.Text = "Karte";
            this.KarteNach.UseVisualStyleBackColor = true;
            this.KarteNach.Click += new System.EventHandler(this.button2_Click);
            // 
            // KarteVon
            // 
            this.KarteVon.Location = new System.Drawing.Point(158, 183);
            this.KarteVon.Name = "KarteVon";
            this.KarteVon.Size = new System.Drawing.Size(178, 39);
            this.KarteVon.TabIndex = 24;
            this.KarteVon.Text = "Karte";
            this.KarteVon.UseVisualStyleBackColor = true;
            this.KarteVon.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vontxt
            // 
            this.Vontxt.FormattingEnabled = true;
            this.Vontxt.Location = new System.Drawing.Point(158, 133);
            this.Vontxt.Name = "Vontxt";
            this.Vontxt.Size = new System.Drawing.Size(178, 33);
            this.Vontxt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 21;
            // 
            // Fehlermeldung
            // 
            this.Fehlermeldung.AutoSize = true;
            this.Fehlermeldung.Location = new System.Drawing.Point(103, 29);
            this.Fehlermeldung.Name = "Fehlermeldung";
            this.Fehlermeldung.Size = new System.Drawing.Size(303, 25);
            this.Fehlermeldung.TabIndex = 20;
            this.Fehlermeldung.Text = "Füllen Sie bitte alle Felder aus";
            this.Fehlermeldung.Visible = false;
            // 
            // Suchen
            // 
            this.Suchen.Location = new System.Drawing.Point(196, 655);
            this.Suchen.Name = "Suchen";
            this.Suchen.Size = new System.Drawing.Size(149, 62);
            this.Suchen.TabIndex = 19;
            this.Suchen.Text = "Suchen";
            this.Suchen.UseVisualStyleBackColor = true;
            this.Suchen.Click += new System.EventHandler(this.Suchen_Click);
            // 
            // Kalender
            // 
            this.Kalender.Location = new System.Drawing.Point(133, 501);
            this.Kalender.Name = "Kalender";
            this.Kalender.Size = new System.Drawing.Size(273, 31);
            this.Kalender.TabIndex = 18;
            this.Kalender.Value = new System.DateTime(2017, 5, 14, 0, 0, 0, 0);
            // 
            // Nachlbl
            // 
            this.Nachlbl.AutoSize = true;
            this.Nachlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nachlbl.Location = new System.Drawing.Point(190, 263);
            this.Nachlbl.Name = "Nachlbl";
            this.Nachlbl.Size = new System.Drawing.Size(98, 36);
            this.Nachlbl.TabIndex = 15;
            this.Nachlbl.Text = "Nach:";
            // 
            // Vonlbl
            // 
            this.Vonlbl.AutoSize = true;
            this.Vonlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vonlbl.Location = new System.Drawing.Point(210, 73);
            this.Vonlbl.Name = "Vonlbl";
            this.Vonlbl.Size = new System.Drawing.Size(78, 36);
            this.Vonlbl.TabIndex = 14;
            this.Vonlbl.Text = "Von:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.Los);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.Station);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2071, 795);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bahnhof Fahrplan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(80, 323);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(659, 437);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Los
            // 
            this.Los.Location = new System.Drawing.Point(189, 193);
            this.Los.Name = "Los";
            this.Los.Size = new System.Drawing.Size(124, 52);
            this.Los.TabIndex = 2;
            this.Los.Text = "Los!";
            this.Los.UseVisualStyleBackColor = true;
            this.Los.Click += new System.EventHandler(this.Los_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 31);
            this.textBox1.TabIndex = 1;
            // 
            // Station
            // 
            this.Station.AutoSize = true;
            this.Station.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Station.Location = new System.Drawing.Point(174, 55);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(148, 36);
            this.Station.TabIndex = 0;
            this.Station.Text = "Stationen";
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 841);
            this.Controls.Add(this.tabControl1);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Anfangsview_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Suchen;
        private System.Windows.Forms.DateTimePicker Kalender;
        private System.Windows.Forms.Label Nachlbl;
        private System.Windows.Forms.Label Vonlbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Station;
        private System.Windows.Forms.Label Fehlermeldung;
        private System.Windows.Forms.Button Los;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ComboBox Vontxt;
        private System.Windows.Forms.Button KarteNach;
        private System.Windows.Forms.Button KarteVon;
        private System.Windows.Forms.ComboBox nachtxt;
        private System.Windows.Forms.ListView Ausgabe;
    }
}

