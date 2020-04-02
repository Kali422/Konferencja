using System;
using System.Windows.Forms;

namespace Konferencja
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int liczbaSal = Convert.ToInt32(textBoxSale.Text);
                if (liczbaSal > 0)
                {
                    label2.Text = "";
                    Form1.setIloscSal(liczbaSal);
                    Close();
                }
                else label2.Text = "Liczba sal musi być dodatnia.";
            }
            catch (FormatException)
            {
                label2.Text = "Źle podana liczba.";
            }
        }
    }
}
