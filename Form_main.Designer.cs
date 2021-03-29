
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label genderCodeLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.buttonOpenRedactor = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demo_aprDataSet = new app_School.Demo_aprDataSet();
            this.genderCodeComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientTableAdapter = new app_School.Demo_aprDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new app_School.Demo_aprDataSetTableAdapters.TableAdapterManager();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Удалить = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBoxLIMIT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_birthday = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            genderCodeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_aprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(10, 142);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(73, 19);
            firstNameLabel.TabIndex = 13;
            firstNameLabel.Text = "Фамилия:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(9, 209);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(40, 19);
            lastNameLabel.TabIndex = 14;
            lastNameLabel.Text = "Имя:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(9, 241);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(75, 19);
            patronymicLabel.TabIndex = 15;
            patronymicLabel.Text = "Отчество:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(10, 174);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(75, 19);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Телефон:";
            // 
            // genderCodeLabel
            // 
            genderCodeLabel.AutoSize = true;
            genderCodeLabel.Location = new System.Drawing.Point(10, 59);
            genderCodeLabel.Name = "genderCodeLabel";
            genderCodeLabel.Size = new System.Drawing.Size(43, 19);
            genderCodeLabel.TabIndex = 17;
            genderCodeLabel.Text = "Пол:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(10, 273);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 19);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email:";
            // 
            // buttonOpenRedactor
            // 
            this.buttonOpenRedactor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenRedactor.FlatAppearance.BorderSize = 3;
            this.buttonOpenRedactor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonOpenRedactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenRedactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenRedactor.Location = new System.Drawing.Point(294, 413);
            this.buttonOpenRedactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenRedactor.Name = "buttonOpenRedactor";
            this.buttonOpenRedactor.Size = new System.Drawing.Size(272, 54);
            this.buttonOpenRedactor.TabIndex = 1;
            this.buttonOpenRedactor.Text = "Добавление и  редактирование пользователя\r\n";
            this.buttonOpenRedactor.UseVisualStyleBackColor = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сколько записей показывать?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(946, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Число записей:";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(1090, 235);
            this.label_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(50, 19);
            this.label_count.TabIndex = 10;
            this.label_count.Text = "0 из 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(genderCodeLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.genderCodeComboBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(patronymicLabel);
            this.groupBox1.Controls.Add(this.patronymicTextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(275, 314);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управления";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(103, 270);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(156, 26);
            this.emailTextBox.TabIndex = 21;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged_1);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.demo_aprDataSet;
            // 
            // demo_aprDataSet
            // 
            this.demo_aprDataSet.DataSetName = "Demo_aprDataSet";
            this.demo_aprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genderCodeComboBox
            // 
            this.genderCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "GenderCode", true));
            this.genderCodeComboBox.FormattingEnabled = true;
            this.genderCodeComboBox.Items.AddRange(new object[] {
            "М - мужской",
            "Ж - женский",
            "Все"});
            this.genderCodeComboBox.Location = new System.Drawing.Point(71, 56);
            this.genderCodeComboBox.Name = "genderCodeComboBox";
            this.genderCodeComboBox.Size = new System.Drawing.Size(188, 26);
            this.genderCodeComboBox.TabIndex = 18;
            this.genderCodeComboBox.Text = "Все";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(103, 174);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(156, 26);
            this.phoneTextBox.TabIndex = 17;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged_1);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(103, 238);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(156, 26);
            this.patronymicTextBox.TabIndex = 16;
            this.patronymicTextBox.TextChanged += new System.EventHandler(this.patronymicTextBox_TextChanged_1);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(103, 206);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(156, 26);
            this.lastNameTextBox.TabIndex = 15;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged_1);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(103, 139);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(156, 26);
            this.firstNameTextBox.TabIndex = 14;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Фильтрация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск:";
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
            this.tableAdapterManager.UpdateOrder = app_School.Demo_aprDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.Удалить});
            this.clientDataGridView.DataSource = this.clientBindingSource1;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 12);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(1152, 220);
            this.clientDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn11.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn12.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn13.HeaderText = "Отчесво";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn14.HeaderText = "День рождение";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "RegistrationDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "Дата регистрации";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn16.HeaderText = "Email";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn17.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "GenderCode";
            this.dataGridViewTextBoxColumn18.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // Удалить
            // 
            this.Удалить.HeaderText = "Удалить";
            this.Удалить.Name = "Удалить";
            this.Удалить.Text = "Удалить";
            this.Удалить.ToolTipText = "Удалить";
            this.Удалить.UseColumnTextForButtonValue = true;
            // 
            // comboBoxLIMIT
            // 
            this.comboBoxLIMIT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource1, "GenderCode", true));
            this.comboBoxLIMIT.FormattingEnabled = true;
            this.comboBoxLIMIT.Items.AddRange(new object[] {
            "10",
            "50",
            "200",
            "Все"});
            this.comboBoxLIMIT.Location = new System.Drawing.Point(802, 239);
            this.comboBoxLIMIT.Name = "comboBoxLIMIT";
            this.comboBoxLIMIT.Size = new System.Drawing.Size(69, 26);
            this.comboBoxLIMIT.TabIndex = 19;
            this.comboBoxLIMIT.Text = "Все";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_birthday);
            this.groupBox2.Location = new System.Drawing.Point(293, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 148);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "В этом месяце день рождениие у:";
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Location = new System.Drawing.Point(28, 25);
            this.label_birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(18, 19);
            this.label_birthday.TabIndex = 10;
            this.label_birthday.Text = "0";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxLIMIT);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenRedactor);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_main";
            this.Text = "School";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_aprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenRedactor;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Demo_aprDataSet demo_aprDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private Demo_aprDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private Demo_aprDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewButtonColumn Удалить;
        private System.Windows.Forms.ComboBox genderCodeComboBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox comboBoxLIMIT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}

