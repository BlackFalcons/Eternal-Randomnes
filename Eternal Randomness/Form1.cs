using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Eternal_Randomness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private string GenerateRandomNumberInRange(int minValue, int maxValue)
        {
            Random r = new Random();
            return r.Next(minValue, maxValue).ToString();
        }

        private static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        private void RevealerCheckboxHide(object sender, EventArgs e)
        {
            RevealerBox.Visible = false;
            RandomNumberText.Visible = true;
        }

        private void GetRandomNumber(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FromNumber.Text) && !String.IsNullOrEmpty(ToNumber.Text))
            {
                try
                {
                    int fnum = int.Parse(GetNumbers(FromNumber.Text));
                    int tnum = int.Parse(GetNumbers(ToNumber.Text));

                    // Replace all non numeric characters.
                    FromNumber.Text = fnum.ToString();
                    ToNumber.Text = tnum.ToString();

                    if (RevealerCheckbox.Checked)
                    {
                        RevealerBox.Visible = true;
                        RandomNumberText.Visible = false;
                    } else
                    {
                        RevealerBox.Visible = false;
                        RandomNumberText.Visible = true;
                    }

                    if (fnum < tnum)
                    {
                        RandomNumberText.Text = GenerateRandomNumberInRange(fnum, tnum + 1);
                    }
                    else
                    {
                        ToNumber.Text = (fnum + 1).ToString();
                        RandomNumberText.Text = GenerateRandomNumberInRange(fnum, tnum + 2);
                    }
                } catch (OverflowException)
                {
                    RandomNumberText.Text = "Too high!";
                } catch (FormatException)
                {
                    RandomNumberText.Text = "Non Int!";
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RandomNumberText_Click(object sender, EventArgs e)
        {

        }

        private void RevealerCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
