namespace WinFormsApp1
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
            tittle = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            priority = new ComboBox();
            dataGridView1 = new DataGridView();
            description = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tittle
            // 
            tittle.Location = new Point(12, 12);
            tittle.Name = "tittle";
            tittle.PlaceholderText = "Введите задачу";
            tittle.Size = new Size(238, 23);
            tittle.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 106);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(273, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // priority
            // 
            priority.FormattingEnabled = true;
            priority.Items.AddRange(new object[] { "Высокий", "Средний", "Низкий" });
            priority.Location = new Point(490, 12);
            priority.Name = "priority";
            priority.Size = new Size(121, 23);
            priority.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 226);
            dataGridView1.TabIndex = 4;
            // 
            // description
            // 
            description.Location = new Point(12, 48);
            description.Name = "description";
            description.PlaceholderText = "Описание задачи";
            description.Size = new Size(238, 23);
            description.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(127, 106);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 6;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(description);
            Controls.Add(dataGridView1);
            Controls.Add(priority);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(tittle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tittle;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox priority;
        private DataGridView dataGridView1;
        private TextBox description;
        private Button button2;
    }
}
