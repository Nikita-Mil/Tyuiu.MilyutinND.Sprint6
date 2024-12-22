namespace Tyuiu.MilyutinND.Sprint6.Task7.V21
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            panelLeft_MND = new Panel();
            groupBoxInputData_MND = new GroupBox();
            dataGridViewIn_MND = new DataGridView();
            panelTopTwo_MND = new Panel();
            groupBoxTask_MND = new GroupBox();
            labelTask_KDR = new Label();
            panelTopOne_MND = new Panel();
            buttonSaveFile_MND = new Button();
            buttonHelp_MND = new Button();
            buttonLoadFile_MND = new Button();
            buttonOpenFile_MND = new Button();
            groupBoxOutputData_MND = new GroupBox();
            dataGridViewOut_MND = new DataGridView();
            panelFill_MND = new Panel();
            splitterL_MND = new Splitter();
            openFileDialogTask_KDR = new OpenFileDialog();
            toolTip_KDR = new ToolTip(components);
            saveFileDialogTask_KDR = new SaveFileDialog();
            panelLeft_MND.SuspendLayout();
            groupBoxInputData_MND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MND).BeginInit();
            panelTopTwo_MND.SuspendLayout();
            groupBoxTask_MND.SuspendLayout();
            panelTopOne_MND.SuspendLayout();
            groupBoxOutputData_MND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MND).BeginInit();
            panelFill_MND.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft_MND
            // 
            panelLeft_MND.Controls.Add(groupBoxInputData_MND);
            panelLeft_MND.Dock = DockStyle.Left;
            panelLeft_MND.Location = new Point(0, 207);
            panelLeft_MND.Margin = new Padding(4, 5, 4, 5);
            panelLeft_MND.Name = "panelLeft_MND";
            panelLeft_MND.Padding = new Padding(7, 8, 7, 8);
            panelLeft_MND.Size = new Size(577, 425);
            panelLeft_MND.TabIndex = 7;
            // 
            // groupBoxInputData_MND
            // 
            groupBoxInputData_MND.Controls.Add(dataGridViewIn_MND);
            groupBoxInputData_MND.Dock = DockStyle.Fill;
            groupBoxInputData_MND.Location = new Point(7, 8);
            groupBoxInputData_MND.Margin = new Padding(4, 5, 4, 5);
            groupBoxInputData_MND.Name = "groupBoxInputData_MND";
            groupBoxInputData_MND.Padding = new Padding(7, 5, 7, 5);
            groupBoxInputData_MND.Size = new Size(563, 409);
            groupBoxInputData_MND.TabIndex = 22;
            groupBoxInputData_MND.TabStop = false;
            groupBoxInputData_MND.Text = "Вывод данных:";
            // 
            // dataGridViewIn_MND
            // 
            dataGridViewIn_MND.AllowUserToResizeColumns = false;
            dataGridViewIn_MND.AllowUserToResizeRows = false;
            dataGridViewIn_MND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewIn_MND.ColumnHeadersHeight = 29;
            dataGridViewIn_MND.ColumnHeadersVisible = false;
            dataGridViewIn_MND.Dock = DockStyle.Fill;
            dataGridViewIn_MND.Location = new Point(7, 25);
            dataGridViewIn_MND.Margin = new Padding(4, 5, 4, 5);
            dataGridViewIn_MND.Name = "dataGridViewIn_MND";
            dataGridViewIn_MND.RowHeadersVisible = false;
            dataGridViewIn_MND.RowHeadersWidth = 51;
            dataGridViewIn_MND.Size = new Size(549, 379);
            dataGridViewIn_MND.TabIndex = 0;
            // 
            // panelTopTwo_MND
            // 
            panelTopTwo_MND.Controls.Add(groupBoxTask_MND);
            panelTopTwo_MND.Dock = DockStyle.Top;
            panelTopTwo_MND.Location = new Point(0, 89);
            panelTopTwo_MND.Margin = new Padding(4, 5, 4, 5);
            panelTopTwo_MND.Name = "panelTopTwo_MND";
            panelTopTwo_MND.Size = new Size(1045, 118);
            panelTopTwo_MND.TabIndex = 6;
            // 
            // groupBoxTask_MND
            // 
            groupBoxTask_MND.Controls.Add(labelTask_KDR);
            groupBoxTask_MND.Location = new Point(4, 3);
            groupBoxTask_MND.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_MND.Name = "groupBoxTask_MND";
            groupBoxTask_MND.Padding = new Padding(13, 15, 13, 15);
            groupBoxTask_MND.Size = new Size(1025, 111);
            groupBoxTask_MND.TabIndex = 17;
            groupBoxTask_MND.TabStop = false;
            groupBoxTask_MND.Text = "Условие";
            // 
            // labelTask_KDR
            // 
            labelTask_KDR.AutoSize = true;
            labelTask_KDR.Location = new Point(17, 23);
            labelTask_KDR.Margin = new Padding(4, 0, 4, 0);
            labelTask_KDR.Name = "labelTask_KDR";
            labelTask_KDR.Padding = new Padding(7, 8, 7, 8);
            labelTask_KDR.Size = new Size(14, 36);
            labelTask_KDR.TabIndex = 2;
            // 
            // panelTopOne_MND
            // 
            panelTopOne_MND.Controls.Add(buttonSaveFile_MND);
            panelTopOne_MND.Controls.Add(buttonHelp_MND);
            panelTopOne_MND.Controls.Add(buttonLoadFile_MND);
            panelTopOne_MND.Controls.Add(buttonOpenFile_MND);
            panelTopOne_MND.Dock = DockStyle.Top;
            panelTopOne_MND.Location = new Point(0, 0);
            panelTopOne_MND.Margin = new Padding(4, 5, 4, 5);
            panelTopOne_MND.Name = "panelTopOne_MND";
            panelTopOne_MND.Size = new Size(1045, 89);
            panelTopOne_MND.TabIndex = 5;
            // 
            // buttonSaveFile_MND
            // 
            buttonSaveFile_MND.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_MND.Enabled = false;
            buttonSaveFile_MND.Location = new Point(184, 5);
            buttonSaveFile_MND.Margin = new Padding(4, 5, 4, 5);
            buttonSaveFile_MND.Name = "buttonSaveFile_MND";
            buttonSaveFile_MND.Size = new Size(81, 75);
            buttonSaveFile_MND.TabIndex = 3;
            toolTip_KDR.SetToolTip(buttonSaveFile_MND, "Сохранить результат в новый файл");
            buttonSaveFile_MND.UseVisualStyleBackColor = true;
            buttonSaveFile_MND.Click += buttonSaveFile_KDR_Click;
            buttonSaveFile_MND.MouseEnter += buttonSaveFile_KDR_MouseEnter;
            // 
            // buttonHelp_MND
            // 
            buttonHelp_MND.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_MND.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_MND.Location = new Point(949, 5);
            buttonHelp_MND.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_MND.Name = "buttonHelp_MND";
            buttonHelp_MND.Size = new Size(81, 75);
            buttonHelp_MND.TabIndex = 2;
            toolTip_KDR.SetToolTip(buttonHelp_MND, "О программе");
            buttonHelp_MND.UseVisualStyleBackColor = true;
            buttonHelp_MND.Click += buttonHelp_KDR_Click;
            buttonHelp_MND.MouseEnter += buttonHelp_KDR_MouseEnter;
            // 
            // buttonLoadFile_MND
            // 
            buttonLoadFile_MND.BackgroundImageLayout = ImageLayout.Center;
            buttonLoadFile_MND.Enabled = false;
            buttonLoadFile_MND.Location = new Point(95, 5);
            buttonLoadFile_MND.Margin = new Padding(4, 5, 4, 5);
            buttonLoadFile_MND.Name = "buttonLoadFile_MND";
            buttonLoadFile_MND.Size = new Size(81, 75);
            buttonLoadFile_MND.TabIndex = 1;
            toolTip_KDR.SetToolTip(buttonLoadFile_MND, "Производит поиск в файле");
            buttonLoadFile_MND.UseVisualStyleBackColor = true;
            buttonLoadFile_MND.Click += buttonLoadFile_KDR_Click;
            buttonLoadFile_MND.MouseEnter += buttonLoadFile_KDR_MouseEnter;
            // 
            // buttonOpenFile_MND
            // 
            buttonOpenFile_MND.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_MND.Location = new Point(11, 5);
            buttonOpenFile_MND.Margin = new Padding(4, 5, 4, 5);
            buttonOpenFile_MND.Name = "buttonOpenFile_MND";
            buttonOpenFile_MND.Size = new Size(76, 75);
            buttonOpenFile_MND.TabIndex = 0;
            toolTip_KDR.SetToolTip(buttonOpenFile_MND, "Выбрать исходный файл загрузки");
            buttonOpenFile_MND.UseVisualStyleBackColor = true;
            buttonOpenFile_MND.Click += buttonOpenFile_KDR_Click;
            buttonOpenFile_MND.MouseEnter += buttonOpenFile_KDR_MouseEnter;
            // 
            // groupBoxOutputData_MND
            // 
            groupBoxOutputData_MND.Controls.Add(dataGridViewOut_MND);
            groupBoxOutputData_MND.Dock = DockStyle.Fill;
            groupBoxOutputData_MND.Location = new Point(7, 8);
            groupBoxOutputData_MND.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutputData_MND.Name = "groupBoxOutputData_MND";
            groupBoxOutputData_MND.Padding = new Padding(7, 5, 7, 5);
            groupBoxOutputData_MND.Size = new Size(454, 409);
            groupBoxOutputData_MND.TabIndex = 18;
            groupBoxOutputData_MND.TabStop = false;
            groupBoxOutputData_MND.Text = "Вывод данных:";
            // 
            // dataGridViewOut_MND
            // 
            dataGridViewOut_MND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOut_MND.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_MND.ColumnHeadersVisible = false;
            dataGridViewOut_MND.Dock = DockStyle.Fill;
            dataGridViewOut_MND.Location = new Point(7, 25);
            dataGridViewOut_MND.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOut_MND.Name = "dataGridViewOut_MND";
            dataGridViewOut_MND.RowHeadersVisible = false;
            dataGridViewOut_MND.RowHeadersWidth = 51;
            dataGridViewOut_MND.Size = new Size(440, 379);
            dataGridViewOut_MND.TabIndex = 1;
            // 
            // panelFill_MND
            // 
            panelFill_MND.Controls.Add(groupBoxOutputData_MND);
            panelFill_MND.Dock = DockStyle.Fill;
            panelFill_MND.Location = new Point(577, 207);
            panelFill_MND.Margin = new Padding(4, 5, 4, 5);
            panelFill_MND.Name = "panelFill_MND";
            panelFill_MND.Padding = new Padding(7, 8, 7, 8);
            panelFill_MND.Size = new Size(468, 425);
            panelFill_MND.TabIndex = 9;
            // 
            // splitterL_MND
            // 
            splitterL_MND.Location = new Point(577, 207);
            splitterL_MND.Margin = new Padding(4, 5, 4, 5);
            splitterL_MND.Name = "splitterL_MND";
            splitterL_MND.Size = new Size(7, 425);
            splitterL_MND.TabIndex = 10;
            splitterL_MND.TabStop = false;
            // 
            // openFileDialogTask_KDR
            // 
            openFileDialogTask_KDR.FileName = "openFileDialog1";
            // 
            // toolTip_KDR
            // 
            toolTip_KDR.IsBalloon = true;
            toolTip_KDR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 632);
            Controls.Add(splitterL_MND);
            Controls.Add(panelFill_MND);
            Controls.Add(panelLeft_MND);
            Controls.Add(panelTopTwo_MND);
            Controls.Add(panelTopOne_MND);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1061, 667);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 21 | Милютин Н. Д.";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelLeft_MND.ResumeLayout(false);
            groupBoxInputData_MND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MND).EndInit();
            panelTopTwo_MND.ResumeLayout(false);
            groupBoxTask_MND.ResumeLayout(false);
            groupBoxTask_MND.PerformLayout();
            panelTopOne_MND.ResumeLayout(false);
            groupBoxOutputData_MND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MND).EndInit();
            panelFill_MND.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelLeft_MND;
        private System.Windows.Forms.GroupBox groupBoxInputData_MND;
        private System.Windows.Forms.Panel panelTopTwo_MND;
        private System.Windows.Forms.GroupBox groupBoxTask_MND;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.Panel panelTopOne_MND;
        private System.Windows.Forms.Button buttonHelp_MND;
        private System.Windows.Forms.Button buttonLoadFile_MND;
        private System.Windows.Forms.Button buttonOpenFile_MND;
        private System.Windows.Forms.DataGridView dataGridViewIn_MND;
        private System.Windows.Forms.GroupBox groupBoxOutputData_MND;
        private System.Windows.Forms.DataGridView dataGridViewOut_MND;
        private System.Windows.Forms.Panel panelFill_MND;
        private System.Windows.Forms.Splitter splitterL_MND;
        private System.Windows.Forms.Button buttonSaveFile_MND;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KDR;
        private System.Windows.Forms.ToolTip toolTip_KDR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_KDR;
    }
}
