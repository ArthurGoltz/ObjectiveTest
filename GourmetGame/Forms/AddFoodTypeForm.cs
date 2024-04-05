using GourmetGame.Models;
using GourmetGame.Repositories;
using System;
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
    public partial class AddFoodTypeForm : Form
    {
        private readonly IGameRepository _gameRepository;
        private readonly string _dishName;
        public AddFoodTypeForm(string dishName)
        {
            _gameRepository = GameRepository.GetInstance();
            _dishName = dishName;
            InitializeComponent();
            InitializeLabelsForDish();
        }

        public void InitializeLabelsForDish()
        {
            string lastDish = _gameRepository.GetTypes().Last();
            if (!_gameRepository.HasGuessedType)
                lastDish = _gameRepository.GetFoodByType(lastDish).Last();

            this.label1.Text = this.label1.Text
                .Replace("#currentDish#", _dishName)
                .Replace("#lastDish#", lastDish);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var typeName = this.txtType.Text;
            if (typeName is null)
            {
                MessageBox.Show("Prato inválido");
                return;
            }

            _gameRepository.Add(typeName, _dishName);

            InitForm initForm = new()
            {
                Location = this.Location,
                Size = this.Size,
                Anchor = this.Anchor,
                StartPosition = this.StartPosition
            };
            initForm.Show();
            this.Hide();
        }
    }
}
