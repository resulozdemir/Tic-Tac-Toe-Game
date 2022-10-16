using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//githuba at
//programi ingilizce değişkenlere cevir


namespace XOX_oyunu
{
    public partial class XOX : Form
    {
        int turn = 0,win = 0,flag = 0;
        //turn = 0 X-turn
        //turn = 1 O-turn

        Image X = new Bitmap(@"C:\Users\erdem\Desktop\görsel programlama\1.hafta\x.png");
        Image O = new Bitmap(@"C:\Users\erdem\Desktop\görsel programlama\1.hafta\o.png");

        void xTurn()
        {
            turn++;
            winer(flag);
        }

        void oTurn()
        {
            turn--;
            winer(flag);
        }

        void xWin()
        {
            label1.Text = "X WIN";
            label1.Visible = Enabled;   
            win += 1;
            yenidenOyna.Visible = Enabled;
        }

        void oWin()
        {
            label1.Text = "O WIN";
            label1.Visible = Enabled;
            win += 1;
            yenidenOyna.Visible = Enabled;
        }

        void winer(int flag)
        {
            

            if (topLeft.BackgroundImage == X && topMiddle.BackgroundImage == X && topRight.BackgroundImage == X)
            {
                xWin();
            }

            else if (leftMiddle.BackgroundImage == X && middle.BackgroundImage == X && middleRight.BackgroundImage == X)
            {
                xWin();
            }

            else if (buttomLeft.BackgroundImage == X && buttomMiddle.BackgroundImage == X && buttomRight.BackgroundImage == X)
            {
                xWin();
            }

            else if (topLeft.BackgroundImage == X && leftMiddle.BackgroundImage == X && buttomLeft.BackgroundImage == X)
            {
                xWin();
            }

            else if (topMiddle.BackgroundImage == X && middle.BackgroundImage == X && buttomMiddle.BackgroundImage == X)
            {
                xWin();
            }

            else if (topRight.BackgroundImage == X && middleRight.BackgroundImage == X && buttomRight.BackgroundImage ==X)
            {
                xWin();
            }

            else if (topLeft.BackgroundImage == X && middle.BackgroundImage == X && buttomRight.BackgroundImage == X)
            {
                xWin();
            }

            else if (topRight.BackgroundImage == X && middle.BackgroundImage == X && buttomLeft.BackgroundImage == X)
            {
                xWin();
            }

            else if (topLeft.BackgroundImage == O && topMiddle.BackgroundImage == O && topRight.BackgroundImage == O)
            {
                oWin();
            }

            else if (leftMiddle.BackgroundImage == O && middle.BackgroundImage == O && middleRight.BackgroundImage == O)
            {
                oWin();
            }

            else if (buttomLeft.BackgroundImage == O && buttomMiddle.BackgroundImage == O && buttomRight.BackgroundImage == O)
            {
                oWin();
            }

            else if (topLeft.BackgroundImage == O && leftMiddle.BackgroundImage == O && buttomLeft.BackgroundImage == O)
            {
                oWin();
            }

            else if (topMiddle.BackgroundImage == O && middle.BackgroundImage == O && buttomMiddle.BackgroundImage == O)
            {
                oWin();
            }

            else if (topRight.BackgroundImage == O && middleRight.BackgroundImage == O && buttomRight.BackgroundImage == O)
            {
                oWin();
            }

            else if (topLeft.BackgroundImage == O && middle.BackgroundImage == O && buttomRight.BackgroundImage == O)
            {
                oWin();
            }

            else if (topRight.BackgroundImage == O && middle.BackgroundImage == O && buttomLeft.BackgroundImage == O)
            {
                oWin();
            }

        }

        public XOX()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win!=1)
            {
                topLeft.BackgroundImage = X;
                topLeft.Enabled = false;
                xTurn();

            }
            else if(turn == 1 && win != 1)
            {
                topLeft.BackgroundImage = O;
                topLeft.Enabled = false;
                oTurn();
            }
        }

        private void buttomRight_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                buttomRight.BackgroundImage = X;
                buttomRight.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                buttomRight.BackgroundImage = O;
                buttomRight.Enabled = false;
                oTurn();
            }
        }

        private void topMiddle_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                topMiddle.BackgroundImage = X;
                topMiddle.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                topMiddle.BackgroundImage = O;
                topMiddle.Enabled = false;
                oTurn();
            }
        }

        private void topRight_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                topRight.BackgroundImage = X;
                topRight.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                topRight.BackgroundImage = O;
                topRight.Enabled = false;
                oTurn();
            }
        }

        private void leftMiddle_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                leftMiddle.BackgroundImage = X;
                leftMiddle.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                leftMiddle.BackgroundImage = O;
                leftMiddle.Enabled = false;
                oTurn();
            }
        }

        private void middle_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                middle.BackgroundImage = X;
                middle.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                middle.BackgroundImage = O;
                middle.Enabled = false;
                oTurn();
            }
        }

        private void middleRight_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                middleRight.BackgroundImage = X;
                middleRight.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                middleRight.BackgroundImage = O;
                middleRight.Enabled = false;
                oTurn();
            }
        }

        private void buttomMiddle_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                buttomMiddle.BackgroundImage = X;
                buttomMiddle.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                buttomMiddle.BackgroundImage = O;    
                buttomMiddle.Enabled = false;
                oTurn();
            }

        }

        private void buttomLeft_Click(object sender, EventArgs e)
        {
            if (turn == 0 && win != 1)
            {
                buttomLeft.BackgroundImage = X;
                buttomLeft.Enabled = false;
                xTurn();
            }
            else if (turn == 1 && win != 1)
            {
                buttomLeft.BackgroundImage = O;
                buttomLeft.Enabled = false;
                oTurn();
            }
        }

        private void yenidenOyna_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            turn = 0;
            win = 0;
            yenidenOyna.Visible = false;
            
            buttomRight.BackgroundImage = default;
            topRight.BackgroundImage = default;
            middleRight.BackgroundImage = default;
            buttomMiddle.BackgroundImage = default;
            middle.BackgroundImage = default;
            topMiddle.BackgroundImage = default;
            topLeft.BackgroundImage = default;
            leftMiddle.BackgroundImage = default;
            buttomLeft.BackgroundImage = default;
            
            buttomRight.Enabled = true;
            topRight.Enabled = true;
            middleRight.Enabled = true;
            buttomMiddle.Enabled = true;
            middle.Enabled = true;
            topMiddle.Enabled = true;
            topLeft.Enabled = true;
            leftMiddle.Enabled = true;
            buttomLeft.Enabled = true;
        }

        private void XOX_Load(object sender, EventArgs e)
        {

        }

    }
}
