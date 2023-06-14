namespace Farmacia
{
    partial class FormProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedor));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregarProveedor = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiarProveedor = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarProveedor = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(613, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 365);
            this.panel2.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Icon")));
            this.btnEliminar.Location = new System.Drawing.Point(96, 214);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(197, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = false;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Icon")));
            this.btnLimpiar.Location = new System.Drawing.Point(96, 132);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(197, 50);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Icon")));
            this.btnAgregar.Location = new System.Drawing.Point(96, 47);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(197, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.materialTextBox2);
            this.panel1.Location = new System.Drawing.Point(3, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 122);
            this.panel1.TabIndex = 2;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Nombre";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(272, 37);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(220, 50);
            this.materialTextBox2.TabIndex = 1;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.AutoSize = false;
            this.btnAgregarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarProveedor.Depth = 0;
            this.btnAgregarProveedor.HighEmphasis = true;
            this.btnAgregarProveedor.Icon = ((System.Drawing.Image)(resources.GetObject("btnAgregarProveedor.Icon")));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(275, 233);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarProveedor.Size = new System.Drawing.Size(220, 36);
            this.btnAgregarProveedor.TabIndex = 3;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarProveedor.UseAccentColor = false;
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.AutoSize = false;
            this.btnLimpiarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiarProveedor.Depth = 0;
            this.btnLimpiarProveedor.HighEmphasis = true;
            this.btnLimpiarProveedor.Icon = ((System.Drawing.Image)(resources.GetObject("btnLimpiarProveedor.Icon")));
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(275, 291);
            this.btnLimpiarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(220, 36);
            this.btnLimpiarProveedor.TabIndex = 4;
            this.btnLimpiarProveedor.Text = "Limpiar";
            this.btnLimpiarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiarProveedor.UseAccentColor = false;
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.AutoSize = false;
            this.btnEliminarProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarProveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarProveedor.Depth = 0;
            this.btnEliminarProveedor.HighEmphasis = true;
            this.btnEliminarProveedor.Icon = ((System.Drawing.Image)(resources.GetObject("btnEliminarProveedor.Icon")));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(275, 350);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarProveedor.Size = new System.Drawing.Size(220, 36);
            this.btnEliminarProveedor.TabIndex = 5;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarProveedor.UseAccentColor = false;
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnLimpiarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.panel1);
            this.Name = "FormProveedor";
            this.Text = "Proveedor";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton btnAgregarProveedor;
        private MaterialSkin.Controls.MaterialButton btnLimpiarProveedor;
        private MaterialSkin.Controls.MaterialButton btnEliminarProveedor;
    }
}