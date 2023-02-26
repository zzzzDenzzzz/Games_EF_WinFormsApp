using Games_EF_WinFormsApp.Constants;
using Games_EF_WinFormsApp.Forms.CreatorGameForms;
using Games_EF_WinFormsApp.Services;

namespace Games_EF_WinFormsApp
{
    public partial class MainForm : Form
    {
        readonly CreatorGameService _creatorGameService;

        readonly GameService _gameService;

        readonly Dictionary<int, Action> LoadTabsMethod;

        public MainForm()
        {
            InitializeComponent();
            _creatorGameService = new();
            _gameService = new();
            LoadTabsMethod = new()
            {
                {0, LoadCreatorGameAsync },
            };
        }

        #region [MainForm_Load, TabControlMain_SelectedIndexChanged]

        void MainForm_Load(object sender, EventArgs e)
        {
            LoadTabsMethod[0]();
        }

        void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTabsMethod[tabControlMain.SelectedIndex]();
        }

        #endregion

        #region [CRUD CreatorGame]

        async void LoadCreatorGameAsync()
        {
            TableCreatorService.ShowTable(
                gridCreatorGames,
                TableCreatorService.CreateCreatorGameTable(await _creatorGameService.GetCreatorGamesAsync()));
        }

        async void BtnAddCreatorGame_Click(object sender, EventArgs e)
        {
            var form = new AddCreatorGameForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _creatorGameService.AddCreatorGameAsync(form.CreatorGameName);
                LoadCreatorGameAsync();
            }
        }

        async void BtnDeleteCreatorGame_Click(object sender, EventArgs e)
        {
            if (gridCreatorGames.SelectedRows.Count > 0)
            {
                var creatorId = int.Parse(gridCreatorGames.SelectedRows[0].Cells[0].Value.ToString()!);
                try
                {
                    await _creatorGameService.DeleteCreatorGameAsync(creatorId);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    LoadCreatorGameAsync();
                }
            }
            else
            {
                MessageBox.Show(DefaultDB.OBJECT_NOT_FOUND);
            }
        }

        #endregion
    }
}