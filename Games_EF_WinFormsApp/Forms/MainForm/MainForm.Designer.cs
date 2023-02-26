namespace Games_EF_WinFormsApp
{
    partial class MainForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCreatorGames = new System.Windows.Forms.TabPage();
            this.btnDeleteCreatorGame = new System.Windows.Forms.Button();
            this.btnAddCreatorGame = new System.Windows.Forms.Button();
            this.gridCreatorGames = new System.Windows.Forms.DataGridView();
            this.tabPageGames = new System.Windows.Forms.TabPage();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.gridGames = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPageCreatorGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreatorGames)).BeginInit();
            this.tabPageGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCreatorGames);
            this.tabControlMain.Controls.Add(this.tabPageGames);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabPageCreatorGames
            // 
            this.tabPageCreatorGames.Controls.Add(this.btnDeleteCreatorGame);
            this.tabPageCreatorGames.Controls.Add(this.btnAddCreatorGame);
            this.tabPageCreatorGames.Controls.Add(this.gridCreatorGames);
            this.tabPageCreatorGames.Location = new System.Drawing.Point(4, 24);
            this.tabPageCreatorGames.Name = "tabPageCreatorGames";
            this.tabPageCreatorGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreatorGames.Size = new System.Drawing.Size(768, 398);
            this.tabPageCreatorGames.TabIndex = 0;
            this.tabPageCreatorGames.Text = "Создатели игр";
            this.tabPageCreatorGames.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCreatorGame
            // 
            this.btnDeleteCreatorGame.Location = new System.Drawing.Point(87, 365);
            this.btnDeleteCreatorGame.Name = "btnDeleteCreatorGame";
            this.btnDeleteCreatorGame.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCreatorGame.TabIndex = 2;
            this.btnDeleteCreatorGame.Text = "Удалить";
            this.btnDeleteCreatorGame.UseVisualStyleBackColor = true;
            this.btnDeleteCreatorGame.Click += new System.EventHandler(this.BtnDeleteCreatorGame_Click);
            // 
            // btnAddCreatorGame
            // 
            this.btnAddCreatorGame.Location = new System.Drawing.Point(6, 365);
            this.btnAddCreatorGame.Name = "btnAddCreatorGame";
            this.btnAddCreatorGame.Size = new System.Drawing.Size(75, 23);
            this.btnAddCreatorGame.TabIndex = 1;
            this.btnAddCreatorGame.Text = "Добавить";
            this.btnAddCreatorGame.UseVisualStyleBackColor = true;
            this.btnAddCreatorGame.Click += new System.EventHandler(this.BtnAddCreatorGame_Click);
            // 
            // gridCreatorGames
            // 
            this.gridCreatorGames.AllowUserToAddRows = false;
            this.gridCreatorGames.AllowUserToDeleteRows = false;
            this.gridCreatorGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCreatorGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCreatorGames.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCreatorGames.Location = new System.Drawing.Point(6, 6);
            this.gridCreatorGames.Name = "gridCreatorGames";
            this.gridCreatorGames.ReadOnly = true;
            this.gridCreatorGames.RowHeadersVisible = false;
            this.gridCreatorGames.RowTemplate.Height = 25;
            this.gridCreatorGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCreatorGames.Size = new System.Drawing.Size(756, 353);
            this.gridCreatorGames.TabIndex = 0;
            // 
            // tabPageGames
            // 
            this.tabPageGames.Controls.Add(this.btnDeleteGame);
            this.tabPageGames.Controls.Add(this.btnAddGame);
            this.tabPageGames.Controls.Add(this.gridGames);
            this.tabPageGames.Location = new System.Drawing.Point(4, 24);
            this.tabPageGames.Name = "tabPageGames";
            this.tabPageGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGames.Size = new System.Drawing.Size(768, 398);
            this.tabPageGames.TabIndex = 1;
            this.tabPageGames.Text = "Игры";
            this.tabPageGames.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Location = new System.Drawing.Point(87, 369);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGame.TabIndex = 2;
            this.btnDeleteGame.Text = "Удалить";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(6, 369);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(75, 23);
            this.btnAddGame.TabIndex = 1;
            this.btnAddGame.Text = "Добавить";
            this.btnAddGame.UseVisualStyleBackColor = true;
            // 
            // gridGames
            // 
            this.gridGames.AllowUserToAddRows = false;
            this.gridGames.AllowUserToDeleteRows = false;
            this.gridGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGames.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridGames.Location = new System.Drawing.Point(6, 6);
            this.gridGames.Name = "gridGames";
            this.gridGames.ReadOnly = true;
            this.gridGames.RowHeadersVisible = false;
            this.gridGames.RowTemplate.Height = 25;
            this.gridGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGames.Size = new System.Drawing.Size(756, 357);
            this.gridGames.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCreatorGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCreatorGames)).EndInit();
            this.tabPageGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageCreatorGames;
        private TabPage tabPageGames;
        private Button btnDeleteCreatorGame;
        private Button btnAddCreatorGame;
        private DataGridView gridCreatorGames;
        private Button btnDeleteGame;
        private Button btnAddGame;
        private DataGridView gridGames;
    }
}