namespace ImmigrationControl
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
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
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
            listBox1.Size = new Size(230, 404);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(248, 32);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(248, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(248, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(248, 167);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
    }
}
