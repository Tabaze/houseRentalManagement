namespace House_Rental_Management.Forms
{
    partial class frmDisplayPhoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplayPhoto));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelValidation = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnNext = new Guna.UI.WinForms.GunaCircleButton();
            this.btnPre = new Guna.UI.WinForms.GunaCircleButton();
            this.pbListImage = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelValidation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbListImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.4745F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5255F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelValidation
            // 
            this.panelValidation.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelValidation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelValidation.BackgroundImage")));
            this.panelValidation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelValidation.BorderColor = System.Drawing.Color.Transparent;
            this.panelValidation.BorderRadius = 3;
            this.panelValidation.BorderThickness = 1;
            this.panelValidation.Controls.Add(this.btnNext);
            this.panelValidation.Controls.Add(this.btnPre);
            this.panelValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelValidation.Location = new System.Drawing.Point(3, 407);
            this.panelValidation.Name = "panelValidation";
            this.panelValidation.ShowBorders = true;
            this.panelValidation.Size = new System.Drawing.Size(756, 58);
            this.panelValidation.TabIndex = 35;
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::House_Rental_Management.Properties.Resources.forward_100px1;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(383, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 18;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.AnimationHoverSpeed = 0.07F;
            this.btnPre.AnimationSpeed = 0.03F;
            this.btnPre.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPre.BorderColor = System.Drawing.Color.Black;
            this.btnPre.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPre.Enabled = false;
            this.btnPre.FocusedColor = System.Drawing.Color.Empty;
            this.btnPre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPre.ForeColor = System.Drawing.Color.White;
            this.btnPre.Image = global::House_Rental_Management.Properties.Resources.back_100px1;
            this.btnPre.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPre.Location = new System.Drawing.Point(327, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPre.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPre.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPre.OnHoverImage = null;
            this.btnPre.OnPressedColor = System.Drawing.Color.Black;
            this.btnPre.Size = new System.Drawing.Size(50, 50);
            this.btnPre.TabIndex = 19;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // pbListImage
            // 
            this.pbListImage.BackColor = System.Drawing.Color.Transparent;
            this.pbListImage.BaseColor = System.Drawing.Color.Black;
            this.pbListImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbListImage.Location = new System.Drawing.Point(3, 3);
            this.pbListImage.Name = "pbListImage";
            this.pbListImage.Size = new System.Drawing.Size(756, 398);
            this.pbListImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbListImage.TabIndex = 0;
            this.pbListImage.TabStop = false;
            // 
            // frmDisplayPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "frmDisplayPhoto";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "frmDisplayPhoto";
            this.Load += new System.EventHandler(this.frmDisplayPhoto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelValidation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbListImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox pbListImage;
        private Bunifu.UI.WinForms.BunifuPanel panelValidation;
        private Guna.UI.WinForms.GunaCircleButton btnNext;
        private Guna.UI.WinForms.GunaCircleButton btnPre;
    }
}