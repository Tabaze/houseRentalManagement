using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using House_Rental_Management.Controls;

namespace House_Rental_Management
{
    public partial class MenuForm : Form
    {
        bool logout=false;
        public MenuForm()
        {
            InitializeComponent();
        }
        void Forms(Control c)
        {
            if(mainPanel.Controls.Contains(c))mainPanel.Controls[c.Name].Focus();
            else mainPanel.Controls.Add(c);
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if(menuPanel.Size == new Size(50, 706))
            {
                menuPanel.Size = new Size(200, 706);
                labelTitre.Text = "Location des Maison";
                pictureBox1.Size = new Size(200, 157);
                if(mainPanel.Controls.Count!=0) mainPanel.Controls[0].Size = new Size(984, 674);
            }
            else
            {
                menuPanel.Size = new Size(50, 706);
                labelTitre.Text = "";
                pictureBox1.Size = new Size(50, 50);
                if (mainPanel.Controls.Count != 0) mainPanel.Controls[0].Size = new Size(1134, 674);
            }
        }

        private void btnAppartement_Click(object sender, EventArgs e)
        {
            frmAppartement frm = new frmAppartement();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(frm);
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(logout) Application.OpenForms[0].Show();
            //else Application.OpenForms[0].Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logout=true;
            Close();
        }
    }
}
