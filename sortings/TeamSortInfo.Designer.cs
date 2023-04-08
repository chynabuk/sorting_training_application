namespace sortings
{
    partial class TeamSortInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamSortInfo));
            labelTeam = new Label();
            teamBack = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTeam
            // 
            labelTeam.AutoSize = true;
            labelTeam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTeam.Location = new Point(84, 25);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new Size(174, 28);
            labelTeam.TabIndex = 6;
            labelTeam.Text = "Сортировка Тима";
            // 
            // teamBack
            // 
            teamBack.BackColor = SystemColors.MenuBar;
            teamBack.Image = (Image)resources.GetObject("teamBack.Image");
            teamBack.Location = new Point(34, 25);
            teamBack.Name = "teamBack";
            teamBack.Size = new Size(34, 29);
            teamBack.TabIndex = 5;
            teamBack.UseVisualStyleBackColor = false;
            teamBack.Click += teamBack_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(1028, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(734, 952);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(878, 683);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TeamSortInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(labelTeam);
            Controls.Add(teamBack);
            Name = "TeamSortInfo";
            Text = "TeamSortInfo";
            WindowState = FormWindowState.Maximized;
            FormClosed += TeamSortInfo_FormClosed;
            Load += TeamSortInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTeam;
        private Button teamBack;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}