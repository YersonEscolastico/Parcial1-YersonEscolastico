namespace Parcial1_YersonEscolastico.UI.Registro
{
    partial class rProductos
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ValorInventariotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ubicacioncomboBox = new System.Windows.Forms.ComboBox();
            this.masButton = new System.Windows.Forms.Button();
            this.ExistenciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostoumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductoID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Inventario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(109, 29);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.IDnumericUpDown.TabIndex = 5;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(109, 82);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(171, 20);
            this.DescripciontextBox.TabIndex = 6;
            // 
            // ValorInventariotextBox
            // 
            this.ValorInventariotextBox.Location = new System.Drawing.Point(109, 179);
            this.ValorInventariotextBox.Name = "ValorInventariotextBox";
            this.ValorInventariotextBox.ReadOnly = true;
            this.ValorInventariotextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorInventariotextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Costo";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Parcial1_YersonEscolastico.Properties.Resources.Eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(205, 263);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 51);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Parcial1_YersonEscolastico.Properties.Resources.Guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(109, 263);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 51);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Parcial1_YersonEscolastico.Properties.Resources.Nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 263);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 51);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial1_YersonEscolastico.Properties.Resources.Buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(187, 14);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(93, 35);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ubicacion";
            // 
            // ubicacioncomboBox
            // 
            this.ubicacioncomboBox.FormattingEnabled = true;
            this.ubicacioncomboBox.Location = new System.Drawing.Point(109, 216);
            this.ubicacioncomboBox.Name = "ubicacioncomboBox";
            this.ubicacioncomboBox.Size = new System.Drawing.Size(100, 21);
            this.ubicacioncomboBox.TabIndex = 16;
            // 
            // masButton
            // 
            this.masButton.Location = new System.Drawing.Point(215, 215);
            this.masButton.Name = "masButton";
            this.masButton.Size = new System.Drawing.Size(35, 21);
            this.masButton.TabIndex = 17;
            this.masButton.Text = "Mas";
            this.masButton.UseVisualStyleBackColor = true;
            this.masButton.Click += new System.EventHandler(this.MasButton_Click);
            // 
            // ExistenciaNumericUpDown
            // 
            this.ExistenciaNumericUpDown.DecimalPlaces = 1;
            this.ExistenciaNumericUpDown.Location = new System.Drawing.Point(109, 113);
            this.ExistenciaNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ExistenciaNumericUpDown.Name = "ExistenciaNumericUpDown";
            this.ExistenciaNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.ExistenciaNumericUpDown.TabIndex = 18;
            this.ExistenciaNumericUpDown.ValueChanged += new System.EventHandler(this.ExistenciaNumericUpDown_ValueChanged);
            // 
            // CostoumericUpDown
            // 
            this.CostoumericUpDown.DecimalPlaces = 1;
            this.CostoumericUpDown.Location = new System.Drawing.Point(109, 146);
            this.CostoumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.CostoumericUpDown.Name = "CostoumericUpDown";
            this.CostoumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.CostoumericUpDown.TabIndex = 19;
            this.CostoumericUpDown.ValueChanged += new System.EventHandler(this.CostoumericUpDown_ValueChanged);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 323);
            this.Controls.Add(this.CostoumericUpDown);
            this.Controls.Add(this.ExistenciaNumericUpDown);
            this.Controls.Add(this.masButton);
            this.Controls.Add(this.ubicacioncomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ValorInventariotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "rProductos";
            this.Text = "Registro de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox ValorInventariotextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button masButton;
        private System.Windows.Forms.ComboBox ubicacioncomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ExistenciaNumericUpDown;
        private System.Windows.Forms.NumericUpDown CostoumericUpDown;
    }
}