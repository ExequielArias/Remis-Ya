
namespace Remis_Ya
{
    partial class Form2
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
            this.txtParteDeChofer = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.dgvChoferesForm2 = new System.Windows.Forms.DataGridView();
            this.Chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferesForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parte del nombre del chofer";
            // 
            // txtParteDeChofer
            // 
            this.txtParteDeChofer.Location = new System.Drawing.Point(15, 47);
            this.txtParteDeChofer.Name = "txtParteDeChofer";
            this.txtParteDeChofer.Size = new System.Drawing.Size(492, 20);
            this.txtParteDeChofer.TabIndex = 1;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(225, 73);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 2;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // dgvChoferesForm2
            // 
            this.dgvChoferesForm2.AllowUserToAddRows = false;
            this.dgvChoferesForm2.AllowUserToDeleteRows = false;
            this.dgvChoferesForm2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferesForm2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chofer,
            this.Nombre});
            this.dgvChoferesForm2.Location = new System.Drawing.Point(15, 119);
            this.dgvChoferesForm2.Name = "dgvChoferesForm2";
            this.dgvChoferesForm2.ReadOnly = true;
            this.dgvChoferesForm2.Size = new System.Drawing.Size(492, 285);
            this.dgvChoferesForm2.TabIndex = 3;
            // 
            // Chofer
            // 
            this.Chofer.HeaderText = "Chofer";
            this.Chofer.Name = "Chofer";
            this.Chofer.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 418);
            this.Controls.Add(this.dgvChoferesForm2);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtParteDeChofer);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferesForm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParteDeChofer;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView dgvChoferesForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}