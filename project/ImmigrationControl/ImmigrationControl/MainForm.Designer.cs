namespace ImmigrationControl
{
    partial class MainForm
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
            label1 = new Label();
            listBox1 = new ListBox();
            button_add = new Button();
            button_remove = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Immigrants";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 304);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button_add
            // 
            button_add.Location = new Point(12, 344);
            button_add.Name = "button_add";
            button_add.Size = new Size(132, 29);
            button_add.TabIndex = 2;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button1_Click;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(150, 344);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(74, 29);
            button_remove.TabIndex = 8;
            button_remove.Text = "Remove";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 32);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 52);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 10;
            label3.Text = "DOB: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 72);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "POB:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 92);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 12;
            label5.Text = "Citizenship:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 112);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 13;
            label6.Text = "PIN:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(539, 32);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(212, 304);
            listBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(677, 344);
            button1.Name = "button1";
            button1.Size = new Size(74, 29);
            button1.TabIndex = 16;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(539, 344);
            button2.Name = "button2";
            button2.Size = new Size(132, 29);
            button2.TabIndex = 15;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(757, 112);
            label7.Name = "label7";
            label7.Size = new Size(13, 20);
            label7.TabIndex = 21;
            label7.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(757, 92);
            label8.Name = "label8";
            label8.Size = new Size(13, 20);
            label8.TabIndex = 20;
            label8.Text = " ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(757, 72);
            label9.Name = "label9";
            label9.Size = new Size(13, 20);
            label9.TabIndex = 19;
            label9.Text = " ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(757, 52);
            label10.Name = "label10";
            label10.Size = new Size(13, 20);
            label10.TabIndex = 18;
            label10.Text = " ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(757, 32);
            label11.Name = "label11";
            label11.Size = new Size(13, 20);
            label11.TabIndex = 17;
            label11.Text = " ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 387);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_remove);
            Controls.Add(button_add);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Immigration control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button_add;
        private Button button_remove;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
