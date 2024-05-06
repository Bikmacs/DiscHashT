namespace prak4HashTable
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.MenuBar;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 304);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Location = new Point(281, 369);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.Location = new Point(111, 322);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuBar;
            button3.Location = new Point(281, 402);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 3;
            button3.Text = "Sort.Name";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuBar;
            button4.Location = new Point(211, 322);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "A - я";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(22, 369);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "Введите текст";
            textBox1.MouseClick += textBox1_MouseClick;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(22, 402);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "Sort. по имени ";
            textBox2.MouseClick += textBox2_MouseClick;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(22, 437);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "Sort. по диску";
            textBox3.MouseClick += textBox3_MouseClick;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuBar;
            button5.Location = new Point(281, 436);
            button5.Name = "button5";
            button5.Size = new Size(125, 29);
            button5.TabIndex = 7;
            button5.Text = "Sort.Disc";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(426, 494);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button5;
    }
}
