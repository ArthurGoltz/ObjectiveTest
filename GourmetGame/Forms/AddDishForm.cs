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
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var dishName = this.txtDish.Text;
            if(dishName is null)
            {
                MessageBox.Show("Prato inválido");
                return;
            }

            AddFoodTypeForm addFoodTypeForm = new(dishName)
            {
                Location = this.Location,
                Size = this.Size,
                Anchor = this.Anchor,
                StartPosition = this.StartPosition
            };
            addFoodTypeForm.Show();
            this.Hide();
        }
    }
}
