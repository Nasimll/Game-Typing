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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int cnt = 0;
        int point = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            points.Text = 0.ToString();
            timer1.Start();

            if (staticLidsts.wordsrd == "Sentances")
            {
                timeDouble.Text = 20.0.ToString();
                caution.Text = "Plese dont forget to put dots!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void labelChanged(object sender, EventArgs e)
        {

            textBox1.Text = string.Empty;


            if (staticLidsts.wordsrd == "Words")
            {
                loopThroughArray(staticLidsts.words);

            }
            else if (staticLidsts.wordsrd == "Sentances")
            {
                loopThroughArray(staticLidsts.sentances);

            }
            else if (staticLidsts.wordsrd == "Both")
            {
                loopThroughBothArray(staticLidsts.both);
            }




        }


        public void loopThroughArray(List<string> array)
        {
            wordsMixed.Text = array[cnt];
            if (cnt < array.Count - 1)
            {
                cnt++;
            }
            else
            {
                cnt = 0;
            }
        }
        public void loopThroughBothArray(List<string> array)
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, 130);

            wordsMixed.Text = array[rand];
            if (cnt < array.Count - 1)
            {
                cnt++;
            }
            else
            {
                cnt = 0;
            }
        }

        private void MyEvent(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == wordsMixed.Text && staticLidsts.wordsrd != "Sentances")
            {
                point = point + 1;
                points.Text = point.ToString();

                timer1.Stop();
                timeDouble.Text = 10.0.ToString();
                timer1.Start();
            }
            else if (textBox1.Text.Trim() == wordsMixed.Text && staticLidsts.wordsrd == "Sentances")
            {
                point = point + 1;
                points.Text = point.ToString();

                timer1.Stop();
                timeDouble.Text = 20.0.ToString();
                timer1.Start();
            }
        }

       



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToDouble(timeDouble.Text) != 0)
            {
                double time = Convert.ToDouble(timeDouble.Text);
                time -= 0.1;
                timeDouble.Text = time.ToString();

            }
            else if (Convert.ToDouble(timeDouble.Text) == 0)
            {
                timer1.Stop();
                MessageBox.Show("You lost the game");
                Application.Restart();
            }

        }
    }
}