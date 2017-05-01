namespace Dictionary
{
    partial class frmDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictionary));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irregularVerbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronounToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUIEVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new DevExpress.XtraEditors.VScrollBar();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btIrregularVerbs = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbMeaning = new System.Windows.Forms.Label();
            this.lbEngWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFamily = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1.SuspendLayout();
            this.Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionaryToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentToolStripMenuItem,
            this.favouriteToolStripMenuItem,
            this.irregularVerbsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // favouriteToolStripMenuItem
            // 
            this.favouriteToolStripMenuItem.Name = "favouriteToolStripMenuItem";
            this.favouriteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.favouriteToolStripMenuItem.Text = "Favourite";
            this.favouriteToolStripMenuItem.Click += new System.EventHandler(this.favouriteToolStripMenuItem_Click);
            // 
            // irregularVerbsToolStripMenuItem
            // 
            this.irregularVerbsToolStripMenuItem.Name = "irregularVerbsToolStripMenuItem";
            this.irregularVerbsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.irregularVerbsToolStripMenuItem.Text = "Irregular Verbs";
            this.irregularVerbsToolStripMenuItem.Click += new System.EventHandler(this.irregularVerbsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWordToolStripMenuItem,
            this.onlineSearchToolStripMenuItem,
            this.pronounToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // newWordToolStripMenuItem
            // 
            this.newWordToolStripMenuItem.Name = "newWordToolStripMenuItem";
            this.newWordToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newWordToolStripMenuItem.Text = "New Word";
            this.newWordToolStripMenuItem.Click += new System.EventHandler(this.newWordToolStripMenuItem_Click);
            // 
            // onlineSearchToolStripMenuItem
            // 
            this.onlineSearchToolStripMenuItem.Name = "onlineSearchToolStripMenuItem";
            this.onlineSearchToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.onlineSearchToolStripMenuItem.Text = "Online Search";
            // 
            // pronounToolStripMenuItem
            // 
            this.pronounToolStripMenuItem.Name = "pronounToolStripMenuItem";
            this.pronounToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.pronounToolStripMenuItem.Text = "Pronounce";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.gUIEVToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gUIEVToolStripMenuItem
            // 
            this.gUIEVToolStripMenuItem.Name = "gUIEVToolStripMenuItem";
            this.gUIEVToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.gUIEVToolStripMenuItem.Text = "GUI E_V";
            this.gUIEVToolStripMenuItem.Click += new System.EventHandler(this.gUIEVToolStripMenuItem_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(33, 58);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(185, 30);
            this.tbSearch.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(33, 105);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(313, 405);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(318, 105);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Opacity = 1F;
            this.vScrollBar1.Size = new System.Drawing.Size(28, 405);
            this.vScrollBar1.TabIndex = 15;
            // 
            // btSearch
            // 
            this.btSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Appearance.Options.UseFont = true;
            this.btSearch.Location = new System.Drawing.Point(224, 58);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(63, 33);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(880, 61);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 30);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Online";
            // 
            // btIrregularVerbs
            // 
            this.btIrregularVerbs.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIrregularVerbs.Appearance.Options.UseFont = true;
            this.btIrregularVerbs.Location = new System.Drawing.Point(371, 58);
            this.btIrregularVerbs.Name = "btIrregularVerbs";
            this.btIrregularVerbs.Size = new System.Drawing.Size(122, 30);
            this.btIrregularVerbs.TabIndex = 20;
            this.btIrregularVerbs.Text = "Irregular Verbs";
            this.btIrregularVerbs.Click += new System.EventHandler(this.btIrregularVerbs_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(499, 58);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(92, 30);
            this.simpleButton4.TabIndex = 21;
            this.simpleButton4.Text = "Idioms";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabPage1);
            this.Main.Controls.Add(this.tabPage2);
            this.Main.Location = new System.Drawing.Point(371, 105);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(601, 405);
            this.Main.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Homepage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbMeaning);
            this.tabPage2.Controls.Add(this.lbEngWord);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbFamily);
            this.tabPage2.Controls.Add(this.simpleButton3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbMeaning
            // 
            this.lbMeaning.AutoSize = true;
            this.lbMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeaning.Location = new System.Drawing.Point(48, 60);
            this.lbMeaning.Name = "lbMeaning";
            this.lbMeaning.Size = new System.Drawing.Size(94, 25);
            this.lbMeaning.TabIndex = 22;
            this.lbMeaning.Text = "Meaning:";
            // 
            // lbEngWord
            // 
            this.lbEngWord.AutoSize = true;
            this.lbEngWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEngWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbEngWord.Location = new System.Drawing.Point(48, 13);
            this.lbEngWord.Name = "lbEngWord";
            this.lbEngWord.Size = new System.Drawing.Size(116, 29);
            this.lbEngWord.TabIndex = 20;
            this.lbEngWord.Text = "Eng word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Example:";
            // 
            // lbFamily
            // 
            this.lbFamily.AutoSize = true;
            this.lbFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFamily.Location = new System.Drawing.Point(48, 155);
            this.lbFamily.Name = "lbFamily";
            this.lbFamily.Size = new System.Drawing.Size(116, 25);
            this.lbFamily.TabIndex = 23;
            this.lbFamily.Text = "Family word";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Random Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meaning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Daily Word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Random Idiom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Meaning";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dictionary.Properties.Resources.Flashcard_mặt_sau;
            this.pictureBox1.Location = new System.Drawing.Point(124, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(12, 13);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(30, 29);
            this.simpleButton3.TabIndex = 24;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(317, 58);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(29, 30);
            this.simpleButton2.TabIndex = 18;
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 559);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.btIrregularVerbs);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDictionary";
            this.Text = "Dictionary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronounToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUIEVToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private DevExpress.XtraEditors.VScrollBar vScrollBar1;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btIrregularVerbs;
        private System.Windows.Forms.ToolStripMenuItem irregularVerbsToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbMeaning;
        private System.Windows.Forms.Label lbEngWord;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label lbFamily;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

