namespace GourmetGame
{
    partial class GuessingDishForm
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
            this.lblFoodQuestion = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblDishId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFoodQuestion
            // 
            this.lblFoodQuestion.AutoSize = true;
            this.lblFoodQuestion.Location = new System.Drawing.Point(38, 28);
            this.lblFoodQuestion.Name = "lblFoodQuestion";
            this.lblFoodQuestion.Size = new System.Drawing.Size(38, 15);
            this.lblFoodQuestion.TabIndex = 0;
            this.lblFoodQuestion.Text = "label1";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(38, 64);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Sim";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(137, 64);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Não";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblDishId
            // 
            this.lblDishId.AutoSize = true;
            this.lblDishId.Location = new System.Drawing.Point(0, 0);
            this.lblDishId.Name = "lblDishId";
            this.lblDishId.Size = new System.Drawing.Size(38, 15);
            this.lblDishId.TabIndex = 3;
            this.lblDishId.Text = "label2";
            this.lblDishId.Visible = false;
            // 
            // GuessingDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 125);
            this.Controls.Add(this.lblDishId);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblFoodQuestion);
            this.Name = "GuessingDishForm";
            this.Text = "Adivinhando Prato...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFoodQuestion;
        private Button btnYes;
        private Button btnNo;
        private Label lblDishId;
    }
}