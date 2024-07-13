namespace EContact
{
    partial class Econtact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            pictureBoxLogo = new PictureBox();
            labelContactID = new Label();
            textBoxContactID = new TextBox();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxContactNumber = new TextBox();
            labelContactNumber = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            ContactView = new DataGridView();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContactView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(16, 11);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(162, 61);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelContactID
            // 
            labelContactID.AutoSize = true;
            labelContactID.BackColor = Color.Transparent;
            labelContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactID.Location = new Point(42, 121);
            labelContactID.Name = "labelContactID";
            labelContactID.Size = new Size(82, 21);
            labelContactID.TabIndex = 1;
            labelContactID.Text = "Contact ID";
            labelContactID.Click += labelContactID_Click;
            // 
            // textBoxContactID
            // 
            textBoxContactID.Enabled = false;
            textBoxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactID.Location = new Point(176, 113);
            textBoxContactID.Name = "textBoxContactID";
            textBoxContactID.ReadOnly = true;
            textBoxContactID.Size = new Size(166, 29);
            textBoxContactID.TabIndex = 2;
            textBoxContactID.TextChanged += textBoxContactID_TextChanged;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(176, 165);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(166, 29);
            textBoxFirstName.TabIndex = 6;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(42, 173);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(86, 21);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(176, 230);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(166, 29);
            textBoxLastName.TabIndex = 8;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(42, 230);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(84, 21);
            labelLastName.TabIndex = 7;
            labelLastName.Text = "Last Name";
            // 
            // textBoxContactNumber
            // 
            textBoxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactNumber.Location = new Point(176, 282);
            textBoxContactNumber.Name = "textBoxContactNumber";
            textBoxContactNumber.Size = new Size(166, 29);
            textBoxContactNumber.TabIndex = 10;
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.BackColor = Color.Transparent;
            labelContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactNumber.Location = new Point(42, 290);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(91, 21);
            labelContactNumber.TabIndex = 9;
            labelContactNumber.Text = "Contact No.";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(176, 356);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(166, 68);
            textBoxAddress.TabIndex = 12;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(42, 356);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(66, 21);
            labelAddress.TabIndex = 11;
            labelAddress.Text = "Address";
            labelAddress.Click += labelAddress_Click;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.Transparent;
            labelGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(42, 455);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(61, 21);
            labelGender.TabIndex = 13;
            labelGender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Segoe UI", 12F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(176, 457);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(166, 29);
            comboBoxGender.TabIndex = 14;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.ForestGreen;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(290, 549);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 48);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.SteelBlue;
            buttonUpdate.Font = new Font("Segoe UI", 12F);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(431, 549);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(98, 48);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Orange;
            buttonClear.Font = new Font("Segoe UI", 12F);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(730, 549);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(98, 48);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Crimson;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(578, 549);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(98, 48);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // ContactView
            // 
            ContactView.AllowUserToAddRows = false;
            ContactView.AllowUserToDeleteRows = false;
            ContactView.AllowUserToResizeColumns = false;
            ContactView.AllowUserToResizeRows = false;
            ContactView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ContactView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ContactView.Location = new Point(384, 173);
            ContactView.Name = "ContactView";
            ContactView.Size = new Size(643, 321);
            ContactView.TabIndex = 19;
            ContactView.CellContentClick += ContactView_CellContentClick;
            ContactView.RowHeaderMouseClick += ContactView_RowHeaderMouseClick;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 14F);
            labelSearch.Location = new Point(384, 121);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(69, 25);
            labelSearch.TabIndex = 20;
            labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(468, 121);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(327, 29);
            textBoxSearch.TabIndex = 21;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1034, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 652);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(ContactView);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxContactNumber);
            Controls.Add(labelContactNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxContactID);
            Controls.Add(labelContactID);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Econtact";
            Padding = new Padding(30);
            Text = "econtact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContactView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelContactID;
        private TextBox textBoxContactID;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxContactNumber;
        private Label labelContactNumber;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonClear;
        private Button buttonDelete;
        private DataGridView ContactView;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private PictureBox pictureBox2;
    }
}
