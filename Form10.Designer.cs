
namespace Remis_Ya
{
    partial class Form10
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdVer = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(60, 16);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(12, 86);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(250, 355);
            this.lstNombres.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRES DE CHOFERES";
            // 
            // cmdVer
            // 
            this.cmdVer.Location = new System.Drawing.Point(187, 17);
            this.cmdVer.Name = "cmdVer";
            this.cmdVer.Size = new System.Drawing.Size(75, 23);
            this.cmdVer.TabIndex = 4;
            this.cmdVer.Text = "VER";
            this.cmdVer.UseVisualStyleBackColor = true;
            this.cmdVer.Click += new System.EventHandler(this.cmdVer_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(187, 46);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 5;
            this.cmdBorrar.Text = "BORRAR";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 455);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdVer;
        private System.Windows.Forms.Button cmdBorrar;
    }
}