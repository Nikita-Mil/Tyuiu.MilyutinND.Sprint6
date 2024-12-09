using Tyuiu.MilyutinND.Sprint6.Task1.V6.Lib;

namespace Tyuiu.MilyutinND.Sprint6.Task1.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart_GVE.Text);
                int stopstep = Convert.ToInt32(textBoxFinish_GVE.Text);

                string strline;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);

                textBoxRes_GVE.Text = "";
                textBoxRes_GVE.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxRes_GVE.AppendText("|    X     |    F(x)    |" + Environment.NewLine);
                textBoxRes_GVE.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     |  {1, 6:f2}    | ", startstep, valueArray[i]);
                    textBoxRes_GVE.AppendText(strline + Environment.NewLine);
                    startstep++;
                }

                textBoxRes_GVE.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-24-1 Милютин Н.Д.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
