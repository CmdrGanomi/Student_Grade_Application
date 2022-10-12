namespace StudentGradeApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.englishBox = new System.Windows.Forms.TextBox();
            this.mathBox = new System.Windows.Forms.TextBox();
            this.scienceBox = new System.Windows.Forms.TextBox();
            this.filipinoBox = new System.Windows.Forms.TextBox();
            this.historyBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(102, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(249, 31);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "English";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(266, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grades";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Math";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Science";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(351, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Filipino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(351, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "History";
            // 
            // englishBox
            // 
            this.englishBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.englishBox.Location = new System.Drawing.Point(138, 99);
            this.englishBox.Name = "englishBox";
            this.englishBox.Size = new System.Drawing.Size(100, 31);
            this.englishBox.TabIndex = 8;
            this.englishBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mathBox
            // 
            this.mathBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mathBox.Location = new System.Drawing.Point(138, 160);
            this.mathBox.Name = "mathBox";
            this.mathBox.Size = new System.Drawing.Size(100, 31);
            this.mathBox.TabIndex = 9;
            this.mathBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // scienceBox
            // 
            this.scienceBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scienceBox.Location = new System.Drawing.Point(138, 218);
            this.scienceBox.Name = "scienceBox";
            this.scienceBox.Size = new System.Drawing.Size(100, 31);
            this.scienceBox.TabIndex = 10;
            this.scienceBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // filipinoBox
            // 
            this.filipinoBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filipinoBox.Location = new System.Drawing.Point(426, 99);
            this.filipinoBox.Name = "filipinoBox";
            this.filipinoBox.Size = new System.Drawing.Size(100, 31);
            this.filipinoBox.TabIndex = 11;
            this.filipinoBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // historyBox
            // 
            this.historyBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyBox.Location = new System.Drawing.Point(426, 160);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(100, 31);
            this.historyBox.TabIndex = 12;
            this.historyBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(102, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "Generate Average";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShow.Location = new System.Drawing.Point(333, 246);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 25);
            this.labelShow.TabIndex = 14;
            this.labelShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelShow.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(655, 421);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.filipinoBox);
            this.Controls.Add(this.scienceBox);
            this.Controls.Add(this.mathBox);
            this.Controls.Add(this.englishBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox englishBox;
        private TextBox mathBox;
        private TextBox scienceBox;
        private TextBox filipinoBox;
        private TextBox historyBox;
        private Button button1;
        private Label labelShow;
    }
}