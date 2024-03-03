namespace ССП_1
{
    partial class ImageViewer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.browseButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.removeAll = new System.Windows.Forms.Button();
            this.writePlaylist = new System.Windows.Forms.Button();
            this.openPlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(12, 24);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(160, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Открыть папку";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(343, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(978, 711);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(178, 24);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить элемент";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(13, 53);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(235, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Удалить выбранные элементы";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 82);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(324, 611);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(254, 53);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(83, 23);
            this.removeAll.TabIndex = 7;
            this.removeAll.Text = "Очистить";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // writePlaylist
            // 
            this.writePlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.writePlaylist.Location = new System.Drawing.Point(13, 699);
            this.writePlaylist.Name = "writePlaylist";
            this.writePlaylist.Size = new System.Drawing.Size(160, 23);
            this.writePlaylist.TabIndex = 8;
            this.writePlaylist.Text = "Записать плейлист";
            this.writePlaylist.UseVisualStyleBackColor = true;
            this.writePlaylist.Click += new System.EventHandler(this.writePlaylist_Click);
            // 
            // openPlaylist
            // 
            this.openPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openPlaylist.Location = new System.Drawing.Point(177, 699);
            this.openPlaylist.Name = "openPlaylist";
            this.openPlaylist.Size = new System.Drawing.Size(160, 23);
            this.openPlaylist.TabIndex = 9;
            this.openPlaylist.Text = "Открыть плейлист";
            this.openPlaylist.UseVisualStyleBackColor = true;
            this.openPlaylist.Click += new System.EventHandler(this.openPlaylist_Click);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 749);
            this.Controls.Add(this.openPlaylist);
            this.Controls.Add(this.writePlaylist);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.browseButton);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button writePlaylist;
        private System.Windows.Forms.Button openPlaylist;
    }
}

