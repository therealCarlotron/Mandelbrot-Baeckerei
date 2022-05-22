namespace Mandelbrot_Bäckerei
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
            this.lbl_MandelbrotGenerator = new System.Windows.Forms.Label();
            this.lbl_Exportieren = new System.Windows.Forms.Label();
            this.pic_MandelBild = new System.Windows.Forms.PictureBox();
            this.lbl_Erstellen = new System.Windows.Forms.Label();
            this.lbl_Groesse = new System.Windows.Forms.Label();
            this.comb_Groesse = new System.Windows.Forms.ComboBox();
            this.txt_Breite = new System.Windows.Forms.TextBox();
            this.txt_Hoehe = new System.Windows.Forms.TextBox();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_H = new System.Windows.Forms.Label();
            this.btn_Runter = new System.Windows.Forms.Button();
            this.btn_Rechts = new System.Windows.Forms.Button();
            this.btn_Hoch = new System.Windows.Forms.Button();
            this.btn_Links = new System.Windows.Forms.Button();
            this.txt_PositionMulti = new System.Windows.Forms.TextBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_Skalierung = new System.Windows.Forms.Label();
            this.txt_Skalierung = new System.Windows.Forms.TextBox();
            this.comb_Medium = new System.Windows.Forms.ComboBox();
            this.lbl_Medium = new System.Windows.Forms.Label();
            this.lbl_Format = new System.Windows.Forms.Label();
            this.comb_Format = new System.Windows.Forms.ComboBox();
            this.btn_Erstellen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.prog_Wartezeit = new System.Windows.Forms.ProgressBar();
            this.txt_Genauigkeit = new System.Windows.Forms.TextBox();
            this.lbl_Genauigkeit = new System.Windows.Forms.Label();
            this.txt_Dateipfad = new System.Windows.Forms.TextBox();
            this.lbl_Dateipfad = new System.Windows.Forms.Label();
            this.btn_Durchsuchen = new System.Windows.Forms.Button();
            this.lbl_Keyframe = new System.Windows.Forms.Label();
            this.btn_Erstellen1 = new System.Windows.Forms.Button();
            this.lbl_KeyInfo = new System.Windows.Forms.Label();
            this.lbl_Framerate = new System.Windows.Forms.Label();
            this.lbl_Dauer = new System.Windows.Forms.Label();
            this.txt_Framerate = new System.Windows.Forms.TextBox();
            this.txt_Dauer = new System.Windows.Forms.TextBox();
            this.prog_Video = new System.Windows.Forms.ProgressBar();
            this.btn_VideoSpeichern = new System.Windows.Forms.Button();
            this.txt_Keyframenummer = new System.Windows.Forms.TextBox();
            this.list_Keyframes = new System.Windows.Forms.ListBox();
            this.btn_Zurueksetzen = new System.Windows.Forms.Button();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_Farbe = new System.Windows.Forms.Label();
            this.comb_Farbe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MandelBild)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MandelbrotGenerator
            // 
            this.lbl_MandelbrotGenerator.AutoSize = true;
            this.lbl_MandelbrotGenerator.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MandelbrotGenerator.Location = new System.Drawing.Point(12, 9);
            this.lbl_MandelbrotGenerator.Name = "lbl_MandelbrotGenerator";
            this.lbl_MandelbrotGenerator.Size = new System.Drawing.Size(823, 90);
            this.lbl_MandelbrotGenerator.TabIndex = 0;
            this.lbl_MandelbrotGenerator.Text = "Mandelbrot Generator";
            // 
            // lbl_Exportieren
            // 
            this.lbl_Exportieren.AutoSize = true;
            this.lbl_Exportieren.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exportieren.Location = new System.Drawing.Point(1033, 670);
            this.lbl_Exportieren.Name = "lbl_Exportieren";
            this.lbl_Exportieren.Size = new System.Drawing.Size(765, 36);
            this.lbl_Exportieren.TabIndex = 1;
            this.lbl_Exportieren.Text = "Exportieren                                                                      " +
    "     ";
            // 
            // pic_MandelBild
            // 
            this.pic_MandelBild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_MandelBild.Location = new System.Drawing.Point(27, 102);
            this.pic_MandelBild.Name = "pic_MandelBild";
            this.pic_MandelBild.Size = new System.Drawing.Size(1000, 1000);
            this.pic_MandelBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_MandelBild.TabIndex = 2;
            this.pic_MandelBild.TabStop = false;
            // 
            // lbl_Erstellen
            // 
            this.lbl_Erstellen.AutoSize = true;
            this.lbl_Erstellen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erstellen.Location = new System.Drawing.Point(1033, 102);
            this.lbl_Erstellen.Name = "lbl_Erstellen";
            this.lbl_Erstellen.Size = new System.Drawing.Size(759, 36);
            this.lbl_Erstellen.TabIndex = 3;
            this.lbl_Erstellen.Text = "Erstellen                                                                        " +
    "       ";
            // 
            // lbl_Groesse
            // 
            this.lbl_Groesse.AutoSize = true;
            this.lbl_Groesse.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Groesse.Location = new System.Drawing.Point(1065, 173);
            this.lbl_Groesse.Name = "lbl_Groesse";
            this.lbl_Groesse.Size = new System.Drawing.Size(88, 31);
            this.lbl_Groesse.TabIndex = 4;
            this.lbl_Groesse.Text = "Größe:";
            // 
            // comb_Groesse
            // 
            this.comb_Groesse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_Groesse.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_Groesse.FormattingEnabled = true;
            this.comb_Groesse.Items.AddRange(new object[] {
            "4K",
            "FullHD",
            "HD",
            "Eigene"});
            this.comb_Groesse.Location = new System.Drawing.Point(1071, 207);
            this.comb_Groesse.Name = "comb_Groesse";
            this.comb_Groesse.Size = new System.Drawing.Size(228, 31);
            this.comb_Groesse.TabIndex = 5;
            this.comb_Groesse.SelectedIndexChanged += new System.EventHandler(this.comb_Groesse_SelectedIndexChanged);
            // 
            // txt_Breite
            // 
            this.txt_Breite.Enabled = false;
            this.txt_Breite.Location = new System.Drawing.Point(1071, 285);
            this.txt_Breite.Name = "txt_Breite";
            this.txt_Breite.Size = new System.Drawing.Size(112, 31);
            this.txt_Breite.TabIndex = 6;
            this.txt_Breite.Text = "500";
            this.txt_Breite.TextChanged += new System.EventHandler(this.txt_Breite_TextChanged);
            // 
            // txt_Hoehe
            // 
            this.txt_Hoehe.Enabled = false;
            this.txt_Hoehe.Location = new System.Drawing.Point(1189, 285);
            this.txt_Hoehe.Name = "txt_Hoehe";
            this.txt_Hoehe.Size = new System.Drawing.Size(110, 31);
            this.txt_Hoehe.TabIndex = 7;
            this.txt_Hoehe.Text = "500";
            this.txt_Hoehe.TextChanged += new System.EventHandler(this.txt_Hoehe_TextChanged);
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B.Location = new System.Drawing.Point(1066, 257);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(26, 25);
            this.lbl_B.TabIndex = 8;
            this.lbl_B.Text = "B";
            // 
            // lbl_H
            // 
            this.lbl_H.AutoSize = true;
            this.lbl_H.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_H.Location = new System.Drawing.Point(1190, 257);
            this.lbl_H.Name = "lbl_H";
            this.lbl_H.Size = new System.Drawing.Size(27, 25);
            this.lbl_H.TabIndex = 9;
            this.lbl_H.Text = "H";
            // 
            // btn_Runter
            // 
            this.btn_Runter.Enabled = false;
            this.btn_Runter.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Runter.Location = new System.Drawing.Point(1470, 342);
            this.btn_Runter.Name = "btn_Runter";
            this.btn_Runter.Size = new System.Drawing.Size(50, 50);
            this.btn_Runter.TabIndex = 10;
            this.btn_Runter.Text = "S";
            this.btn_Runter.UseVisualStyleBackColor = true;
            this.btn_Runter.Click += new System.EventHandler(this.btn_Runter_Click);
            // 
            // btn_Rechts
            // 
            this.btn_Rechts.Enabled = false;
            this.btn_Rechts.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rechts.Location = new System.Drawing.Point(1399, 275);
            this.btn_Rechts.Name = "btn_Rechts";
            this.btn_Rechts.Size = new System.Drawing.Size(50, 50);
            this.btn_Rechts.TabIndex = 11;
            this.btn_Rechts.Text = "W";
            this.btn_Rechts.UseVisualStyleBackColor = true;
            this.btn_Rechts.Click += new System.EventHandler(this.btn_Rechts_Click);
            // 
            // btn_Hoch
            // 
            this.btn_Hoch.Enabled = false;
            this.btn_Hoch.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hoch.Location = new System.Drawing.Point(1470, 207);
            this.btn_Hoch.Name = "btn_Hoch";
            this.btn_Hoch.Size = new System.Drawing.Size(50, 50);
            this.btn_Hoch.TabIndex = 12;
            this.btn_Hoch.Text = "N";
            this.btn_Hoch.UseVisualStyleBackColor = true;
            this.btn_Hoch.Click += new System.EventHandler(this.btn_Hoch_Click);
            // 
            // btn_Links
            // 
            this.btn_Links.Enabled = false;
            this.btn_Links.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Links.Location = new System.Drawing.Point(1543, 275);
            this.btn_Links.Name = "btn_Links";
            this.btn_Links.Size = new System.Drawing.Size(50, 50);
            this.btn_Links.TabIndex = 13;
            this.btn_Links.Text = "O";
            this.btn_Links.UseVisualStyleBackColor = true;
            this.btn_Links.Click += new System.EventHandler(this.btn_Links_Click);
            // 
            // txt_PositionMulti
            // 
            this.txt_PositionMulti.Enabled = false;
            this.txt_PositionMulti.Location = new System.Drawing.Point(1470, 284);
            this.txt_PositionMulti.Name = "txt_PositionMulti";
            this.txt_PositionMulti.Size = new System.Drawing.Size(50, 31);
            this.txt_PositionMulti.TabIndex = 14;
            this.txt_PositionMulti.Text = "1";
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.Location = new System.Drawing.Point(1393, 173);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(109, 31);
            this.lbl_Position.TabIndex = 15;
            this.lbl_Position.Text = "Position:";
            // 
            // lbl_Skalierung
            // 
            this.lbl_Skalierung.AutoSize = true;
            this.lbl_Skalierung.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Skalierung.Location = new System.Drawing.Point(1683, 173);
            this.lbl_Skalierung.Name = "lbl_Skalierung";
            this.lbl_Skalierung.Size = new System.Drawing.Size(136, 31);
            this.lbl_Skalierung.TabIndex = 16;
            this.lbl_Skalierung.Text = "Skalierung:";
            // 
            // txt_Skalierung
            // 
            this.txt_Skalierung.Enabled = false;
            this.txt_Skalierung.Location = new System.Drawing.Point(1689, 205);
            this.txt_Skalierung.Name = "txt_Skalierung";
            this.txt_Skalierung.Size = new System.Drawing.Size(148, 31);
            this.txt_Skalierung.TabIndex = 17;
            this.txt_Skalierung.Text = "10000";
            this.txt_Skalierung.TextChanged += new System.EventHandler(this.txt_Skalierung_TextChanged);
            // 
            // comb_Medium
            // 
            this.comb_Medium.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_Medium.FormattingEnabled = true;
            this.comb_Medium.Items.AddRange(new object[] {
            "Bild",
            "Video"});
            this.comb_Medium.Location = new System.Drawing.Point(1071, 766);
            this.comb_Medium.Name = "comb_Medium";
            this.comb_Medium.Size = new System.Drawing.Size(191, 31);
            this.comb_Medium.TabIndex = 18;
            this.comb_Medium.SelectedIndexChanged += new System.EventHandler(this.comb_Medium_SelectedIndexChanged);
            // 
            // lbl_Medium
            // 
            this.lbl_Medium.AutoSize = true;
            this.lbl_Medium.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Medium.Location = new System.Drawing.Point(1065, 732);
            this.lbl_Medium.Name = "lbl_Medium";
            this.lbl_Medium.Size = new System.Drawing.Size(111, 31);
            this.lbl_Medium.TabIndex = 19;
            this.lbl_Medium.Text = "Medium:";
            // 
            // lbl_Format
            // 
            this.lbl_Format.AutoSize = true;
            this.lbl_Format.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Format.Location = new System.Drawing.Point(1065, 810);
            this.lbl_Format.Name = "lbl_Format";
            this.lbl_Format.Size = new System.Drawing.Size(98, 31);
            this.lbl_Format.TabIndex = 21;
            this.lbl_Format.Text = "Format:";
            // 
            // comb_Format
            // 
            this.comb_Format.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_Format.FormattingEnabled = true;
            this.comb_Format.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".bmp"});
            this.comb_Format.Location = new System.Drawing.Point(1071, 844);
            this.comb_Format.Name = "comb_Format";
            this.comb_Format.Size = new System.Drawing.Size(191, 31);
            this.comb_Format.TabIndex = 20;
            this.comb_Format.Text = ".png";
            this.comb_Format.SelectedIndexChanged += new System.EventHandler(this.comb_Format_SelectedIndexChanged);
            // 
            // btn_Erstellen
            // 
            this.btn_Erstellen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Erstellen.Location = new System.Drawing.Point(1071, 461);
            this.btn_Erstellen.Name = "btn_Erstellen";
            this.btn_Erstellen.Size = new System.Drawing.Size(276, 50);
            this.btn_Erstellen.TabIndex = 22;
            this.btn_Erstellen.Text = "Erstellen";
            this.btn_Erstellen.UseVisualStyleBackColor = true;
            this.btn_Erstellen.Click += new System.EventHandler(this.btn_Erstellen_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1071, 1059);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = "Bild Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prog_Wartezeit
            // 
            this.prog_Wartezeit.Location = new System.Drawing.Point(1071, 517);
            this.prog_Wartezeit.Name = "prog_Wartezeit";
            this.prog_Wartezeit.Size = new System.Drawing.Size(276, 34);
            this.prog_Wartezeit.TabIndex = 24;
            // 
            // txt_Genauigkeit
            // 
            this.txt_Genauigkeit.Location = new System.Drawing.Point(1689, 283);
            this.txt_Genauigkeit.Name = "txt_Genauigkeit";
            this.txt_Genauigkeit.Size = new System.Drawing.Size(148, 31);
            this.txt_Genauigkeit.TabIndex = 26;
            this.txt_Genauigkeit.Text = "100";
            // 
            // lbl_Genauigkeit
            // 
            this.lbl_Genauigkeit.AutoSize = true;
            this.lbl_Genauigkeit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genauigkeit.Location = new System.Drawing.Point(1683, 251);
            this.lbl_Genauigkeit.Name = "lbl_Genauigkeit";
            this.lbl_Genauigkeit.Size = new System.Drawing.Size(150, 31);
            this.lbl_Genauigkeit.TabIndex = 25;
            this.lbl_Genauigkeit.Text = "Genauigkeit:";
            // 
            // txt_Dateipfad
            // 
            this.txt_Dateipfad.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dateipfad.Location = new System.Drawing.Point(1071, 997);
            this.txt_Dateipfad.Name = "txt_Dateipfad";
            this.txt_Dateipfad.Size = new System.Drawing.Size(480, 32);
            this.txt_Dateipfad.TabIndex = 27;
            this.txt_Dateipfad.Text = "C:\\Users";
            // 
            // lbl_Dateipfad
            // 
            this.lbl_Dateipfad.AutoSize = true;
            this.lbl_Dateipfad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dateipfad.Location = new System.Drawing.Point(1065, 963);
            this.lbl_Dateipfad.Name = "lbl_Dateipfad";
            this.lbl_Dateipfad.Size = new System.Drawing.Size(163, 31);
            this.lbl_Dateipfad.TabIndex = 28;
            this.lbl_Dateipfad.Text = "Speicherpfad:";
            // 
            // btn_Durchsuchen
            // 
            this.btn_Durchsuchen.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Durchsuchen.Location = new System.Drawing.Point(1557, 990);
            this.btn_Durchsuchen.Name = "btn_Durchsuchen";
            this.btn_Durchsuchen.Size = new System.Drawing.Size(137, 43);
            this.btn_Durchsuchen.TabIndex = 29;
            this.btn_Durchsuchen.Text = "Durchsuchen";
            this.btn_Durchsuchen.UseVisualStyleBackColor = true;
            this.btn_Durchsuchen.Click += new System.EventHandler(this.btn_Durchsuchen_Click);
            // 
            // lbl_Keyframe
            // 
            this.lbl_Keyframe.AutoSize = true;
            this.lbl_Keyframe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Keyframe.Location = new System.Drawing.Point(1440, 732);
            this.lbl_Keyframe.Name = "lbl_Keyframe";
            this.lbl_Keyframe.Size = new System.Drawing.Size(125, 31);
            this.lbl_Keyframe.TabIndex = 30;
            this.lbl_Keyframe.Text = "Keyframe:";
            // 
            // btn_Erstellen1
            // 
            this.btn_Erstellen1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Erstellen1.Location = new System.Drawing.Point(1592, 729);
            this.btn_Erstellen1.Name = "btn_Erstellen1";
            this.btn_Erstellen1.Size = new System.Drawing.Size(137, 41);
            this.btn_Erstellen1.TabIndex = 32;
            this.btn_Erstellen1.Text = "Erstellen";
            this.btn_Erstellen1.UseVisualStyleBackColor = true;
            this.btn_Erstellen1.Click += new System.EventHandler(this.btn_Erstellen1_Click);
            // 
            // lbl_KeyInfo
            // 
            this.lbl_KeyInfo.AutoSize = true;
            this.lbl_KeyInfo.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeyInfo.Location = new System.Drawing.Point(1803, 46);
            this.lbl_KeyInfo.Name = "lbl_KeyInfo";
            this.lbl_KeyInfo.Size = new System.Drawing.Size(0, 25);
            this.lbl_KeyInfo.TabIndex = 34;
            // 
            // lbl_Framerate
            // 
            this.lbl_Framerate.AutoSize = true;
            this.lbl_Framerate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Framerate.Location = new System.Drawing.Point(1457, 827);
            this.lbl_Framerate.Name = "lbl_Framerate";
            this.lbl_Framerate.Size = new System.Drawing.Size(129, 31);
            this.lbl_Framerate.TabIndex = 36;
            this.lbl_Framerate.Text = "Framerate:";
            // 
            // lbl_Dauer
            // 
            this.lbl_Dauer.AutoSize = true;
            this.lbl_Dauer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dauer.Location = new System.Drawing.Point(1437, 865);
            this.lbl_Dauer.Name = "lbl_Dauer";
            this.lbl_Dauer.Size = new System.Drawing.Size(149, 31);
            this.lbl_Dauer.TabIndex = 37;
            this.lbl_Dauer.Text = "Dauer (in s):";
            // 
            // txt_Framerate
            // 
            this.txt_Framerate.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Framerate.Location = new System.Drawing.Point(1592, 826);
            this.txt_Framerate.Name = "txt_Framerate";
            this.txt_Framerate.Size = new System.Drawing.Size(137, 32);
            this.txt_Framerate.TabIndex = 38;
            // 
            // txt_Dauer
            // 
            this.txt_Dauer.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dauer.Location = new System.Drawing.Point(1592, 864);
            this.txt_Dauer.Name = "txt_Dauer";
            this.txt_Dauer.Size = new System.Drawing.Size(137, 32);
            this.txt_Dauer.TabIndex = 39;
            // 
            // prog_Video
            // 
            this.prog_Video.Location = new System.Drawing.Point(1656, 1059);
            this.prog_Video.Name = "prog_Video";
            this.prog_Video.Size = new System.Drawing.Size(327, 43);
            this.prog_Video.TabIndex = 40;
            // 
            // btn_VideoSpeichern
            // 
            this.btn_VideoSpeichern.Enabled = false;
            this.btn_VideoSpeichern.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VideoSpeichern.Location = new System.Drawing.Point(1399, 1059);
            this.btn_VideoSpeichern.Name = "btn_VideoSpeichern";
            this.btn_VideoSpeichern.Size = new System.Drawing.Size(251, 43);
            this.btn_VideoSpeichern.TabIndex = 41;
            this.btn_VideoSpeichern.Text = "Video Speichern";
            this.btn_VideoSpeichern.UseVisualStyleBackColor = true;
            this.btn_VideoSpeichern.Click += new System.EventHandler(this.btn_VideoSpeichern_Click);
            // 
            // txt_Keyframenummer
            // 
            this.txt_Keyframenummer.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Keyframenummer.Location = new System.Drawing.Point(1592, 776);
            this.txt_Keyframenummer.Name = "txt_Keyframenummer";
            this.txt_Keyframenummer.Size = new System.Drawing.Size(137, 32);
            this.txt_Keyframenummer.TabIndex = 42;
            this.txt_Keyframenummer.Text = "1";
            this.txt_Keyframenummer.TextChanged += new System.EventHandler(this.txt_Keyframenummer_TextChanged);
            // 
            // list_Keyframes
            // 
            this.list_Keyframes.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Keyframes.FormattingEnabled = true;
            this.list_Keyframes.ItemHeight = 23;
            this.list_Keyframes.Location = new System.Drawing.Point(1762, 732);
            this.list_Keyframes.Name = "list_Keyframes";
            this.list_Keyframes.Size = new System.Drawing.Size(221, 142);
            this.list_Keyframes.TabIndex = 43;
            // 
            // btn_Zurueksetzen
            // 
            this.btn_Zurueksetzen.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zurueksetzen.Location = new System.Drawing.Point(1762, 880);
            this.btn_Zurueksetzen.Name = "btn_Zurueksetzen";
            this.btn_Zurueksetzen.Size = new System.Drawing.Size(221, 41);
            this.btn_Zurueksetzen.TabIndex = 44;
            this.btn_Zurueksetzen.Text = "Zurücksetzen";
            this.btn_Zurueksetzen.UseVisualStyleBackColor = true;
            this.btn_Zurueksetzen.Click += new System.EventHandler(this.btn_Zurueksetzen_Click);
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.Location = new System.Drawing.Point(1537, 342);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(45, 25);
            this.lbl_X.TabIndex = 45;
            this.lbl_X.Text = "x: 0";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Y.Location = new System.Drawing.Point(1536, 367);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(46, 25);
            this.lbl_Y.TabIndex = 46;
            this.lbl_Y.Text = "y: 0";
            // 
            // lbl_Farbe
            // 
            this.lbl_Farbe.AutoSize = true;
            this.lbl_Farbe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Farbe.Location = new System.Drawing.Point(1683, 379);
            this.lbl_Farbe.Name = "lbl_Farbe";
            this.lbl_Farbe.Size = new System.Drawing.Size(82, 31);
            this.lbl_Farbe.TabIndex = 47;
            this.lbl_Farbe.Text = "Farbe:";
            // 
            // comb_Farbe
            // 
            this.comb_Farbe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_Farbe.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_Farbe.FormattingEnabled = true;
            this.comb_Farbe.Items.AddRange(new object[] {
            "SW",
            "Rot",
            "Gruen",
            "Blau",
            "Multi 1",
            "Multi 2",
            "Eigene"});
            this.comb_Farbe.Location = new System.Drawing.Point(1689, 413);
            this.comb_Farbe.Name = "comb_Farbe";
            this.comb_Farbe.Size = new System.Drawing.Size(228, 31);
            this.comb_Farbe.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2045, 1136);
            this.Controls.Add(this.comb_Farbe);
            this.Controls.Add(this.lbl_Farbe);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.btn_Zurueksetzen);
            this.Controls.Add(this.list_Keyframes);
            this.Controls.Add(this.txt_Keyframenummer);
            this.Controls.Add(this.btn_VideoSpeichern);
            this.Controls.Add(this.prog_Video);
            this.Controls.Add(this.txt_Dauer);
            this.Controls.Add(this.txt_Framerate);
            this.Controls.Add(this.lbl_Dauer);
            this.Controls.Add(this.lbl_Framerate);
            this.Controls.Add(this.lbl_KeyInfo);
            this.Controls.Add(this.btn_Erstellen1);
            this.Controls.Add(this.lbl_Keyframe);
            this.Controls.Add(this.btn_Durchsuchen);
            this.Controls.Add(this.lbl_Dateipfad);
            this.Controls.Add(this.txt_Dateipfad);
            this.Controls.Add(this.txt_Genauigkeit);
            this.Controls.Add(this.lbl_Genauigkeit);
            this.Controls.Add(this.prog_Wartezeit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Erstellen);
            this.Controls.Add(this.lbl_Format);
            this.Controls.Add(this.comb_Format);
            this.Controls.Add(this.lbl_Medium);
            this.Controls.Add(this.comb_Medium);
            this.Controls.Add(this.txt_Skalierung);
            this.Controls.Add(this.lbl_Skalierung);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.txt_PositionMulti);
            this.Controls.Add(this.btn_Links);
            this.Controls.Add(this.btn_Hoch);
            this.Controls.Add(this.btn_Rechts);
            this.Controls.Add(this.btn_Runter);
            this.Controls.Add(this.lbl_H);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.txt_Hoehe);
            this.Controls.Add(this.txt_Breite);
            this.Controls.Add(this.comb_Groesse);
            this.Controls.Add(this.lbl_Groesse);
            this.Controls.Add(this.lbl_Erstellen);
            this.Controls.Add(this.pic_MandelBild);
            this.Controls.Add(this.lbl_Exportieren);
            this.Controls.Add(this.lbl_MandelbrotGenerator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(2071, 1207);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pic_MandelBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MandelbrotGenerator;
        private System.Windows.Forms.Label lbl_Exportieren;
        private System.Windows.Forms.PictureBox pic_MandelBild;
        private System.Windows.Forms.Label lbl_Erstellen;
        private System.Windows.Forms.Label lbl_Groesse;
        private System.Windows.Forms.ComboBox comb_Groesse;
        private System.Windows.Forms.TextBox txt_Breite;
        private System.Windows.Forms.TextBox txt_Hoehe;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_H;
        private System.Windows.Forms.Button btn_Runter;
        private System.Windows.Forms.Button btn_Rechts;
        private System.Windows.Forms.Button btn_Hoch;
        private System.Windows.Forms.Button btn_Links;
        private System.Windows.Forms.TextBox txt_PositionMulti;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label lbl_Skalierung;
        private System.Windows.Forms.TextBox txt_Skalierung;
        private System.Windows.Forms.ComboBox comb_Medium;
        private System.Windows.Forms.Label lbl_Medium;
        private System.Windows.Forms.Label lbl_Format;
        private System.Windows.Forms.ComboBox comb_Format;
        private System.Windows.Forms.Button btn_Erstellen;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar prog_Wartezeit;
        private System.Windows.Forms.TextBox txt_Genauigkeit;
        private System.Windows.Forms.Label lbl_Genauigkeit;
        private System.Windows.Forms.TextBox txt_Dateipfad;
        private System.Windows.Forms.Label lbl_Dateipfad;
        private System.Windows.Forms.Button btn_Durchsuchen;
        private System.Windows.Forms.Label lbl_Keyframe;
        private System.Windows.Forms.Button btn_Erstellen1;
        private System.Windows.Forms.Label lbl_KeyInfo;
        private System.Windows.Forms.Label lbl_Framerate;
        private System.Windows.Forms.Label lbl_Dauer;
        private System.Windows.Forms.TextBox txt_Framerate;
        private System.Windows.Forms.TextBox txt_Dauer;
        private System.Windows.Forms.ProgressBar prog_Video;
        private System.Windows.Forms.Button btn_VideoSpeichern;
        private System.Windows.Forms.TextBox txt_Keyframenummer;
        private System.Windows.Forms.ListBox list_Keyframes;
        private System.Windows.Forms.Button btn_Zurueksetzen;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_Farbe;
        private System.Windows.Forms.ComboBox comb_Farbe;
    }
}

