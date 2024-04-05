using GourmetGame.Models;
using GourmetGame.Repositories;

namespace GourmetGame
{
    public partial class GuessingDishForm : Form
    {
        private readonly IEnumerable<string> _dishList;
        private readonly IGameRepository _gameRepository;
        private int _countCurrentDish = 0;
        public GuessingDishForm(string foodType)
        {
            _gameRepository = GameRepository.GetInstance();

            _dishList = _gameRepository.GetFoodByType(foodType);

            InitializeComponent();
            InitializeLabelsForDish(_dishList.First());
        }


        public void InitializeLabelsForDish(string dish)
        {
            this.lblFoodQuestion.Text = $"O prato que você pensou é {dish}?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            WinForm winForm = new()
            {
                Location = this.Location,
                Size = this.Size,
                Anchor = this.Anchor,
                StartPosition = this.StartPosition
            };
            winForm.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            var indexofType = ++_countCurrentDish;
            if (_dishList.Count() > indexofType)
                InitializeLabelsForDish(_dishList.ElementAt(indexofType));
            else
            {
                AddDishForm addDishForm = new()
                {
                    Location = this.Location,
                    Size = this.Size,
                    Anchor = this.Anchor,
                    StartPosition = this.StartPosition
                };
                addDishForm.Show();
                this.Hide();
            }
        }
    }
}
