namespace GourmetGame
{
    partial class GuessingFoodTypeForm
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
            this.lblFoodTypeId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFoodQuestion
            // 
            this.lblFoodQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFoodQuestion.AutoSize = true;
            this.lblFoodQuestion.Location = new System.Drawing.Point(38, 28);
            this.lblFoodQuestion.Name = "lblFoodQuestion";
            this.lblFoodQuestion.Size = new System.Drawing.Size(38, 15);
            this.lblFoodQuestion.TabIndex = 0;
            this.lblFoodQuestion.Text = "label1";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYes.Location = new System.Drawing.Point(38, 68);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNo.Location = new System.Drawing.Point(145, 68);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblFoodTypeId
            // 
            this.lblFoodTypeId.AutoSize = true;
            this.lblFoodTypeId.Location = new System.Drawing.Point(3, -1);
            this.lblFoodTypeId.Name = "lblFoodTypeId";
            this.lblFoodTypeId.Size = new System.Drawing.Size(38, 15);
            this.lblFoodTypeId.TabIndex = 3;
            this.lblFoodTypeId.Text = "label1";
            this.lblFoodTypeId.Visible = false;
            // 
            // GuessingFoodTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 125);
            this.Controls.Add(this.lblFoodTypeId);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblFoodQuestion);
            this.Name = "GuessingFoodTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivinhando Tipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFoodQuestion;
        private Button btnYes;
        private Button btnNo;
        private Label lblFoodTypeId;
    }
}