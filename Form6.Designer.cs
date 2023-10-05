
namespace Remis_Ya
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDestino = new System.Windows.Forms.RadioButton();
            this.optOrigen = new System.Windows.Forms.RadioButton();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.dgvFrm6 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDestino);
            this.groupBox1.Controls.Add(this.optOrigen);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BARRIO";
            // 
            // optDestino
            // 
            this.optDestino.AutoSize = true;
            this.optDestino.Location = new System.Drawing.Point(159, 41);
            this.optDestino.Name = "optDestino";
            this.optDestino.Size = new System.Drawing.Size(73, 17);
            this.optDestino.TabIndex = 1;
            this.optDestino.TabStop = true;
            this.optDestino.Text = "DESTINO";
            this.optDestino.UseVisualStyleBackColor = true;
            // 
            // optOrigen
            // 
            this.optOrigen.AutoSize = true;
            this.optOrigen.Checked = true;
            this.optOrigen.Location = new System.Drawing.Point(28, 41);
            this.optOrigen.Name = "optOrigen";
            this.optOrigen.Size = new System.Drawing.Size(67, 17);
            this.optOrigen.TabIndex = 0;
            this.optOrigen.TabStop = true;
            this.optOrigen.Text = "ORIGEN";
            this.optOrigen.UseVisualStyleBackColor = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(288, 75);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(102, 34);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "CONSULTAR";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // dgvFrm6
            // 
            this.dgvFrm6.AllowUserToAddRows = false;
            this.dgvFrm6.AllowUserToDeleteRows = false;
            this.dgvFrm6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrm6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2});
            this.dgvFrm6.Location = new System.Drawing.Point(24, 115);
            this.dgvFrm6.Name = "dgvFrm6";
            this.dgvFrm6.ReadOnly = true;
            this.dgvFrm6.Size = new System.Drawing.Size(444, 279);
            this.dgvFrm6.TabIndex = 2;
            // 
            // C1
            // 
            this.C1.HeaderText = "Nombre del barrio";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 200;
            // 
            // C2
            // 
            this.C2.HeaderText = "Cantidad total";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 200;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.dgvFrm6);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrm6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optDestino;
        private System.Windows.Forms.RadioButton optOrigen;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView dgvFrm6;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
    }
}