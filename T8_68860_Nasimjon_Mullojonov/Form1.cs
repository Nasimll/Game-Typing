using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T8_68860_Nasimjon_Mullojonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            staticLidsts.ReadProductFromFile();

            if (wordOnly.Checked)
            {
                staticLidsts.wordsrd = Mode.Words.ToString();
            }
            else if (sentenceOnly.Checked)
            {

                staticLidsts.wordsrd = Mode.Sentances.ToString();


            }
            else if (both.Checked)
            {

                staticLidsts.wordsrd = Mode.Both.ToString();

            }

            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void checkRadio(object sender, EventArgs e)
        {

        }


    }
}