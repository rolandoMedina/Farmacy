using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FormProductos : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager m1;
        public FormProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            m1 = MaterialSkinManager.Instance;
            m1.AddFormToManage(this);
            m1.Theme = MaterialSkinManager.Themes.DARK;
            m1.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);


        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
