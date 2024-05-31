using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeyatharan
{
    public partial class Form1 : Form
    {
        int CardHeight = 89;
        int CardWidth =  63;
        int[] pulledcard = new int[53];
        int[] dealerdeck = new int[53];
        int[] playerdeck = new int[53];

        private int variablä;

        PictureBox card = new PictureBox();
        public Form1()
        {
            InitializeComponent();
            start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start()
        {
            //chosencard();
            PullnewcardPlayer();
        }

        private void chosencard()
        {
            card.Location = new Point(100, 100);
            card.Width = CardWidth;
            card.Height = CardHeight;
            card.ImageLocation = @"..\..\Deck\AceofSpades.jpg";
            card.SizeMode = PictureBoxSizeMode.Zoom;
            card.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(card);
        }
        private void PullnewcardPlayer()
        {
            Random rnd = new Random();
            int cardnum = rnd.Next(1, 53);

            if (pulledcard[cardnum - 1] == 1)
            {
                cardnum = rnd.Next(1, 53);
            }
            else
            {
                pulledcard[cardnum - 1] = 1;
                for (int i = 0; i > playerdeck.Length; i++)
                {
                    int z = 1;
                    if(z != 0)
                    {
                        z = playerdeck[i];
                    }

                    if (z == 0)
                    {
                        playerdeck[i] = cardnum;
                        
                        i = playerdeck.Length;
                    }
                }
            }
            Debug.WriteLine(playerdeck[0]);


        }
        private void PullnewcardDealer()
        {
            Random rnd = new Random();
            int cardnum = rnd.Next(1, 53);

            if (pulledcard[cardnum - 1] == 1)
            {
                cardnum = rnd.Next(1, 53);
            }
            else
            {
                pulledcard[cardnum - 1] = 1;

            }


        }

    }
}
