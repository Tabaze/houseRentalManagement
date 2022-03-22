using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace House_Rental_Management.Forms
{
    public partial class frmDisplayPhoto : MaterialForm
    {
        string key;
        ImageList img;
        public frmDisplayPhoto(ImageList ls)
        {
            InitializeComponent();
            img = ls;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(img.Images.IndexOfKey(key)==0)btnPre.Enabled = false;
            else
            {
                btnPre.Enabled = true;
                btnNext.Enabled = true;
                pbListImage.Image = img.Images[img.Images.IndexOfKey(key)-1];
                key = img.Images.Keys[img.Images.IndexOfKey(key) - 1];
                if (img.Images.IndexOfKey(key) == 0) btnPre.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (img.Images.IndexOfKey(key) == img.Images.Keys.Count-1) btnNext.Enabled = false;
            else
            {
                btnPre.Enabled= true;
                btnNext.Enabled = true;
                pbListImage.Image = img.Images[img.Images.IndexOfKey(key) + 1];
                key = img.Images.Keys[img.Images.IndexOfKey(key) + 1];
                if (img.Images.IndexOfKey(key) == img.Images.Keys.Count - 1) btnNext.Enabled = false;
            }
        }

        private void frmDisplayPhoto_Load(object sender, EventArgs e)
        {
            pbListImage.Image = img.Images[0];
            key = img.Images.Keys[0];
        }
    }
}
