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
    public partial class EasyGame : Form
    {
        Random rand;
        int resRand;
        int card;
        char letter;
        char nextLetter;
        int time;
        const int runtime = 63;
        public EasyGame()
        {
            InitializeComponent();
            rand = new Random();
            nextLetter = 'A';
            WhichCard();
            timer60Sec.Start();
            time = 0;
        }
        private void EasyGame_Load(object sender, EventArgs e)
        {
            ShowButtons(false);
        }
        public void WhichCard()
        {
            if (nextLetter > 'Z')
                return;
            char[] let = new char[26];
            let[nextLetter - 'A'] = nextLetter;
            card = rand.Next(1, 5);
            if (card == 1)
            {
                btn1Choise.Text = nextLetter.ToString();
                nextLetter++;
                btn2Choise.Text = RandomLetter(let);
                btn3Choise.Text = RandomLetter(let);
                btn4Choise.Text = RandomLetter(let);
            }
            if (card == 2)
            {
                btn2Choise.Text = nextLetter.ToString();
                nextLetter++;
                btn4Choise.Text = RandomLetter(let);
                btn1Choise.Text = RandomLetter(let);
                btn3Choise.Text = RandomLetter(let);
            }
            if (card == 3)
            {
                btn3Choise.Text = nextLetter.ToString();
                nextLetter++;
                btn2Choise.Text = RandomLetter(let);
                btn4Choise.Text = RandomLetter(let);
                btn1Choise.Text = RandomLetter(let);
            }
            if (card == 4)
            {
                btn4Choise.Text = nextLetter.ToString();
                nextLetter++;
                btn2Choise.Text = RandomLetter(let);
                btn3Choise.Text = RandomLetter(let);
                btn1Choise.Text = RandomLetter(let);
            }
        }
        public string RandomLetter(char[] arr)
        {
            do
            {
                resRand = rand.Next(0, 25);
                letter = (char)('A' + resRand);
                if (arr[resRand] != letter)//if arr[resRand]=letter, it means that the cell of the letter is full, so we need to pick a different number
                {
                    arr[resRand] = letter;
                    break;
                }
            } while (arr[resRand] == letter);
            return letter.ToString();
        }

        private void btn1Choise_Click(object sender, EventArgs e)
        {
            if (char.Parse(btn1Choise.Text) != nextLetter - 1)
            {
                MessageBox.Show("Try Again!");
                return;
            }
            else
            {
                lblABC.Visible = true;
                lblABC.Text += btn1Choise.Text + " ";
            }
            if (char.Parse(btn1Choise.Text) == 'Z')
            {
                timer60Sec.Stop();
                ShowButtons(false);
                lblReady.Location = new Point(293, 158);
                lblReady.Text = "Great job!";
                lblGreatjob.Visible = true;
                btnMainMenu.Visible = true; btnMainMenu.Location = new Point(343, 323);

            }
            WhichCard();
        }
        private void btn2Choise_Click(object sender, EventArgs e)
        {
            if (char.Parse(btn2Choise.Text) != nextLetter - 1)
            {
                MessageBox.Show("Try Again!");
                return;
            }
            else
            {
                lblABC.Visible = true;
                lblABC.Text += btn2Choise.Text + " ";
            }
            if (char.Parse(btn2Choise.Text) == 'Z')
            {
                timer60Sec.Stop();
                ShowButtons(false);
                lblReady.Location = new Point(293, 158);
                lblReady.Text = "Great job!";
                lblGreatjob.Visible = true;
                btnMainMenu.Visible = true; btnMainMenu.Location = new Point(343, 323);
            }
            WhichCard();
        }
        private void btn3Choise_Click(object sender, EventArgs e)
        {
            if (char.Parse(btn3Choise.Text) != nextLetter - 1)
            {
                MessageBox.Show("Try Again!");
                return;
            }
            else
            {
                lblABC.Visible = true;
                lblABC.Text += btn3Choise.Text + " ";
            }
            if (char.Parse(btn3Choise.Text) == 'Z')
            {
                timer60Sec.Stop();
                ShowButtons(false);
                lblReady.Location = new Point(293, 158);
                lblReady.Text = "Great job!";
                lblGreatjob.Visible = true;
                btnMainMenu.Visible = true; btnMainMenu.Location = new Point(343, 323);
            }
            WhichCard();
        }
        private void btn4Choise_Click(object sender, EventArgs e)
        {
            if (char.Parse(btn4Choise.Text) != nextLetter - 1)
            {
                MessageBox.Show("Try Again!");
                return;
            }
            else
            {
                lblABC.Visible = true;
                lblABC.Text += btn4Choise.Text + " ";
            }
            if (char.Parse(btn4Choise.Text) == 'Z')
            {
                timer60Sec.Stop();
                ShowButtons(false);
                lblReady.Location = new Point(293, 158);
                lblReady.Text = "Great job!";
                lblGreatjob.Visible = true;
                btnMainMenu.Visible = true; btnMainMenu.Location = new Point(343, 323);
            }
            WhichCard();
        }
        public void ShowButtons(bool show)
        {
            if (show)
            {
                btn1Choise.Visible = true;
                btn2Choise.Visible = true;
                btn3Choise.Visible = true;
                btn4Choise.Visible = true;
                return;
            }
            btn1Choise.Visible = false;
            btn2Choise.Visible = false;
            btn3Choise.Visible = false;
            btn4Choise.Visible = false;
            return;
        }
        private void timer60Sec_Tick(object sender, EventArgs e)
        {
            time++;
            switch (time)
            {
                case 1:
                    lblReady.Text = "   " + "Set...";
                    return;
                case 2:
                    lblReady.Text = "   " + "Go!!!";
                    ShowButtons(true);
                    return;
                case 63:
                    lblReady.Visible = true;
                    lblReady.Location = new Point(219, 108);
                    lblReady.Text = "Oops...Out of time!";
                    ShowButtons(false);
                    timer60Sec.Stop();
                     btnMainMenu.Visible = true;
                    return;
                default:
                    lblReady.Text = "    " + (runtime - time).ToString();
                    return;
            }
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   