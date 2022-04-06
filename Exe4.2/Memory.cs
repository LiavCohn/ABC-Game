using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe4._2
{
    public partial class Memory : Form
    {
        Button[] arr;
        Random rand;
        int res;
        char letter;
        char[] c;
        int[] intarr;
        Button[] checkbtn;
        int counter;
        int tick = 0;
        int tick2 = 0;
        int timeleft= 25;
        int pairfound;
        public Memory()
        {
            InitializeComponent();
            arr = new Button[] { this.btn1, this.btn2, this.btn3, this.btn4, this.btn5, this.btn6, this.btn7, this.btn8, this.btn9, this.btn10, this.btn11, this.btn12, this.btn13, this.btn14, this.btn15, this.btn16, this.btn17, this.btn18, this.btn19, this.btn20 };
            rand = new Random();
            res = 0;
            c = new char[26];//a-z
            intarr = new int[20];//numbers of the buttons
            intarr[0] = 1;//in the Checkbtn method, if intarr[0]=0, theres an eternal loop, setting this value to 1, avoids it
            checkbtn = new Button[2];
            counter = 0;//if two buttons that has been selected
            timer1IsPair.Start();
            timer2GameCountdown.Start();
            pairfound = 0;
        }
        public string RandomLetter()
        {
           do
           {   
                res = rand.Next(0, 26);
                letter = (char)('A' + res);
                if (c[res] != letter)
                {
                    c[res] = letter;
                    break;
                }
           } while (c[res] == letter);
            
            return letter.ToString();
        }//give random letter, with repeating the same ones we already have in our array
        private void Memory_Load(object sender, EventArgs e)
        {
            Set();
            ShowBtn(false);
        }
        public void Set()
        {
            int res = 0;
            for (int i = 0; i < 10; i++)
            {
                res = NextBtn();
                arr[res].Text = RandomLetter();
                arr[NextBtn()].Text = arr[res].Text.ToLower();
            }
        }
        public int NextBtn()
        {
            int idx = 0;
            do
            {
                idx = rand.Next(0, 20);//the array contains 20 places, each one for a different button,in their order,,each cell is set in the begining to 0
                if (intarr[idx] != idx)//if this condtion happens,means theres an empty cell
                {
                    intarr[idx] = idx;
                    break;
                }
            } while (intarr[idx] == idx);
            return idx;
        }//check next btn available

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.ForeColor = Color.Black;
            checkbtn[counter++] = btn1;
        }
        private void btn2_Click(object sender, EventArgs e)
        {           
            btn2.ForeColor = Color.Black;
            checkbtn[counter++] = btn2;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.ForeColor = Color.Black;
            checkbtn[counter++] = btn3;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.ForeColor = Color.Black;
            checkbtn[counter++] = btn4;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.ForeColor = Color.Black;
            checkbtn[counter++] = btn5;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.ForeColor = Color.Black;
            checkbtn[counter++] = btn6;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.ForeColor = Color.Black;
            checkbtn[counter++] = btn7;
        }
        private void btn8_Click(object sender, EventArgs e)
        {

            btn8.ForeColor = Color.Black;
            checkbtn[counter++] = btn8;
        }
        private void btn9_Click(object sender, EventArgs e)
        {

            btn9.ForeColor = Color.Black;
            checkbtn[counter++] = btn9;
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            btn10.ForeColor = Color.Black;
            checkbtn[counter++] = btn10;
        }
        private void btn11_Click(object sender, EventArgs e)
        {

            btn11.ForeColor = Color.Black;
            checkbtn[counter++] = btn11;
        }
        private void btn12_Click(object sender, EventArgs e)
        {
            btn12.ForeColor = Color.Black;
            checkbtn[counter++] = btn12;

        }
        private void btn13_Click(object sender, EventArgs e)
        {
            btn13.ForeColor = Color.Black;
            checkbtn[counter++] = btn13;

        }
        private void btn14_Click(object sender, EventArgs e)
        {
            btn14.ForeColor = Color.Black;
            checkbtn[counter++] = btn14;
        }
        private void btn15_Click(object sender, EventArgs e)
        {
            btn15.ForeColor = Color.Black;
            checkbtn[counter++] = btn15;
    
        }
        private void btn16_Click(object sender, EventArgs e)
        {
            btn16.ForeColor = Color.Black;
            checkbtn[counter++] = btn16;
        }
        private void btn17_Click(object sender, EventArgs e)
        {
            btn17.ForeColor = Color.Black;
            checkbtn[counter++] = btn17;
        }
        private void btn18_Click(object sender, EventArgs e)
        {
            btn18.ForeColor = Color.Black;
            checkbtn[counter++] = btn18;
        }
        private void btn19_Click(object sender, EventArgs e)
        {
            btn19.ForeColor = Color.Black;
            checkbtn[counter++] = btn19;
        }
        private void btn20_Click(object sender, EventArgs e)
        {
            btn20.ForeColor = Color.Black;
            checkbtn[counter++] = btn20;
        }
        public void IsPair()
        {   
            if (counter== 2)
            {
                if (checkbtn[0]==checkbtn[1])//The same button has been selected
                {
                    counter = 1;//reset to 1, it gives an option to choose a different button
                    MessageBox.Show("Choose a diffrent button!");
                    
                }
                else if (checkbtn[0].Text.ToLower() == checkbtn[1].Text.ToLower())
                {
                    checkbtn[0].Enabled = false;
                    checkbtn[1].Enabled = false;
                    timeleft+= 5;
                    counter = 0;
                    pairfound++;
                }
                else
                {
                    counter = 0;
                    checkbtn[0].ForeColor = Color.AntiqueWhite;
                    checkbtn[1].ForeColor = Color.AntiqueWhite;                 
                }
            }
            return;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter==2)
            {
                System.Threading.Thread.Sleep(300);
                IsPair();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            tick2++;
            switch(tick2)
            {
                case 1:
                    lblCount.Text = "  Set...";
                    break;
                case 2:
                    lblCount.Text = "  Go!!";
                    DisableBtn(false);
                    break;
                
                default:
                    lblCount.Text =(timeleft + 3 - tick2).ToString();
                    lblCount.Location = new Point(615, 76);                   
                    ShowBtn(true); 
                    break;
            }
            if (lblCount.Text == "0")
            {
                timer2GameCountdown.Stop();
                lblCount.Location = new Point(615, 76);
                lblCount.Text = "Out Of Time!";
                DisableBtn(true);
                NextStep();
               
            }
            if(pairfound==10)
            {
                timer2GameCountdown.Stop();
                lblCount.Location = new Point(615, 76);
                lblCount.Text = "Great Job!!";
                btnMainMenu.Visible = true;
            }
        }
        public void DisableBtn(bool asnwer)
        {
            if (asnwer)
            {
                foreach (var item in arr)
                {
                    item.Enabled = false;
                }
            }
            else
            {
                foreach (var item in arr)
                {
                    item.Enabled = true;
                }
            }
        }
        public void ShowBtn(bool show)
        {
            if(show)
            foreach (var item in arr)
            {
                item.Visible = true;
                    
            }
            else
            {
                foreach (var item in arr)
                {
                    item.Visible = false;
                    
                }
            }
        }
        public void NextStep()
        {
            
            btnMainMenu.Visible = true;
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
