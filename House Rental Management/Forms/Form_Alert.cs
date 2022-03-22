using House_Rental_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rental_Management
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }
        public static DialogResult rr;
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private enmAction action;
        enmType t;
        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t == enmType.Info || t==enmType.Warning)
            {
                Opacity = 1;
                return;
            }
            switch(this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case Form_Alert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Alert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            rr = DialogResult.Yes;
            Close();
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            t = type;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    if (type != enmType.Info)
                    {
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                        this.Location = new Point(this.x, this.y);
                    }
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch(type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.StartPosition = FormStartPosition.CenterScreen;
                    pictureBox2.Visible = false;
                    this.Size = new Size(347, 137);
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.StartPosition = FormStartPosition.CenterScreen;
                    pictureBox2.Visible = false;
                    this.Size = new Size(347, 137);
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }
            this.lblMsg.Text = msg;
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
            if (type == enmType.Info || type==enmType.Warning) this.ShowDialog();
            else Show();
        }
    }
}
