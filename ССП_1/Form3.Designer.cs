namespace ССП_1
{
    partial class Form3
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
            System.Windows.Forms.Label Контраст;
            this.selectedPictureBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.black_and_white = new System.Windows.Forms.Button();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.exposureTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.removeAll = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sepia = new System.Windows.Forms.Button();
            this.rotate_270 = new System.Windows.Forms.Button();
            this.rotate_90 = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            Контраст = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Контраст
            // 
            Контраст.Location = new System.Drawing.Point(0, 0);
            Контраст.Name = "Контраст";
            Контраст.Size = new System.Drawing.Size(100, 23);
            Контраст.TabIndex = 28;
            // 
            // selectedPictureBox
            // 
            this.selectedPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedPictureBox.Location = new System.Drawing.Point(0, 0);
            this.selectedPictureBox.Name = "selectedPictureBox";
            this.selectedPictureBox.Size = new System.Drawing.Size(1095, 669);
            this.selectedPictureBox.TabIndex = 0;
            this.selectedPictureBox.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextButton.Location = new System.Drawing.Point(560, 724);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(545, 30);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(517, 18);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(137, 16);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Изображение 1 из 1";
            // 
            // previousButton
            // 
            this.previousButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previousButton.Location = new System.Drawing.Point(10, 724);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(545, 30);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(Контраст);
            this.groupBox1.Controls.Add(this.previousButton);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1472, 798);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.black_and_white);
            this.panel3.Controls.Add(this.contrastTrackBar);
            this.panel3.Controls.Add(this.exposureTrackBar);
            this.panel3.Controls.Add(this.zoomBar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.apply);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.removeAll);
            this.panel3.Controls.Add(this.save);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sepia);
            this.panel3.Controls.Add(this.rotate_270);
            this.panel3.Controls.Add(this.rotate_90);
            this.panel3.Controls.Add(this.negative);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.brightnessTrackBar);
            this.panel3.Location = new System.Drawing.Point(1111, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 732);
            this.panel3.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Масштаб";
            // 
            // black_and_white
            // 
            this.black_and_white.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.black_and_white.Location = new System.Drawing.Point(22, 398);
            this.black_and_white.Name = "black_and_white";
            this.black_and_white.Size = new System.Drawing.Size(282, 31);
            this.black_and_white.TabIndex = 18;
            this.black_and_white.Text = "Черно-белый";
            this.black_and_white.UseVisualStyleBackColor = true;
            this.black_and_white.Click += new System.EventHandler(this.black_and_white_Click);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contrastTrackBar.Location = new System.Drawing.Point(9, 55);
            this.contrastTrackBar.Maximum = 50;
            this.contrastTrackBar.Minimum = -50;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(313, 56);
            this.contrastTrackBar.TabIndex = 4;
            // 
            // exposureTrackBar
            // 
            this.exposureTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exposureTrackBar.Location = new System.Drawing.Point(9, 133);
            this.exposureTrackBar.Maximum = 50;
            this.exposureTrackBar.Minimum = -50;
            this.exposureTrackBar.Name = "exposureTrackBar";
            this.exposureTrackBar.Size = new System.Drawing.Size(313, 56);
            this.exposureTrackBar.TabIndex = 5;
            // 
            // zoomBar
            // 
            this.zoomBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zoomBar.Location = new System.Drawing.Point(28, 553);
            this.zoomBar.Maximum = 100;
            this.zoomBar.Minimum = -100;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(276, 56);
            this.zoomBar.TabIndex = 23;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Экспозиция: 0";
            // 
            // apply
            // 
            this.apply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.apply.Location = new System.Drawing.Point(28, 625);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(276, 42);
            this.apply.TabIndex = 22;
            this.apply.Text = "Применить";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Контрастность: 0";
            // 
            // removeAll
            // 
            this.removeAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeAll.Location = new System.Drawing.Point(22, 472);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(282, 31);
            this.removeAll.TabIndex = 21;
            this.removeAll.Text = "Убрать эффект";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.save.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.save.Location = new System.Drawing.Point(152, 698);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(153, 30);
            this.save.TabIndex = 11;
            this.save.Text = "Сохранить как...";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Эффекты";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Яркость: 0";
            // 
            // sepia
            // 
            this.sepia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sepia.Location = new System.Drawing.Point(22, 435);
            this.sepia.Name = "sepia";
            this.sepia.Size = new System.Drawing.Size(138, 31);
            this.sepia.TabIndex = 19;
            this.sepia.Text = "Сепия";
            this.sepia.UseVisualStyleBackColor = true;
            this.sepia.Click += new System.EventHandler(this.sepia_Click);
            // 
            // rotate_270
            // 
            this.rotate_270.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rotate_270.Location = new System.Drawing.Point(21, 305);
            this.rotate_270.Name = "rotate_270";
            this.rotate_270.Size = new System.Drawing.Size(139, 40);
            this.rotate_270.TabIndex = 13;
            this.rotate_270.Text = "<90";
            this.rotate_270.UseVisualStyleBackColor = true;
            this.rotate_270.Click += new System.EventHandler(this.rotate_270_Click);
            // 
            // rotate_90
            // 
            this.rotate_90.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rotate_90.Location = new System.Drawing.Point(166, 305);
            this.rotate_90.Name = "rotate_90";
            this.rotate_90.Size = new System.Drawing.Size(139, 40);
            this.rotate_90.TabIndex = 14;
            this.rotate_90.Text = "90>";
            this.rotate_90.UseVisualStyleBackColor = true;
            this.rotate_90.Click += new System.EventHandler(this.rotate_90_Click);
            // 
            // negative
            // 
            this.negative.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.negative.Location = new System.Drawing.Point(166, 435);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(138, 31);
            this.negative.TabIndex = 17;
            this.negative.Text = "Негатив";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Поворот";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.brightnessTrackBar.Location = new System.Drawing.Point(9, 208);
            this.brightnessTrackBar.Maximum = 50;
            this.brightnessTrackBar.Minimum = -50;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(313, 56);
            this.brightnessTrackBar.TabIndex = 16;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.selectedPictureBox);
            this.panel2.Location = new System.Drawing.Point(10, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 669);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(36, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 798);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox selectedPictureBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button black_and_white;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.TrackBar exposureTrackBar;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sepia;
        private System.Windows.Forms.Button rotate_270;
        private System.Windows.Forms.Button rotate_90;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
    }
}