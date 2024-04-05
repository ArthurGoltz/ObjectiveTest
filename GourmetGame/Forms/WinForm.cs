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
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
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
