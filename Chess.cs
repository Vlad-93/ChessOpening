using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ChessOpening
{
    public partial class Chess : Form
    {
        private ChessEntities chessContext;
        bool columnsShow = false;

        public Chess()
        {
            InitializeComponent();
        }

        private void Chess_Load(object sender, EventArgs e)
        {
            chessContext = new ChessEntities();

            var players = from d in chessContext.Players.Include("Games")
                          orderby d.LastName
                          select d;

            var results = from c in chessContext.ResultGames.Include("Games")
                          orderby c.ResultId
                          select c;

            var debuts = from b in chessContext.Debuts.Include("Games")
                         orderby b.Comment
                         select b;

            var gameTypes = from a in chessContext.GameTypes.Include("Games")
                            orderby a.GameTypeId
                            select a;

            try
            {
                //Игрок белыми
                comboBoxPlayerWhite.DisplayMember = "LastName";
                comboBoxPlayerWhite.DataSource = players.ToList();                               
                //Игрок чёрными
                comboBoxPlayerBlack.DisplayMember = "LastName";
                comboBoxPlayerBlack.DataSource = players.ToList();
                //Результат
                comboBoxResult.DisplayMember = "Comment";
                comboBoxResult.DataSource = results.ToList();
                //Дебют
                comboBoxDebut.DisplayMember = "Comment";
                comboBoxDebut.DataSource = debuts.ToList();
                //Тип игры
                comboBoxGameType.DisplayMember = "TitleGameType";
                comboBoxGameType.DataSource = gameTypes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        //Отображение данных из базы данных
        private void buttonShow_Click(object sender, EventArgs e)
        {
            Output();
        }

        private void Output()
        {
            try
            {
                dataGridView1.DataSource = chessContext.Games.ToList();
                //Отображение столбцов
                //dataGridView1.Columns["GameId"].Visible = false;
                dataGridView1.Columns["TimeToPlay"].Visible = false;
                dataGridView1.Columns["AddTimeToMove"].Visible = false;
                dataGridView1.Columns["Debut1"].Visible = false;
                dataGridView1.Columns["GameType1"].Visible = false;
                dataGridView1.Columns["Player"].Visible = false;
                dataGridView1.Columns["Player1"].Visible = false;
                dataGridView1.Columns["ResultGame"].Visible = false;
                ////Переименовка столбцов
                //dataGridView1.Columns["PlayerWhite"].HeaderText = "Игрок белыми";
                //dataGridView1.Columns["PlayerBlack"].HeaderText = "Игрок чёрными";
                //dataGridView1.Columns["Result"].HeaderText = "Результат";
                //dataGridView1.Columns["Debut"].HeaderText = "Дебют";
                //dataGridView1.Columns["GameType"].HeaderText = "Тип игры";
                //dataGridView1.Columns["NumberMoves"].HeaderText = "Количество ходов";
                //dataGridView1.Columns["DateGame"].HeaderText = "Дата партии";

                dataGridView1.AllowUserToDeleteRows = false;
                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataShow();
        }

        //Отображение данных в ячейках таблицы (вместо id)
        private void DataShow()
        {
            if (!columnsShow)
                ColumnsShow();  //Выполняется 1 раз

            //int numColumns = dataGridView2.ColumnCount;
            int numRows = dataGridView1.RowCount;
            int i;
            long player1Id, player2Id, resultId, debutId, gameTypeId;

            //Добавление строк
            while (dataGridView2.RowCount < numRows)
                dataGridView2.Rows.Add();

            //Удаление строк
            while (dataGridView2.RowCount > numRows)
                dataGridView2.Rows.Remove(dataGridView2.Rows[0]);

            //for (i = 0; i < numRows; i++)
            //    for (j = 0; j < numColumns; j++)
            //        dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);

            //Заполнение строк                
            for (i = 0; i < numRows; i++)
            {
                player1Id = Convert.ToInt64(dataGridView1.Rows[i].Cells["PlayerWhite"].Value);
                player2Id = Convert.ToInt64(dataGridView1.Rows[i].Cells["PlayerBlack"].Value);
                resultId = Convert.ToInt64(dataGridView1.Rows[i].Cells["Result"].Value);
                debutId = Convert.ToInt64(dataGridView1.Rows[i].Cells["Debut"].Value);
                gameTypeId = Convert.ToInt64(dataGridView1.Rows[i].Cells["GameType"].Value);

                dataGridView2.Rows[i].Cells["GameId"].Value = dataGridView1.Rows[i].Cells["GameId"].Value;

                dataGridView2.Rows[i].Cells["PlayerWhite"].Value = chessContext.Players.Find(player1Id).LastName;
                dataGridView2.Rows[i].Cells["PlayerBlack"].Value = chessContext.Players.Find(player2Id).LastName;
                dataGridView2.Rows[i].Cells["Result"].Value = chessContext.ResultGames.Find(resultId).Comment;
                dataGridView2.Rows[i].Cells["Debut"].Value = chessContext.Debuts.Find(debutId).Comment;
                dataGridView2.Rows[i].Cells["GameType"].Value = chessContext.GameTypes.Find(gameTypeId).TitleGameType;

                dataGridView2.Rows[i].Cells["NumberMoves"].Value = dataGridView1.Rows[i].Cells["NumberMoves"].Value;
                dataGridView2.Rows[i].Cells["DateGame"].Value = Convert.ToString(dataGridView1.Rows[i].Cells["DateGame"].Value).Substring(0, 10);
            }

        }

        //Создание столбцов DataGridView2
        public bool ColumnsShow()
        {         
            dataGridView2.Columns.Add("GameId", "Номер_партии");
            dataGridView2.Columns.Add("PlayerWhite", "Игрок_белыми");
            dataGridView2.Columns.Add("PlayerBlack", "Игрок_чёрными");
            dataGridView2.Columns.Add("Result", "Результат");
            dataGridView2.Columns.Add("Debut", "Дебют");
            dataGridView2.Columns.Add("GameType", "Тип_игры");

            dataGridView2.Columns.Add("TimeToPlay", "Времени_на_игру");
            dataGridView2.Columns["TimeToPlay"].Visible = false;
            dataGridView2.Columns.Add("AddTimeToMove", "Дополнительное_время_на_ход");
            dataGridView2.Columns["AddTimeToMove"].Visible = false;

            dataGridView2.Columns.Add("NumberMoves", "Количество_ходов");
            dataGridView2.Columns.Add("DateGame", "Дата_партии");

            //dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            int i;
            int numColumns = dataGridView2.ColumnCount;            

            for (i = 0; i < numColumns; i++)
                dataGridView2.Columns[i].ValueType = typeof(string);

             return columnsShow = true;
        }

        //Добавление данных в базу данных
        private void buttonAdd_Click(object sender, EventArgs e)
        {           
            try
            {
                Player player1 = (Player)comboBoxPlayerWhite.SelectedItem;
                Player player2 = (Player)comboBoxPlayerBlack.SelectedItem;
                ResultGame result = (ResultGame)comboBoxResult.SelectedItem;
                Debut debut = (Debut)comboBoxDebut.SelectedItem;
                GameType gameType = (GameType)comboBoxGameType.SelectedItem;

                Game game = new Game
                {
                    PlayerWhite = player1.PlayerId,
                    PlayerBlack = player2.PlayerId,
                    Result = result.ResultId,
                    Debut = debut.DebutID,
                    GameType = gameType.GameTypeId,
                    TimeToPlay = null,
                    AddTimeToMove = null,
                    NumberMoves = Int16.Parse(textBoxMoves.Text),
                    DateGame = dateTimePicker1.Value.Date
                }; 
                chessContext.Games.Add(game);
                chessContext.SaveChanges();
                textBoxMoves.Text = String.Empty;                
            }    
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }

            Output();
        }

        //Выбор строки база данных
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            var game = dataGridView1.CurrentRow.DataBoundItem as Game;
            if (game == null)
                return;
            labelId.Text = Convert.ToString(game.GameId);  
            comboBoxPlayerWhite.SelectedItem = chessContext.Players.Find(game.PlayerWhite);
            comboBoxPlayerBlack.SelectedItem = chessContext.Players.Find(game.PlayerBlack);
            comboBoxResult.SelectedItem = chessContext.ResultGames.Find(game.Result);
            comboBoxDebut.SelectedItem = chessContext.Debuts.Find(game.Debut);
            comboBoxGameType.SelectedItem = chessContext.GameTypes.Find(game.GameType);
            textBoxMoves.Text = Convert.ToString(game.NumberMoves);
            dateTimePicker1.Value = game.DateGame.Value.Date;  
        }

        //Выбор строки представление
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
                return;
            int rowId = dataGridView2.CurrentRow.Index;
            var game = dataGridView1.Rows[rowId].DataBoundItem as Game;
            if (game == null)
                return;
            labelId.Text = Convert.ToString(game.GameId);
            comboBoxPlayerWhite.SelectedItem = chessContext.Players.Find(game.PlayerWhite);
            comboBoxPlayerBlack.SelectedItem = chessContext.Players.Find(game.PlayerBlack);
            comboBoxResult.SelectedItem = chessContext.ResultGames.Find(game.Result);
            comboBoxDebut.SelectedItem = chessContext.Debuts.Find(game.Debut);
            comboBoxGameType.SelectedItem = chessContext.GameTypes.Find(game.GameType);
            textBoxMoves.Text = Convert.ToString(game.NumberMoves);
            dateTimePicker1.Value = game.DateGame.Value.Date;
        }

        //Изменение данных
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty)
                return;
            var gameId = Convert.ToInt32(labelId.Text);
            var game = chessContext.Games.Find(gameId);
            if (game == null)
                return;
            game.PlayerWhite = ((Player)comboBoxPlayerWhite.SelectedItem).PlayerId;
            game.PlayerBlack = ((Player)comboBoxPlayerBlack.SelectedItem).PlayerId;
            game.Result = ((ResultGame)comboBoxResult.SelectedItem).ResultId;
            game.Debut = ((Debut)comboBoxDebut.SelectedItem).DebutID;
            game.GameType = ((GameType)comboBoxGameType.SelectedItem).GameTypeId;
            game.TimeToPlay = null;
            game.AddTimeToMove = null;
            game.NumberMoves = Int16.Parse(textBoxMoves.Text);
            game.DateGame = dateTimePicker1.Value.Date;
            
            chessContext.Entry(game).State = EntityState.Modified;
            chessContext.SaveChanges();
            Output();
        }

        //Удаление данных
        private void buttonDelete_Click(object sender, EventArgs e)
        {            
            if (labelId.Text == String.Empty)
                return;
            var gameId = Convert.ToInt32(labelId.Text);
            var game = chessContext.Games.Find(gameId);
            chessContext.Entry(game).State = EntityState.Deleted;
            chessContext.SaveChanges();
            Output();
        }

        //Отображение данных: база данных
        private void radioButtonDB_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;

            labelId.Text = String.Empty;
        }

        //Отображение данных: представление
        private void radioButtonVeiw_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;

            labelId.Text = String.Empty;
        }       
    }
}
