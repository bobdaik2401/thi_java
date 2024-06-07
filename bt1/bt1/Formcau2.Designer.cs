namespace bt1
{
    partial class Formcau2
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
            this.btnSnt = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTimSnt = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(190, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số N";
            // 
            // btnSnt
            // 
            this.btnSnt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSnt.Location = new System.Drawing.Point(185, 120);
            this.btnSnt.Name = "btnSnt";
            this.btnSnt.Size = new System.Drawing.Size(427, 55);
            this.btnSnt.TabIndex = 1;
            this.btnSnt.Text = "Kiểm tra số nguyên tố";
            this.btnSnt.UseVisualStyleBackColor = false;
            this.btnSnt.Click += new System.EventHandler(this.btnSnt_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtN.Location = new System.Drawing.Point(457, 57);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(155, 46);
            this.txtN.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox1.Location = new System.Drawing.Point(57, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(678, 48);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnTimSnt
            // 
            this.btnTimSnt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimSnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimSnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimSnt.Location = new System.Drawing.Point(185, 266);
            this.btnTimSnt.Name = "btnTimSnt";
            this.btnTimSnt.Size = new System.Drawing.Size(427, 67);
            this.btnTimSnt.TabIndex = 4;
            this.btnTimSnt.Text = "Tìm các số nguyên tố <N";
            this.btnTimSnt.UseVisualStyleBackColor = false;
            this.btnTimSnt.Click += new System.EventHandler(this.btnTimSnt_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 358);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(776, 51);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Formcau2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnTimSnt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnSnt);
            this.Controls.Add(this.label1);
            this.Name = "Formcau2";
            this.Text = "Formcau2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSnt;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTimSnt;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}