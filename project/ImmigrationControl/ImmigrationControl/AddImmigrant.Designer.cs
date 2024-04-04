namespace ImmigrationControl
{
    partial class AddImmigrant
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
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_add_immigrant = new Button();
            button_cancel = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 28);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(108, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 50);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 14;
            label2.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 81);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 15;
            label3.Text = "Place of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 115);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 16;
            label4.Text = "Citizenship";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 149);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 17;
            label5.Text = "PIN";
            // 
            // button_add_immigrant
            // 
            button_add_immigrant.DialogResult = DialogResult.OK;
            button_add_immigrant.Location = new Point(8, 179);
            button_add_immigrant.Name = "button_add_immigrant";
            button_add_immigrant.Size = new Size(144, 29);
            button_add_immigrant.TabIndex = 18;
            button_add_immigrant.Text = "Add immigrant";
            button_add_immigrant.UseVisualStyleBackColor = true;
            button_add_immigrant.Click += button_add_immigrant_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(218, 179);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 19;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // AddImmigrant
            // 
            AcceptButton = button_add_immigrant;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_cancel;
            ClientSize = new Size(319, 214);
            Controls.Add(button_cancel);
            Controls.Add(button_add_immigrant);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Name = "AddImmigrant";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Add immigrant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_add_immigrant;
        private Button button_cancel;
    }
}