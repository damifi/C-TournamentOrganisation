
namespace TournamentUI
{
    partial class CreateTeamForm
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
            this.teamName = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewTeamMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createTeamMemberButton = new System.Windows.Forms.Button();
            this.mobile = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMemberListbox = new System.Windows.Forms.ListBox();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewTeamMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(21, 120);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(274, 35);
            this.teamName.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(12, 80);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(163, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name:";
            this.teamNameLabel.Click += new System.EventHandler(this.tournamentNameLabel_Click);
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(213, 50);
            this.createTeamLabel.TabIndex = 11;
            this.createTeamLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamMemberButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.addTeamMemberButton.Location = new System.Drawing.Point(58, 269);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(214, 42);
            this.addTeamMemberButton.TabIndex = 19;
            this.addTeamMemberButton.Text = "Add Team Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(21, 225);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(274, 38);
            this.selectTeamMemberDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(21, 181);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewTeamMemberGroupBox
            // 
            this.addNewTeamMemberGroupBox.Controls.Add(this.createTeamMemberButton);
            this.addNewTeamMemberGroupBox.Controls.Add(this.mobile);
            this.addNewTeamMemberGroupBox.Controls.Add(this.mobileLabel);
            this.addNewTeamMemberGroupBox.Controls.Add(this.email);
            this.addNewTeamMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewTeamMemberGroupBox.Controls.Add(this.lastName);
            this.addNewTeamMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewTeamMemberGroupBox.Controls.Add(this.firstName);
            this.addNewTeamMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewTeamMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewTeamMemberGroupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.addNewTeamMemberGroupBox.Location = new System.Drawing.Point(30, 335);
            this.addNewTeamMemberGroupBox.Name = "addNewTeamMemberGroupBox";
            this.addNewTeamMemberGroupBox.Size = new System.Drawing.Size(337, 271);
            this.addNewTeamMemberGroupBox.TabIndex = 20;
            this.addNewTeamMemberGroupBox.TabStop = false;
            this.addNewTeamMemberGroupBox.Text = "Add New Team Member";
            // 
            // createTeamMemberButton
            // 
            this.createTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamMemberButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTeamMemberButton.Location = new System.Drawing.Point(46, 222);
            this.createTeamMemberButton.Name = "createTeamMemberButton";
            this.createTeamMemberButton.Size = new System.Drawing.Size(237, 42);
            this.createTeamMemberButton.TabIndex = 20;
            this.createTeamMemberButton.Text = "Create Team Member";
            this.createTeamMemberButton.UseVisualStyleBackColor = true;
            this.createTeamMemberButton.Click += new System.EventHandler(this.createTeamMemberButton_Click);
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(165, 179);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(148, 43);
            this.mobile.TabIndex = 16;
            this.mobile.TextChanged += new System.EventHandler(this.mobile_TextChanged);
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mobileLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.mobileLabel.Location = new System.Drawing.Point(16, 179);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(101, 37);
            this.mobileLabel.TabIndex = 15;
            this.mobileLabel.Text = "Mobile";
            this.mobileLabel.Click += new System.EventHandler(this.mobileLabel_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(165, 140);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(148, 43);
            this.email.TabIndex = 14;
            this.email.TextChanged += new System.EventHandler(this.teamOneScore_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.emailLabel.Location = new System.Drawing.Point(16, 135);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 37);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(165, 99);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(148, 43);
            this.lastName.TabIndex = 12;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 97);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(165, 58);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(148, 43);
            this.firstName.TabIndex = 10;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 55);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // teamMemberListbox
            // 
            this.teamMemberListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMemberListbox.FormattingEnabled = true;
            this.teamMemberListbox.ItemHeight = 30;
            this.teamMemberListbox.Location = new System.Drawing.Point(416, 120);
            this.teamMemberListbox.Name = "teamMemberListbox";
            this.teamMemberListbox.Size = new System.Drawing.Size(274, 482);
            this.teamMemberListbox.TabIndex = 21;
            this.teamMemberListbox.SelectedIndexChanged += new System.EventHandler(this.tournamentPlayersListbox_SelectedIndexChanged);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteMemberButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteMemberButton.Location = new System.Drawing.Point(696, 307);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(183, 88);
            this.deleteMemberButton.TabIndex = 22;
            this.deleteMemberButton.Text = "Delete Member";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTeamButton.Location = new System.Drawing.Point(346, 613);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(192, 73);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 698);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.teamMemberListbox);
            this.Controls.Add(this.addNewTeamMemberGroupBox);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewTeamMemberGroupBox.ResumeLayout(false);
            this.addNewTeamMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Button addTeamMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewTeamMemberGroupBox;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Button createTeamMemberButton;
        private System.Windows.Forms.ListBox teamMemberListbox;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}