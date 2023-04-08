namespace sortings
{
    partial class SortingStepsInfo
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
            richTBArray = new RichTextBox();
            SuspendLayout();
            // 
            // richTBArray
            // 
            richTBArray.BackColor = Color.LightSteelBlue;
            richTBArray.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTBArray.ForeColor = SystemColors.InfoText;
            richTBArray.Location = new Point(90, 28);
            richTBArray.Name = "richTBArray";
            richTBArray.ReadOnly = true;
            richTBArray.Size = new Size(631, 573);
            richTBArray.TabIndex = 0;
            richTBArray.Text = "";
            // 
            // SortingStepsInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(richTBArray);
            Name = "SortingStepsInfo";
            Text = "SortingSteps";
            FormClosed += SortingSteps_FormClosed;
            Load += SortingSteps_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTBArray;
    }
}