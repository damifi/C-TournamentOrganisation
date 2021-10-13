
namespace TournamentUI
{
    partial class CreatePrizeForm
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.placeNumber = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeName = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizePercentage = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.prizeMoney = new System.Windows.Forms.TextBox();
            this.prizeMoneyLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrizeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.createPrizeLabel.Location = new System.Drawing.Point(12, 9);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(209, 50);
            this.createPrizeLabel.TabIndex = 12;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumber
            // 
            this.placeNumber.Location = new System.Drawing.Point(220, 92);
            this.placeNumber.Name = "placeNumber";
            this.placeNumber.Size = new System.Drawing.Size(148, 35);
            this.placeNumber.TabIndex = 14;
            this.placeNumber.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.placeNumberLabel.Location = new System.Drawing.Point(31, 89);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(183, 37);
            this.placeNumberLabel.TabIndex = 13;
            this.placeNumberLabel.Text = "Place Number";
            this.placeNumberLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // placeName
            // 
            this.placeName.Location = new System.Drawing.Point(220, 148);
            this.placeName.Name = "placeName";
            this.placeName.Size = new System.Drawing.Size(148, 35);
            this.placeName.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.placeNameLabel.Location = new System.Drawing.Point(31, 145);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(157, 37);
            this.placeNameLabel.TabIndex = 15;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizePercentage
            // 
            this.prizePercentage.Location = new System.Drawing.Point(249, 323);
            this.prizePercentage.Name = "prizePercentage";
            this.prizePercentage.Size = new System.Drawing.Size(119, 35);
            this.prizePercentage.TabIndex = 18;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.prizePercentageLabel.Location = new System.Drawing.Point(31, 321);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(212, 37);
            this.prizePercentageLabel.TabIndex = 17;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeMoney
            // 
            this.prizeMoney.Location = new System.Drawing.Point(220, 202);
            this.prizeMoney.Name = "prizeMoney";
            this.prizeMoney.Size = new System.Drawing.Size(148, 35);
            this.prizeMoney.TabIndex = 20;
            // 
            // prizeMoneyLabel
            // 
            this.prizeMoneyLabel.AutoSize = true;
            this.prizeMoneyLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeMoneyLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.prizeMoneyLabel.Location = new System.Drawing.Point(31, 199);
            this.prizeMoneyLabel.Name = "prizeMoneyLabel";
            this.prizeMoneyLabel.Size = new System.Drawing.Size(163, 37);
            this.prizeMoneyLabel.TabIndex = 19;
            this.prizeMoneyLabel.Text = "Prize Money";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.orLabel.Location = new System.Drawing.Point(123, 261);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(108, 37);
            this.orLabel.TabIndex = 21;
            this.orLabel.Text = "---or---";
            this.orLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(129, 414);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(192, 73);
            this.createPrizeButton.TabIndex = 26;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 900);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizeMoney);
            this.Controls.Add(this.prizeMoneyLabel);
            this.Controls.Add(this.prizePercentage);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.placeName);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumber);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.TextBox placeNumber;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeName;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizePercentage;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.TextBox prizeMoney;
        private System.Windows.Forms.Label prizeMoneyLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}