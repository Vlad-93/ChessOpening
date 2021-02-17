namespace ChessOpening
{
    partial class Chess
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelPlayerWhite = new System.Windows.Forms.Label();
            this.labelPlayerBlack = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelGameType = new System.Windows.Forms.Label();
            this.textBoxMoves = new System.Windows.Forms.TextBox();
            this.comboBoxPlayerWhite = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPlayerBlack = new System.Windows.Forms.ComboBox();
            this.comboBoxResult = new System.Windows.Forms.ComboBox();
            this.comboBoxGameType = new System.Windows.Forms.ComboBox();
            this.comboBoxDebut = new System.Windows.Forms.ComboBox();
            this.labelDebut = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.radioButtonDB = new System.Windows.Forms.RadioButton();
            this.radioButtonVeiw = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(557, 123);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 40);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить данные";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(557, 200);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(234, 41);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Показать данные";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(754, 123);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(160, 40);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelPlayerWhite
            // 
            this.labelPlayerWhite.AutoSize = true;
            this.labelPlayerWhite.Location = new System.Drawing.Point(30, 31);
            this.labelPlayerWhite.Name = "labelPlayerWhite";
            this.labelPlayerWhite.Size = new System.Drawing.Size(101, 17);
            this.labelPlayerWhite.TabIndex = 4;
            this.labelPlayerWhite.Text = "Игрок белыми";
            // 
            // labelPlayerBlack
            // 
            this.labelPlayerBlack.AutoSize = true;
            this.labelPlayerBlack.Location = new System.Drawing.Point(30, 79);
            this.labelPlayerBlack.Name = "labelPlayerBlack";
            this.labelPlayerBlack.Size = new System.Drawing.Size(109, 17);
            this.labelPlayerBlack.TabIndex = 5;
            this.labelPlayerBlack.Text = "Игрок чёрными";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 126);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(76, 17);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат";
            // 
            // labelGameType
            // 
            this.labelGameType.AutoSize = true;
            this.labelGameType.Location = new System.Drawing.Point(30, 218);
            this.labelGameType.Name = "labelGameType";
            this.labelGameType.Size = new System.Drawing.Size(68, 17);
            this.labelGameType.TabIndex = 7;
            this.labelGameType.Text = "Тип игры";
            // 
            // textBoxMoves
            // 
            this.textBoxMoves.Location = new System.Drawing.Point(732, 23);
            this.textBoxMoves.Name = "textBoxMoves";
            this.textBoxMoves.Size = new System.Drawing.Size(58, 22);
            this.textBoxMoves.TabIndex = 8;
            // 
            // comboBoxPlayerWhite
            // 
            this.comboBoxPlayerWhite.FormattingEnabled = true;
            this.comboBoxPlayerWhite.Location = new System.Drawing.Point(151, 28);
            this.comboBoxPlayerWhite.Name = "comboBoxPlayerWhite";
            this.comboBoxPlayerWhite.Size = new System.Drawing.Size(267, 24);
            this.comboBoxPlayerWhite.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(732, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // comboBoxPlayerBlack
            // 
            this.comboBoxPlayerBlack.FormattingEnabled = true;
            this.comboBoxPlayerBlack.Location = new System.Drawing.Point(151, 76);
            this.comboBoxPlayerBlack.Name = "comboBoxPlayerBlack";
            this.comboBoxPlayerBlack.Size = new System.Drawing.Size(267, 24);
            this.comboBoxPlayerBlack.TabIndex = 18;
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.FormattingEnabled = true;
            this.comboBoxResult.Location = new System.Drawing.Point(151, 123);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Size = new System.Drawing.Size(267, 24);
            this.comboBoxResult.TabIndex = 19;
            // 
            // comboBoxGameType
            // 
            this.comboBoxGameType.FormattingEnabled = true;
            this.comboBoxGameType.Location = new System.Drawing.Point(151, 217);
            this.comboBoxGameType.Name = "comboBoxGameType";
            this.comboBoxGameType.Size = new System.Drawing.Size(267, 24);
            this.comboBoxGameType.TabIndex = 20;
            // 
            // comboBoxDebut
            // 
            this.comboBoxDebut.FormattingEnabled = true;
            this.comboBoxDebut.Location = new System.Drawing.Point(151, 170);
            this.comboBoxDebut.Name = "comboBoxDebut";
            this.comboBoxDebut.Size = new System.Drawing.Size(267, 24);
            this.comboBoxDebut.TabIndex = 21;
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.Location = new System.Drawing.Point(30, 174);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(52, 17);
            this.labelDebut.TabIndex = 22;
            this.labelDebut.Text = "Дебют";
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Location = new System.Drawing.Point(646, 23);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(43, 17);
            this.labelMoves.TabIndex = 23;
            this.labelMoves.Text = "Ходы";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(646, 65);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "Дата";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(946, 123);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 40);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(475, 212);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 17);
            this.labelId.TabIndex = 26;
            this.labelId.Visible = false;
            // 
            // radioButtonDB
            // 
            this.radioButtonDB.AutoSize = true;
            this.radioButtonDB.Location = new System.Drawing.Point(838, 212);
            this.radioButtonDB.Name = "radioButtonDB";
            this.radioButtonDB.Size = new System.Drawing.Size(113, 21);
            this.radioButtonDB.TabIndex = 28;
            this.radioButtonDB.TabStop = true;
            this.radioButtonDB.Text = "База данных";
            this.radioButtonDB.UseVisualStyleBackColor = true;
            this.radioButtonDB.CheckedChanged += new System.EventHandler(this.radioButtonDB_CheckedChanged);
            // 
            // radioButtonVeiw
            // 
            this.radioButtonVeiw.AutoSize = true;
            this.radioButtonVeiw.Checked = true;
            this.radioButtonVeiw.Location = new System.Drawing.Point(974, 210);
            this.radioButtonVeiw.Name = "radioButtonVeiw";
            this.radioButtonVeiw.Size = new System.Drawing.Size(132, 21);
            this.radioButtonVeiw.TabIndex = 29;
            this.radioButtonVeiw.TabStop = true;
            this.radioButtonVeiw.Text = "Представление";
            this.radioButtonVeiw.UseVisualStyleBackColor = true;
            this.radioButtonVeiw.CheckedChanged += new System.EventHandler(this.radioButtonVeiw_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 253);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1148, 442);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 699);
            this.Controls.Add(this.radioButtonVeiw);
            this.Controls.Add(this.radioButtonDB);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.labelDebut);
            this.Controls.Add(this.comboBoxDebut);
            this.Controls.Add(this.comboBoxGameType);
            this.Controls.Add(this.comboBoxResult);
            this.Controls.Add(this.comboBoxPlayerBlack);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxPlayerWhite);
            this.Controls.Add(this.textBoxMoves);
            this.Controls.Add(this.labelGameType);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelPlayerBlack);
            this.Controls.Add(this.labelPlayerWhite);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Chess";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Chess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelPlayerWhite;
        private System.Windows.Forms.Label labelPlayerBlack;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelGameType;
        private System.Windows.Forms.TextBox textBoxMoves;
        private System.Windows.Forms.ComboBox comboBoxPlayerWhite;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxPlayerBlack;
        private System.Windows.Forms.ComboBox comboBoxResult;
        private System.Windows.Forms.ComboBox comboBoxGameType;
        private System.Windows.Forms.ComboBox comboBoxDebut;
        private System.Windows.Forms.Label labelDebut;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.RadioButton radioButtonDB;
        private System.Windows.Forms.RadioButton radioButtonVeiw;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

