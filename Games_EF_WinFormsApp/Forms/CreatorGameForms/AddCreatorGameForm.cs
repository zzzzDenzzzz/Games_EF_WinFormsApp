using Games_EF_WinFormsApp.Constants;
using System.ComponentModel;

namespace Games_EF_WinFormsApp.Forms.CreatorGameForms
{
    public partial class AddCreatorGameForm : Form
    {
        public string CreatorGameName => txtName.Text.Trim();

        public AddCreatorGameForm()
        {
            InitializeComponent();
        }

        void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length > DefaultDB.STRING_VALUE_MAX_LENGTH)
            {
                errorName.SetError(txtName, DefaultDB.NAME_TOO_LONG);
                e.Cancel = true;
            }
            else if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorName.SetError(txtName, DefaultDB.NAME_CANNOT_BE_EMPTY);
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtName, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
