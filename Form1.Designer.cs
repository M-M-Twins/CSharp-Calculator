namespace WinFormsApp2
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
            txt2 = new TextBox();
            txt1 = new TextBox();
            txt3 = new TextBox();
            sum = new Button();
            min = new Button();
            mult = new Button();
            div = new Button();
            Exit = new Button();
            clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt2
            // 
            txt2.BackColor = Color.FromArgb(192, 255, 192);
            txt2.Location = new Point(511, 34);
            txt2.Name = "txt2";
            txt2.Size = new Size(150, 31);
            txt2.TabIndex = 0;
            // 
            // txt1
            // 
            txt1.BackColor = Color.FromArgb(192, 255, 192);
            txt1.Location = new Point(51, 34);
            txt1.Name = "txt1";
            txt1.Size = new Size(150, 31);
            txt1.TabIndex = 1;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt3
            // 
            txt3.BackColor = Color.FromArgb(192, 255, 192);
            txt3.Location = new Point(748, 34);
            txt3.Name = "txt3";
            txt3.Size = new Size(150, 31);
            txt3.TabIndex = 2;
            // 
            // sum
            // 
            sum.BackColor = Color.Orange;
            sum.Location = new Point(220, 34);
            sum.Name = "sum";
            sum.Size = new Size(64, 31);
            sum.TabIndex = 3;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = false;
            sum.Click += button1_Click;
            // 
            // min
            // 
            min.BackColor = Color.Gold;
            min.Location = new Point(290, 34);
            min.Name = "min";
            min.Size = new Size(64, 31);
            min.TabIndex = 4;
            min.Text = "-";
            min.UseVisualStyleBackColor = false;
            min.Click += min_Click;
            // 
            // mult
            // 
            mult.BackColor = Color.Orange;
            mult.Location = new Point(360, 34);
            mult.Name = "mult";
            mult.Size = new Size(64, 31);
            mult.TabIndex = 5;
            mult.Text = "*";
            mult.UseVisualStyleBackColor = false;
            mult.Click += mult_Click;
            // 
            // div
            // 
            div.BackColor = Color.Gold;
            div.Location = new Point(430, 34);
            div.Name = "div";
            div.Size = new Size(64, 31);
            div.TabIndex = 6;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += div_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(255, 192, 192);
            Exit.Location = new Point(49, 90);
            Exit.Name = "Exit";
            Exit.Size = new Size(235, 34);
            Exit.TabIndex = 7;
            Exit.Text = "خروج";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.FromArgb(255, 192, 192);
            clear.Location = new Point(663, 90);
            clear.Name = "clear";
            clear.Size = new Size(235, 34);
            clear.TabIndex = 8;
            clear.Text = "پاک کردن";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(691, 40);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 9;
            label1.Text = "=";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1045, 136);
            Controls.Add(label1);
            Controls.Add(clear);
            Controls.Add(Exit);
            Controls.Add(div);
            Controls.Add(mult);
            Controls.Add(min);
            Controls.Add(sum);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(txt2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt2;
        private TextBox txt1;
        private TextBox txt3;
        private Button sum;
        private Button min;
        private Button mult;
        private Button div;
        private Button Exit;
        private Button clear;
        private Label label1;
    }
}
