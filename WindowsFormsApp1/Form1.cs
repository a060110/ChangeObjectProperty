using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainLabel.Text == "正在學C#")
            {
                MainLabel.Text = "我叫賴群凱";
            }
            else
            {
                MainLabel.Text = "正在學C#";
            }
        }

       private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainLabel.BorderStyle==BorderStyle.None)
            {
                MainLabel.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MainLabel.BorderStyle = BorderStyle.None;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MainLabel.ForeColor==Color.Black)
            {
                MainLabel.ForeColor = Color.White;
                MainLabel.BackColor = Color.Black;
            }
            else
            {
                MainLabel.ForeColor = Color.Black;
                MainLabel.BackColor = Color.White;
            }
        }


        Font _tmp = new Font("PMingLiU", 18, FontStyle.Italic);

        private void button4_Click(object sender, EventArgs e)
        {
            var font0 = new Font("PMingLiU", 18, FontStyle.Italic);
            var font1 = new Font("Algerian", 22, FontStyle.Regular);

            if (!MainLabel.Font.Equals(font0))
            {
                MainLabel.Font =font0;
            }
            else 
            {
                //this._tmp = MainLabel.Font;
                MainLabel.Font = font1;
            }
            // this.
            //if (MainLabel.Font==new Font("PMingLiU", 18pt)
            //{

            //}
            //MainLabel.Font = new Font("Algerian", 22, FontStyle.Italic);
        }
    }
}
