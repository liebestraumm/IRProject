namespace IR_project
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
            this.collBTN = new System.Windows.Forms.Button();
            this.indexBTN = new System.Windows.Forms.Button();
            this.goBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTXT = new System.Windows.Forms.TextBox();
            this.preBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.PageLBL = new System.Windows.Forms.Label();
            this.txtbx = new System.Windows.Forms.RichTextBox();
            this.resBTN = new System.Windows.Forms.Button();
            this.resPathBTN = new System.Windows.Forms.Button();
            this.savinResultsLBL = new System.Windows.Forms.Label();
            this.indexPathLBL = new System.Windows.Forms.Label();
            this.collectionPathLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageCountLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // collBTN
            // 
            this.collBTN.Location = new System.Drawing.Point(18, 13);
            this.collBTN.Name = "collBTN";
            this.collBTN.Size = new System.Drawing.Size(102, 23);
            this.collBTN.TabIndex = 2;
            this.collBTN.Text = "Source collection";
            this.collBTN.UseVisualStyleBackColor = true;
            this.collBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // indexBTN
            // 
            this.indexBTN.Enabled = false;
            this.indexBTN.Location = new System.Drawing.Point(18, 38);
            this.indexBTN.Name = "indexBTN";
            this.indexBTN.Size = new System.Drawing.Size(101, 23);
            this.indexBTN.TabIndex = 3;
            this.indexBTN.Text = "Index Dir";
            this.indexBTN.UseVisualStyleBackColor = true;
            this.indexBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // goBTN
            // 
            this.goBTN.Enabled = false;
            this.goBTN.Location = new System.Drawing.Point(515, 96);
            this.goBTN.Name = "goBTN";
            this.goBTN.Size = new System.Drawing.Size(68, 23);
            this.goBTN.TabIndex = 4;
            this.goBTN.Text = "Go";
            this.goBTN.UseVisualStyleBackColor = true;
            this.goBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(63, 98);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(446, 20);
            this.searchTXT.TabIndex = 11;
            // 
            // preBTN
            // 
            this.preBTN.Enabled = false;
            this.preBTN.Location = new System.Drawing.Point(225, 591);
            this.preBTN.Name = "preBTN";
            this.preBTN.Size = new System.Drawing.Size(36, 23);
            this.preBTN.TabIndex = 7;
            this.preBTN.Text = "<";
            this.preBTN.UseVisualStyleBackColor = true;
            this.preBTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nextBTN
            // 
            this.nextBTN.Enabled = false;
            this.nextBTN.Location = new System.Drawing.Point(349, 591);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(36, 23);
            this.nextBTN.TabIndex = 8;
            this.nextBTN.Text = ">";
            this.nextBTN.UseVisualStyleBackColor = true;
            this.nextBTN.Click += new System.EventHandler(this.button5_Click);
            // 
            // PageLBL
            // 
            this.PageLBL.AutoSize = true;
            this.PageLBL.Location = new System.Drawing.Point(267, 596);
            this.PageLBL.Name = "PageLBL";
            this.PageLBL.Size = new System.Drawing.Size(13, 13);
            this.PageLBL.TabIndex = 9;
            this.PageLBL.Text = "1";
            // 
            // txtbx
            // 
            this.txtbx.Location = new System.Drawing.Point(19, 124);
            this.txtbx.Name = "txtbx";
            this.txtbx.ReadOnly = true;
            this.txtbx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtbx.Size = new System.Drawing.Size(564, 461);
            this.txtbx.TabIndex = 10;
            this.txtbx.Text = "";
            this.txtbx.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtbx_LinkClicked);
            // 
            // resBTN
            // 
            this.resBTN.Enabled = false;
            this.resBTN.Location = new System.Drawing.Point(18, 63);
            this.resBTN.Name = "resBTN";
            this.resBTN.Size = new System.Drawing.Size(75, 23);
            this.resBTN.TabIndex = 12;
            this.resBTN.Text = "Save result";
            this.resBTN.UseVisualStyleBackColor = true;
            this.resBTN.Click += new System.EventHandler(this.button6_Click);
            // 
            // resPathBTN
            // 
            this.resPathBTN.Enabled = false;
            this.resPathBTN.Location = new System.Drawing.Point(93, 63);
            this.resPathBTN.Name = "resPathBTN";
            this.resPathBTN.Size = new System.Drawing.Size(26, 23);
            this.resPathBTN.TabIndex = 13;
            this.resPathBTN.Text = "...";
            this.resPathBTN.UseVisualStyleBackColor = true;
            this.resPathBTN.Click += new System.EventHandler(this.button7_Click);
            // 
            // savinResultsLBL
            // 
            this.savinResultsLBL.AutoSize = true;
            this.savinResultsLBL.Location = new System.Drawing.Point(125, 68);
            this.savinResultsLBL.Name = "savinResultsLBL";
            this.savinResultsLBL.Size = new System.Drawing.Size(0, 13);
            this.savinResultsLBL.TabIndex = 14;
            // 
            // indexPathLBL
            // 
            this.indexPathLBL.AutoSize = true;
            this.indexPathLBL.Location = new System.Drawing.Point(125, 43);
            this.indexPathLBL.Name = "indexPathLBL";
            this.indexPathLBL.Size = new System.Drawing.Size(0, 13);
            this.indexPathLBL.TabIndex = 15;
            // 
            // collectionPathLBL
            // 
            this.collectionPathLBL.AutoSize = true;
            this.collectionPathLBL.Location = new System.Drawing.Point(127, 18);
            this.collectionPathLBL.Name = "collectionPathLBL";
            this.collectionPathLBL.Size = new System.Drawing.Size(0, 13);
            this.collectionPathLBL.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "/";
            // 
            // pageCountLBL
            // 
            this.pageCountLBL.AutoSize = true;
            this.pageCountLBL.Location = new System.Drawing.Point(317, 596);
            this.pageCountLBL.Name = "pageCountLBL";
            this.pageCountLBL.Size = new System.Drawing.Size(13, 13);
            this.pageCountLBL.TabIndex = 18;
            this.pageCountLBL.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 622);
            this.Controls.Add(this.pageCountLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.collectionPathLBL);
            this.Controls.Add(this.indexPathLBL);
            this.Controls.Add(this.savinResultsLBL);
            this.Controls.Add(this.resPathBTN);
            this.Controls.Add(this.resBTN);
            this.Controls.Add(this.txtbx);
            this.Controls.Add(this.PageLBL);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.preBTN);
            this.Controls.Add(this.searchTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBTN);
            this.Controls.Add(this.indexBTN);
            this.Controls.Add(this.collBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button collBTN;
        private System.Windows.Forms.Button indexBTN;
        private System.Windows.Forms.Button goBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTXT;
        private System.Windows.Forms.Button preBTN;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Label PageLBL;
        private System.Windows.Forms.RichTextBox txtbx;
        private System.Windows.Forms.Button resBTN;
        private System.Windows.Forms.Button resPathBTN;
        private System.Windows.Forms.Label savinResultsLBL;
        private System.Windows.Forms.Label indexPathLBL;
        private System.Windows.Forms.Label collectionPathLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pageCountLBL;
    }
}

