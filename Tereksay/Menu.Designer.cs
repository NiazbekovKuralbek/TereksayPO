namespace WindowsFormsApp2Tereksay
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.учредителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.социальнаяОтветственностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетИМедиаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "О Компании";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Подразделения компании";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Учредители компании";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "Производство";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "Социальная ответственность";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 463);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "Отчеты и Медиа";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.оКомпанииToolStripMenuItem, this.производствоToolStripMenuItem, this.социальнаяОтветственностьToolStripMenuItem, this.отчетИМедиаToolStripMenuItem, this.справочникToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оКомпанииToolStripMenuItem
            // 
            this.оКомпанииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.сотрудникиToolStripMenuItem, this.сотрудникиToolStripMenuItem1, this.учредителиToolStripMenuItem });
            this.оКомпанииToolStripMenuItem.Name = "оКомпанииToolStripMenuItem";
            this.оКомпанииToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.оКомпанииToolStripMenuItem.Text = "О Компании";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сотрудникиToolStripMenuItem.Text = "История";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            // 
            // учредителиToolStripMenuItem
            // 
            this.учредителиToolStripMenuItem.Name = "учредителиToolStripMenuItem";
            this.учредителиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.учредителиToolStripMenuItem.Text = "Учредители";
            // 
            // производствоToolStripMenuItem
            // 
            this.производствоToolStripMenuItem.Name = "производствоToolStripMenuItem";
            this.производствоToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.производствоToolStripMenuItem.Text = "Производство";
            // 
            // социальнаяОтветственностьToolStripMenuItem
            // 
            this.социальнаяОтветственностьToolStripMenuItem.Name = "социальнаяОтветственностьToolStripMenuItem";
            this.социальнаяОтветственностьToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.социальнаяОтветственностьToolStripMenuItem.Text = "Социальная ответственность";
            // 
            // отчетИМедиаToolStripMenuItem
            // 
            this.отчетИМедиаToolStripMenuItem.Name = "отчетИМедиаToolStripMenuItem";
            this.отчетИМедиаToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.отчетИМедиаToolStripMenuItem.Text = "Отчет и медиа";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 552);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Разработка ИС деятельности горнодобывабщей компании ОсОО \"Эти Бакыр Терексай\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem отчетИМедиаToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem социальнаяОтветственностьToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem производствоToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem учредителиToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оКомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;

        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}