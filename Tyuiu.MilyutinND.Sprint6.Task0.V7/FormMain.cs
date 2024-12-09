using Tyuiu.MilyutinND.Sprint6.Task0.V7.Lib;
namespace Tyuiu.MilyutinND.Sprint6.Task0.V7


{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult_IAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_IAA.Text)));
        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-24-1 Милютин Никита Дмитрииевич", "Сообщение");
        }

        private void textBoxVarX_IAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_IAA_Enter(object sender, EventArgs e)
        {

        }
    }
}
