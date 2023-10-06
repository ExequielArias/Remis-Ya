
namespace Remis_Ya
{
    partial class Form9
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
            this.cboFecha = new System.Windows.Forms.ComboBox();
            this.dgvFrm9 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA DEL VIAJE \r\n";
            // 
            // cboFecha
            // 
            this.cboFecha.FormattingEnabled = true;
            this.cboFecha.Location = new System.Drawing.Point(15, 36);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(399, 21);
            this.cboFecha.TabIndex = 1;
            this.cboFecha.SelectedIndexChanged += new System.EventHandler(this.cboFecha_SelectedIndexChanged);
            // 
            // dgvFrm9
            // 
            this.dgvFrm9.AllowUserToAddRows = false;
            this.dgvFrm9.AllowUserToDeleteRows = false;
            this.dgvFrm9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrm9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2});
            this.dgvFrm9.Location = new System.Drawing.Point(15, 87);
            this.dgvFrm9.Name = "dgvFrm9";
            this.dgvFrm9.ReadOnly = true;
            this.dgvFrm9.Size = new System.Drawing.Size(399, 351);
            this.dgvFrm9.TabIndex = 2;
            // 
            // C1
            // 
            this.C1.HeaderText = "NOMBRE DEL CHOFER";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            // 
            // C2
            // 
            this.C2.HeaderText = "IMPORTE TOTAL";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.dgvFrm9);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFecha;
        private System.Windows.Forms.DataGridView dgvFrm9;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
    }
}