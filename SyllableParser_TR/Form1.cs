using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SyllableParser_TR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HataBildir(string text)
        {
            MessageBox.Show(text, "Hata", MessageBoxButtons.OK);
        }

        private void Hecele()
        {
            List<string> heceler = new List<string>();

            string[] sozcukler = tbGirilenMetin.Text
                .Replace("\'", "").Replace("-", "").Replace("’", "")
                .Split(' ', '.', ',', ';', ':');

            try
            {
                foreach (string sozcuk in sozcukler)
                {
                    char[] harfler = sozcuk.ToCharArray();
                    string hece = string.Empty;
                    int uzunluk = harfler.Length;

                    for (int i = 0; i < uzunluk; i++)
                    {
                        if (harfler[i].SesliHarfMi())
                        {
                            if (i + 2 < uzunluk)
                            {
                                if (harfler[i + 2].SesliHarfMi())
                                {
                                    hece = harfler[i].ToString();
                                    i += 0;
                                }
                                else
                                {
                                    hece = harfler[i].ToString() +
                                        harfler[i + 1].ToString();
                                    i += 1;
                                }
                            }
                            else if (i + 1 < uzunluk)
                            {
                                hece = harfler[i].ToString() +
                                           harfler[i + 1].ToString();
                                i += 1;
                            }
                            else
                            {
                                hece = harfler[i].ToString();
                                i += 1;
                            }
                        }
                        else if (harfler[i].RakamMi())
                        {
                            hece = harfler[i].ToString();
                            i += 0;
                        }
                        else
                        {
                            if (i + 3 < uzunluk)
                            {
                                if (harfler[i + 3].SesliHarfMi())
                                {
                                    hece = harfler[i].ToString() +
                                        harfler[i + 1].ToString();
                                    i += 1;
                                }
                                else
                                {
                                    if (i + 4 < uzunluk)
                                    {
                                        if (harfler[i + 4].SesliHarfMi())
                                        {
                                            hece = harfler[i].ToString() +
                                                harfler[i + 1].ToString() +
                                                harfler[i + 2].ToString();
                                            i += 2;
                                        }
                                        else
                                        {
                                            hece = harfler[i].ToString() +
                                                harfler[i + 1].ToString() +
                                                harfler[i + 2].ToString() +
                                                harfler[i + 3].ToString();
                                            i += 3;
                                        }
                                    }
                                    else
                                    {
                                        hece = harfler[i].ToString() +
                                                harfler[i + 1].ToString() +
                                                harfler[i + 2].ToString() +
                                                harfler[i + 3].ToString();
                                        i += 3;
                                    }
                                }
                            }
                            else
                            {
                                if (i + 2 < uzunluk)
                                {
                                    hece = harfler[i].ToString() +
                                        harfler[i + 1].ToString() +
                                        harfler[i + 2].ToString();
                                    i += 2;
                                }
                                else
                                {
                                    hece = harfler[i].ToString() +
                                        harfler[i + 1].ToString();
                                    i += 1;
                                }
                            }
                        }

                        heceler.Add(hece);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                //MessageBox.Show("Eksik harf! Sözcük Türkçe değil veya yanlış yazılmış.", "Hata");
            }

            tbHeceSayisi.Text = heceler.Count.ToString();
            tbHeceler.Clear();

            foreach (string syllable in heceler)
            {
                tbHeceler.AppendText(syllable + "-");
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            Hecele();
        }

        private void tbGirilenMetin_TextChanged(object sender, EventArgs e)
        {
            if (tbGirilenMetin.Text.Equals("about me", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("(c) Fatih YAZICI, 2015", "Yazılım Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbGirilenMetin.Clear();
                tbHeceler.Clear();
            }
            else
            {
                Hecele();
            }
        }
    }

    public static class MyCharExtensionClass
    {
        public static bool SesliHarfMi(this char c)
        {
            string vowels = "aeıioöuüAEIİOÖUÜâîûÂÎÛ";
            if (vowels.Contains(c.ToString()))
                return true;
            else
                return false;
        }
        public static bool RakamMi(this char c)
        {
            string digits = "0123456789";
            if (digits.Contains(c.ToString()))
                return true;
            else
                return false;
        }
    }
}
