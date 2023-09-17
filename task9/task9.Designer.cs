namespace task9
{
    partial class task9
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabRandom = new System.Windows.Forms.TabPage();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.grpConstructor = new System.Windows.Forms.GroupBox();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstArray = new System.Windows.Forms.ListBox();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNegative = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabRandom.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.grpConstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            this.grpList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "TXT file|*.txt";
            // 
            // tab
            // 
            this.tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab.Controls.Add(this.tabRandom);
            this.tab.Controls.Add(this.tabFile);
            this.tab.Location = new System.Drawing.Point(6, 19);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(395, 128);
            this.tab.TabIndex = 0;
            // 
            // tabRandom
            // 
            this.tabRandom.Controls.Add(this.numTo);
            this.tabRandom.Controls.Add(this.label3);
            this.tabRandom.Controls.Add(this.numFrom);
            this.tabRandom.Controls.Add(this.label2);
            this.tabRandom.Controls.Add(this.label1);
            this.tabRandom.Controls.Add(this.numCount);
            this.tabRandom.Location = new System.Drawing.Point(4, 25);
            this.tabRandom.Name = "tabRandom";
            this.tabRandom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandom.Size = new System.Drawing.Size(387, 99);
            this.tabRandom.TabIndex = 0;
            this.tabRandom.Text = "Випадкові числа";
            this.tabRandom.UseVisualStyleBackColor = true;
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.label4);
            this.tabFile.Controls.Add(this.btnBrowse);
            this.tabFile.Controls.Add(this.txtFile);
            this.tabFile.Controls.Add(this.label6);
            this.tabFile.Location = new System.Drawing.Point(4, 25);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(387, 99);
            this.tabFile.TabIndex = 1;
            this.tabFile.Text = "Із файлу";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // grpConstructor
            // 
            this.grpConstructor.Controls.Add(this.tab);
            this.grpConstructor.Location = new System.Drawing.Point(12, 12);
            this.grpConstructor.Name = "grpConstructor";
            this.grpConstructor.Size = new System.Drawing.Size(407, 153);
            this.grpConstructor.TabIndex = 1;
            this.grpConstructor.TabStop = false;
            this.grpConstructor.Text = "Варіант заповнення";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(162, 4);
            this.numCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(59, 20);
            this.numCount.TabIndex = 0;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість елементів масиву:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Діапазон чисел: від";
            // 
            // numFrom
            // 
            this.numFrom.Location = new System.Drawing.Point(118, 30);
            this.numFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFrom.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(64, 20);
            this.numFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "до";
            // 
            // numTo
            // 
            this.numTo.Location = new System.Drawing.Point(213, 30);
            this.numTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTo.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(64, 20);
            this.numTo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Шлях до файлу:";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(97, 4);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(249, 20);
            this.txtFile.TabIndex = 8;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(352, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 58);
            this.label4.TabIndex = 10;
            this.label4.Text = "Файл у форматі TXT має містити один рядок з цілими\r\nчислами (додатні або від\'ємні" +
    ").\r\n\r\nРозділювач чисел - символ крапки \".\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.Location = new System.Drawing.Point(6, 19);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(139, 277);
            this.lstArray.TabIndex = 2;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.lstArray);
            this.grpList.Location = new System.Drawing.Point(426, 13);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(151, 310);
            this.grpList.TabIndex = 3;
            this.grpList.TabStop = false;
            this.grpList.Text = "Склад масиву";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(112, 171);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(207, 31);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Заповнити та проаналізувати";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNegative);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аналіз масиву";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Кількість від\'ємних:";
            // 
            // txtNegative
            // 
            this.txtNegative.Enabled = false;
            this.txtNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNegative.Location = new System.Drawing.Point(269, 30);
            this.txtNegative.Name = "txtNegative";
            this.txtNegative.Size = new System.Drawing.Size(100, 20);
            this.txtNegative.TabIndex = 1;
            // 
            // txtLast
            // 
            this.txtLast.Enabled = false;
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLast.Location = new System.Drawing.Point(269, 57);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Індекс останнього від\'ємного:";
            // 
            // txtSum
            // 
            this.txtSum.Enabled = false;
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSum.Location = new System.Drawing.Point(269, 83);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Сума від початку до останнього від\'ємного:";
            // 
            // task9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpConstructor);
            this.Name = "task9";
            this.Text = "Простий клас з одновимірним масивом";
            this.tab.ResumeLayout(false);
            this.tabRandom.ResumeLayout(false);
            this.tabRandom.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.grpConstructor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            this.grpList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabRandom;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.GroupBox grpConstructor;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNegative;
        private System.Windows.Forms.Label label5;
    }
}

