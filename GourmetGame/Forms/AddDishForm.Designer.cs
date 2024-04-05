namespace GourmetGame
{
    partial class AddDishForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDish = new System.Windows.Forms.Label();
            this.txtDish = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDish
            // 
            this.lblDish.AutoSize = true;
            this.lblDish.Location = new System.Drawing.Point(47, 29);
            this.lblDish.Name = "lblDish";
            this.lblDish.Size = new System.Drawing.Size(138, 15);
            this.lblDish.TabIndex = 0;
            this.lblDish.Text = "Qual prato você pensou?";
            // 
            // txtDish
            // 
            this.txtDish.Location = new System.Drawing.Point(47, 47);
            this.txtDish.Name = "txtDish";
            this.txtDish.Size = new System.Drawing.Size(217, 23);
            this.txtDish.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(87, 76);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 125);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDish);
            this.Controls.Add(this.lblDish);
            this.Name = "AddDishForm";
            this.Text = "Desisto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDish;
        private TextBox txtDish;
        private Button btnOk;
    }
}