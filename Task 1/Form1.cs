using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            label.Text = DateTime.Now.ToLongTimeString();

        }
        private void Timer_Tick1(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.AddHours(-4).ToLongTimeString();
        }

        Label label = new Label();
        Label label2 = new Label();
        Timer timerLondon = new Timer();
        private void button2_Click(object sender, EventArgs e)
        {
            timerBaku.Stop();
            label.Font = new Font("Comic Sans MS", 30, FontStyle.Bold);
            label.Location = new Point(250, 100);
            label.Text = DateTime.Now.AddHours(-4).ToLongTimeString();
            label.AutoSize = true;
            label.ForeColor = Color.Black;
            this.Controls.Add(label);

            label2.Font = new Font("Comic Sans MS", 30, FontStyle.Bold);
            label2.Location = new Point(110, 160);
            label2.Text = DateTime.Now.AddHours(-4).ToLongDateString();
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            this.Controls.Add(label2);

            timerLondon.Interval = 1000;
            timerLondon.Tick += Timer_Tick1;

            timerLondon.Start();

            this.BackgroundImage = Properties.Resources.London_image_3;

        }

        Timer timerBaku = new Timer();
        private void Bakubtt_Click(object sender, EventArgs e)
        {
            timerLondon.Stop();
            label.Font = new Font("Comic Sans MS", 30, FontStyle.Bold);
            label.Location = new Point(250, 100);
            label.Text = DateTime.Now.ToLongTimeString();
            label.AutoSize = true;
            label.ForeColor = Color.Black;
            this.Controls.Add(label);

            label2.Font = new Font("Comic Sans MS", 30, FontStyle.Bold);
            label2.Location = new Point(110, 160);
            label2.Text = DateTime.Now.ToLongDateString();
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            this.Controls.Add(label2);

            timerBaku.Interval = 1000;
            timerBaku.Tick += Timer_Tick;

            timerBaku.Start();

            this.BackgroundImage = Properties.Resources.Baku_image_2;
        }
    }
}
