namespace Parcial1_YersonEscolastico.UI.Consultas
{
    partial class cInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.RefrescarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Inventario";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(12, 64);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(144, 29);
            this.TotalTextBox.TabIndex = 1;
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefrescarButton.Image = global::Parcial1_YersonEscolastico.Properties.Resources.Actualizat;
            this.RefrescarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RefrescarButton.Location = new System.Drawing.Point(173, 54);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(102, 39);
            this.RefrescarButton.TabIndex = 2;
            this.RefrescarButton.Text = "   Refrescar";
            this.RefrescarButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.RefrescarButton.UseVisualStyleBackColor = true;
            this.RefrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // cInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 134);
            this.Controls.Add(this.RefrescarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "cInventario";
            this.Text = "cInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button RefrescarButton;
    }
}