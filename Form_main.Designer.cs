
namespace app_School
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label genderCodeLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.buttonOpenRedactor = new System.Windows.Forms.Button();
            this.sChoolDataSet = new app_School.SChoolDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new app_School.SChoolDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new app_School.SChoolDataSetTableAdapters.TableAdapterManager();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Удалить = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBoxLIMIT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            genderCodeLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sChoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderCodeLabel
            // 
            genderCodeLabel.AutoSize = true;
            genderCodeLabel.Location = new System.Drawing.Point(14, 71);
            genderCodeLabel.Name = "genderCodeLabel";
            genderCodeLabel.Size = new System.Drawing.Size(43, 19);
            genderCodeLabel.TabIndex = 0;
            genderCodeLabel.Text = "Пол:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(319, 54);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(73, 19);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Фамилия:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(320, 92);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(40, 19);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "Имя:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(596, 50);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(75, 19);
            patronymicLabel.TabIndex = 6;
            patronymicLabel.Text = "Отчество:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(319, 138);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(127, 19);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Номер телефона:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(596, 92);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 19);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // buttonOpenRedactor
            // 
            this.buttonOpenRedactor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenRedactor.FlatAppearance.BorderSize = 3;
            this.buttonOpenRedactor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenRedactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenRedactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenRedactor.Location = new System.Drawing.Point(1008, 378);
            this.buttonOpenRedactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenRedactor.Name = "buttonOpenRedactor";
            this.buttonOpenRedactor.Size = new System.Drawing.Size(255, 45);
            this.buttonOpenRedactor.TabIndex = 1;
            this.buttonOpenRedactor.Text = "Добавление и  редактирование";
            this.buttonOpenRedactor.UseVisualStyleBackColor = true;
            this.buttonOpenRedactor.Click += new System.EventHandler(this.buttonOpenRedactor_Click);
            // 
            // sChoolDataSet
            // 
            this.sChoolDataSet.DataSetName = "SChoolDataSet";
            this.sChoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.sChoolDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachedProductTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.DocumentByServiceTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicePhotoTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.TagOfClientTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = app_School.SChoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Удалить});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 14);
            this.clientDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.RowHeadersWidth = 51;
            this.clientDataGridView.RowTemplate.Height = 24;
            this.clientDataGridView.Size = new System.Drawing.Size(1287, 329);
            this.clientDataGridView.TabIndex = 3;
            this.clientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Индификатор";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GenderCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RegistrationDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата регистрации";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // Удалить
            // 
            this.Удалить.HeaderText = "Удалить";
            this.Удалить.MinimumWidth = 6;
            this.Удалить.Name = "Удалить";
            this.Удалить.Text = "Удалить";
            this.Удалить.ToolTipText = "Удалить";
            this.Удалить.UseColumnTextForButtonValue = true;
            this.Удалить.Width = 125;
            // 
            // comboBoxLIMIT
            // 
            this.comboBoxLIMIT.FormattingEnabled = true;
            this.comboBoxLIMIT.Items.AddRange(new object[] {
            "10",
            "50",
            "200",
            "Все"});
            this.comboBoxLIMIT.Location = new System.Drawing.Point(921, 378);
            this.comboBoxLIMIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLIMIT.Name = "comboBoxLIMIT";
            this.comboBoxLIMIT.Size = new System.Drawing.Size(80, 26);
            this.comboBoxLIMIT.TabIndex = 7;
            this.comboBoxLIMIT.Text = "Все";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сколько записей показывать?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1086, 590);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Число записей:";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(1233, 590);
            this.label_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(50, 19);
            this.label_count.TabIndex = 10;
            this.label_count.Text = "0 из 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderCodeComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(patronymicLabel);
            this.groupBox1.Controls.Add(this.patronymicTextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(genderCodeLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 350);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(897, 264);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управления";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // genderCodeComboBox
            // 
            this.genderCodeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Все",
            "М - мужской",
            "Ж - женский"});
            this.genderCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "GenderCode", true));
            this.genderCodeComboBox.FormattingEnabled = true;
            this.genderCodeComboBox.Items.AddRange(new object[] {
            "М - мужской",
            "Ж- женский",
            "Все"});
            this.genderCodeComboBox.Location = new System.Drawing.Point(67, 67);
            this.genderCodeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderCodeComboBox.Name = "genderCodeComboBox";
            this.genderCodeComboBox.Size = new System.Drawing.Size(182, 26);
            this.genderCodeComboBox.TabIndex = 14;
            this.genderCodeComboBox.Text = "Все";
            this.genderCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.genderCodeComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Фильтрация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(698, 89);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(169, 26);
            this.emailTextBox.TabIndex = 11;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(485, 134);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(169, 26);
            this.phoneTextBox.TabIndex = 9;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(700, 47);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(167, 26);
            this.patronymicTextBox.TabIndex = 7;
            this.patronymicTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(423, 89);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(167, 26);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(423, 50);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(167, 26);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(928, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "В этом месяце день рождениие у:";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 629);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLIMIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.buttonOpenRedactor);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_main";
            this.Text = "School";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sChoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenRedactor;
        private SChoolDataSet sChoolDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SChoolDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private SChoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.ComboBox comboBoxLIMIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewButtonColumn Удалить;
        private System.Windows.Forms.ComboBox genderCodeComboBox;
        private System.Windows.Forms.Label label3;
    }
}

