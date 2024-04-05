using GourmetGame.Models;
using GourmetGame.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GourmetGame
{
    public partial class GuessingFoodTypeForm : Form
    {
        private readonly IEnumerable<string> _foodTypeList;
        private readonly IGameRepository _gameRepository;
        private int _countCurrentFoodTypes = 0;

        public GuessingFoodTypeForm()
        {
            _gameRepository = GameRepository.GetInstance();
            _foodTypeList = _gameRepository.GetTypes();
            InitializeComponent();
            InitializeLabelsForFoodType(_foodTypeList.First());
        }

        public void InitializeLabelsForFoodType(string foodType)
        {
            this.lblFoodQuestion.Text = $"O prato que você pensou é {foodType}?";
            this.lblFoodTypeId.Text = foodType;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var foodType = this.lblFoodTypeId.Text;

            _gameRepository.HasGuessedType = true;

            GuessingDishForm guessingDishForm = new(foodType)
            {
                Location = this.Location,
                Size = this.Size,
                Anchor = this.Anchor,
                StartPosition = this.StartPosition
            };
            guessingDishForm.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            var indexofType = ++_countCurrentFoodTypes;

            if (_foodTypeList.Count() > indexofType)
                InitializeLabelsForFoodType(_foodTypeList.ElementAt(indexofType));
            else
            {
                _gameRepository.HasGuessedType = false;

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
