using System;
using System.Data;
using System.Windows.Forms;

namespace GameSetup
{
    public partial class highscores : Form
    {
        private DataSet scoresDataset;
        private DataTable scoresDataTable;

        public highscores()
        {
            InitializeComponent();
        }

        private void highscores_Load(object sender, EventArgs e)
        {
            DataSet scoresDataSet = new DataSet();
            string xmlPath = @"C:\Users\Dave\Desktop\BlackJack_Master - Copy 6-2-2018\GameSetup\Resources\MyXML.xml";
            scoresDataSet.ReadXml(xmlPath);
            DataTable scoresDataTable = scoresDataSet.Tables["score"];
            dataGridTest.DataSource = scoresDataTable;
            dataGridTest.Columns["playerName"].HeaderText = "Player";
            dataGridTest.Columns["points"].HeaderText = "Score";
        }

        private void highScoreslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scoresToplabel_Click(object sender, EventArgs e)
        {
        }
    }
}
