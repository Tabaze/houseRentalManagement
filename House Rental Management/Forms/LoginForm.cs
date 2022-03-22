using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace House_Rental_Management
{
    public partial class LoginForm : Form
    {
        LocationMaisonDataContext db=new LocationMaisonDataContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnHide.BringToFront();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                btnShow.BringToFront();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") txtPassword.PasswordChar = '\0';
            else txtPassword.PasswordChar = '*';
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                utilisateur ut = db.utilisateur.Single(x => x.login == txtUsername.Text && x.password == txtPassword.Text);
                if (ut != null)
                {
                    MenuForm frm = new MenuForm();
                    frm.Show();
                    this.Hide();
                }
            }
            catch 
            {
                Form_Alert alert = new Form_Alert();
                alert.showAlert("Nom d'utilisateur ou \n mot de  passe incorrect", Form_Alert.enmType.Error);
            }
        }
    }
}
