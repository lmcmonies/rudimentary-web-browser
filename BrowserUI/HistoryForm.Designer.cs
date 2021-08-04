namespace BrowserUI
{
    partial class HistoryForm
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
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.HistorySearch = new System.Windows.Forms.Button();
            this.FavouriteButton = new System.Windows.Forms.Button();
            this.SessionHistoryBox = new System.Windows.Forms.ListBox();
            this.SessionFavourite = new System.Windows.Forms.Button();
            this.SessionSearch = new System.Windows.Forms.Button();
            this.SessionHistoryLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HistoryBox
            // 
            this.HistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.ItemHeight = 31;
            this.HistoryBox.Location = new System.Drawing.Point(477, 52);
            this.HistoryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(268, 374);
            this.HistoryBox.TabIndex = 0;
            // 
            // HistorySearch
            // 
            this.HistorySearch.BackColor = System.Drawing.Color.White;
            this.HistorySearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistorySearch.Location = new System.Drawing.Point(779, 222);
            this.HistorySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistorySearch.Name = "HistorySearch";
            this.HistorySearch.Size = new System.Drawing.Size(114, 73);
            this.HistorySearch.TabIndex = 1;
            this.HistorySearch.Text = "Search";
            this.HistorySearch.UseVisualStyleBackColor = false;
            this.HistorySearch.Click += new System.EventHandler(this.HistorySearch_Click);
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.BackColor = System.Drawing.Color.White;
            this.FavouriteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavouriteButton.Location = new System.Drawing.Point(779, 106);
            this.FavouriteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.Size = new System.Drawing.Size(114, 73);
            this.FavouriteButton.TabIndex = 2;
            this.FavouriteButton.Text = "Favourite";
            this.FavouriteButton.UseVisualStyleBackColor = false;
            this.FavouriteButton.Click += new System.EventHandler(this.FavouriteButton_Click);
            // 
            // SessionHistoryBox
            // 
            this.SessionHistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SessionHistoryBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionHistoryBox.FormattingEnabled = true;
            this.SessionHistoryBox.ItemHeight = 31;
            this.SessionHistoryBox.Location = new System.Drawing.Point(12, 52);
            this.SessionHistoryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SessionHistoryBox.Name = "SessionHistoryBox";
            this.SessionHistoryBox.Size = new System.Drawing.Size(268, 374);
            this.SessionHistoryBox.TabIndex = 3;
            // 
            // SessionFavourite
            // 
            this.SessionFavourite.BackColor = System.Drawing.Color.White;
            this.SessionFavourite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFavourite.Location = new System.Drawing.Point(318, 106);
            this.SessionFavourite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SessionFavourite.Name = "SessionFavourite";
            this.SessionFavourite.Size = new System.Drawing.Size(114, 73);
            this.SessionFavourite.TabIndex = 5;
            this.SessionFavourite.Text = "Favourite";
            this.SessionFavourite.UseVisualStyleBackColor = false;
            this.SessionFavourite.Click += new System.EventHandler(this.SessionFavourite_Click);
            // 
            // SessionSearch
            // 
            this.SessionSearch.BackColor = System.Drawing.Color.White;
            this.SessionSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionSearch.Location = new System.Drawing.Point(318, 222);
            this.SessionSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SessionSearch.Name = "SessionSearch";
            this.SessionSearch.Size = new System.Drawing.Size(114, 73);
            this.SessionSearch.TabIndex = 4;
            this.SessionSearch.Text = "Search";
            this.SessionSearch.UseVisualStyleBackColor = false;
            this.SessionSearch.Click += new System.EventHandler(this.SessionSearch_Click);
            // 
            // SessionHistoryLabel
            // 
            this.SessionHistoryLabel.AutoSize = true;
            this.SessionHistoryLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionHistoryLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SessionHistoryLabel.Location = new System.Drawing.Point(52, 16);
            this.SessionHistoryLabel.Name = "SessionHistoryLabel";
            this.SessionHistoryLabel.Size = new System.Drawing.Size(177, 32);
            this.SessionHistoryLabel.TabIndex = 6;
            this.SessionHistoryLabel.Text = "Session History";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HistoryLabel.Location = new System.Drawing.Point(527, 16);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(184, 32);
            this.HistoryLabel.TabIndex = 7;
            this.HistoryLabel.Text = "All Time History";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 483);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.SessionHistoryLabel);
            this.Controls.Add(this.SessionFavourite);
            this.Controls.Add(this.SessionSearch);
            this.Controls.Add(this.SessionHistoryBox);
            this.Controls.Add(this.FavouriteButton);
            this.Controls.Add(this.HistorySearch);
            this.Controls.Add(this.HistoryBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryBox;
        private System.Windows.Forms.Button HistorySearch;
        private System.Windows.Forms.Button FavouriteButton;
        private System.Windows.Forms.ListBox SessionHistoryBox;
        private System.Windows.Forms.Button SessionFavourite;
        private System.Windows.Forms.Button SessionSearch;
        private System.Windows.Forms.Label SessionHistoryLabel;
        private System.Windows.Forms.Label HistoryLabel;
    }
}