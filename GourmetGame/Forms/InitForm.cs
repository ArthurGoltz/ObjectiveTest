using GourmetGame.Repositories;

namespace GourmetGame
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GuessingFoodTypeForm guessingFoodTypeForm = new()
            {
                Location = this.Location,
                Size = this.Size,
                Anchor = this.Anchor,
                StartPosition = this.StartPosition
            };
            guessingFoodTypeForm.Show();
            this.Hide();
        }

    }
}
