namespace BrowserUI
{
    partial class HomeForm
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
            this.HomeUrl = new System.Windows.Forms.RichTextBox();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.HomeNameLabel = new System.Windows.Forms.Label();
            this.HomeName = new System.Windows.Forms.RichTextBox();
            this.HomeCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeUrl
            // 
            this.HomeUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeUrl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeUrl.Location = new System.Drawing.Point(129, 135);
            this.HomeUrl.Name = "HomeUrl";
            this.HomeUrl.Size = new System.Drawing.Size(373, 60);
            this.HomeUrl.TabIndex = 0;
            this.HomeUrl.Text = "";
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.Black;
            this.HomeLabel.Location = new System.Drawing.Point(32, 157);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(53, 38);
            this.HomeLabel.TabIndex = 1;
            this.HomeLabel.Text = "Url";
         
            // 
            // HomeNameLabel
            // 
            this.HomeNameLabel.AutoSize = true;
            this.HomeNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeNameLabel.ForeColor = System.Drawing.Color.Black;
            this.HomeNameLabel.Location = new System.Drawing.Point(32, 66);
            this.HomeNameLabel.Name = "HomeNameLabel";
            this.HomeNameLabel.Size = new System.Drawing.Size(91, 38);
            this.HomeNameLabel.TabIndex = 3;
            this.HomeNameLabel.Text = "Name";
            // 
            // HomeName
            // 
            this.HomeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeName.Location = new System.Drawing.Point(129, 44);
            this.HomeName.Name = "HomeName";
            this.HomeName.Size = new System.Drawing.Size(373, 60);
            this.HomeName.TabIndex = 2;
            this.HomeName.Text = "";
            // 
            // HomeCreateButton
            // 
            this.HomeCreateButton.BackColor = System.Drawing.Color.White;
            this.HomeCreateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HomeCreateButton.Location = new System.Drawing.Point(246, 228);
            this.HomeCreateButton.Name = "HomeCreateButton";
            this.HomeCreateButton.Size = new System.Drawing.Size(142, 64);
            this.HomeCreateButton.TabIndex = 4;
            this.HomeCreateButton.Text = "Save";
            this.HomeCreateButton.UseVisualStyleBackColor = false;
            this.HomeCreateButton.Click += new System.EventHandler(this.HomeCreateButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 340);
            this.Controls.Add(this.HomeCreateButton);
            this.Controls.Add(this.HomeNameLabel);
            this.Controls.Add(this.HomeName);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.HomeUrl);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox HomeUrl;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label HomeNameLabel;
        private System.Windows.Forms.RichTextBox HomeName;
        private System.Windows.Forms.Button HomeCreateButton;
    }
}