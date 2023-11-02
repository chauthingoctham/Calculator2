namespace Calculator2
{
    partial class Form1
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
            this.btCong = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.btTru = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(82, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.ForeColor = System.Drawing.Color.Blue;
            this.btCong.Location = new System.Drawing.Point(678, 341);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(86, 83);
            this.btCong.TabIndex = 1;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.ForeColor = System.Drawing.Color.Blue;
            this.txta.Location = new System.Drawing.Point(209, 77);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(357, 39);
            this.txta.TabIndex = 2;
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.ForeColor = System.Drawing.Color.Blue;
            this.btTru.Location = new System.Drawing.Point(518, 341);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(86, 83);
            this.btTru.TabIndex = 3;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(191, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tính toán";
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.ForeColor = System.Drawing.Color.Blue;
            this.txtb.Location = new System.Drawing.Point(209, 173);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(357, 39);
            this.txtb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(82, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số b:";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetqua.ForeColor = System.Drawing.Color.Blue;
            this.txtKetqua.Location = new System.Drawing.Point(209, 259);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(357, 39);
            this.txtKetqua.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(82, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tinh toan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Label label4;
    }
}

