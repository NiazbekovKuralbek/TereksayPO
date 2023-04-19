namespace WindowsFormsApp2Tereksay
{
    partial class Production
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production));
            this.InformationLabel = new System.Windows.Forms.Label();
            this.ReserveInfoButton = new System.Windows.Forms.Button();
            this.MiningInfoButton = new System.Windows.Forms.Button();
            this.FactoryInfobutton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationLabel.Location = new System.Drawing.Point(21, 48);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(733, 190);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = resources.GetString("InformationLabel.Text");
            // 
            // ReserveInfoButton
            // 
            this.ReserveInfoButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReserveInfoButton.Location = new System.Drawing.Point(63, 255);
            this.ReserveInfoButton.Name = "ReserveInfoButton";
            this.ReserveInfoButton.Size = new System.Drawing.Size(148, 55);
            this.ReserveInfoButton.TabIndex = 1;
            this.ReserveInfoButton.Text = "Запасы компании";
            this.ReserveInfoButton.UseVisualStyleBackColor = true;
            this.ReserveInfoButton.Click += new System.EventHandler(this.ReserveInfoButton_Click);
            // 
            // MiningInfoButton
            // 
            this.MiningInfoButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiningInfoButton.Location = new System.Drawing.Point(266, 255);
            this.MiningInfoButton.Name = "MiningInfoButton";
            this.MiningInfoButton.Size = new System.Drawing.Size(155, 55);
            this.MiningInfoButton.TabIndex = 2;
            this.MiningInfoButton.Text = "Добыча Компании";
            this.MiningInfoButton.UseVisualStyleBackColor = true;
            this.MiningInfoButton.Click += new System.EventHandler(this.MiningInfoButton_Click);
            // 
            // FactoryInfobutton
            // 
            this.FactoryInfobutton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactoryInfobutton.Location = new System.Drawing.Point(482, 255);
            this.FactoryInfobutton.Name = "FactoryInfobutton";
            this.FactoryInfobutton.Size = new System.Drawing.Size(169, 55);
            this.FactoryInfobutton.TabIndex = 3;
            this.FactoryInfobutton.Text = "Фабрики компании";
            this.FactoryInfobutton.UseVisualStyleBackColor = true;
            this.FactoryInfobutton.Click += new System.EventHandler(this.FactoryInfobutton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(110, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(482, 23);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Производство компании ОсОО \"Эти Бакыр Терексай\"";
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.FactoryInfobutton);
            this.Controls.Add(this.MiningInfoButton);
            this.Controls.Add(this.ReserveInfoButton);
            this.Controls.Add(this.InformationLabel);
            this.Name = "Production";
            this.Text = "Production";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button ReserveInfoButton;
        private System.Windows.Forms.Button MiningInfoButton;
        private System.Windows.Forms.Button FactoryInfobutton;
        private System.Windows.Forms.Label TitleLabel;
    }
}