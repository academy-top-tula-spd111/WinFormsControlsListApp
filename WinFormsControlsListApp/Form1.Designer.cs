namespace WinFormsControlsListApp
{
    partial class Form1
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
            this.listCities = new System.Windows.Forms.ListBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnDelCity = new System.Windows.Forms.Button();
            this.btnShowSelections = new System.Windows.Forms.Button();
            this.listSelections = new System.Windows.Forms.ListBox();
            this.cmbPhones = new System.Windows.Forms.ComboBox();
            this.btnShowChecks = new System.Windows.Forms.Button();
            this.chkBoxCities = new System.Windows.Forms.CheckedListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listCities
            // 
            this.listCities.FormattingEnabled = true;
            this.listCities.ItemHeight = 15;
            this.listCities.Location = new System.Drawing.Point(12, 12);
            this.listCities.Name = "listCities";
            this.listCities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCities.Size = new System.Drawing.Size(213, 214);
            this.listCities.TabIndex = 0;
            this.listCities.SelectedIndexChanged += new System.EventHandler(this.listCities_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(264, 12);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(227, 23);
            this.txtCity.TabIndex = 1;
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(372, 51);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(119, 23);
            this.btnAddCity.TabIndex = 2;
            this.btnAddCity.Text = "Add";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnDelCity
            // 
            this.btnDelCity.Location = new System.Drawing.Point(372, 203);
            this.btnDelCity.Name = "btnDelCity";
            this.btnDelCity.Size = new System.Drawing.Size(119, 23);
            this.btnDelCity.TabIndex = 2;
            this.btnDelCity.Text = "Delete";
            this.btnDelCity.UseVisualStyleBackColor = true;
            this.btnDelCity.Click += new System.EventHandler(this.btnDelCity_Click);
            // 
            // btnShowSelections
            // 
            this.btnShowSelections.Location = new System.Drawing.Point(372, 243);
            this.btnShowSelections.Name = "btnShowSelections";
            this.btnShowSelections.Size = new System.Drawing.Size(119, 23);
            this.btnShowSelections.TabIndex = 2;
            this.btnShowSelections.Text = "Show";
            this.btnShowSelections.UseVisualStyleBackColor = true;
            this.btnShowSelections.Click += new System.EventHandler(this.btnShowSelections_Click);
            // 
            // listSelections
            // 
            this.listSelections.FormattingEnabled = true;
            this.listSelections.ItemHeight = 15;
            this.listSelections.Location = new System.Drawing.Point(13, 243);
            this.listSelections.Name = "listSelections";
            this.listSelections.Size = new System.Drawing.Size(212, 184);
            this.listSelections.TabIndex = 3;
            // 
            // cmbPhones
            // 
            this.cmbPhones.DropDownHeight = 300;
            this.cmbPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhones.DropDownWidth = 50;
            this.cmbPhones.FormattingEnabled = true;
            this.cmbPhones.IntegralHeight = false;
            this.cmbPhones.Location = new System.Drawing.Point(545, 12);
            this.cmbPhones.MaxDropDownItems = 2;
            this.cmbPhones.Name = "cmbPhones";
            this.cmbPhones.Size = new System.Drawing.Size(243, 23);
            this.cmbPhones.Sorted = true;
            this.cmbPhones.TabIndex = 4;
            // 
            // btnShowChecks
            // 
            this.btnShowChecks.Location = new System.Drawing.Point(669, 243);
            this.btnShowChecks.Name = "btnShowChecks";
            this.btnShowChecks.Size = new System.Drawing.Size(119, 23);
            this.btnShowChecks.TabIndex = 5;
            this.btnShowChecks.Text = "Show Cheks";
            this.btnShowChecks.UseVisualStyleBackColor = true;
            this.btnShowChecks.Click += new System.EventHandler(this.btnShowChecks_Click);
            // 
            // chkBoxCities
            // 
            this.chkBoxCities.CheckOnClick = true;
            this.chkBoxCities.FormattingEnabled = true;
            this.chkBoxCities.Location = new System.Drawing.Point(545, 68);
            this.chkBoxCities.MultiColumn = true;
            this.chkBoxCities.Name = "chkBoxCities";
            this.chkBoxCities.Size = new System.Drawing.Size(243, 130);
            this.chkBoxCities.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(371, 306);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(518, 306);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 23);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chkBoxCities);
            this.Controls.Add(this.btnShowChecks);
            this.Controls.Add(this.cmbPhones);
            this.Controls.Add(this.listSelections);
            this.Controls.Add(this.btnShowSelections);
            this.Controls.Add(this.btnDelCity);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.listCities);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listCities;
        private TextBox txtCity;
        private Button btnAddCity;
        private Button btnDelCity;
        private Button btnShowSelections;
        private ListBox listSelections;
        private ComboBox cmbPhones;
        private Button btnShowChecks;
        private CheckedListBox chkBoxCities;
        private NumericUpDown numericUpDown1;
        private DomainUpDown domainUpDown1;
    }
}