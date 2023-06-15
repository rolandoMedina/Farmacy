using Farmacia.Logica.Facturacion;
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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager m;
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            //Propiedades Material Skin
            m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);

            //Reloj
            lblTimer.Text = DateTime.Now.ToLongTimeString();
            clock.Start();

            //Setiar Tamaño de labels
            lblBienvenida.Font = new Font("Arial", 16, FontStyle.Regular);
            lblTimer.Font = new Font("Arial", 32, FontStyle.Regular);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*EJEMPLO DE USO
             CODIGOS DE RESULTADO
            EL 0 ES QUE LA VALIDACION FALLO, ES DECIR, HAY CAMPOS
            VACIOS
            
            EL 1 ES QUE TODO SALIO BIEN
            
            EL 2 ES QUE EL REGISTRO NO EXISTE
            
             ASI VA A SER EN TODOS LOS METODOS, LOS MISMO VA A DEVOLVER*/
            ClienteController CC = new ClienteController();

            var result = CC.eliminar("001-101203-1010M");
            switch (result)
            {
                case 0:
                    MessageBox.Show("Rellene to los campos");
                    break;

                case 1:
                    MessageBox.Show("Registro eliminado");
                    break;

                case 2:
                    MessageBox.Show("Cliente no existe");
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialListView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            FormProductos f = new FormProductos();
            f.ShowDialog();
        }

        private void materialListView3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente();
            f.ShowDialog();

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor f = new FormProveedor();
            f.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialListView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            FormFactura f = new FormFactura();
            f.ShowDialog();
        }

        private void materialTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRolesAdministracion_Click(object sender, EventArgs e)
        {
            roles.Visible = true;
            usuarios.Visible = false;
        }

        private void btnUsuariosAdministracion_Click(object sender, EventArgs e)
        {
            usuarios.Visible=true;
            roles.Visible=false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            /*EJEMPLO DE USO
             CODIGOS DE RESULTADO
            EL 0 ES QUE LA VALIDACION FALLO, ES DECIR, HAY CAMPOS
            VACIOS
            
            EL 1 ES QUE TODO SALIO BIEN
            
            EL 2 ES QUE EL REGISTRO NO EXISTE
            
             ASI VA A SER EN TODOS LOS METODOS, LOS MISMO VA A DEVOLVER*/
            ClienteController CC = new ClienteController();

            var result = CC.eliminar("001-101203-1010M");
            switch (result)
            {
                case 0:
                    MessageBox.Show("Rellene to los campos");
                    break;

                case 1:
                    MessageBox.Show("Registro eliminado");
                    break;

                case 2:
                    MessageBox.Show("Cliente no existe");
                    break;
            }

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {
            
        }

        private void clock_Tick_1(object sender, EventArgs e)
        {
            clock.Start();
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblTimer_Click_1(object sender, EventArgs e)
        {

        }
    }
}
