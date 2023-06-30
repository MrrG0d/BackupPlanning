
namespace kursovaja
{
    partial class RecoveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryForm));
            this.DB_ComboBox = new System.Windows.Forms.ComboBox();
            this.BD_Label = new System.Windows.Forms.Label();
            this.OkButtonPath = new System.Windows.Forms.Button();
            this.CatalogBackup_Label = new System.Windows.Forms.Label();
            this.TextBoxPathBackup = new System.Windows.Forms.TextBox();
            this.CatalogButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DB_ComboBox
            // 
            this.DB_ComboBox.FormattingEnabled = true;
            this.DB_ComboBox.Location = new System.Drawing.Point(32, 52);
            this.DB_ComboBox.Name = "DB_ComboBox";
            this.DB_ComboBox.Size = new System.Drawing.Size(261, 24);
            this.DB_ComboBox.TabIndex = 10;
            // 
            // BD_Label
            // 
            this.BD_Label.AutoSize = true;
            this.BD_Label.Location = new System.Drawing.Point(29, 32);
            this.BD_Label.Name = "BD_Label";
            this.BD_Label.Size = new System.Drawing.Size(89, 17);
            this.BD_Label.TabIndex = 11;
            this.BD_Label.Text = "Выбрать БД";
            // 
            // OkButtonPath
            // 
            this.OkButtonPath.Location = new System.Drawing.Point(368, 200);
            this.OkButtonPath.Name = "OkButtonPath";
            this.OkButtonPath.Size = new System.Drawing.Size(95, 29);
            this.OkButtonPath.TabIndex = 12;
            this.OkButtonPath.Text = "Ok";
            this.OkButtonPath.UseVisualStyleBackColor = true;
            this.OkButtonPath.Click += new System.EventHandler(this.OkButtonPath_Click);
            // 
            // CatalogBackup_Label
            // 
            this.CatalogBackup_Label.AutoSize = true;
            this.CatalogBackup_Label.Location = new System.Drawing.Point(29, 94);
            this.CatalogBackup_Label.Name = "CatalogBackup_Label";
            this.CatalogBackup_Label.Size = new System.Drawing.Size(147, 17);
            this.CatalogBackup_Label.TabIndex = 13;
            this.CatalogBackup_Label.Text = "Дирректория бэкапа";
            // 
            // TextBoxPathBackup
            // 
            this.TextBoxPathBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPathBackup.Location = new System.Drawing.Point(32, 114);
            this.TextBoxPathBackup.Name = "TextBoxPathBackup";
            this.TextBoxPathBackup.Size = new System.Drawing.Size(321, 24);
            this.TextBoxPathBackup.TabIndex = 14;
            // 
            // CatalogButton2
            // 
            this.CatalogButton2.Location = new System.Drawing.Point(373, 114);
            this.CatalogButton2.Name = "CatalogButton2";
            this.CatalogButton2.Size = new System.Drawing.Size(90, 24);
            this.CatalogButton2.TabIndex = 15;
            this.CatalogButton2.Text = "Выбрать...";
            this.CatalogButton2.UseVisualStyleBackColor = true;
            this.CatalogButton2.Click += new System.EventHandler(this.CatalogButton2_Click);
            // 
            // RecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 241);
            this.Controls.Add(this.CatalogButton2);
            this.Controls.Add(this.TextBoxPathBackup);
            this.Controls.Add(this.CatalogBackup_Label);
            this.Controls.Add(this.OkButtonPath);
            this.Controls.Add(this.BD_Label);
            this.Controls.Add(this.DB_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecoveryForm";
            this.Text = "Бэкапер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DB_ComboBox;
        private System.Windows.Forms.Label BD_Label;
        private System.Windows.Forms.Button OkButtonPath;
        private System.Windows.Forms.Label CatalogBackup_Label;
        private System.Windows.Forms.TextBox TextBoxPathBackup;
        private System.Windows.Forms.Button CatalogButton2;
    }
}