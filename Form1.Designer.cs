namespace manipulate_images
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.radioRow = new System.Windows.Forms.RadioButton();
            this.radioCol = new System.Windows.Forms.RadioButton();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.pictureBoxRow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 817);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddPhoto
            // 
            this.AddPhoto.Location = new System.Drawing.Point(1261, 12);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(94, 29);
            this.AddPhoto.TabIndex = 1;
            this.AddPhoto.Text = "Add Photo";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // radioRow
            // 
            this.radioRow.AutoSize = true;
            this.radioRow.Checked = true;
            this.radioRow.Location = new System.Drawing.Point(1261, 57);
            this.radioRow.Name = "radioRow";
            this.radioRow.Size = new System.Drawing.Size(59, 24);
            this.radioRow.TabIndex = 2;
            this.radioRow.TabStop = true;
            this.radioRow.Text = "Row";
            this.radioRow.UseVisualStyleBackColor = true;
            // 
            // radioCol
            // 
            this.radioCol.AutoSize = true;
            this.radioCol.Location = new System.Drawing.Point(1261, 87);
            this.radioCol.Name = "radioCol";
            this.radioCol.Size = new System.Drawing.Size(72, 24);
            this.radioCol.TabIndex = 3;
            this.radioCol.Text = "Collun";
            this.radioCol.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(1261, 127);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(80, 29);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // pictureBoxRow
            // 
            this.pictureBoxRow.Location = new System.Drawing.Point(200, 12);
            this.pictureBoxRow.Name = "pictureBoxRow";
            this.pictureBoxRow.Size = new System.Drawing.Size(886, 817);
            this.pictureBoxRow.TabIndex = 5;
            this.pictureBoxRow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 841);
            this.Controls.Add(this.pictureBoxRow);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.radioCol);
            this.Controls.Add(this.radioRow);
            this.Controls.Add(this.AddPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button AddPhoto;
        private RadioButton radioRow;
        private RadioButton radioCol;
        private Button ClearBtn;
        private PictureBox pictureBoxRow;
    }
}