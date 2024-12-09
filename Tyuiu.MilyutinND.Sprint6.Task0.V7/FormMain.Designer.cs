namespace Tyuiu.MilyutinND.Sprint6.Task0.V7
{
    partial class FormMain
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_IAA = new GroupBox();
            pictureBoxTask_IAA = new PictureBox();
            textBoxTask_IAA = new TextBox();
            groupBoxInput_IAA = new GroupBox();
            labelVarA_IAA = new Label();
            textBoxVarX_IAA = new TextBox();
            groupBoxOutput_IAA = new GroupBox();
            labelResult_IAA = new Label();
            textBoxResult_IAA = new TextBox();
            buttonInfo_IAA = new Button();
            buttonResult_IAA = new Button();
            groupBoxTask_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_IAA).BeginInit();
            groupBoxInput_IAA.SuspendLayout();
            groupBoxOutput_IAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_IAA
            // 
            groupBoxTask_IAA.Controls.Add(pictureBoxTask_IAA);
            groupBoxTask_IAA.Controls.Add(textBoxTask_IAA);
            groupBoxTask_IAA.Location = new Point(12, 40);
            groupBoxTask_IAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_IAA.Name = "groupBoxTask_IAA";
            groupBoxTask_IAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_IAA.Size = new Size(776, 249);
            groupBoxTask_IAA.TabIndex = 0;
            groupBoxTask_IAA.TabStop = false;
            groupBoxTask_IAA.Text = "Условие";
            groupBoxTask_IAA.Enter += groupBoxTask_IAA_Enter;
            // 
            // pictureBoxTask_IAA
            // 
            pictureBoxTask_IAA.Image = (Image)resources.GetObject("pictureBoxTask_IAA.Image");
            pictureBoxTask_IAA.Location = new Point(557, 40);
            pictureBoxTask_IAA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxTask_IAA.Name = "pictureBoxTask_IAA";
            pictureBoxTask_IAA.Size = new Size(219, 133);
            pictureBoxTask_IAA.TabIndex = 1;
            pictureBoxTask_IAA.TabStop = false;
            // 
            // textBoxTask_IAA
            // 
            textBoxTask_IAA.Location = new Point(19, 40);
            textBoxTask_IAA.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_IAA.Multiline = true;
            textBoxTask_IAA.Name = "textBoxTask_IAA";
            textBoxTask_IAA.ReadOnly = true;
            textBoxTask_IAA.Size = new Size(532, 190);
            textBoxTask_IAA.TabIndex = 0;
            textBoxTask_IAA.Text = "Дано выражение вычислить его значение при x = 3";
            // 
            // groupBoxInput_IAA
            // 
            groupBoxInput_IAA.Controls.Add(labelVarA_IAA);
            groupBoxInput_IAA.Controls.Add(textBoxVarX_IAA);
            groupBoxInput_IAA.Location = new Point(12, 296);
            groupBoxInput_IAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_IAA.Name = "groupBoxInput_IAA";
            groupBoxInput_IAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_IAA.Size = new Size(520, 148);
            groupBoxInput_IAA.TabIndex = 1;
            groupBoxInput_IAA.TabStop = false;
            groupBoxInput_IAA.Text = "Ввод данных";
            // 
            // labelVarA_IAA
            // 
            labelVarA_IAA.AutoSize = true;
            labelVarA_IAA.Location = new Point(7, 40);
            labelVarA_IAA.Name = "labelVarA_IAA";
            labelVarA_IAA.Size = new Size(114, 20);
            labelVarA_IAA.TabIndex = 1;
            labelVarA_IAA.Text = "Переменная X:";
            // 
            // textBoxVarX_IAA
            // 
            textBoxVarX_IAA.Location = new Point(10, 76);
            textBoxVarX_IAA.Margin = new Padding(3, 4, 3, 4);
            textBoxVarX_IAA.Name = "textBoxVarX_IAA";
            textBoxVarX_IAA.ReadOnly = true;
            textBoxVarX_IAA.Size = new Size(100, 27);
            textBoxVarX_IAA.TabIndex = 0;
            textBoxVarX_IAA.Text = "3";
            textBoxVarX_IAA.TextChanged += textBoxVarX_IAA_TextChanged;
            // 
            // groupBoxOutput_IAA
            // 
            groupBoxOutput_IAA.Controls.Add(labelResult_IAA);
            groupBoxOutput_IAA.Controls.Add(textBoxResult_IAA);
            groupBoxOutput_IAA.Location = new Point(539, 298);
            groupBoxOutput_IAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_IAA.Name = "groupBoxOutput_IAA";
            groupBoxOutput_IAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_IAA.Size = new Size(249, 146);
            groupBoxOutput_IAA.TabIndex = 2;
            groupBoxOutput_IAA.TabStop = false;
            groupBoxOutput_IAA.Text = "Вывод данных";
            // 
            // labelResult_IAA
            // 
            labelResult_IAA.AutoSize = true;
            labelResult_IAA.Location = new Point(7, 39);
            labelResult_IAA.Name = "labelResult_IAA";
            labelResult_IAA.Size = new Size(78, 20);
            labelResult_IAA.TabIndex = 1;
            labelResult_IAA.Text = "Результат:";
            // 
            // textBoxResult_IAA
            // 
            textBoxResult_IAA.Location = new Point(6, 75);
            textBoxResult_IAA.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_IAA.Name = "textBoxResult_IAA";
            textBoxResult_IAA.ReadOnly = true;
            textBoxResult_IAA.Size = new Size(237, 27);
            textBoxResult_IAA.TabIndex = 0;
            // 
            // buttonInfo_IAA
            // 
            buttonInfo_IAA.FlatStyle = FlatStyle.Flat;
            buttonInfo_IAA.Location = new Point(592, 486);
            buttonInfo_IAA.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_IAA.Name = "buttonInfo_IAA";
            buttonInfo_IAA.Size = new Size(38, 50);
            buttonInfo_IAA.TabIndex = 3;
            buttonInfo_IAA.Text = "?";
            buttonInfo_IAA.UseVisualStyleBackColor = true;
            buttonInfo_IAA.Click += buttonInfo_IAA_Click;
            // 
            // buttonResult_IAA
            // 
            buttonResult_IAA.Location = new Point(653, 486);
            buttonResult_IAA.Margin = new Padding(3, 4, 3, 4);
            buttonResult_IAA.Name = "buttonResult_IAA";
            buttonResult_IAA.Size = new Size(111, 50);
            buttonResult_IAA.TabIndex = 3;
            buttonResult_IAA.Text = "Выполнить";
            buttonResult_IAA.UseVisualStyleBackColor = true;
            buttonResult_IAA.Click += buttonResult_IAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 612);
            Controls.Add(buttonResult_IAA);
            Controls.Add(buttonInfo_IAA);
            Controls.Add(groupBoxOutput_IAA);
            Controls.Add(groupBoxInput_IAA);
            Controls.Add(groupBoxTask_IAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 7 | Милютин Н. Д.";
            groupBoxTask_IAA.ResumeLayout(false);
            groupBoxTask_IAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_IAA).EndInit();
            groupBoxInput_IAA.ResumeLayout(false);
            groupBoxInput_IAA.PerformLayout();
            groupBoxOutput_IAA.ResumeLayout(false);
            groupBoxOutput_IAA.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask_IAA;
        private System.Windows.Forms.PictureBox pictureBoxTask_IAA;
        private System.Windows.Forms.TextBox textBoxTask_IAA;
        private System.Windows.Forms.GroupBox groupBoxInput_IAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.Button buttonResult_IAA;
        private System.Windows.Forms.Label labelVarA_IAA;
        private System.Windows.Forms.TextBox textBoxVarX_IAA;
        private System.Windows.Forms.Label labelResult_IAA;
        private System.Windows.Forms.TextBox textBoxResult_IAA;
    
    }
}
