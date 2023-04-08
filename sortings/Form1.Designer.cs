namespace sortings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lArraySize = new Label();
            tbArraySize = new TextBox();
            bGenerate = new Button();
            bSort = new Button();
            rtbResult = new RichTextBox();
            lResult = new Label();
            rbPancake = new RadioButton();
            rbInsert = new RadioButton();
            rbSelect = new RadioButton();
            gpSortTypes = new GroupBox();
            heap = new Button();
            tim = new Button();
            pancake = new Button();
            lbSortType = new Label();
            progressBar = new ProgressBar();
            lbPercent = new Label();
            backgroundSorting = new System.ComponentModel.BackgroundWorker();
            steps = new Button();
            rtArray = new RichTextBox();
            ttPancake = new ToolTip(components);
            ttTim = new ToolTip(components);
            ttHeap = new ToolTip(components);
            btCompare = new Button();
            label1 = new Label();
            gpSortTypes.SuspendLayout();
            SuspendLayout();
            // 
            // lArraySize
            // 
            lArraySize.AutoSize = true;
            lArraySize.BackColor = Color.Transparent;
            lArraySize.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lArraySize.Location = new Point(194, 71);
            lArraySize.Name = "lArraySize";
            lArraySize.Size = new Size(196, 32);
            lArraySize.TabIndex = 0;
            lArraySize.Text = "Размер массива:";
            // 
            // tbArraySize
            // 
            tbArraySize.BackColor = SystemColors.Control;
            tbArraySize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbArraySize.Location = new Point(194, 125);
            tbArraySize.Name = "tbArraySize";
            tbArraySize.Size = new Size(196, 34);
            tbArraySize.TabIndex = 1;
            // 
            // bGenerate
            // 
            bGenerate.BackColor = Color.CadetBlue;
            bGenerate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bGenerate.Location = new Point(194, 191);
            bGenerate.Name = "bGenerate";
            bGenerate.Size = new Size(196, 49);
            bGenerate.TabIndex = 2;
            bGenerate.Text = "Сгенерировать";
            bGenerate.UseVisualStyleBackColor = false;
            bGenerate.Click += bGenerate_Click_1;
            // 
            // bSort
            // 
            bSort.BackColor = Color.CadetBlue;
            bSort.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bSort.Location = new Point(1234, 399);
            bSort.Name = "bSort";
            bSort.Size = new Size(225, 54);
            bSort.TabIndex = 4;
            bSort.Text = "Отсортировать";
            bSort.UseVisualStyleBackColor = false;
            bSort.Click += bSort_Click;
            // 
            // rtbResult
            // 
            rtbResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbResult.Location = new Point(944, 670);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(782, 156);
            rtbResult.TabIndex = 5;
            rtbResult.Text = "";
            rtbResult.TextChanged += rtbResult_TextChanged;
            // 
            // lResult
            // 
            lResult.AutoSize = true;
            lResult.BackColor = Color.Transparent;
            lResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lResult.Location = new Point(944, 621);
            lResult.Name = "lResult";
            lResult.Size = new Size(85, 32);
            lResult.TabIndex = 6;
            lResult.Text = "Вывод";
            // 
            // rbPancake
            // 
            rbPancake.AutoSize = true;
            rbPancake.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbPancake.Location = new Point(6, 30);
            rbPancake.Name = "rbPancake";
            rbPancake.Size = new Size(224, 32);
            rbPancake.TabIndex = 7;
            rbPancake.TabStop = true;
            rbPancake.Text = "Блинная сортировка";
            rbPancake.UseVisualStyleBackColor = true;
            rbPancake.CheckedChanged += rbBubble_CheckedChanged;
            // 
            // rbInsert
            // 
            rbInsert.AutoSize = true;
            rbInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbInsert.Location = new Point(283, 30);
            rbInsert.Name = "rbInsert";
            rbInsert.Size = new Size(195, 32);
            rbInsert.TabIndex = 8;
            rbInsert.TabStop = true;
            rbInsert.Text = "Сортировка Тима";
            rbInsert.UseVisualStyleBackColor = true;
            rbInsert.CheckedChanged += rbInsert_CheckedChanged;
            // 
            // rbSelect
            // 
            rbSelect.AutoSize = true;
            rbSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbSelect.Location = new Point(533, 30);
            rbSelect.Name = "rbSelect";
            rbSelect.Size = new Size(202, 32);
            rbSelect.TabIndex = 9;
            rbSelect.TabStop = true;
            rbSelect.Text = "Сортировка кучей";
            rbSelect.UseVisualStyleBackColor = true;
            rbSelect.CheckedChanged += rbSelect_CheckedChanged;
            // 
            // gpSortTypes
            // 
            gpSortTypes.BackColor = SystemColors.GradientInactiveCaption;
            gpSortTypes.Controls.Add(heap);
            gpSortTypes.Controls.Add(tim);
            gpSortTypes.Controls.Add(pancake);
            gpSortTypes.Controls.Add(rbPancake);
            gpSortTypes.Controls.Add(rbSelect);
            gpSortTypes.Controls.Add(rbInsert);
            gpSortTypes.Location = new Point(944, 125);
            gpSortTypes.Name = "gpSortTypes";
            gpSortTypes.Size = new Size(782, 92);
            gpSortTypes.TabIndex = 10;
            gpSortTypes.TabStop = false;
            // 
            // heap
            // 
            heap.Location = new Point(730, 34);
            heap.Name = "heap";
            heap.Size = new Size(35, 28);
            heap.TabIndex = 12;
            heap.Text = "?";
            heap.UseVisualStyleBackColor = true;
            heap.Click += heap_Click;
            heap.MouseHover += heap_MouseHover;
            // 
            // tim
            // 
            tim.Location = new Point(474, 34);
            tim.Name = "tim";
            tim.Size = new Size(39, 28);
            tim.TabIndex = 11;
            tim.Text = "?";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            tim.MouseHover += tim_MouseHover;
            // 
            // pancake
            // 
            pancake.Location = new Point(226, 35);
            pancake.Name = "pancake";
            pancake.Size = new Size(37, 28);
            pancake.TabIndex = 10;
            pancake.Text = "?";
            pancake.UseVisualStyleBackColor = true;
            pancake.Click += pancake_Click;
            pancake.MouseHover += pancake_MouseHover;
            // 
            // lbSortType
            // 
            lbSortType.AutoSize = true;
            lbSortType.BackColor = Color.Transparent;
            lbSortType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbSortType.Location = new Point(944, 71);
            lbSortType.Name = "lbSortType";
            lbSortType.Size = new Size(209, 32);
            lbSortType.TabIndex = 11;
            lbSortType.Text = "Типы сортировок";
            // 
            // progressBar
            // 
            progressBar.ForeColor = SystemColors.ActiveCaption;
            progressBar.Location = new Point(944, 530);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(782, 38);
            progressBar.TabIndex = 12;
            progressBar.Visible = false;
            progressBar.Click += progressBar_Click;
            // 
            // lbPercent
            // 
            lbPercent.AutoSize = true;
            lbPercent.BackColor = Color.Transparent;
            lbPercent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbPercent.Location = new Point(1236, 467);
            lbPercent.Name = "lbPercent";
            lbPercent.Size = new Size(221, 32);
            lbPercent.TabIndex = 13;
            lbPercent.Text = "Идет процесс... 0%";
            lbPercent.Visible = false;
            lbPercent.Click += lbPercent_Click;
            // 
            // backgroundSorting
            // 
            backgroundSorting.WorkerReportsProgress = true;
            backgroundSorting.WorkerSupportsCancellation = true;
            backgroundSorting.DoWork += backgroundSorting_DoWork;
            backgroundSorting.ProgressChanged += backgroundSorting_ProgressChanged;
            backgroundSorting.RunWorkerCompleted += backgroundSorting_RunWorkerCompleted;
            // 
            // steps
            // 
            steps.BackColor = Color.CadetBlue;
            steps.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            steps.Location = new Point(1262, 870);
            steps.Name = "steps";
            steps.Size = new Size(145, 60);
            steps.TabIndex = 14;
            steps.Text = "Шаги";
            steps.UseVisualStyleBackColor = false;
            steps.Click += steps_Click;
            // 
            // rtArray
            // 
            rtArray.Cursor = Cursors.No;
            rtArray.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rtArray.Location = new Point(194, 506);
            rtArray.Name = "rtArray";
            rtArray.ReadOnly = true;
            rtArray.Size = new Size(308, 424);
            rtArray.TabIndex = 15;
            rtArray.Text = "";
            // 
            // ttPancake
            // 
            ttPancake.Popup += toolTip1_Popup;
            // 
            // btCompare
            // 
            btCompare.BackColor = Color.CadetBlue;
            btCompare.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btCompare.Location = new Point(1162, 240);
            btCompare.Name = "btCompare";
            btCompare.Size = new Size(353, 60);
            btCompare.TabIndex = 16;
            btCompare.Text = "Сравнить";
            btCompare.UseVisualStyleBackColor = false;
            btCompare.Click += btCompare_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(194, 451);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 17;
            label1.Text = "Сгенерированный массив:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(btCompare);
            Controls.Add(rtArray);
            Controls.Add(steps);
            Controls.Add(lbPercent);
            Controls.Add(progressBar);
            Controls.Add(lbSortType);
            Controls.Add(gpSortTypes);
            Controls.Add(lResult);
            Controls.Add(rtbResult);
            Controls.Add(bSort);
            Controls.Add(bGenerate);
            Controls.Add(tbArraySize);
            Controls.Add(lArraySize);
            Name = "Form1";
            Text = "Тренажер сортировок";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            gpSortTypes.ResumeLayout(false);
            gpSortTypes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox tbArraySize;
        private Label lArraySize;
        private Button bGenerate;
        private TextBox tbResult;
        private Label lResult;
        private Button bSort;
        private RichTextBox rtbResult;
        private RadioButton rbPancake;
        private RadioButton rbInsert;
        private RadioButton rbSelect;
        private GroupBox gpSortTypes;
        private Label lbSortType;
        private ProgressBar progressBar;
        private Label lbPercent;
        private System.ComponentModel.BackgroundWorker backgroundSorting;
        private Button steps;
        private RichTextBox rtArray;
        private Button heap;
        private Button tim;
        private Button pancake;
        private ToolTip ttPancake;
        private ToolTip ttTim;
        private ToolTip ttHeap;
        private Button btCompare;
        private Label label1;
    }
}