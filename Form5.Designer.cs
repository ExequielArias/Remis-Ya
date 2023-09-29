
namespace Remis_Ya
{
    partial class Form5
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
            this.lstNombresDeChoferes = new System.Windows.Forms.ListBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE CHOFER";
            // 
            // lstNombresDeChoferes
            // 
            this.lstNombresDeChoferes.FormattingEnabled = true;
            this.lstNombresDeChoferes.Location = new System.Drawing.Point(27, 51);
            this.lstNombresDeChoferes.Name = "lstNombresDeChoferes";
            this.lstNombresDeChoferes.Size = new System.Drawing.Size(172, 342);
            this.lstNombresDeChoferes.TabIndex = 1;
            this.lstNombresDeChoferes.SelectedIndexChanged += new System.EventHandler(this.lstNombresDeChoferes_SelectedIndexChanged);
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Desde,
            this.Hasta,
            this.Km,
            this.Importe});
            this.dgvInfo.Location = new System.Drawing.Point(223, 51);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.Size = new System.Drawing.Size(544, 342);
            this.dgvInfo.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "FECHA";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "BARRIO DESDE";
            this.Desde.Name = "Desde";
            this.Desde.ReadOnly = true;
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "BARRIO HASTA";
            this.Hasta.Name = "Hasta";
            this.Hasta.ReadOnly = true;
            // 
            // Km
            // 
            this.Km.HeaderText = "KM";
            this.Km.Name = "Km";
            this.Km.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "IMPORTE";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 441);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.lstNombresDeChoferes);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNombresDeChoferes;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}