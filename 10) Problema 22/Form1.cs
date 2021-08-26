using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10__Problema_22
{
    public partial class Hangman : Form
    {
        
        public Hangman()
        {
            InitializeComponent();
        }
        private int greseli;
        private string cuvantf,rep;
        void citire(ref int greseli,ref string cuvantf, ref string rep)
        {
            var rand = new Random();
            int n = rand.Next(0,8);

            string filePath = @"G:\GitFINAL\10) Problema 22 - nonimag\Cuvinte.txt";
            string line = File.ReadLines(filePath).Skip(n).Take(1).First();
         
            string nrs  = line.Substring(line.Length - 2);
            int nr= Convert.ToInt32(nrs);
            string cuvant =line.Substring(0, line.Length - 2);
             greseli = 12 - nr-1;
            cuvantf = cuvant.Trim();
            

            rep = "";
            for (int i = 0; i < cuvantf.Length; i++)
            { rep += "_"; }
            reper();
            System.Windows.Forms.MessageBox.Show(cuvantf);
            Console.ReadLine();



            h1.BackColor = Color.Transparent;
            h2.BackColor = Color.Transparent;
            h3.BackColor = Color.Transparent;
            h4.BackColor = Color.Transparent;
            h5.BackColor = Color.Transparent;
            h6.BackColor = Color.Transparent;
            h7.BackColor = Color.Transparent;
            h8.BackColor = Color.Transparent;
            h9.BackColor = Color.Transparent;
            h10.BackColor = Color.Transparent;

            if (greseli == 1)
            {
                h1.BackColor = Color.SaddleBrown;

            }
            else if (greseli == 2)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;


            }
            else if (greseli == 3)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;


            }
            else if (greseli == 4)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;


            }
            else if (greseli == 5)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;
                h5.BackColor = Color.Black;


            }
            else if (greseli == 6)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;
                h5.BackColor = Color.Black;
                h6.BackColor = Color.Black;


            }
            else if (greseli == 7)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;
                h5.BackColor = Color.Black;
                h6.BackColor = Color.Black;
                h7.BackColor = Color.Black;


            }
            else if (greseli == 8)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;
                h5.BackColor = Color.Black;
                h6.BackColor = Color.Black;
                h7.BackColor = Color.Black;
                h8.BackColor = Color.Black;


            }
            else if (greseli == 9)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;
                h5.BackColor = Color.Black;
                h6.BackColor = Color.Black;
                h7.BackColor = Color.Black;
                h8.BackColor = Color.Black;
                h9.BackColor = Color.Black;



            }
            else if (greseli == 10)
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;
                h5.BackColor = Color.Black;
                h6.BackColor = Color.Black;
                h7.BackColor = Color.Black;
                h8.BackColor = Color.Black;
                h9.BackColor = Color.Black;
                h10.BackColor = Color.Black;



            }

        }
        private void reper()
        {
            Show.Text = "";
            for(int i=0;i<cuvantf.Length;i++)
            {
                Show.Text += rep.Substring(i, 1);
                Show.Text += " ";
            }
        }
      
        void check2(object sender, ref string rep)
        {
            Button alegere = sender as Button;
            char[] aux1 = new char[rep.Length];
            char[] aux2 = new char[rep.Length];
          
                aux1 = rep.ToCharArray();
                aux2 = cuvantf.ToCharArray();

                char caracter = alegere.Text.ElementAt(0);
                for (int i = 0; i < rep.Length; i++)
                {
                    if (aux2[i] == caracter)
                    {
                        aux1[i] = caracter;
                    }
                }
                rep = new string(aux1);
            reper();
        }
        private void updatareHang(object sender, EventArgs e)
        {
            Button alegere = sender as Button;

            if (cuvantf.Contains(alegere.Text))
            {
                check2(sender, ref rep);
            }
            else if (greseli <10)
            {if (greseli == 1)
                {
                    h1.BackColor = Color.SaddleBrown;
                   
                }
            else if (greseli == 2)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    

                }
                else if (greseli == 3)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    h3.BackColor = Color.SaddleBrown;
                    

                }
                else if (greseli == 4)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    h3.BackColor = Color.SaddleBrown;
                    h4.BackColor = Color.Black;
                   

                }
                else if (greseli == 5)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    h3.BackColor = Color.SaddleBrown;
                    h4.BackColor = Color.Black;
                    h5.BackColor = Color.Black;
                    

                }
                else if (greseli == 6)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    h3.BackColor = Color.SaddleBrown;
                    h4.BackColor = Color.Black;
                    h5.BackColor = Color.Black;
                    h6.BackColor = Color.Black;
                    

                }
                else if (greseli == 7)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    h3.BackColor = Color.SaddleBrown;
                    h4.BackColor = Color.Black;
                    h5.BackColor = Color.Black;
                    h6.BackColor = Color.Black;
                    h7.BackColor = Color.Black;
                    

                }
                else if (greseli == 8)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    h3.BackColor = Color.SaddleBrown;
                    h4.BackColor = Color.Black;
                    h5.BackColor = Color.Black;
                    h6.BackColor = Color.Black;
                    h7.BackColor = Color.Black;
                    h8.BackColor = Color.Black;
                    

                }
                else if (greseli == 9)
                {
                    h1.BackColor = Color.SaddleBrown;
                    h2.BackColor = Color.SaddleBrown;
                    h3.BackColor = Color.SaddleBrown;
                    h4.BackColor = Color.Black;
                    h5.BackColor = Color.Black;
                    h6.BackColor = Color.Black;
                    h7.BackColor = Color.Black;
                    h8.BackColor = Color.Black;
                    h9.BackColor = Color.Black;
                   


                }
              


                greseli++;
            }
            else
            {
                h1.BackColor = Color.SaddleBrown;
                h2.BackColor = Color.SaddleBrown;
                h3.BackColor = Color.SaddleBrown;
                h4.BackColor = Color.Black;
                h5.BackColor = Color.Black;
                h6.BackColor = Color.Black;
                h7.BackColor = Color.Black;
                h8.BackColor = Color.Black;
                h9.BackColor = Color.Black;
                h10.BackColor = Color.Black;
                Show.Text = "Ai pierdut!"; }
            if (rep.Equals(cuvantf))
            { Show.Text = "Ai castigat!"; }
        }
       
     


       
        private void Hangman_Load(object sender, EventArgs e)
        {
            
            citire(ref greseli,ref cuvantf,ref rep);
            

        }

      
        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            citire(ref greseli,ref cuvantf,ref rep);
        }
    }
}
