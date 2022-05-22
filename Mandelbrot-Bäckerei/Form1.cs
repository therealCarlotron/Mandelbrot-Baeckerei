using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_Bäckerei
{
    public partial class Form1 : Form
    {
        //Allgemeine Variablen
        Bitmap Speichern;
        private int Breite = 500;
        private int Hoehe = 500;
        private double xVerschiebung = 0;
        private double yVerschiebung = 0;
        private double Skalierung = 10000;
        private double SkalierungAlt = 10000;
        private bool Skaliert = false;
        private double[] xVerschiebungKey = new double[10];
        private double[] yVerschiebungKey = new double[10];
        private double[] SkalierungKey = new double[10];
        private int Keyframenummer = 1;
        //Farben
        private Color SW(int AnzahlWdh, int Genauigkeit)
        {
            int Werte = Convert.ToInt32(((double)AnzahlWdh / (double)Genauigkeit) * 255.0);
            Color SW = Color.FromArgb(255, Werte, Werte, Werte);
            return SW;
        }
        private Color Rot(int AnzahlWdh, int Genauigkeit)
        {
            int Werte = Convert.ToInt32(((double)AnzahlWdh / (double)Genauigkeit) * 255.0);
            Color Rot = Color.FromArgb(255, Werte, 0, 0);
            return Rot;
        }
        private Color Gruen(int AnzahlWdh, int Genauigkeit)
        {
            int Werte = Convert.ToInt32(((double)AnzahlWdh / (double)Genauigkeit) * 255.0);
            Color Gruen = Color.FromArgb(255, 0, Werte, 0);
            return Gruen;
        }
        private Color Blau(int AnzahlWdh, int Genauigkeit)
        {
            int Werte = Convert.ToInt32(((double)AnzahlWdh / (double)Genauigkeit) * 255.0);
            Color Blau = Color.FromArgb(255, 0, 0, Werte);
            return Blau;
        }
        private Color Multi(int AnzahlWdh, int Genauigkeit)
        {
            double Pruef = ((double)AnzahlWdh / (double)Genauigkeit) * 100.0;
            int Werte = Convert.ToInt32(((double)AnzahlWdh / (double)Genauigkeit) * 10);
            Color Multi = Color.White;
            if (Pruef < 10)
            {
                Multi = Color.FromArgb(255, 0, 60 + Werte, 0);
            }
            else if (10 <= Pruef & Pruef < 20)
            {
                Multi = Color.FromArgb(255, 50, 180 + Werte, 100);
            }
            else if (20 <= Pruef & Pruef < 30)
            {
                Multi = Color.FromArgb(255, 30, 30, 200 + Werte);
            }
            else if (30 <= Pruef & Pruef < 40)
            {
                Multi = Color.FromArgb(255, 240 + Werte, 60, 200 + Werte);
            }
            else if (40 <= Pruef & Pruef < 50)
            {
                Multi = Color.FromArgb(255, Werte, 20, 200 + Werte);
            }
            else if (50 <= Pruef & Pruef < 60)
            {
                Multi = Color.FromArgb(255, Werte + 240, 0, 240 + Werte);
            }
            else if (60 <= Pruef & Pruef < 70)
            {
                Multi = Color.FromArgb(255, 0, 240 + Werte, 240 + Werte);
            }
            else if (70 <= Pruef & Pruef < 80)
            {
                Multi = Color.FromArgb(255, 240 + Werte, 240 + Werte, 0);
            }
            else if (80 <= Pruef & Pruef < 90)
            {
                Multi = Color.FromArgb(255, Werte + 240, 0, 0);
            }
            else
            {
                Multi = Color.FromArgb(255, 0, 0, 240 + Werte);
            }
            return Multi;
        }
        private Color Multi2(int AnzahlWdh, int Genauigkeit)
        {
            int Werte = Convert.ToInt32(((double)AnzahlWdh / (double)Genauigkeit) * 255.0);
            Color Multi2 = Color.FromArgb(255, Werte, 255 - Werte, Convert.ToInt32(100.0 + (double)Werte / 2.0));
            return Multi2;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void MandelnFrischUndHeiss()
        {
            //Bild einstellen
            Bitmap MeinMandelbrot;
            MeinMandelbrot = new Bitmap(Breite, Hoehe);
            Color Hintergrund = Color.FromArgb(255, 255, 255, 255);
            Graphics g = Graphics.FromImage(MeinMandelbrot);
            g.Clear(Hintergrund);

            //Wertematrix einstellen
            double[,,] Wertematrix = new double[Breite, Hoehe, 2];
            for (int i = 0; i < Breite; i++)
            {
                for (int j = 0; j < Hoehe; j++)
                {
                    Wertematrix[i, j, 0] = -1 * ((Breite / 2) - i);
                    Wertematrix[i, j, 1] = (Hoehe / 2) - j;
                }
            }

            //Position aendern
            for (int i = 0; i < Breite; i++)
            {
                for (int j = 0; j < Hoehe; j++)
                {
                    if (Skaliert)
                    {
                        xVerschiebung = xVerschiebung * (Skalierung / SkalierungAlt);
                        yVerschiebung = yVerschiebung * (Skalierung / SkalierungAlt);
                        Skaliert = false;
                    }
                    Wertematrix[i, j, 0] = Wertematrix[i, j, 0] + xVerschiebung;
                    Wertematrix[i, j, 1] = Wertematrix[i, j, 1] + yVerschiebung;
                }
            }

            //Skalieren
            for (int i = 0; i < Breite; i++)
            {
                for (int j = 0; j < Hoehe; j++)
                {
                    Wertematrix[i, j, 0] = Wertematrix[i, j, 0] * (100 / Skalierung);
                    Wertematrix[i, j, 1] = Wertematrix[i, j, 1] * (100 / Skalierung);
                }
            }

            //Berechnungen fuer Mandelbrot
            Color NichtsFarbe = Color.Black;
            double c1;
            double c2;
            double z1 = 0;
            double z2 = 0;
            int u = 1;
            double tmp = 0;
            int Genauigkeit = Convert.ToInt32(txt_Genauigkeit.Text);
            Color FarbenAmRande = Color.White;

            for (int i = 0; i < Breite; i++)
            {
                for (int j = 0; j < Hoehe; j++)
                {
                    c1 = Wertematrix[i, j, 0];
                    c2 = Wertematrix[i, j, 1];
                    u = 1;
                    z1 = 0;
                    z2 = 0;
                    while (Math.Sqrt(z1 * z1 + z2 * z2) <= 2 & u < Genauigkeit)
                    {
                        tmp = (z1 * z1) - (z2 * z2) + c1;
                        z2 = 2 * z1 * z2 + c2;
                        z1 = tmp;
                        double Betrag = (z1 * z1) + (z2 * z2);
                        u++;
                    }
                    if (u >= Genauigkeit)
                    {
                        MeinMandelbrot.SetPixel(i, j, NichtsFarbe);
                    }
                    else
                    {
                        if (comb_Farbe.SelectedIndex == 1)
                        {
                            FarbenAmRande = Rot(u, Genauigkeit);
                        }
                        else if (comb_Farbe.SelectedIndex == 2)
                        {
                            FarbenAmRande = Gruen(u, Genauigkeit);
                        }
                        else if (comb_Farbe.SelectedIndex == 3)
                        {
                            FarbenAmRande = Blau(u, Genauigkeit);
                        }
                        else if (comb_Farbe.SelectedIndex == 4)
                        {
                            FarbenAmRande = Multi(u, Genauigkeit);
                        }
                        else if (comb_Farbe.SelectedIndex == 5)
                        {
                            FarbenAmRande = Multi2(u, Genauigkeit);
                        }
                        else
                        {
                            FarbenAmRande = SW(u, Genauigkeit);
                        }
                        
                        MeinMandelbrot.SetPixel(i, j, FarbenAmRande);
                    }
                    prog_Wartezeit.Value = Convert.ToInt32(((double)i / (double)Breite) * 100.0);

                }
            }
            lbl_X.Text = "x: " + xVerschiebung;
            lbl_Y.Text = "y: " + yVerschiebung;

            //Bild ausgeben
            pic_MandelBild.Image = MeinMandelbrot;
            Speichern = MeinMandelbrot;
        }

        private void PunktEinfaerben(double xKoordinate, double yKoordinate)
        {

        }
        
        private void btn_Erstellen_Click(object sender, EventArgs e)
        {
            //Mandelbrot backen
            MandelnFrischUndHeiss();

            //Knoepfe freigeben
            btn_Hoch.Enabled = true;
            btn_Runter.Enabled = true;
            btn_Rechts.Enabled = true;
            btn_Links.Enabled = true;
            txt_PositionMulti.Enabled = true;
            txt_Skalierung.Enabled = true;
        }

        private void comb_Groesse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_Groesse.SelectedIndex == 0)
            {
                txt_Breite.Enabled = false;
                txt_Hoehe.Enabled = false;
                txt_Breite.Text = "4096";
                txt_Hoehe.Text = "2304";
            }
            if (comb_Groesse.SelectedIndex == 1)
            {
                txt_Breite.Enabled = false;
                txt_Hoehe.Enabled = false;
                txt_Breite.Text = "1920";
                txt_Hoehe.Text = "1080";
            }
            if (comb_Groesse.SelectedIndex == 2)
            {
                txt_Breite.Enabled = false;
                txt_Hoehe.Enabled = false;
                txt_Breite.Text = "1280";
                txt_Hoehe.Text = "720";
            }
            if (comb_Groesse.SelectedIndex == 3)
            {
                txt_Breite.Enabled = true;
                txt_Hoehe.Enabled = true;
            }
        }

        private void txt_Breite_TextChanged(object sender, EventArgs e)
        {
            Breite = Convert.ToInt32(txt_Breite.Text);
        }

        private void txt_Hoehe_TextChanged(object sender, EventArgs e)
        {
            Hoehe = Convert.ToInt32(txt_Hoehe.Text);
        }

        private void btn_Hoch_Click(object sender, EventArgs e)
        {
            yVerschiebung = yVerschiebung + Convert.ToDouble(txt_PositionMulti.Text);
            lbl_Y.Text = "y: " + yVerschiebung.ToString();
            MandelnFrischUndHeiss();
        }

        private void btn_Runter_Click(object sender, EventArgs e)
        {
            yVerschiebung = yVerschiebung - Convert.ToDouble(txt_PositionMulti.Text);
            lbl_Y.Text = "y: " + yVerschiebung.ToString();
            MandelnFrischUndHeiss();
        }

        private void btn_Rechts_Click(object sender, EventArgs e)
        {
            xVerschiebung = xVerschiebung - Convert.ToDouble(txt_PositionMulti.Text);
            lbl_X.Text = "x: " + xVerschiebung.ToString();
            MandelnFrischUndHeiss();
        }

        private void btn_Links_Click(object sender, EventArgs e)
        {
            xVerschiebung = xVerschiebung + Convert.ToDouble(txt_PositionMulti.Text);
            lbl_X.Text = "x: " + xVerschiebung.ToString();
            MandelnFrischUndHeiss();
        }

        private void txt_Skalierung_TextChanged(object sender, EventArgs e)
        {
            SkalierungAlt = Skalierung;
            Skalierung = Convert.ToDouble(txt_Skalierung.Text);
            Skaliert = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Speichern.Save(@txt_Dateipfad.Text + comb_Format.Text);
        }

        private void btn_Durchsuchen_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Halt alles Zeug (*.*)|*.*";
            saveFileDialog.InitialDirectory = @"C:\Users";
            saveFileDialog.ShowDialog();
            txt_Dateipfad.Text = saveFileDialog.FileName;
        }

        private void btn_Erstellen1_Click(object sender, EventArgs e)
        {
            Keyframenummer = Convert.ToInt32(txt_Keyframenummer.Text);
            xVerschiebungKey[Keyframenummer - 1] = xVerschiebung;
            yVerschiebungKey[Keyframenummer - 1] = yVerschiebung;
            SkalierungKey[Keyframenummer - 1] = Skalierung;
            list_Keyframes.Items.Add("Pos.: " + xVerschiebungKey[Keyframenummer - 1].ToString() + " " +
                yVerschiebungKey[Keyframenummer - 1].ToString() + " Skal.: "
                + SkalierungKey[Keyframenummer - 1].ToString());
            Keyframenummer++;
            txt_Keyframenummer.Text = Keyframenummer.ToString();
        }

        private void txt_Keyframenummer_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Zurueksetzen_Click(object sender, EventArgs e)
        {
            txt_Keyframenummer.Text = "1";
            Keyframenummer = 1;
            list_Keyframes.Items.Clear();
        }

        private void btn_VideoSpeichern_Click(object sender, EventArgs e)
        {
            //Video erstellen
            int AnzBilder = Convert.ToInt32(txt_Framerate.Text) * Convert.ToInt32(txt_Dauer.Text);
            double SteigungY = (yVerschiebungKey[1] - yVerschiebungKey[0]) / ((double)AnzBilder * (double)AnzBilder * (double)AnzBilder);
            double SteigungX = (xVerschiebungKey[1] - xVerschiebungKey[0]) / ((double)AnzBilder * (double)AnzBilder * (double)AnzBilder);
            double SteigungSkalierung = (SkalierungKey[1] - SkalierungKey[0]) / ((double)AnzBilder * (double)AnzBilder * (double)AnzBilder);
            for (int i = 0; i < AnzBilder; i++)
            {
                //xVerschiebungKey[0] + (xVerschiebungKey[1] - xVerschiebungKey[0]) / (double)AnzBilder * (double)i
                xVerschiebung = SteigungX * (double)i * (double)i * (double)i + xVerschiebungKey[0];
                yVerschiebung = SteigungY * (double)i * (double)i * (double)i + yVerschiebungKey[0];
                Skalierung = SteigungSkalierung * (double)i * (double)i * (double)i + SkalierungKey[0];
                Console.WriteLine("X: " + xVerschiebung.ToString() + " Y: " + yVerschiebung.ToString() + " Skal.: " + Skalierung.ToString());
                MandelnFrischUndHeiss();
                Speichern.Save(@txt_Dateipfad.Text + i.ToString() + comb_Format.Text);
                prog_Video.Value = Convert.ToInt32((double)i / (double)AnzBilder * 100.0);
            }
            prog_Video.Value = 0;
        }

        private void comb_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comb_Medium_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_Medium.SelectedIndex == 0)
            {
                button1.Enabled = true;
                btn_VideoSpeichern.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                btn_VideoSpeichern.Enabled = true;
            }
        }
    }
}
