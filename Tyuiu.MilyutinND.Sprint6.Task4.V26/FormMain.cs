using Tyuiu.MilyutinND.Sprint6.Task4.V26.Lib;

namespace Tyuiu.MilyutinND.Sprint6.Task4.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonClick_MDD(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_MDD.Text);
                int stopStep = Convert.ToInt32(textBoxStop_MDD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxOut_MDD.Text = "";
                chartstart_MDD.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartstart_MDD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOut_MDD.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ButtonSave_MDD(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOut_MDD.Text);
                DialogResult dialogResult = MessageBox.Show("����" + path + "�������� �������!\n  ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonHelp_MDD(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 V26 �������� ������ ������ ������-23-1 �������� ���� ���������� ", "���������");
        }
    }

}
