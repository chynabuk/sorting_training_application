namespace sortings
{
    partial class HeapSortInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeapSortInfo));
            labelHeap = new Label();
            pictureBox1 = new PictureBox();
            heapBack = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelHeap
            // 
            labelHeap.AutoSize = true;
            labelHeap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeap.Location = new Point(73, 13);
            labelHeap.Name = "labelHeap";
            labelHeap.Size = new Size(181, 28);
            labelHeap.TabIndex = 0;
            labelHeap.Text = "Сортировка кучей";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 724);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // heapBack
            // 
            heapBack.BackColor = SystemColors.MenuBar;
            heapBack.Image = (Image)resources.GetObject("heapBack.Image");
            heapBack.Location = new Point(33, 12);
            heapBack.Name = "heapBack";
            heapBack.Size = new Size(34, 29);
            heapBack.TabIndex = 2;
            heapBack.UseVisualStyleBackColor = false;
            heapBack.Click += heapBack_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(1066, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(668, 974);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // HeapSortInfo
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(richTextBox1);
            Controls.Add(heapBack);
            Controls.Add(pictureBox1);
            Controls.Add(labelHeap);
            Name = "HeapSortInfo";
            WindowState = FormWindowState.Maximized;
            FormClosed += HeapSortInfo_FormClosed;
            Load += HeapSortInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeap;
        private PictureBox pictureBox1;
        private Button heapBack;
        private RichTextBox richTextBox1;
    }
}