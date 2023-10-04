
namespace WFA231004
{
    partial class FrmDekodolo
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
            this.lblUI01 = new System.Windows.Forms.Label();
            this.txtBetu = new System.Windows.Forms.TextBox();
            this.pnlTxtMatrix = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblUI01
            // 
            this.lblUI01.AutoSize = true;
            this.lblUI01.Location = new System.Drawing.Point(12, 32);
            this.lblUI01.Name = "lblUI01";
            this.lblUI01.Size = new System.Drawing.Size(82, 20);
            this.lblUI01.TabIndex = 0;
            this.lblUI01.Text = "Karakter:";
            // 
            // txtBetu
            // 
            this.txtBetu.Location = new System.Drawing.Point(100, 29);
            this.txtBetu.Name = "txtBetu";
            this.txtBetu.Size = new System.Drawing.Size(39, 26);
            this.txtBetu.TabIndex = 1;
            // 
            // pnlTxtMatrix
            // 
            this.pnlTxtMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTxtMatrix.AutoSize = true;
            this.pnlTxtMatrix.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTxtMatrix.Location = new System.Drawing.Point(12, 79);
            this.pnlTxtMatrix.Name = "pnlTxtMatrix";
            this.pnlTxtMatrix.Size = new System.Drawing.Size(139, 71);
            this.pnlTxtMatrix.TabIndex = 2;
            // 
            // FrmDekodolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(163, 162);
            this.Controls.Add(this.pnlTxtMatrix);
            this.Controls.Add(this.txtBetu);
            this.Controls.Add(this.lblUI01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDekodolo";
            this.Text = "Karakter Dekódoló GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUI01;
        private System.Windows.Forms.TextBox txtBetu;
        private System.Windows.Forms.Panel pnlTxtMatrix;
    }
}

