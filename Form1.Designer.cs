namespace BPNN_Activity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(122, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 34);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(122, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 34);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(123, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 34);
            textBox3.TabIndex = 2;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(295, 169);
            button1.Name = "button1";
            button1.Size = new Size(161, 72);
            button1.TabIndex = 3;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(122, 266);
            button2.Name = "button2";
            button2.Size = new Size(187, 67);
            button2.TabIndex = 4;
            button2.Text = "Train the Neural Net";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(482, 192);
            button3.Name = "button3";
            button3.Size = new Size(125, 41);
            button3.TabIndex = 5;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(122, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 34);
            textBox4.TabIndex = 6;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.InactiveCaption;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(449, 151);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 34);
            textBox5.TabIndex = 7;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
