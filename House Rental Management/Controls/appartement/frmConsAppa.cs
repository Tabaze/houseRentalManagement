using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing;
using House_Rental_Management.Forms;

namespace House_Rental_Management.Controls
{
    public partial class frmConsAppa : UserControl
    {
        bool add = false , supp = false;
        appartement ap;
        LocationMaisonDataContext db = new LocationMaisonDataContext();
        public frmConsAppa()
        {
            InitializeComponent();
        }
        void changePicture(string folder)
        {
            photoList.Items.Clear();
            string[] paths = Directory.GetFiles(Application.StartupPath+"/" + folder);
            photoList.SmallImageList = imageList1;
            photoList.View = View.SmallIcon;
            imageList1.ImageSize = new Size(256, 256);
            foreach (string pic in paths)
            {
                imageList1.Images.Add(pic,Image.FromFile(pic));
            }
            for (int j = 0; j < imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                photoList.Items.Add(item);
            }
        }
        void load()
        {
            supp = false;
            cbxCategorie.DisplayMember = "categorie1";
            cbxCategorie.ValueMember = "idCategorie";
            cbxCategorie.DataSource = db.categorie;
            cbxPropre.DisplayMember = "nomProp";
            cbxPropre.ValueMember = "idProp";
            cbxPropre.DataSource = db.proprietaire;
            dataAppar.DataSource = db.appartement.Select(x => new { Numero = x.idApp, Adresse = x.addressApp, Prix = x.prixApp, Type = x.typeApp });
        }
        void active(bool ex)
        {
            dataAppar.Enabled = !ex;
            panelInfo.Enabled = ex;
            panelMod.Visible = !ex;
            panelValidation.Visible = ex;
            panelPicture.Visible = ex;
        }
        private void frmConsAppa_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataAppar_SelectionChanged(object sender, EventArgs e)
        {
            if (!supp)
            {
                ap = db.appartement.SingleOrDefault(x => x.idApp.Equals(dataAppar.CurrentRow.Cells[0].Value));
                if(ap!= null)
                {
                    txtAdresse.Text = ap.addressApp;
                    txtPrix.Text = Math.Round((decimal)ap.prixApp, 2, MidpointRounding.AwayFromZero).ToString();
                    txtType.Text = ap.typeApp;
                    for (int i = 0; i < cbxCategorie.Items.Count; i++)
                    {
                        cbxCategorie.SelectedIndex = i;
                        if (cbxCategorie.SelectedValue.ToString() == ap.idCategorie.ToString()) break;
                    }
                    for (int i = 0; i < cbxPropre.Items.Count; i++)
                    {
                        cbxPropre.SelectedIndex = i;
                        if (cbxPropre.SelectedValue.ToString() == ap.idProp.ToString()) break;
                    }
                    photoList.Items.Clear();
                    imageList1.Images.Clear();
                    if (ap.folderPath!="")changePicture(ap.folderPath);
                }
            }
        }

        private void btnAjou_Click(object sender, EventArgs e)
        {
            active(true);
            txtAdresse.Clear();
            txtPrix.Clear();
            txtType.Clear();
            add = true;
            photoList.Items.Clear();
            imageList1.Images.Clear();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            if (add)
            {
                ap = new appartement();
                db.appartement.InsertOnSubmit(ap);
            }
            else
            {
                ap = db.appartement.Single(x => x.idApp.Equals(dataAppar.CurrentRow.Cells[0].Value));
            }
            ap.addressApp = txtAdresse.Text;
            ap.typeApp = txtType.Text;
            ap.prixApp = (decimal)double.Parse(txtPrix.Text);
            ap.idCategorie = long.Parse(cbxCategorie.SelectedValue.ToString());
            ap.idProp = long.Parse(cbxPropre.SelectedValue.ToString());
            Form_Alert al = new Form_Alert();
            al.showAlert("Etes vous sur de valider", Form_Alert.enmType.Info);
            if (Form_Alert.rr == DialogResult.Yes) 
            {
                db.SubmitChanges();
                ap.folderPath = "Appartements/" + ap.idApp;
                if (!Directory.Exists(Application.StartupPath + "/" + ap.folderPath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(Application.StartupPath + "/" + ap.folderPath);
                }
                db.SubmitChanges();
                Form_Alert frm = new Form_Alert();
                frm.showAlert("Operation terminé avec \n success", Form_Alert.enmType.Success);
                add = false;
                active(false);
                load();
                Form_Alert.rr = DialogResult.No;
            } 
            else
            {
                Form_Alert frm = new Form_Alert();
                frm.showAlert("Opreration anuuler", Form_Alert.enmType.Error);
                add = false;
                active(false);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            active(true);
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            string path;

            if (add) {
                var id = (from app in db.appartement
                          select app).ToList() ;
                path = "Appartements/" + (id[id.Count-1].idApp+1); 
            }
            else path = "Appartements/" + dataAppar.CurrentRow.Cells[0].Value;
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Random r = new Random();
                string nom = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");
                nom += (r.Next() * 1000);
                nom += Path.GetExtension(ofd.FileName);
                File.Copy(ofd.FileName, Application.StartupPath+"\\"+  path+"\\" + nom);
                photoList.Items.Clear();
                imageList1.Images.Clear();
                changePicture(path);
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert("Opreration anuuler", Form_Alert.enmType.Error);
            add = false;
            active(false);
        }

        private void btnRemPic_Click(object sender, EventArgs e)
        {
            if (photoList.SelectedIndices.Count != -1)
            {
                string file = imageList1.Images.Keys[photoList.SelectedItems[0].Index];
                imageList1.Images.Clear();
                photoList.Items.RemoveAt(photoList.SelectedItems[0].Index);
                File.Delete(file);
                changePicture(ap.folderPath);
            }
        }

        

        private void photoList_DoubleClick(object sender, EventArgs e)
        {
            frmDisplayPhoto frm = new frmDisplayPhoto(imageList1);
            frm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Form_Alert al = new Form_Alert();
            al.showAlert("Etes vous sur de supprimer\n l'appartement", Form_Alert.enmType.Warning);
            if (Form_Alert.rr == DialogResult.Yes)
            {
                supp = true;
                ap = db.appartement.Single(x => x.idApp.Equals(dataAppar.CurrentRow.Cells[0].Value));
                if(Directory.Exists(Application.StartupPath + "\\" + ap.folderPath))Directory.Delete(Application.StartupPath+"\\" + ap.folderPath);
                db.appartement.DeleteOnSubmit(ap);
                db.SubmitChanges();
                Form_Alert frm = new Form_Alert();
                frm.showAlert("Operation terminé avec \n success", Form_Alert.enmType.Success);
                Form_Alert.rr = DialogResult.No;
                load();
            }
        }
    }
}
