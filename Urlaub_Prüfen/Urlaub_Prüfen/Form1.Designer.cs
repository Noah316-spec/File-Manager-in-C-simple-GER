namespace Urlaub_Prüfen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filepathbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filenamelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filetyplabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(758, 381);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Hopstarter-Sleek-Xp-Basic-Folder.48.png");
            this.iconList.Images.SetKeyName(1, "Archivos_25593.png");
            this.iconList.Images.SetKeyName(2, "files_text_lines_list_archive_document_doc_file_icon_258975.png");
            this.iconList.Images.SetKeyName(3, "doc_filetype_icon_177541.png");
            this.iconList.Images.SetKeyName(4, "application_software_adobereader_acrobat_adobereader_pdf_aplicacion_1828.png");
            this.iconList.Images.SetKeyName(5, "filetype_mp_icon_177528.png");
            this.iconList.Images.SetKeyName(6, "MP4_29705.png");
            this.iconList.Images.SetKeyName(7, "exe_115515.png");
            this.iconList.Images.SetKeyName(8, "file_unknow_icon_207188.png");
            this.iconList.Images.SetKeyName(9, "png_filetype_icon_177523.png");
            this.iconList.Images.SetKeyName(10, "folder64.png");
            this.iconList.Images.SetKeyName(11, "PowerPoint_2013_23479.png");
            this.iconList.Images.SetKeyName(12, "Excel_2013_23480.png");
            this.iconList.Images.SetKeyName(13, "microsoft_office_access_logo_icon_145727.png");
            this.iconList.Images.SetKeyName(14, "Trayse101-Basic-Filetypes-2-Url.48.png");
            this.iconList.Images.SetKeyName(15, "zip_filetype_icon_177508.png");
            this.iconList.Images.SetKeyName(16, "marcuse_ink_logo_icon_169968.png");
            this.iconList.Images.SetKeyName(17, "file_ini_format_type_icon_134715.png");
            // 
            // filepathbox
            // 
            this.filepathbox.Location = new System.Drawing.Point(89, 12);
            this.filepathbox.Multiline = true;
            this.filepathbox.Name = "filepathbox";
            this.filepathbox.Size = new System.Drawing.Size(604, 26);
            this.filepathbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filenamelabel
            // 
            this.filenamelabel.AutoSize = true;
            this.filenamelabel.Location = new System.Drawing.Point(27, 428);
            this.filenamelabel.Name = "filenamelabel";
            this.filenamelabel.Size = new System.Drawing.Size(51, 13);
            this.filenamelabel.TabIndex = 6;
            this.filenamelabel.Text = "FileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "--";
            // 
            // filetyplabel
            // 
            this.filetyplabel.AutoSize = true;
            this.filetyplabel.Location = new System.Drawing.Point(606, 428);
            this.filetyplabel.Name = "filetyplabel";
            this.filetyplabel.Size = new System.Drawing.Size(41, 13);
            this.filetyplabel.TabIndex = 8;
            this.filetyplabel.Text = "FileTyp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CreationTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last AccessTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filetyplabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filenamelabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filepathbox);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox filepathbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label filenamelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filetyplabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

