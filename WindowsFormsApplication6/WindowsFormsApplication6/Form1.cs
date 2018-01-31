using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        private int[] melyni = new int[5];
        private int[] juodi = new int[5];
        private int[] raudoni = new int[5];
        private int[] geltoni = new int[5];
        private int[] zali = new int[5];
        public Random rng = new Random();
        private int kal = 0;
        private bool loop = false;
        private bool gen = false;

        public Form1()
        {
            InitializeComponent();
        }

        public int[] genera (int a, int b)
        {
            int i = 0;
            int[] tempor = new int[5];
            while (i < 5)
            {
                int temp = rng.Next(a, b);
                int flag = 0;
                foreach (int sk in tempor)
                {
                    if (sk == temp)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    tempor[i] = temp;
                    i++;
                }

            }
            return tempor;
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            melyni = genera(1, 15);
            juodi = genera(16, 30);
            raudoni = genera(31, 45);
            geltoni = genera(46, 60);
            zali = genera(61, 75);
            //-------------------------------------------
            M1.Text = melyni[0].ToString();
            M2.Text = melyni[1].ToString();
            M3.Text = melyni[2].ToString();
            M4.Text = melyni[3].ToString();
            M5.Text = melyni[4].ToString();

            J1.Text = juodi[0].ToString();
            J2.Text = juodi[1].ToString();
            J3.Text = juodi[2].ToString();
            J4.Text = juodi[3].ToString();
            J5.Text = juodi[4].ToString();

            R1.Text = raudoni[0].ToString();
            R2.Text = raudoni[1].ToString();
            R3.Text = raudoni[2].ToString();
            R4.Text = raudoni[3].ToString();
            R5.Text = raudoni[4].ToString();

            G1.Text = geltoni[0].ToString();
            G2.Text = geltoni[1].ToString();
            G3.Text = geltoni[2].ToString();
            G4.Text = geltoni[3].ToString();
            G5.Text = geltoni[4].ToString();

            Z1.Text = zali[0].ToString();
            Z2.Text = zali[1].ToString();
            Z3.Text = zali[2].ToString();
            Z4.Text = zali[3].ToString();
            Z5.Text = zali[4].ToString();
            //-----------------------------------------
            clear_text();

            Game.Text = null;
        }

        void clear_text()
        {
            M1.BackColor = Color.White;
            M2.BackColor = Color.White;
            M3.BackColor = Color.White;
            M4.BackColor = Color.White;
            M5.BackColor = Color.White;

            J1.BackColor = Color.White;
            J2.BackColor = Color.White;
            J3.BackColor = Color.White;
            J4.BackColor = Color.White;
            J5.BackColor = Color.White;

            R1.BackColor = Color.White;
            R2.BackColor = Color.White;
            R3.BackColor = Color.White;
            R4.BackColor = Color.White;
            R5.BackColor = Color.White;

            G1.BackColor = Color.White;
            G2.BackColor = Color.White;
            G3.BackColor = Color.White;
            G4.BackColor = Color.White;
            G5.BackColor = Color.White;

            Z1.BackColor = Color.White;
            Z2.BackColor = Color.White;
            Z3.BackColor = Color.White;
            Z4.BackColor = Color.White;
            Z5.BackColor = Color.White;
        }

        void Susidedam (int[] t, ref List<int> b)
        {
            foreach (int sk in t)
            {
                b.Add(sk);
            }
        }

        void Spalvinamt (int sk)
        {
            
            if (sk < 16)
            {
                if(sk.ToString() == M1.Text)
                {
                    M1.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == M2.Text)
                {
                    M2.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == M3.Text)
                {
                    M3.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == M4.Text)
                {
                    M4.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == M5.Text)
                {
                    M5.BackColor = Color.Green;
                    kal++;
                }

            }
            else if (sk > 15 && sk < 31)
            {
                if (sk.ToString() == J1.Text)
                {
                    J1.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == J2.Text)
                {
                    J2.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == J3.Text)
                {
                    J3.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == J4.Text)
                { 
                    J4.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == J5.Text)
                {
                    J5.BackColor = Color.Green;
                    kal++;
                }
            }
            else if(sk > 30 && sk < 46)
            {
                if (sk.ToString() == R1.Text)
                {
                    R1.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == R2.Text)
                {
                    R2.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == R3.Text)
                {
                    R3.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == R4.Text)
                {
                    R4.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == R5.Text)
                {
                    R5.BackColor = Color.Green;
                    kal++;
                }
            }
            else if (sk > 45 && sk < 61)
            {
                if (sk.ToString() == G1.Text)
                {
                    G1.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == G2.Text)
                {
                    G2.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == G3.Text)
                {
                    G3.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == G4.Text)
                {
                    G4.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == G5.Text)
                {
                    G5.BackColor = Color.Green;
                    kal++;
                }
            }
            else
            {
                if (sk.ToString() == Z1.Text)
                {
                    Z1.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == Z2.Text)
                {
                    Z2.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == Z3.Text)
                {
                    Z3.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == Z4.Text)
                {
                    Z4.BackColor = Color.Green;
                    kal++;
                }
                else if (sk.ToString() == Z5.Text)
                {
                    Z5.BackColor = Color.Green;
                    kal++;
                }
            }
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            kal = 0;
            List<int> Kamuoliukai = new List<int>();
            List<int> bilietas = new List<int>();
            Susidedam(melyni, ref bilietas);
            Susidedam(juodi, ref bilietas);
            Susidedam(raudoni, ref bilietas);
            Susidedam(geltoni, ref bilietas);
            Susidedam(zali, ref bilietas);
            Game.Text = null;
            int i = 0;
            int sssss = 0;
            bool go = true;
            clear_text();
            while (go)
            {
                sssss++;
                while (i < 50)
                {
                    int kamuoliukas = rng.Next(1, 75);
                    int flag = 0;
                    foreach (int sk in Kamuoliukai)
                    {
                        if (sk == kamuoliukas)
                        {
                            flag++;
                        }
                    }
                    if (flag == 0)
                    {
                        Kamuoliukai.Add(kamuoliukas);
                        string tt = Game.Text;
                        tt += " " + kamuoliukas.ToString();
                        Game.Text = tt;
                        Spalvinamt(kamuoliukas);
                        i++;
                    }
                    


                }
                if (loop)
                {
                    if (kal >= 25)
                    {
                        go = false;
                        counttillwin.Text = sssss.ToString();
                    }
                    else
                    {
                        kal = 0;
                        i = 0;
                        counttillwin.Text = sssss.ToString();
                        Game.Text = null;
                        Kamuoliukai.Clear();
                        if (gen)
                        {
                            bGenerate_Click(null, null);
                        }
                    }
                }
                else
                {
                    go = false;
                }
                
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(loop)
            {
                loop = false;
            }
            else
            {
                loop = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(gen)
            {
                gen = false;
            }
            else
            {
                gen = true;
            }
        }
    }
}
