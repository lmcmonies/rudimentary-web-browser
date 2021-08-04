namespace BrowserUI
{
    partial class BrowserForm
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
            this.BrowserTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.FavouriteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryManager = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavouritesManager = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePageManager = new System.Windows.Forms.ToolStripMenuItem();
            this.URLBox = new System.Windows.Forms.RichTextBox();
            this.HTMLLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorCodeLabel = new System.Windows.Forms.Label();
            this.HTMLBox = new System.Windows.Forms.RichTextBox();
            this.BrowserTableLayout.SuspendLayout();
            this.BarLayout.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.HTMLLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowserTableLayout
            // 
            this.BrowserTableLayout.ColumnCount = 1;
            this.BrowserTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BrowserTableLayout.Controls.Add(this.BarLayout, 0, 0);
            this.BrowserTableLayout.Controls.Add(this.HTMLLayout, 0, 1);
            this.BrowserTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTableLayout.Location = new System.Drawing.Point(0, 0);
            this.BrowserTableLayout.Name = "BrowserTableLayout";
            this.BrowserTableLayout.RowCount = 2;
            this.BrowserTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.79021F));
            this.BrowserTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.20979F));
            this.BrowserTableLayout.Size = new System.Drawing.Size(1048, 572);
            this.BrowserTableLayout.TabIndex = 0;
            // 
            // BarLayout
            // 
            this.BarLayout.ColumnCount = 6;
            this.BarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.BarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.BarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.BarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.BarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.BarLayout.Controls.Add(this.RefreshButton, 2, 0);
            this.BarLayout.Controls.Add(this.ForwardButton, 1, 0);
            this.BarLayout.Controls.Add(this.BackButton, 0, 0);
            this.BarLayout.Controls.Add(this.FavouriteButton, 4, 0);
            this.BarLayout.Controls.Add(this.menuStrip1, 5, 0);
            this.BarLayout.Controls.Add(this.URLBox, 3, 0);
            this.BarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarLayout.Location = new System.Drawing.Point(3, 3);
            this.BarLayout.Name = "BarLayout";
            this.BarLayout.RowCount = 1;
            this.BarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BarLayout.Size = new System.Drawing.Size(1042, 49);
            this.BarLayout.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.White;
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshButton.ForeColor = System.Drawing.Color.Black;
            this.RefreshButton.Location = new System.Drawing.Point(103, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(45, 43);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "⟳";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.White;
            this.ForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForwardButton.Location = new System.Drawing.Point(53, 3);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(44, 43);
            this.ForwardButton.TabIndex = 1;
            this.ForwardButton.Text = ">>";
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 43);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.BackColor = System.Drawing.Color.White;
            this.FavouriteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FavouriteButton.Location = new System.Drawing.Point(906, 3);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.Size = new System.Drawing.Size(47, 43);
            this.FavouriteButton.TabIndex = 3;
            this.FavouriteButton.Text = "★";
            this.FavouriteButton.UseVisualStyleBackColor = false;
            this.FavouriteButton.Click += new System.EventHandler(this.FavouriteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(956, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(86, 49);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.favouriteToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(60, 45);
            this.Menu.Text = "Menu";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryManager});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // HistoryManager
            // 
            this.HistoryManager.Name = "HistoryManager";
            this.HistoryManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HistoryManager.Size = new System.Drawing.Size(259, 26);
            this.HistoryManager.Text = "History Manager ";
            this.HistoryManager.Click += new System.EventHandler(this.HistoryManager_Click);
            // 
            // favouriteToolStripMenuItem
            // 
            this.favouriteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FavouritesManager});
            this.favouriteToolStripMenuItem.Name = "favouriteToolStripMenuItem";
            this.favouriteToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.favouriteToolStripMenuItem.Text = "Favourites";
            // 
            // FavouritesManager
            // 
            this.FavouritesManager.Name = "FavouritesManager";
            this.FavouritesManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FavouritesManager.Size = new System.Drawing.Size(270, 26);
            this.FavouritesManager.Text = "Favourites Manager";
            this.FavouritesManager.Click += new System.EventHandler(this.FavouritesManager_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageManager});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.homeToolStripMenuItem.Text = "Home ";
            // 
            // HomePageManager
            // 
            this.HomePageManager.Name = "HomePageManager";
            this.HomePageManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.HomePageManager.Size = new System.Drawing.Size(284, 26);
            this.HomePageManager.Text = "Home Page Manager";
            this.HomePageManager.Click += new System.EventHandler(this.HomePageManager_Click);
            // 
            // URLBox
            // 
            this.URLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URLBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLBox.Location = new System.Drawing.Point(154, 3);
            this.URLBox.Multiline = false;
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(746, 43);
            this.URLBox.TabIndex = 5;
            this.URLBox.Text = "";
            this.URLBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.URLBox_KeyPress);
            // 
            // HTMLLayout
            // 
            this.HTMLLayout.ColumnCount = 1;
            this.HTMLLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HTMLLayout.Controls.Add(this.ErrorCodeLabel, 0, 0);
            this.HTMLLayout.Controls.Add(this.HTMLBox, 0, 1);
            this.HTMLLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTMLLayout.Location = new System.Drawing.Point(3, 58);
            this.HTMLLayout.Name = "HTMLLayout";
            this.HTMLLayout.RowCount = 2;
            this.HTMLLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.197652F));
            this.HTMLLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.80235F));
            this.HTMLLayout.Size = new System.Drawing.Size(1042, 511);
            this.HTMLLayout.TabIndex = 1;
            // 
            // ErrorCodeLabel
            // 
            this.ErrorCodeLabel.AutoSize = true;
            this.ErrorCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorCodeLabel.Location = new System.Drawing.Point(3, 0);
            this.ErrorCodeLabel.Name = "ErrorCodeLabel";
            this.ErrorCodeLabel.Size = new System.Drawing.Size(1036, 46);
            this.ErrorCodeLabel.TabIndex = 0;
            this.ErrorCodeLabel.Text = "Error";
            // 
            // HTMLBox
            // 
            this.HTMLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HTMLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTMLBox.Location = new System.Drawing.Point(3, 49);
            this.HTMLBox.Name = "HTMLBox";
            this.HTMLBox.Size = new System.Drawing.Size(1036, 459);
            this.HTMLBox.TabIndex = 1;
            this.HTMLBox.Text = "";
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 572);
            this.Controls.Add(this.BrowserTableLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BrowserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowserForm_FormClosing);
            this.BrowserTableLayout.ResumeLayout(false);
            this.BarLayout.ResumeLayout(false);
            this.BarLayout.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.HTMLLayout.ResumeLayout(false);
            this.HTMLLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BrowserTableLayout;
        private System.Windows.Forms.TableLayoutPanel BarLayout;
        private System.Windows.Forms.TableLayoutPanel HTMLLayout;
        private System.Windows.Forms.Label ErrorCodeLabel;
        private System.Windows.Forms.RichTextBox HTMLBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FavouriteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistoryManager;
        private System.Windows.Forms.ToolStripMenuItem favouriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavouritesManager;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomePageManager;
        private System.Windows.Forms.RichTextBox URLBox;
    }
}

