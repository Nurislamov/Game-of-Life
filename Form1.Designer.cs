namespace Game_of_Life
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CellColorButton = new System.Windows.Forms.Button();
            this.nudCellDensity = new System.Windows.Forms.NumericUpDown();
            this.CellDensity = new System.Windows.Forms.Label();
            this.nudScreenResolution = new System.Windows.Forms.NumericUpDown();
            this.ScreenResolution = new System.Windows.Forms.Label();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.PlayingFieldPicBox = new System.Windows.Forms.PictureBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCellDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayingFieldPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.StopButton);
            this.splitContainer1.Panel1.Controls.Add(this.StartButton);
            this.splitContainer1.Panel1.Controls.Add(this.CellColorButton);
            this.splitContainer1.Panel1.Controls.Add(this.nudCellDensity);
            this.splitContainer1.Panel1.Controls.Add(this.CellDensity);
            this.splitContainer1.Panel1.Controls.Add(this.nudScreenResolution);
            this.splitContainer1.Panel1.Controls.Add(this.ScreenResolution);
            this.splitContainer1.Panel1.Controls.Add(this.BackgroundColorButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.PlayingFieldPicBox);
            this.splitContainer1.Size = new System.Drawing.Size(984, 461);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // CellColorButton
            // 
            this.CellColorButton.BackColor = System.Drawing.Color.Black;
            this.CellColorButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellColorButton.ForeColor = System.Drawing.Color.White;
            this.CellColorButton.Location = new System.Drawing.Point(11, 219);
            this.CellColorButton.Name = "CellColorButton";
            this.CellColorButton.Size = new System.Drawing.Size(117, 48);
            this.CellColorButton.TabIndex = 7;
            this.CellColorButton.Text = "Cell Color";
            this.CellColorButton.UseVisualStyleBackColor = false;
            this.CellColorButton.Click += new System.EventHandler(this.CellColorButton_Click);
            // 
            // nudCellDensity
            // 
            this.nudCellDensity.Location = new System.Drawing.Point(11, 111);
            this.nudCellDensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCellDensity.Name = "nudCellDensity";
            this.nudCellDensity.Size = new System.Drawing.Size(117, 20);
            this.nudCellDensity.TabIndex = 4;
            this.nudCellDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCellDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // CellDensity
            // 
            this.CellDensity.AutoSize = true;
            this.CellDensity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellDensity.Location = new System.Drawing.Point(8, 90);
            this.CellDensity.Name = "CellDensity";
            this.CellDensity.Size = new System.Drawing.Size(82, 18);
            this.CellDensity.TabIndex = 3;
            this.CellDensity.Text = "Cell Density";
            // 
            // nudScreenResolution
            // 
            this.nudScreenResolution.Location = new System.Drawing.Point(11, 45);
            this.nudScreenResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudScreenResolution.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudScreenResolution.Name = "nudScreenResolution";
            this.nudScreenResolution.Size = new System.Drawing.Size(117, 20);
            this.nudScreenResolution.TabIndex = 2;
            this.nudScreenResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudScreenResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ScreenResolution
            // 
            this.ScreenResolution.AutoSize = true;
            this.ScreenResolution.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScreenResolution.Location = new System.Drawing.Point(8, 24);
            this.ScreenResolution.Name = "ScreenResolution";
            this.ScreenResolution.Size = new System.Drawing.Size(120, 18);
            this.ScreenResolution.TabIndex = 1;
            this.ScreenResolution.Text = "Screen Resolution";
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.BackColor = System.Drawing.Color.Black;
            this.BackgroundColorButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackgroundColorButton.ForeColor = System.Drawing.Color.White;
            this.BackgroundColorButton.Location = new System.Drawing.Point(11, 165);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(117, 48);
            this.BackgroundColorButton.TabIndex = 0;
            this.BackgroundColorButton.Text = "Background Color";
            this.BackgroundColorButton.UseVisualStyleBackColor = false;
            this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
            // 
            // PlayingFieldPicBox
            // 
            this.PlayingFieldPicBox.Location = new System.Drawing.Point(3, 3);
            this.PlayingFieldPicBox.Name = "PlayingFieldPicBox";
            this.PlayingFieldPicBox.Size = new System.Drawing.Size(96, 100);
            this.PlayingFieldPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayingFieldPicBox.TabIndex = 0;
            this.PlayingFieldPicBox.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 60;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.Color.Green;
            this.StartButton.Location = new System.Drawing.Point(11, 300);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(117, 48);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.ForeColor = System.Drawing.Color.Red;
            this.StopButton.Location = new System.Drawing.Point(11, 354);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(117, 48);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop Game";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Game of Life";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCellDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScreenResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayingFieldPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BackgroundColorButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label ScreenResolution;
        private System.Windows.Forms.NumericUpDown nudCellDensity;
        private System.Windows.Forms.Label CellDensity;
        private System.Windows.Forms.NumericUpDown nudScreenResolution;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button CellColorButton;
        private System.Windows.Forms.PictureBox PlayingFieldPicBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
    }
}

