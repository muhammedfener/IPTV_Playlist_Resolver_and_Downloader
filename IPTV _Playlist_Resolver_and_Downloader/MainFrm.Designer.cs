namespace IPTV__Playlist_Resolver_and_Downloader
{
    partial class MainFrm
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
            this.txtm3ulink = new System.Windows.Forms.TextBox();
            this.lblm3uurl = new System.Windows.Forms.Label();
            this.btnm3udownload = new System.Windows.Forms.Button();
            this.lvwContent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.btnSearchGroup = new System.Windows.Forms.Button();
            this.btnMovieDownload = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblDownText = new System.Windows.Forms.Label();
            this.lblDownloadSpeed = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtm3ulink
            // 
            this.txtm3ulink.Location = new System.Drawing.Point(73, 12);
            this.txtm3ulink.Name = "txtm3ulink";
            this.txtm3ulink.Size = new System.Drawing.Size(326, 20);
            this.txtm3ulink.TabIndex = 0;
            // 
            // lblm3uurl
            // 
            this.lblm3uurl.AutoSize = true;
            this.lblm3uurl.Location = new System.Drawing.Point(12, 15);
            this.lblm3uurl.Name = "lblm3uurl";
            this.lblm3uurl.Size = new System.Drawing.Size(55, 13);
            this.lblm3uurl.TabIndex = 1;
            this.lblm3uurl.Text = "M3U URL";
            // 
            // btnm3udownload
            // 
            this.btnm3udownload.Location = new System.Drawing.Point(405, 10);
            this.btnm3udownload.Name = "btnm3udownload";
            this.btnm3udownload.Size = new System.Drawing.Size(93, 23);
            this.btnm3udownload.TabIndex = 2;
            this.btnm3udownload.Text = "M3U Download";
            this.btnm3udownload.UseVisualStyleBackColor = true;
            this.btnm3udownload.Click += new System.EventHandler(this.btnm3udownload_Click);
            // 
            // lvwContent
            // 
            this.lvwContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwContent.FullRowSelect = true;
            this.lvwContent.HideSelection = false;
            this.lvwContent.Location = new System.Drawing.Point(12, 98);
            this.lvwContent.MultiSelect = false;
            this.lvwContent.Name = "lvwContent";
            this.lvwContent.Size = new System.Drawing.Size(593, 360);
            this.lvwContent.TabIndex = 3;
            this.lvwContent.UseCompatibleStateImageBehavior = false;
            this.lvwContent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Group Title";
            this.columnHeader1.Width = 213;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 337;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(162, 69);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(83, 23);
            this.btnSearchName.TabIndex = 5;
            this.btnSearchName.Text = "Search Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(339, 69);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 6;
            this.btnResetFilter.Text = "Reset Filter";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(432, 69);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(173, 23);
            this.pbDownload.Step = 1;
            this.pbDownload.TabIndex = 7;
            // 
            // btnSearchGroup
            // 
            this.btnSearchGroup.Location = new System.Drawing.Point(251, 69);
            this.btnSearchGroup.Name = "btnSearchGroup";
            this.btnSearchGroup.Size = new System.Drawing.Size(82, 23);
            this.btnSearchGroup.TabIndex = 8;
            this.btnSearchGroup.Text = "Search Group";
            this.btnSearchGroup.UseVisualStyleBackColor = true;
            this.btnSearchGroup.Click += new System.EventHandler(this.btnSearchGroup_Click);
            // 
            // btnMovieDownload
            // 
            this.btnMovieDownload.Location = new System.Drawing.Point(504, 10);
            this.btnMovieDownload.Name = "btnMovieDownload";
            this.btnMovieDownload.Size = new System.Drawing.Size(100, 23);
            this.btnMovieDownload.TabIndex = 9;
            this.btnMovieDownload.Text = "Movie Download";
            this.btnMovieDownload.UseVisualStyleBackColor = true;
            this.btnMovieDownload.Click += new System.EventHandler(this.btnMovieDownload_Click);
            // 
            // lblDownText
            // 
            this.lblDownText.AutoSize = true;
            this.lblDownText.Location = new System.Drawing.Point(403, 36);
            this.lblDownText.Name = "lblDownText";
            this.lblDownText.Size = new System.Drawing.Size(95, 13);
            this.lblDownText.TabIndex = 10;
            this.lblDownText.Text = "Download Speed: ";
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.AutoSize = true;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(504, 36);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblDownloadSpeed.TabIndex = 10;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(403, 53);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(89, 13);
            this.lblRemaining.TabIndex = 10;
            this.lblRemaining.Text = "Remaining Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(498, 53);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(0, 13);
            this.lblRemainingTime.TabIndex = 10;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDownloadSpeed);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblDownText);
            this.Controls.Add(this.btnMovieDownload);
            this.Controls.Add(this.btnSearchGroup);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvwContent);
            this.Controls.Add(this.btnm3udownload);
            this.Controls.Add(this.lblm3uurl);
            this.Controls.Add(this.txtm3ulink);
            this.Name = "MainFrm";
            this.Text = "IPTV Movie Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtm3ulink;
        private System.Windows.Forms.Label lblm3uurl;
        private System.Windows.Forms.Button btnm3udownload;
        private System.Windows.Forms.ListView lvwContent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Button btnSearchGroup;
        private System.Windows.Forms.Button btnMovieDownload;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label lblDownText;
        private System.Windows.Forms.Label lblDownloadSpeed;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRemainingTime;
    }
}

