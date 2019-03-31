namespace DJLF47___GKLB_INTM038___Stitching
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
            this.components = new System.ComponentModel.Container();
            this.open = new System.Windows.Forms.Button();
            this.dataGridViewKepek = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MldbUpRadio = new System.Windows.Forms.RadioButton();
            this.MldbRadio = new System.Windows.Forms.RadioButton();
            this.KazeUpRadio = new System.Windows.Forms.RadioButton();
            this.KazeRadio = new System.Windows.Forms.RadioButton();
            this.Channel1Radio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Channerl3Radio = new System.Windows.Forms.RadioButton();
            this.Channel2Radio = new System.Windows.Forms.RadioButton();
            this.TresholdTrack = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WeickerRadio = new System.Windows.Forms.RadioButton();
            this.PmG2Radio = new System.Windows.Forms.RadioButton();
            this.PmG1Radio = new System.Windows.Forms.RadioButton();
            this.CharbonnierRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultImage = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKepek)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TresholdTrack)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(352, 409);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Open/Start";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // dataGridViewKepek
            // 
            this.dataGridViewKepek.AllowUserToAddRows = false;
            this.dataGridViewKepek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKepek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.FileName});
            this.dataGridViewKepek.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewKepek.Name = "dataGridViewKepek";
            this.dataGridViewKepek.ReadOnly = true;
            this.dataGridViewKepek.Size = new System.Drawing.Size(622, 352);
            this.dataGridViewKepek.TabIndex = 0;
            // 
            // View
            // 
            this.View.FillWeight = 200F;
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 200;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MldbUpRadio);
            this.panel1.Controls.Add(this.MldbRadio);
            this.panel1.Controls.Add(this.KazeUpRadio);
            this.panel1.Controls.Add(this.KazeRadio);
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 125);
            this.panel1.TabIndex = 5;
            // 
            // MldbUpRadio
            // 
            this.MldbUpRadio.AutoSize = true;
            this.MldbUpRadio.Location = new System.Drawing.Point(16, 88);
            this.MldbUpRadio.Name = "MldbUpRadio";
            this.MldbUpRadio.Size = new System.Drawing.Size(82, 17);
            this.MldbUpRadio.TabIndex = 3;
            this.MldbUpRadio.TabStop = true;
            this.MldbUpRadio.Text = "MldbUpright";
            this.MldbUpRadio.UseVisualStyleBackColor = true;
            // 
            // MldbRadio
            // 
            this.MldbRadio.AutoSize = true;
            this.MldbRadio.Location = new System.Drawing.Point(16, 64);
            this.MldbRadio.Name = "MldbRadio";
            this.MldbRadio.Size = new System.Drawing.Size(48, 17);
            this.MldbRadio.TabIndex = 2;
            this.MldbRadio.TabStop = true;
            this.MldbRadio.Text = "Mldb";
            this.MldbRadio.UseVisualStyleBackColor = true;
            // 
            // KazeUpRadio
            // 
            this.KazeUpRadio.AutoSize = true;
            this.KazeUpRadio.Location = new System.Drawing.Point(15, 41);
            this.KazeUpRadio.Name = "KazeUpRadio";
            this.KazeUpRadio.Size = new System.Drawing.Size(83, 17);
            this.KazeUpRadio.TabIndex = 1;
            this.KazeUpRadio.TabStop = true;
            this.KazeUpRadio.Text = "KazeUpright";
            this.KazeUpRadio.UseVisualStyleBackColor = true;
            // 
            // KazeRadio
            // 
            this.KazeRadio.AutoSize = true;
            this.KazeRadio.Location = new System.Drawing.Point(15, 16);
            this.KazeRadio.Name = "KazeRadio";
            this.KazeRadio.Size = new System.Drawing.Size(49, 17);
            this.KazeRadio.TabIndex = 0;
            this.KazeRadio.TabStop = true;
            this.KazeRadio.Text = "Kaze";
            this.KazeRadio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KazeRadio.UseVisualStyleBackColor = true;
            // 
            // Channel1Radio
            // 
            this.Channel1Radio.AutoSize = true;
            this.Channel1Radio.Location = new System.Drawing.Point(4, 16);
            this.Channel1Radio.Name = "Channel1Radio";
            this.Channel1Radio.Size = new System.Drawing.Size(72, 17);
            this.Channel1Radio.TabIndex = 6;
            this.Channel1Radio.TabStop = true;
            this.Channel1Radio.Text = "1 channel";
            this.Channel1Radio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Channerl3Radio);
            this.panel2.Controls.Add(this.Channel1Radio);
            this.panel2.Controls.Add(this.Channel2Radio);
            this.panel2.Location = new System.Drawing.Point(114, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 125);
            this.panel2.TabIndex = 7;
            // 
            // Channerl3Radio
            // 
            this.Channerl3Radio.AutoSize = true;
            this.Channerl3Radio.Location = new System.Drawing.Point(3, 82);
            this.Channerl3Radio.Name = "Channerl3Radio";
            this.Channerl3Radio.Size = new System.Drawing.Size(72, 17);
            this.Channerl3Radio.TabIndex = 1;
            this.Channerl3Radio.TabStop = true;
            this.Channerl3Radio.Text = "3 channel";
            this.Channerl3Radio.UseVisualStyleBackColor = true;
            // 
            // Channel2Radio
            // 
            this.Channel2Radio.AutoSize = true;
            this.Channel2Radio.Location = new System.Drawing.Point(4, 49);
            this.Channel2Radio.Name = "Channel2Radio";
            this.Channel2Radio.Size = new System.Drawing.Size(72, 17);
            this.Channel2Radio.TabIndex = 0;
            this.Channel2Radio.TabStop = true;
            this.Channel2Radio.Text = "2 channel";
            this.Channel2Radio.UseVisualStyleBackColor = true;
            // 
            // TresholdTrack
            // 
            this.TresholdTrack.LargeChange = 1;
            this.TresholdTrack.Location = new System.Drawing.Point(12, 531);
            this.TresholdTrack.Maximum = 10000;
            this.TresholdTrack.Name = "TresholdTrack";
            this.TresholdTrack.Size = new System.Drawing.Size(568, 45);
            this.TresholdTrack.TabIndex = 8;
            this.TresholdTrack.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.WeickerRadio);
            this.panel3.Controls.Add(this.PmG2Radio);
            this.panel3.Controls.Add(this.PmG1Radio);
            this.panel3.Controls.Add(this.CharbonnierRadio);
            this.panel3.Location = new System.Drawing.Point(206, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 125);
            this.panel3.TabIndex = 9;
            // 
            // WeickerRadio
            // 
            this.WeickerRadio.AutoSize = true;
            this.WeickerRadio.Location = new System.Drawing.Point(21, 97);
            this.WeickerRadio.Name = "WeickerRadio";
            this.WeickerRadio.Size = new System.Drawing.Size(65, 17);
            this.WeickerRadio.TabIndex = 3;
            this.WeickerRadio.TabStop = true;
            this.WeickerRadio.Text = "Weicker";
            this.WeickerRadio.UseVisualStyleBackColor = true;
            // 
            // PmG2Radio
            // 
            this.PmG2Radio.AutoSize = true;
            this.PmG2Radio.Location = new System.Drawing.Point(21, 69);
            this.PmG2Radio.Name = "PmG2Radio";
            this.PmG2Radio.Size = new System.Drawing.Size(54, 17);
            this.PmG2Radio.TabIndex = 2;
            this.PmG2Radio.TabStop = true;
            this.PmG2Radio.Text = "PmG2";
            this.PmG2Radio.UseVisualStyleBackColor = true;
            // 
            // PmG1Radio
            // 
            this.PmG1Radio.AutoSize = true;
            this.PmG1Radio.Location = new System.Drawing.Point(21, 41);
            this.PmG1Radio.Name = "PmG1Radio";
            this.PmG1Radio.Size = new System.Drawing.Size(54, 17);
            this.PmG1Radio.TabIndex = 1;
            this.PmG1Radio.TabStop = true;
            this.PmG1Radio.Text = "PmG1";
            this.PmG1Radio.UseVisualStyleBackColor = true;
            // 
            // CharbonnierRadio
            // 
            this.CharbonnierRadio.AutoSize = true;
            this.CharbonnierRadio.Location = new System.Drawing.Point(21, 16);
            this.CharbonnierRadio.Name = "CharbonnierRadio";
            this.CharbonnierRadio.Size = new System.Drawing.Size(82, 17);
            this.CharbonnierRadio.TabIndex = 0;
            this.CharbonnierRadio.TabStop = true;
            this.CharbonnierRadio.Text = "Charbonnier";
            this.CharbonnierRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Treshold:";
            // 
            // resultImage
            // 
            this.resultImage.Location = new System.Drawing.Point(619, 1);
            this.resultImage.Name = "resultImage";
            this.resultImage.Size = new System.Drawing.Size(756, 575);
            this.resultImage.TabIndex = 2;
            this.resultImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 579);
            this.Controls.Add(this.resultImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TresholdTrack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewKepek);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "DJLF47 - Stitching";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKepek)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TresholdTrack)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.DataGridView dataGridViewKepek;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton MldbUpRadio;
        private System.Windows.Forms.RadioButton MldbRadio;
        private System.Windows.Forms.RadioButton KazeUpRadio;
        private System.Windows.Forms.RadioButton KazeRadio;
        private System.Windows.Forms.RadioButton Channel1Radio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Channerl3Radio;
        private System.Windows.Forms.RadioButton Channel2Radio;
        private System.Windows.Forms.TrackBar TresholdTrack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton WeickerRadio;
        private System.Windows.Forms.RadioButton PmG2Radio;
        private System.Windows.Forms.RadioButton PmG1Radio;
        private System.Windows.Forms.RadioButton CharbonnierRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox resultImage;
    }
}

