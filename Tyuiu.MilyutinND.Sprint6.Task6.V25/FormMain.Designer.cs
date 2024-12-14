using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Image = System.Drawing.Image;

namespace Tyuiu.MilyutinND.Sprint6.Task6.V25
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBoxCondition_IPG = new GroupBox();
            textBoxCondition_IPG = new TextBox();
            groupBoxOutput_IPG = new GroupBox();
            textBoxOutput_IPG = new TextBox();
            groupBoxInput_IPG = new GroupBox();
            textBoxInput_IPG = new TextBox();
            buttonOpenFile_IPG = new Button();
            buttonDone_IPG = new Button();
            buttonHelp_IPG = new Button();
            openFileDialogTask_IPG = new OpenFileDialog();
            toolTipTask_IPG = new ToolTip(components);
            checkBox1 = new CheckBox();
            groupBoxCondition_IPG.SuspendLayout();
            groupBoxOutput_IPG.SuspendLayout();
            groupBoxInput_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(textBoxCondition_IPG);
            groupBoxCondition_IPG.Location = new Point(7, 118);
            groupBoxCondition_IPG.Margin = new Padding(2, 2, 2, 2);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Padding = new Padding(2, 2, 2, 2);
            groupBoxCondition_IPG.Size = new Size(828, 125);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие: ";
            // 
            // textBoxCondition_IPG
            // 
            textBoxCondition_IPG.BorderStyle = BorderStyle.None;
            textBoxCondition_IPG.Location = new Point(14, 20);
            textBoxCondition_IPG.Margin = new Padding(2, 2, 2, 2);
            textBoxCondition_IPG.Multiline = true;
            textBoxCondition_IPG.Name = "textBoxCondition_IPG";
            textBoxCondition_IPG.ReadOnly = true;
            textBoxCondition_IPG.Size = new Size(810, 79);
            textBoxCondition_IPG.TabIndex = 0;
            // 
            // groupBoxOutput_IPG
            // 
            groupBoxOutput_IPG.Controls.Add(textBoxOutput_IPG);
            groupBoxOutput_IPG.Location = new Point(476, 246);
            groupBoxOutput_IPG.Margin = new Padding(2, 2, 2, 2);
            groupBoxOutput_IPG.Name = "groupBoxOutput_IPG";
            groupBoxOutput_IPG.Padding = new Padding(2, 2, 2, 2);
            groupBoxOutput_IPG.Size = new Size(359, 289);
            groupBoxOutput_IPG.TabIndex = 0;
            groupBoxOutput_IPG.TabStop = false;
            groupBoxOutput_IPG.Text = "Вывод: ";
            // 
            // textBoxOutput_IPG
            // 
            textBoxOutput_IPG.BorderStyle = BorderStyle.None;
            textBoxOutput_IPG.Location = new Point(4, 24);
            textBoxOutput_IPG.Margin = new Padding(2, 2, 2, 2);
            textBoxOutput_IPG.Multiline = true;
            textBoxOutput_IPG.Name = "textBoxOutput_IPG";
            textBoxOutput_IPG.Size = new Size(352, 259);
            textBoxOutput_IPG.TabIndex = 0;
            // 
            // groupBoxInput_IPG
            // 
            groupBoxInput_IPG.Controls.Add(textBoxInput_IPG);
            groupBoxInput_IPG.Location = new Point(7, 246);
            groupBoxInput_IPG.Margin = new Padding(2, 2, 2, 2);
            groupBoxInput_IPG.Name = "groupBoxInput_IPG";
            groupBoxInput_IPG.Padding = new Padding(2, 2, 2, 2);
            groupBoxInput_IPG.Size = new Size(465, 289);
            groupBoxInput_IPG.TabIndex = 0;
            groupBoxInput_IPG.TabStop = false;
            groupBoxInput_IPG.Text = "Ввод: ";
            // 
            // textBoxInput_IPG
            // 
            textBoxInput_IPG.BorderStyle = BorderStyle.None;
            textBoxInput_IPG.Location = new Point(4, 30);
            textBoxInput_IPG.Margin = new Padding(2, 2, 2, 2);
            textBoxInput_IPG.Multiline = true;
            textBoxInput_IPG.Name = "textBoxInput_IPG";
            textBoxInput_IPG.Size = new Size(454, 259);
            textBoxInput_IPG.TabIndex = 0;
            // 
            // buttonOpenFile_IPG
            // 
            buttonOpenFile_IPG.Location = new Point(22, 26);
            buttonOpenFile_IPG.Margin = new Padding(2, 2, 2, 2);
            buttonOpenFile_IPG.Name = "buttonOpenFile_IPG";
            buttonOpenFile_IPG.Size = new Size(100, 67);
            buttonOpenFile_IPG.TabIndex = 1;
            buttonOpenFile_IPG.UseVisualStyleBackColor = true;
            buttonOpenFile_IPG.Click += buttonOpenFile_IPG_Click;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.Location = new Point(178, 26);
            buttonDone_IPG.Margin = new Padding(2, 2, 2, 2);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(84, 67);
            buttonDone_IPG.TabIndex = 1;
            buttonDone_IPG.UseVisualStyleBackColor = true;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            // 
            // buttonHelp_IPG
            // 
            buttonHelp_IPG.Location = new Point(664, 32);
            buttonHelp_IPG.Margin = new Padding(2, 2, 2, 2);
            buttonHelp_IPG.Name = "buttonHelp_IPG";
            buttonHelp_IPG.Size = new Size(89, 67);
            buttonHelp_IPG.TabIndex = 1;
            buttonHelp_IPG.UseVisualStyleBackColor = true;
            buttonHelp_IPG.Click += buttonHelp_IPG_Click;
            // 
            // openFileDialogTask_IPG
            // 
            openFileDialogTask_IPG.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(245, 95);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 536);
            Controls.Add(checkBox1);
            Controls.Add(buttonHelp_IPG);
            Controls.Add(buttonDone_IPG);
            Controls.Add(buttonOpenFile_IPG);
            Controls.Add(groupBoxInput_IPG);
            Controls.Add(groupBoxOutput_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 25| Милютин Н.Д.";
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            groupBoxOutput_IPG.ResumeLayout(false);
            groupBoxOutput_IPG.PerformLayout();
            groupBoxInput_IPG.ResumeLayout(false);
            groupBoxInput_IPG.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private GroupBox groupBoxOutput_IPG;
        private GroupBox groupBoxInput_IPG;
        private TextBox textBoxCondition_IPG;
        private Button buttonOpenFile_IPG;
        private Button buttonDone_IPG;
        private Button buttonHelp_IPG;
        private TextBox textBoxOutput_IPG;
        private TextBox textBoxInput_IPG;
        private OpenFileDialog openFileDialogTask_IPG;
        private ToolTip toolTipTask_IPG;
        private CheckBox checkBox1;
    }
}