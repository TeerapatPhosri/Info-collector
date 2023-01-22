namespace Info_collector
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
            this.name_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.birth_box = new System.Windows.Forms.TextBox();
            this.high_box = new System.Windows.Forms.TextBox();
            this.grade_box = new System.Windows.Forms.TextBox();
            this.degree_box = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.monitor = new System.Windows.Forms.DataGridView();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.by_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collect_bot = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.ming = new System.Windows.Forms.TextBox();
            this.maxg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(12, 35);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 23);
            this.name_box.TabIndex = 0;
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(118, 35);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 23);
            this.id_box.TabIndex = 1;
            // 
            // birth_box
            // 
            this.birth_box.Location = new System.Drawing.Point(224, 35);
            this.birth_box.Name = "birth_box";
            this.birth_box.Size = new System.Drawing.Size(100, 23);
            this.birth_box.TabIndex = 2;
            // 
            // high_box
            // 
            this.high_box.Location = new System.Drawing.Point(12, 89);
            this.high_box.Name = "high_box";
            this.high_box.Size = new System.Drawing.Size(100, 23);
            this.high_box.TabIndex = 3;
            // 
            // grade_box
            // 
            this.grade_box.Location = new System.Drawing.Point(118, 89);
            this.grade_box.Name = "grade_box";
            this.grade_box.Size = new System.Drawing.Size(100, 23);
            this.grade_box.TabIndex = 4;
            // 
            // degree_box
            // 
            this.degree_box.Location = new System.Drawing.Point(224, 89);
            this.degree_box.Name = "degree_box";
            this.degree_box.Size = new System.Drawing.Size(100, 23);
            this.degree_box.TabIndex = 5;
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(129, 117);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(75, 23);
            this.enter_button.TabIndex = 6;
            this.enter_button.Text = "Result";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // monitor
            // 
            this.monitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name,
            this.column_id,
            this.by_column,
            this.column_high,
            this.column_grade,
            this.degree_column});
            this.monitor.Location = new System.Drawing.Point(12, 146);
            this.monitor.Name = "monitor";
            this.monitor.RowTemplate.Height = 25;
            this.monitor.Size = new System.Drawing.Size(312, 88);
            this.monitor.TabIndex = 7;
            // 
            // Column_name
            // 
            this.Column_name.DataPropertyName = "NAME";
            this.Column_name.HeaderText = "Name";
            this.Column_name.Name = "Column_name";
            // 
            // column_id
            // 
            this.column_id.DataPropertyName = "id";
            this.column_id.HeaderText = "ID";
            this.column_id.Name = "column_id";
            // 
            // by_column
            // 
            this.by_column.DataPropertyName = "by";
            this.by_column.HeaderText = "Birth Year";
            this.by_column.Name = "by_column";
            // 
            // column_high
            // 
            this.column_high.DataPropertyName = "height";
            this.column_high.HeaderText = "Height";
            this.column_high.Name = "column_high";
            // 
            // column_grade
            // 
            this.column_grade.DataPropertyName = "grade";
            this.column_grade.HeaderText = "Grade";
            this.column_grade.Name = "column_grade";
            // 
            // degree_column
            // 
            this.degree_column.DataPropertyName = "degree";
            this.degree_column.HeaderText = "Degree";
            this.degree_column.Name = "degree_column";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Birth Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bachelor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Height";
            // 
            // Name
            // 
            this.Name.HeaderText = "Column1";
            this.Name.Name = "Name";
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            // 
            // collect_bot
            // 
            this.collect_bot.Location = new System.Drawing.Point(10, 253);
            this.collect_bot.Name = "collect_bot";
            this.collect_bot.Size = new System.Drawing.Size(75, 23);
            this.collect_bot.TabIndex = 15;
            this.collect_bot.Text = "enter";
            this.collect_bot.UseVisualStyleBackColor = true;
            this.collect_bot.Click += new System.EventHandler(this.collect_bot_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(93, 254);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(75, 23);
            this.amount.TabIndex = 16;
            // 
            // ming
            // 
            this.ming.Location = new System.Drawing.Point(255, 254);
            this.ming.Name = "ming";
            this.ming.Size = new System.Drawing.Size(75, 23);
            this.ming.TabIndex = 17;
            // 
            // maxg
            // 
            this.maxg.Location = new System.Drawing.Point(174, 254);
            this.maxg.Name = "maxg";
            this.maxg.Size = new System.Drawing.Size(75, 23);
            this.maxg.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Students";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 237);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Best grade";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Lowest grade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 299);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxg);
            this.Controls.Add(this.ming);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.collect_bot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.degree_box);
            this.Controls.Add(this.grade_box);
            this.Controls.Add(this.high_box);
            this.Controls.Add(this.birth_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.name_box);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.monitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox name_box;
        private TextBox id_box;
        private TextBox birth_box;
        private TextBox high_box;
        private TextBox grade_box;
        private TextBox degree_box;
        private Button enter_button;
        private DataGridView monitor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ID;
        private Button collect_bot;
        private TextBox amount;
        private TextBox ming;
        private TextBox maxg;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn Column_name;
        private DataGridViewTextBoxColumn column_id;
        private DataGridViewTextBoxColumn by_column;
        private DataGridViewTextBoxColumn column_high;
        private DataGridViewTextBoxColumn column_grade;
        private DataGridViewTextBoxColumn degree_column;
    }
}