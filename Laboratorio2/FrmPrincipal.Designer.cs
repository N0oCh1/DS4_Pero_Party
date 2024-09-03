namespace Laboratorio2
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnEnun1 = new System.Windows.Forms.Button();
            this.BtnEnun2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnEnun4 = new System.Windows.Forms.Button();
            this.BtnEnun5 = new System.Windows.Forms.Button();
            this.BtnEnun6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(67, 79);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 302);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu de enunciados para laboratorio #2";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.BtnEnun1);
            this.flowLayoutPanel2.Controls.Add(this.BtnEnun2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(125, 80);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(526, 93);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // BtnEnun1
            // 
            this.BtnEnun1.AutoSize = true;
            this.BtnEnun1.BackColor = System.Drawing.Color.Black;
            this.BtnEnun1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnun1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEnun1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnun1.ForeColor = System.Drawing.Color.White;
            this.BtnEnun1.Location = new System.Drawing.Point(24, 23);
            this.BtnEnun1.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.BtnEnun1.Name = "BtnEnun1";
            this.BtnEnun1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnun1.Size = new System.Drawing.Size(201, 47);
            this.BtnEnun1.TabIndex = 0;
            this.BtnEnun1.Text = "Enunciado 1";
            this.BtnEnun1.UseVisualStyleBackColor = false;
            this.BtnEnun1.Click += new System.EventHandler(this.BtnEnun1_Click);
            // 
            // BtnEnun2
            // 
            this.BtnEnun2.AutoSize = true;
            this.BtnEnun2.BackColor = System.Drawing.Color.Black;
            this.BtnEnun2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnun2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEnun2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnun2.ForeColor = System.Drawing.Color.White;
            this.BtnEnun2.Location = new System.Drawing.Point(257, 23);
            this.BtnEnun2.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.BtnEnun2.Name = "BtnEnun2";
            this.BtnEnun2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnun2.Size = new System.Drawing.Size(245, 47);
            this.BtnEnun2.TabIndex = 1;
            this.BtnEnun2.Text = "Enunciado 2, 3";
            this.BtnEnun2.UseVisualStyleBackColor = false;
            this.BtnEnun2.Click += new System.EventHandler(this.BtnEnun2_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.BtnEnun4);
            this.flowLayoutPanel3.Controls.Add(this.BtnEnun5);
            this.flowLayoutPanel3.Controls.Add(this.BtnEnun6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(31, 177);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(715, 93);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // BtnEnun4
            // 
            this.BtnEnun4.AutoSize = true;
            this.BtnEnun4.BackColor = System.Drawing.Color.Black;
            this.BtnEnun4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnun4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEnun4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnun4.ForeColor = System.Drawing.Color.White;
            this.BtnEnun4.Location = new System.Drawing.Point(24, 23);
            this.BtnEnun4.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.BtnEnun4.Name = "BtnEnun4";
            this.BtnEnun4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnun4.Size = new System.Drawing.Size(201, 47);
            this.BtnEnun4.TabIndex = 0;
            this.BtnEnun4.Text = "Enunciado 4";
            this.BtnEnun4.UseVisualStyleBackColor = false;
            this.BtnEnun4.Click += new System.EventHandler(this.BtnEnun4_Click);
            // 
            // BtnEnun5
            // 
            this.BtnEnun5.AutoSize = true;
            this.BtnEnun5.BackColor = System.Drawing.Color.Black;
            this.BtnEnun5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnun5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEnun5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnun5.ForeColor = System.Drawing.Color.White;
            this.BtnEnun5.Location = new System.Drawing.Point(257, 23);
            this.BtnEnun5.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.BtnEnun5.Name = "BtnEnun5";
            this.BtnEnun5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnun5.Size = new System.Drawing.Size(201, 47);
            this.BtnEnun5.TabIndex = 1;
            this.BtnEnun5.Text = "Enunciado 5";
            this.BtnEnun5.UseVisualStyleBackColor = false;
            // 
            // BtnEnun6
            // 
            this.BtnEnun6.AutoSize = true;
            this.BtnEnun6.BackColor = System.Drawing.Color.Black;
            this.BtnEnun6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnun6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEnun6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnun6.ForeColor = System.Drawing.Color.White;
            this.BtnEnun6.Location = new System.Drawing.Point(490, 23);
            this.BtnEnun6.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.BtnEnun6.Name = "BtnEnun6";
            this.BtnEnun6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnun6.Size = new System.Drawing.Size(201, 47);
            this.BtnEnun6.TabIndex = 2;
            this.BtnEnun6.Text = "Enunciado 6";
            this.BtnEnun6.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnEnun2;
        private System.Windows.Forms.Button BtnEnun1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnEnun4;
        private System.Windows.Forms.Button BtnEnun5;
        private System.Windows.Forms.Button BtnEnun6;
    }
}

