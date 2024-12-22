using Tyuiu.MilyutinND.Sprint6.Task7.V21.Lib;

namespace Tyuiu.MilyutinND.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KDR.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_KDR.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonLoadFile_KDR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_MND.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_MND.Enabled = true;
        }
        private void buttonOpenFile_KDR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDR.ShowDialog();
            openFilePath = openFileDialogTask_KDR.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_MND.ColumnCount = columns;
            dataGridViewIn_MND.RowCount = rows;
            dataGridViewOut_MND.ColumnCount = columns;
            dataGridViewOut_MND.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_MND.Columns[i].Width = 25;
                dataGridViewOut_MND.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_MND.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonLoadFile_MND.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_MND.ColumnCount = 38;
            dataGridViewOut_MND.ColumnCount = 38;

            dataGridViewIn_MND.RowCount = 38;
            dataGridViewOut_MND.RowCount = 38;

            panelLeft_MND.Width = this.Width / 2;

            for (int i = 0; i < 38; i++)
            {
                dataGridViewIn_MND.Columns[i].Width = 19;
                dataGridViewOut_MND.Columns[i].Width = 19;
            }
        }

        private void buttonSaveFile_KDR_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KDR.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_KDR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KDR.ShowDialog();

            string path = saveFileDialogTask_KDR.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_MND.RowCount;
            int columns = dataGridViewOut_MND.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_MND.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_MND.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Открыть файл";
        }

        private void buttonLoadFile_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Сохранить";
        }

        private void buttonHelp_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Справка";
        }

    }
}
