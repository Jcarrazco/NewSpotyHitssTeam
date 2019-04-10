namespace SpotyHitss.UI.Client
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInsertSong = new System.Windows.Forms.TabPage();
            this.btnSearchSong = new System.Windows.Forms.Button();
            this.btnInsertSong = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReleaseYSong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabListByArtis = new System.Windows.Forms.TabPage();
            this.dataSearchByArtist = new System.Windows.Forms.DataGridView();
            this.txtArtistSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchByArtist = new System.Windows.Forms.Button();
            this.tabInsertAlbum = new System.Windows.Forms.TabPage();
            this.btnInsertAlbum = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReleaseAlbum = new System.Windows.Forms.TextBox();
            this.txtNameAlbum = new System.Windows.Forms.TextBox();
            this.tabListByGenre = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenreSearch = new System.Windows.Forms.TextBox();
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.dataSearchByGenre = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabInsertSong.SuspendLayout();
            this.tabListByArtis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchByArtist)).BeginInit();
            this.tabInsertAlbum.SuspendLayout();
            this.tabListByGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchByGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInsertSong);
            this.tabControl.Controls.Add(this.tabListByArtis);
            this.tabControl.Controls.Add(this.tabInsertAlbum);
            this.tabControl.Controls.Add(this.tabListByGenre);
            this.tabControl.Location = new System.Drawing.Point(13, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 379);
            this.tabControl.TabIndex = 0;
            // 
            // tabInsertSong
            // 
            this.tabInsertSong.Controls.Add(this.btnSearchSong);
            this.tabInsertSong.Controls.Add(this.btnInsertSong);
            this.tabInsertSong.Controls.Add(this.textBox4);
            this.tabInsertSong.Controls.Add(this.label5);
            this.tabInsertSong.Controls.Add(this.txtArtistName);
            this.tabInsertSong.Controls.Add(this.label4);
            this.tabInsertSong.Controls.Add(this.txtReleaseYSong);
            this.tabInsertSong.Controls.Add(this.label3);
            this.tabInsertSong.Controls.Add(this.txtNameSong);
            this.tabInsertSong.Controls.Add(this.label2);
            this.tabInsertSong.Location = new System.Drawing.Point(4, 22);
            this.tabInsertSong.Name = "tabInsertSong";
            this.tabInsertSong.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertSong.Size = new System.Drawing.Size(767, 353);
            this.tabInsertSong.TabIndex = 0;
            this.tabInsertSong.Text = "InsertSong";
            this.tabInsertSong.UseVisualStyleBackColor = true;
            // 
            // btnSearchSong
            // 
            this.btnSearchSong.Location = new System.Drawing.Point(309, 87);
            this.btnSearchSong.Name = "btnSearchSong";
            this.btnSearchSong.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSong.TabIndex = 9;
            this.btnSearchSong.Text = "Search";
            this.btnSearchSong.UseVisualStyleBackColor = true;
            // 
            // btnInsertSong
            // 
            this.btnInsertSong.Location = new System.Drawing.Point(309, 116);
            this.btnInsertSong.Name = "btnInsertSong";
            this.btnInsertSong.Size = new System.Drawing.Size(75, 23);
            this.btnInsertSong.TabIndex = 8;
            this.btnInsertSong.Text = "Insert";
            this.btnInsertSong.UseVisualStyleBackColor = true;
            this.btnInsertSong.Click += new System.EventHandler(this.btnInsertSong_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "File Song";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(128, 64);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(256, 20);
            this.txtArtistName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Artist name";
            // 
            // txtReleaseYSong
            // 
            this.txtReleaseYSong.Location = new System.Drawing.Point(128, 38);
            this.txtReleaseYSong.Name = "txtReleaseYSong";
            this.txtReleaseYSong.Size = new System.Drawing.Size(256, 20);
            this.txtReleaseYSong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Release year";
            // 
            // txtNameSong
            // 
            this.txtNameSong.Location = new System.Drawing.Point(128, 12);
            this.txtNameSong.Name = "txtNameSong";
            this.txtNameSong.Size = new System.Drawing.Size(256, 20);
            this.txtNameSong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // tabListByArtis
            // 
            this.tabListByArtis.Controls.Add(this.dataSearchByArtist);
            this.tabListByArtis.Controls.Add(this.txtArtistSearch);
            this.tabListByArtis.Controls.Add(this.label6);
            this.tabListByArtis.Controls.Add(this.btnSearchByArtist);
            this.tabListByArtis.Location = new System.Drawing.Point(4, 22);
            this.tabListByArtis.Name = "tabListByArtis";
            this.tabListByArtis.Padding = new System.Windows.Forms.Padding(3);
            this.tabListByArtis.Size = new System.Drawing.Size(767, 353);
            this.tabListByArtis.TabIndex = 1;
            this.tabListByArtis.Text = "List by artist";
            this.tabListByArtis.UseVisualStyleBackColor = true;
            // 
            // dataSearchByArtist
            // 
            this.dataSearchByArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchByArtist.Location = new System.Drawing.Point(20, 53);
            this.dataSearchByArtist.Name = "dataSearchByArtist";
            this.dataSearchByArtist.Size = new System.Drawing.Size(741, 285);
            this.dataSearchByArtist.TabIndex = 3;
            // 
            // txtArtistSearch
            // 
            this.txtArtistSearch.Location = new System.Drawing.Point(82, 10);
            this.txtArtistSearch.Name = "txtArtistSearch";
            this.txtArtistSearch.Size = new System.Drawing.Size(234, 20);
            this.txtArtistSearch.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Artist name";
            // 
            // btnSearchByArtist
            // 
            this.btnSearchByArtist.Location = new System.Drawing.Point(322, 8);
            this.btnSearchByArtist.Name = "btnSearchByArtist";
            this.btnSearchByArtist.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByArtist.TabIndex = 0;
            this.btnSearchByArtist.Text = "Search";
            this.btnSearchByArtist.UseVisualStyleBackColor = true;
            this.btnSearchByArtist.Click += new System.EventHandler(this.btnSearchByArtist_Click);
            // 
            // tabInsertAlbum
            // 
            this.tabInsertAlbum.Controls.Add(this.btnInsertAlbum);
            this.tabInsertAlbum.Controls.Add(this.label8);
            this.tabInsertAlbum.Controls.Add(this.label7);
            this.tabInsertAlbum.Controls.Add(this.txtReleaseAlbum);
            this.tabInsertAlbum.Controls.Add(this.txtNameAlbum);
            this.tabInsertAlbum.Location = new System.Drawing.Point(4, 22);
            this.tabInsertAlbum.Name = "tabInsertAlbum";
            this.tabInsertAlbum.Size = new System.Drawing.Size(767, 353);
            this.tabInsertAlbum.TabIndex = 2;
            this.tabInsertAlbum.Text = "Insert Album";
            this.tabInsertAlbum.UseVisualStyleBackColor = true;
            // 
            // btnInsertAlbum
            // 
            this.btnInsertAlbum.Location = new System.Drawing.Point(225, 68);
            this.btnInsertAlbum.Name = "btnInsertAlbum";
            this.btnInsertAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnInsertAlbum.TabIndex = 4;
            this.btnInsertAlbum.Text = "Insert";
            this.btnInsertAlbum.UseVisualStyleBackColor = true;
            this.btnInsertAlbum.Click += new System.EventHandler(this.btnInsertAlbum_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Release Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // txtReleaseAlbum
            // 
            this.txtReleaseAlbum.Location = new System.Drawing.Point(98, 41);
            this.txtReleaseAlbum.Name = "txtReleaseAlbum";
            this.txtReleaseAlbum.Size = new System.Drawing.Size(203, 20);
            this.txtReleaseAlbum.TabIndex = 1;
            // 
            // txtNameAlbum
            // 
            this.txtNameAlbum.Location = new System.Drawing.Point(98, 15);
            this.txtNameAlbum.Name = "txtNameAlbum";
            this.txtNameAlbum.Size = new System.Drawing.Size(203, 20);
            this.txtNameAlbum.TabIndex = 0;
            // 
            // tabListByGenre
            // 
            this.tabListByGenre.Controls.Add(this.label9);
            this.tabListByGenre.Controls.Add(this.txtGenreSearch);
            this.tabListByGenre.Controls.Add(this.btnSearchGenre);
            this.tabListByGenre.Controls.Add(this.dataSearchByGenre);
            this.tabListByGenre.Location = new System.Drawing.Point(4, 22);
            this.tabListByGenre.Name = "tabListByGenre";
            this.tabListByGenre.Size = new System.Drawing.Size(767, 353);
            this.tabListByGenre.TabIndex = 3;
            this.tabListByGenre.Text = "List by Genre";
            this.tabListByGenre.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Genre";
            // 
            // txtGenreSearch
            // 
            this.txtGenreSearch.Location = new System.Drawing.Point(85, 15);
            this.txtGenreSearch.Name = "txtGenreSearch";
            this.txtGenreSearch.Size = new System.Drawing.Size(182, 20);
            this.txtGenreSearch.TabIndex = 2;
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.Location = new System.Drawing.Point(284, 13);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.btnSearchGenre.Size = new System.Drawing.Size(75, 23);
            this.btnSearchGenre.TabIndex = 1;
            this.btnSearchGenre.Text = "Search";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // dataSearchByGenre
            // 
            this.dataSearchByGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchByGenre.Location = new System.Drawing.Point(20, 50);
            this.dataSearchByGenre.Name = "dataSearchByGenre";
            this.dataSearchByGenre.Size = new System.Drawing.Size(731, 288);
            this.dataSearchByGenre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NewSpotyHitss";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabInsertSong.ResumeLayout(false);
            this.tabInsertSong.PerformLayout();
            this.tabListByArtis.ResumeLayout(false);
            this.tabListByArtis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchByArtist)).EndInit();
            this.tabInsertAlbum.ResumeLayout(false);
            this.tabInsertAlbum.PerformLayout();
            this.tabListByGenre.ResumeLayout(false);
            this.tabListByGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchByGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInsertSong;
        private System.Windows.Forms.TabPage tabListByArtis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabInsertAlbum;
        private System.Windows.Forms.TabPage tabListByGenre;
        private System.Windows.Forms.Button btnSearchSong;
        private System.Windows.Forms.Button btnInsertSong;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReleaseYSong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataSearchByArtist;
        private System.Windows.Forms.TextBox txtArtistSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchByArtist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReleaseAlbum;
        private System.Windows.Forms.TextBox txtNameAlbum;
        private System.Windows.Forms.Button btnInsertAlbum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenreSearch;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.DataGridView dataSearchByGenre;
    }
}

