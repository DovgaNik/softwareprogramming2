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
            button_add.Size = new Size(45, 29);
            button_add.TabIndex = 2;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button1_Click;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(152, 344);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(72, 29);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
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
    }
}
