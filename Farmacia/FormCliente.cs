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
    public partial class FormCliente : MaterialSkin.Controls.MaterialForm
    {
        public FormCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
