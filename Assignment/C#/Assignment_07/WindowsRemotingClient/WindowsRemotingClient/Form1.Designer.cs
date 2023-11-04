
namespace WindowsRemotingClient
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
            this.btnHighest = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHighest
            // 
            this.btnHighest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHighest.Location = new System.Drawing.Point(58, 275);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(194, 58);
            this.btnHighest.TabIndex = 0;
            this.btnHighest.Text = "Highest Number";
            this.btnHighest.UseVisualStyleBackColor = false;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(81, 74);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(135, 20);
            this.num1.TabIndex = 1;
            this.num1.Text = "Enter Number 1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(81, 143);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(135, 20);
            this.num2.TabIndex = 2;
            this.num2.Text = "Enter Number 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(544, 93);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(178, 26);
            this.textResult.TabIndex = 5;
            // 
            // btnSmallest
            // 
            this.btnSmallest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSmallest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallest.Location = new System.Drawing.Point(302, 275);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(202, 58);
            this.btnSmallest.TabIndex = 6;
            this.btnSmallest.Text = "Smallest Number";
            this.btnSmallest.UseVisualStyleBackColor = false;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(561, 275);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(182, 55);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemainder.Location = new System.Drawing.Point(839, 275);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(212, 55);
            this.btnRemainder.TabIndex = 8;
            this.btnRemainder.Text = "Remainder";
            this.btnRemainder.UseVisualStyleBackColor = false;
            this.btnRemainder.Click += new System.EventHandler(this.btnRemainder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSmallest);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.btnHighest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.Label label1;
    }
}

