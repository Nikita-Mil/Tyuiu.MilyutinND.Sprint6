namespace Tyuiu.MilyutinND.Sprint6.Task1.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonInfo_GVE = new Button();
            buttonDone_GVE = new Button();
            groupBoxUsl_GVE = new GroupBox();
            pictureBoxUsl_GVE = new PictureBox();
            labelUsl_GVE = new Label();
            groupBoxInPut_GVE = new GroupBox();
            textBoxStart_GVE = new TextBox();
            textBoxFinish_GVE = new TextBox();
            labelFinish_GVE = new Label();
            labelStart_GVE = new Label();
            groupBoxRes_GVE = new GroupBox();
            labelRes_GVE = new Label();
            textBoxRes_GVE = new TextBox();
            groupBoxUsl_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsl_GVE).BeginInit();
            groupBoxInPut_GVE.SuspendLayout();
            groupBoxRes_GVE.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInfo_GVE
            // 
            buttonInfo_GVE.BackColor = Color.DodgerBlue;
            buttonInfo_GVE.Location = new Point(293, 462);
            buttonInfo_GVE.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_GVE.Name = "buttonInfo_GVE";
            buttonInfo_GVE.Size = new Size(77, 85);
            buttonInfo_GVE.TabIndex = 0;
            buttonInfo_GVE.Text = "Справка";
            buttonInfo_GVE.UseVisualStyleBackColor = false;
            buttonInfo_GVE.Click += buttonInfo_GVE_Click;
            // 
            // buttonDone_GVE
            // 
            buttonDone_GVE.BackColor = Color.Green;
            buttonDone_GVE.Location = new Point(376, 462);
            buttonDone_GVE.Margin = new Padding(3, 4, 3, 4);
            buttonDone_GVE.Name = "buttonDone_GVE";
            buttonDone_GVE.Size = new Size(148, 85);
            buttonDone_GVE.TabIndex = 1;
            buttonDone_GVE.Text = "Выполнить";
            buttonDone_GVE.UseVisualStyleBackColor = false;
            buttonDone_GVE.Click += buttonDone_GVE_Click;
            // 
            // groupBoxUsl_GVE
            // 
            groupBoxUsl_GVE.Controls.Add(pictureBoxUsl_GVE);
            groupBoxUsl_GVE.Controls.Add(labelUsl_GVE);
            groupBoxUsl_GVE.Location = new Point(26, 35);
            groupBoxUsl_GVE.Margin = new Padding(3, 4, 3, 4);
            groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            groupBoxUsl_GVE.Padding = new Padding(3, 4, 3, 4);
            groupBoxUsl_GVE.Size = new Size(498, 405);
            groupBoxUsl_GVE.TabIndex = 2;
            groupBoxUsl_GVE.TabStop = false;
            groupBoxUsl_GVE.Text = "Условие";
            // 
            // pictureBoxUsl_GVE
            // 
            pictureBoxUsl_GVE.BackgroundImage = (Image)resources.GetObject("pictureBoxUsl_GVE.BackgroundImage");
            pictureBoxUsl_GVE.Location = new Point(22, 83);
            pictureBoxUsl_GVE.Margin = new Padding(3, 4, 3, 4);
            pictureBoxUsl_GVE.Name = "pictureBoxUsl_GVE";
            pictureBoxUsl_GVE.Size = new Size(373, 52);
            pictureBoxUsl_GVE.TabIndex = 1;
            pictureBoxUsl_GVE.TabStop = false;
            // 
            // labelUsl_GVE
            // 
            labelUsl_GVE.AutoSize = true;
            labelUsl_GVE.Location = new Point(22, 39);
            labelUsl_GVE.Name = "labelUsl_GVE";
            labelUsl_GVE.Size = new Size(415, 40);
            labelUsl_GVE.TabIndex = 0;
            labelUsl_GVE.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в таблице.\r\n";
            // 
            // groupBoxInPut_GVE
            // 
            groupBoxInPut_GVE.Controls.Add(textBoxStart_GVE);
            groupBoxInPut_GVE.Controls.Add(textBoxFinish_GVE);
            groupBoxInPut_GVE.Controls.Add(labelFinish_GVE);
            groupBoxInPut_GVE.Controls.Add(labelStart_GVE);
            groupBoxInPut_GVE.Location = new Point(26, 448);
            groupBoxInPut_GVE.Margin = new Padding(3, 4, 3, 4);
            groupBoxInPut_GVE.Name = "groupBoxInPut_GVE";
            groupBoxInPut_GVE.Padding = new Padding(3, 4, 3, 4);
            groupBoxInPut_GVE.Size = new Size(261, 100);
            groupBoxInPut_GVE.TabIndex = 3;
            groupBoxInPut_GVE.TabStop = false;
            groupBoxInPut_GVE.Text = "Ввод данных";
            // 
            // textBoxStart_GVE
            // 
            textBoxStart_GVE.Location = new Point(10, 52);
            textBoxStart_GVE.Margin = new Padding(3, 4, 3, 4);
            textBoxStart_GVE.Name = "textBoxStart_GVE";
            textBoxStart_GVE.Size = new Size(100, 27);
            textBoxStart_GVE.TabIndex = 2;
            textBoxStart_GVE.Text = "-5";
            // 
            // textBoxFinish_GVE
            // 
            textBoxFinish_GVE.Location = new Point(139, 52);
            textBoxFinish_GVE.Margin = new Padding(3, 4, 3, 4);
            textBoxFinish_GVE.Name = "textBoxFinish_GVE";
            textBoxFinish_GVE.Size = new Size(100, 27);
            textBoxFinish_GVE.TabIndex = 2;
            textBoxFinish_GVE.Text = "5";
            // 
            // labelFinish_GVE
            // 
            labelFinish_GVE.AutoSize = true;
            labelFinish_GVE.Location = new Point(136, 28);
            labelFinish_GVE.Name = "labelFinish_GVE";
            labelFinish_GVE.Size = new Size(94, 20);
            labelFinish_GVE.TabIndex = 1;
            labelFinish_GVE.Text = "Конец шага:";
            // 
            // labelStart_GVE
            // 
            labelStart_GVE.AutoSize = true;
            labelStart_GVE.Location = new Point(7, 28);
            labelStart_GVE.Name = "labelStart_GVE";
            labelStart_GVE.Size = new Size(88, 20);
            labelStart_GVE.TabIndex = 0;
            labelStart_GVE.Text = "Старт шага:";
            // 
            // groupBoxRes_GVE
            // 
            groupBoxRes_GVE.Controls.Add(labelRes_GVE);
            groupBoxRes_GVE.Controls.Add(textBoxRes_GVE);
            groupBoxRes_GVE.Location = new Point(550, 36);
            groupBoxRes_GVE.Margin = new Padding(3, 4, 3, 4);
            groupBoxRes_GVE.Name = "groupBoxRes_GVE";
            groupBoxRes_GVE.Padding = new Padding(3, 4, 3, 4);
            groupBoxRes_GVE.Size = new Size(217, 512);
            groupBoxRes_GVE.TabIndex = 4;
            groupBoxRes_GVE.TabStop = false;
            groupBoxRes_GVE.Text = "Вывод данных";
            // 
            // labelRes_GVE
            // 
            labelRes_GVE.AutoSize = true;
            labelRes_GVE.Location = new Point(7, 28);
            labelRes_GVE.Name = "labelRes_GVE";
            labelRes_GVE.Size = new Size(78, 20);
            labelRes_GVE.TabIndex = 1;
            labelRes_GVE.Text = "Результат:";
            // 
            // textBoxRes_GVE
            // 
            textBoxRes_GVE.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_GVE.Location = new Point(6, 56);
            textBoxRes_GVE.Margin = new Padding(3, 4, 3, 4);
            textBoxRes_GVE.Multiline = true;
            textBoxRes_GVE.Name = "textBoxRes_GVE";
            textBoxRes_GVE.ReadOnly = true;
            textBoxRes_GVE.ScrollBars = ScrollBars.Vertical;
            textBoxRes_GVE.Size = new Size(205, 448);
            textBoxRes_GVE.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(groupBoxRes_GVE);
            Controls.Add(groupBoxInPut_GVE);
            Controls.Add(groupBoxUsl_GVE);
            Controls.Add(buttonDone_GVE);
            Controls.Add(buttonInfo_GVE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 6 | Милютин Н. Д.";
            groupBoxUsl_GVE.ResumeLayout(false);
            groupBoxUsl_GVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsl_GVE).EndInit();
            groupBoxInPut_GVE.ResumeLayout(false);
            groupBoxInPut_GVE.PerformLayout();
            groupBoxRes_GVE.ResumeLayout(false);
            groupBoxRes_GVE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.Label labelUsl_GVE;
        private System.Windows.Forms.GroupBox groupBoxInPut_GVE;
        private System.Windows.Forms.TextBox textBoxStart_GVE;
        private System.Windows.Forms.TextBox textBoxFinish_GVE;
        private System.Windows.Forms.Label labelFinish_GVE;
        private System.Windows.Forms.Label labelStart_GVE;
        private System.Windows.Forms.GroupBox groupBoxRes_GVE;
        private System.Windows.Forms.Label labelRes_GVE;
        private System.Windows.Forms.TextBox textBoxRes_GVE;
        private System.Windows.Forms.PictureBox pictureBoxUsl_GVE;
    }
}
