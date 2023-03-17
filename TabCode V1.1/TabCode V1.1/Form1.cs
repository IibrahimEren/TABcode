using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabCode_V1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region HARFTEN RAKAMLARA BAŞLANGIÇ
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) &&
                (e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '?' && e.KeyChar != '!'))
                e.Handled = true;
            if ((e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] Harfler;
            Harfler = textBox1.Text.ToArray();
            string cevrilmişifade = "";
            foreach (var item in Harfler)
            {
                try
                {
                    switch (item)
                    {
                        case 'A':
                        case 'a':
                            cevrilmişifade += "" + "11";
                            break;
                        case 'B':
                        case 'b':
                            cevrilmişifade += "" + "12";
                            break;
                        case 'C':
                        case 'c':
                            cevrilmişifade += "" + "13";
                            break;
                            break;
                        case 'D':
                        case 'd':
                            cevrilmişifade += "" + "14";
                            break;
                        case 'E':
                        case 'e':
                            cevrilmişifade += "" + "15";
                            break;
                        case 'F':
                        case 'f':
                            cevrilmişifade += "" + "21";
                            break;
                        case 'G':
                        case 'g':
                            cevrilmişifade += "" + "22";
                            break;
                        case 'H':
                        case 'h':
                            cevrilmişifade += "" + "23";
                            break;
                        case 'I':
                        case 'i':
                            cevrilmişifade += "" + "24";
                            break;
                        case 'J':
                        case 'j':
                            cevrilmişifade += "" + "25";
                            break;
                        case 'L':
                        case 'l':
                            cevrilmişifade += "" + "31";
                            break;
                        case 'M':
                        case 'm':
                            cevrilmişifade += "" + "32";
                            break;
                        case 'N':
                        case 'n':
                            cevrilmişifade += "" + "33";
                            break;
                        case 'O':
                        case 'o':
                            cevrilmişifade += "" + "34";
                            break;
                        case 'P':
                        case 'p':
                            cevrilmişifade += "" + "35";
                            break;
                        case 'Q':
                        case 'q':
                            cevrilmişifade += "" + "41";
                            break;
                        case 'R':
                        case 'r':
                            cevrilmişifade += "" + "42";
                            break;
                        case 'S':
                        case 's':
                            cevrilmişifade += "" + "43";
                            break;
                        case 'T':
                        case 't':
                            cevrilmişifade += "" + "44";
                            break;
                        case 'U':
                        case 'u':
                            cevrilmişifade += "" + "45";
                            break;
                        case 'V':
                        case 'v':
                            cevrilmişifade += "" + "51";
                            break;
                        case 'Y':
                        case 'y':
                            cevrilmişifade += "" + "54";
                            break;
                        case 'W':
                        case 'w':
                            cevrilmişifade += "" + "52";
                            break;
                        case 'X':
                        case 'x':
                            cevrilmişifade += "" + "53";
                            break;
                        case 'Z':
                        case 'z':
                            cevrilmişifade += "" + "55";
                            break;
                        case 'K':
                        case 'k':
                            cevrilmişifade += "61";
                            break;
                        case 'ı':
                            cevrilmişifade += "16";
                            break;
                        case 'Ö':
                        case 'ö':
                            cevrilmişifade += "64";
                            break;
                        case 'Ü':
                        case 'ü':
                            cevrilmişifade += "63";
                            break;
                        case 'Ç':
                        case 'ç':
                            cevrilmişifade += "65";
                            break;
                        case 'Ğ':
                        case 'ğ':
                            cevrilmişifade += "62";
                            break;
                        case 'Ş':
                        case 'ş':
                            cevrilmişifade += "26";
                            break;
                        case ' ':
                            cevrilmişifade += "" + " ";
                            break;
                        case '.':
                            cevrilmişifade += "36";
                            break;
                        case ',':
                            cevrilmişifade += "46";
                            break;
                        case '?':
                            cevrilmişifade += "56";
                            break;
                        case '!':
                            cevrilmişifade += "66";
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    textBox1.Focus();
                }
            }
            textBox2.Text = (cevrilmişifade);
        }
        #endregion HARFTEN RAKAMLARA SON
        #region RAKAMLARDAN HARFLERE  BAŞLANGIÇ
        private void txtRakamlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '?' && e.KeyChar != '!'))
                e.Handled = true;
            if ((e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            char[] rakam;
            rakam = txtRakamlar.Text.ToArray();
            string harfler = "";
            if (txtRakamlar.Text == "")
                errorProvider1.SetError(txtRakamlar, "Boş bırakmamayı unutmayın"); 
            for (int i = 0; i < rakam.Length; i++)
            {
                if (i + 1 == rakam.Length)
                {
                    break;
                }
                else
                {
                    if (rakam[i].ToString() == "1")
                    {
                        if (rakam[i + 1].ToString() == "1")
                        {
                            harfler += "A";
                        }
                        else if (rakam[i + 1].ToString() == "2")
                        {
                            harfler += "B";
                        }
                        else if (rakam[i + 1].ToString() == "3")
                        {
                            harfler += "C";
                        }
                        else if (rakam[i + 1].ToString() == "4")
                        {
                            harfler += "D";
                        }
                        else if (rakam[i + 1].ToString() == "5")
                        {
                            harfler += "E";
                        }
                        else if (rakam[i + 1].ToString() == "6")
                            harfler += "I";
                        else
                            harfler += "*";
                    }
                    else if (rakam[i].ToString() == "2")
                    {
                        if (rakam[i + 1].ToString() == "1")
                        {
                            harfler += "F";
                        }
                        else if (rakam[i + 1].ToString() == "2")
                        {
                            harfler += "G";
                        }
                        else if (rakam[i + 1].ToString() == "3")
                        {
                            harfler += "H";
                        }
                        else if (rakam[i + 1].ToString() == "4")
                        {
                            harfler += "I";
                        }
                        else if (rakam[i + 1].ToString() == "5")
                        {
                            harfler += "J";
                        }
                        else if (rakam[i + 1].ToString() == "6")
                            harfler += "Ş";
                        else
                            harfler += "*";
                    }
                    else if (rakam[i].ToString() == "3")
                    {
                        if (rakam[i + 1].ToString() == "1")
                        {
                            harfler += "L";
                        }
                        else if (rakam[i + 1].ToString() == "2")
                        {
                            harfler += "M";
                        }
                        else if (rakam[i + 1].ToString() == "3")
                        {
                            harfler += "N";
                        }
                        else if (rakam[i + 1].ToString() == "4")
                        {
                            harfler += "O";
                        }
                        else if (rakam[i + 1].ToString() == "5")
                        {
                            harfler += "P";
                        }
                        else if (rakam[i + 1].ToString() == "6")
                            harfler += ".";
                        else
                            harfler += "*";
                    }
                    else if (rakam[i].ToString() == "4")
                    {
                        if (rakam[i + 1].ToString() == "1")
                        {
                            harfler += "Q";
                        }
                        else if (rakam[i + 1].ToString() == "2")
                        {
                            harfler += "R";
                        }
                        else if (rakam[i + 1].ToString() == "3")
                        {
                            harfler += "S";
                        }
                        else if (rakam[i + 1].ToString() == "4")
                        {
                            harfler += "T";
                        }
                        else if (rakam[i + 1].ToString() == "5")
                        {
                            harfler += "U";
                        }
                        else if (rakam[i + 1].ToString() == "6")
                            harfler += ",";
                        else
                            harfler += "*";
                    }
                    else if (rakam[i].ToString() == "5")
                    {
                        if (rakam[i + 1].ToString() == "1")
                        {
                            harfler += "V";
                        }
                        else if (rakam[i + 1].ToString() == "2")
                        {
                            harfler += "W";
                        }
                        else if (rakam[i + 1].ToString() == "3")
                        {
                            harfler += "X";
                        }
                        else if (rakam[i + 1].ToString() == "4")
                        {
                            harfler += "Y";
                        }
                        else if (rakam[i + 1].ToString() == "5")
                        {
                            harfler += "Z";
                        }
                        else if (rakam[i + 1].ToString() == "6")
                            harfler += "?";
                        else
                            harfler += "*";
                    }
                    //tamam burasını ilerleticem ya
                    else if (rakam[i].ToString() == "6")
                    {
                        if (rakam[i + 1].ToString() == "1")
                            harfler += "K";
                        else if (rakam[i + 1].ToString() == "2")
                            harfler += "Ğ";
                        else if (rakam[i + 1].ToString() == "3")
                            harfler += "Ü";
                        else if (rakam[i + 1].ToString() == "4")
                            harfler += "Ö";
                        else if (rakam[i + 1].ToString() == "5")
                            harfler += "Ç";
                        else if (rakam[i + 1].ToString() == "6")
                            harfler += "!";
                    }
                    else if (rakam[i].ToString() == ",")
                        harfler += ",";
                    else if (rakam[i].ToString() == ".")
                        harfler += ".";
                    else if (rakam[i].ToString() == "?")
                        harfler += "?";
                    else if (rakam[i].ToString() == "!")
                        harfler += "!";
                    else if (rakam[i].ToString() == " ")
                    {
                        harfler += " ";
                        continue;
                    }

                    else
                        harfler += "*";

                    i++;
                }

            }
            txtHarfler.Text = harfler;
        }
        #endregion RAKAMLARDAN HARFLERE SON

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = btnCevir;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            textBox1.Focus();
        }
    }
}
