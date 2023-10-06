
namespace Remis_Ya
{
    partial class Form3
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
            this.dgvForm3 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForm3
            // 
            this.dgvForm3.AllowUserToAddRows = false;
            this.dgvForm3.AllowUserToDeleteRows = false;
            this.dgvForm3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.C2});
            this.dgvForm3.Location = new System.Drawing.Point(12, 12);
            this.dgvForm3.Name = "dgvForm3";
            this.dgvForm3.ReadOnly = true;
            this.dgvForm3.Size = new System.Drawing.Size(644, 324);
            this.dgvForm3.TabIndex = 0;
            // 
            // c1
            // 
            this.c1.HeaderText = "Nombre del chofer";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 300;
            // 
            // C2
            // 
            this.C2.HeaderText = "Total Recaudado";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 300;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 355);
            this.Controls.Add(this.dgvForm3);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
    }
}