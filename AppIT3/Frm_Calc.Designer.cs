namespace AppIT3
{
    partial class Frm_Calc
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقم الاول";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(37, 15);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(238, 29);
            this.num1.TabIndex = 1;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(37, 50);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(238, 29);
            this.num2.TabIndex = 3;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "الرقم الثاني";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(37, 85);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(238, 29);
            this.result.TabIndex = 5;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "النتيجة";
            // 
            // btn_sum
            // 
            this.btn_sum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sum.Location = new System.Drawing.Point(300, 130);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(63, 37);
            this.btn_sum.TabIndex = 6;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(231, 130);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(63, 37);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mult.Location = new System.Drawing.Point(162, 130);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(63, 37);
            this.btn_mult.TabIndex = 8;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(81, 130);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(63, 37);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(12, 130);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(63, 37);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.Location = new System.Drawing.Point(12, 173);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(351, 37);
            this.btn_equal.TabIndex = 11;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // Frm_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 219);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Calc";
            this.Load += new System.EventHandler(this.Frm_Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_equal;
    }
}