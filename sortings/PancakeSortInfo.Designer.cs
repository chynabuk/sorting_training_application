namespace sortings
{
    partial class PancakeSortInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PancakeSortInfo));
            pancakeBack = new Button();
            labelPancake = new Label();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pancakeBack
            // 
            pancakeBack.BackColor = SystemColors.MenuBar;
            pancakeBack.Image = (Image)resources.GetObject("pancakeBack.Image");
            pancakeBack.Location = new Point(32, 12);
            pancakeBack.Name = "pancakeBack";
            pancakeBack.Size = new Size(34, 29);
            pancakeBack.TabIndex = 3;
            pancakeBack.UseVisualStyleBackColor = false;
            pancakeBack.Click += pancakeBack_Click;
            // 
            // labelPancake
            // 
            labelPancake.AutoSize = true;
            labelPancake.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPancake.Location = new Point(81, 12);
            labelPancake.Name = "labelPancake";
            labelPancake.Size = new Size(203, 28);
            labelPancake.TabIndex = 4;
            labelPancake.Text = "Блинная сортировка";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(932, 701);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(1099, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(697, 962);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // PancakeSortInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(labelPancake);
            Controls.Add(pancakeBack);
            Name = "PancakeSortInfo";
            WindowState = FormWindowState.Maximized;
            FormClosed += PancakeSortInfo_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pancakeBack;
        private Label labelPancake;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}