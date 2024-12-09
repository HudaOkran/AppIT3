namespace AppIT3
{
    partial class Frm_clac3
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.but_dev = new System.Windows.Forms.Button();
            this.but_sum = new System.Windows.Forms.Button();
            this.but_sub = new System.Windows.Forms.Button();
            this.but_mult = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_equ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(171, 20);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 29);
            this.num1.TabIndex = 0;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "الرقم الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "النتيجة";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(171, 86);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 29);
            this.result.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "الرقم الثاني";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(171, 51);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 29);
            this.num2.TabIndex = 4;
            this.num2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // but_dev
            // 
            this.but_dev.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dev.Location = new System.Drawing.Point(81, 129);
            this.but_dev.Name = "but_dev";
            this.but_dev.Size = new System.Drawing.Size(75, 39);
            this.but_dev.TabIndex = 6;
            this.but_dev.Text = "/";
            this.but_dev.UseVisualStyleBackColor = true;
            this.but_dev.Click += new System.EventHandler(this.but_dev_Click);
            // 
            // but_sum
            // 
            this.but_sum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sum.Location = new System.Drawing.Point(318, 129);
            this.but_sum.Name = "but_sum";
            this.but_sum.Size = new System.Drawing.Size(75, 39);
            this.but_sum.TabIndex = 7;
            this.but_sum.Text = "+";
            this.but_sum.UseVisualStyleBackColor = true;
            this.but_sum.Click += new System.EventHandler(this.but_sum_Click);
            // 
            // but_sub
            // 
            this.but_sub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sub.Location = new System.Drawing.Point(241, 129);
            this.but_sub.Name = "but_sub";
            this.but_sub.Size = new System.Drawing.Size(75, 39);
            this.but_sub.TabIndex = 8;
            this.but_sub.Text = "-";
            this.but_sub.UseVisualStyleBackColor = true;
            this.but_sub.Click += new System.EventHandler(this.but_sub_Click);
            // 
            // but_mult
            // 
            this.but_mult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_mult.Location = new System.Drawing.Point(161, 129);
            this.but_mult.Name = "but_mult";
            this.but_mult.Size = new System.Drawing.Size(75, 39);
            this.but_mult.TabIndex = 9;
            this.but_mult.Text = "*";
            this.but_mult.UseVisualStyleBackColor = true;
            this.but_mult.Click += new System.EventHandler(this.but_mult_Click);
            // 
            // but_clear
            // 
            this.but_clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_clear.Location = new System.Drawing.Point(3, 129);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 39);
            this.but_clear.TabIndex = 10;
            this.but_clear.Text = "c";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_equ
            // 
            this.but_equ.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_equ.Location = new System.Drawing.Point(3, 174);
            this.but_equ.Name = "but_equ";
            this.but_equ.Size = new System.Drawing.Size(390, 39);
            this.but_equ.TabIndex = 11;
            this.but_equ.Text = "=";
            this.but_equ.UseVisualStyleBackColor = true;
            this.but_equ.Click += new System.EventHandler(this.but_equ_Click);
            // 
            // Frm_clac3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 242);
            this.Controls.Add(this.but_equ);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_mult);
            this.Controls.Add(this.but_sub);
            this.Controls.Add(this.but_sum);
            this.Controls.Add(this.but_dev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1);
            this.Name = "Frm_clac3";
            this.Text = "Frm_clac3";
            this.Load += new System.EventHandler(this.Frm_clac3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button but_dev;
        private System.Windows.Forms.Button but_sum;
        private System.Windows.Forms.Button but_sub;
        private System.Windows.Forms.Button but_mult;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_equ;
    }
}