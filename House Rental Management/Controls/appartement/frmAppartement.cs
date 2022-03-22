using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rental_Management.Controls
{
    public partial class frmAppartement : UserControl
    {
        public frmAppartement()
        {
            InitializeComponent();
            Forms(new frmConsAppa());
        }
        void Forms(Control c){
            panelContent.Controls.Clear();
            panelContent.Controls.Add(c);
        }

        
    }
}
