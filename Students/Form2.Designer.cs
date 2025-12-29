namespace Students
{
    partial class Form2
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
            System.Windows.Forms.Label кодСтудентаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label датаРожденияLabel;
            System.Windows.Forms.Label родителиLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортныеДанныеLabel;
            System.Windows.Forms.Label номерЗачёткиLabel;
            System.Windows.Forms.Label датаПоступленияLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label курсLabel;
            System.Windows.Forms.Label кодСпециальностиLabel;
            System.Windows.Forms.Label очнаяФормаОбученияLabel;
            System.Windows.Forms.Label labelTitle;
            this.студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new Students.StudentsDataSet();
            this.кодСтудентаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.датаРожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.родителиComboBox = new System.Windows.Forms.ComboBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.паспортныеДанныеMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.номерЗачёткиMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.датаПоступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.курсNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.кодСпециальностиComboBox = new System.Windows.Forms.ComboBox();
            this.специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.очнаяФормаОбученияCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.студентыTableAdapter = new Students.StudentsDataSetTableAdapters.СтудентыTableAdapter();
            this.специальностиTableAdapter = new Students.StudentsDataSetTableAdapters.СпециальностиTableAdapter();
            this.tableAdapterManager = new Students.StudentsDataSetTableAdapters.TableAdapterManager();
            кодСтудентаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            датаРожденияLabel = new System.Windows.Forms.Label();
            родителиLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортныеДанныеLabel = new System.Windows.Forms.Label();
            номерЗачёткиLabel = new System.Windows.Forms.Label();
            датаПоступленияLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            курсLabel = new System.Windows.Forms.Label();
            кодСпециальностиLabel = new System.Windows.Forms.Label();
            очнаяФормаОбученияLabel = new System.Windows.Forms.Label();
            labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).BeginInit();
            this.студентыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // кодСтудентаLabel
            // 
            кодСтудентаLabel.AutoSize = true;
            кодСтудентаLabel.Location = new System.Drawing.Point(30, 120);
            кодСтудентаLabel.Name = "кодСтудентаLabel";
            кодСтудентаLabel.Size = new System.Drawing.Size(75, 13);
            кодСтудентаLabel.TabIndex = 1;
            кодСтудентаLabel.Text = "Код студента:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(30, 150);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(30, 180);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 5;
            полLabel.Text = "Пол:";
            // 
            // датаРожденияLabel
            // 
            датаРожденияLabel.AutoSize = true;
            датаРожденияLabel.Location = new System.Drawing.Point(30, 210);
            датаРожденияLabel.Name = "датаРожденияLabel";
            датаРожденияLabel.Size = new System.Drawing.Size(89, 13);
            датаРожденияLabel.TabIndex = 7;
            датаРожденияLabel.Text = "Дата рождения:";
            // 
            // родителиLabel
            // 
            родителиLabel.AutoSize = true;
            родителиLabel.Location = new System.Drawing.Point(30, 240);
            родителиLabel.Name = "родителиLabel";
            родителиLabel.Size = new System.Drawing.Size(56, 13);
            родителиLabel.TabIndex = 9;
            родителиLabel.Text = "Родители:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(30, 270);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 11;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(30, 300);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 13;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортныеДанныеLabel
            // 
            паспортныеДанныеLabel.AutoSize = true;
            паспортныеДанныеLabel.Location = new System.Drawing.Point(30, 330);
            паспортныеДанныеLabel.Name = "паспортныеДанныеLabel";
            паспортныеДанныеLabel.Size = new System.Drawing.Size(110, 13);
            паспортныеДанныеLabel.TabIndex = 15;
            паспортныеДанныеLabel.Text = "Паспортные данные:";
            // 
            // номерЗачёткиLabel
            // 
            номерЗачёткиLabel.AutoSize = true;
            номерЗачёткиLabel.Location = new System.Drawing.Point(30, 360);
            номерЗачёткиLabel.Name = "номерЗачёткиLabel";
            номерЗачёткиLabel.Size = new System.Drawing.Size(82, 13);
            номерЗачёткиLabel.TabIndex = 17;
            номерЗачёткиLabel.Text = "Номер зачётки:";
            // 
            // датаПоступленияLabel
            // 
            датаПоступленияLabel.AutoSize = true;
            датаПоступленияLabel.Location = new System.Drawing.Point(30, 390);
            датаПоступленияLabel.Name = "датаПоступленияLabel";
            датаПоступленияLabel.Size = new System.Drawing.Size(99, 13);
            датаПоступленияLabel.TabIndex = 19;
            датаПоступленияLabel.Text = "Дата поступления:";
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(30, 420);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(45, 13);
            группаLabel.TabIndex = 21;
            группаLabel.Text = "Группа:";
            // 
            // курсLabel
            // 
            курсLabel.AutoSize = true;
            курсLabel.Location = new System.Drawing.Point(30, 450);
            курсLabel.Name = "курсLabel";
            курсLabel.Size = new System.Drawing.Size(35, 13);
            курсLabel.TabIndex = 23;
            курсLabel.Text = "Курс:";
            // 
            // кодСпециальностиLabel
            // 
            кодСпециальностиLabel.AutoSize = true;
            кодСпециальностиLabel.Location = new System.Drawing.Point(30, 480);
            кодСпециальностиLabel.Name = "кодСпециальностиLabel";
            кодСпециальностиLabel.Size = new System.Drawing.Size(103, 13);
            кодСпециальностиLabel.TabIndex = 25;
            кодСпециальностиLabel.Text = "Код специальности:";
            // 
            // очнаяФормаОбученияLabel
            // 
            очнаяФормаОбученияLabel.AutoSize = true;
            очнаяФормаОбученияLabel.Location = new System.Drawing.Point(30, 510);
            очнаяФормаОбученияLabel.Name = "очнаяФормаОбученияLabel";
            очнаяФормаОбученияLabel.Size = new System.Drawing.Size(127, 13);
            очнаяФормаОбученияLabel.TabIndex = 27;
            очнаяФормаОбученияLabel.Text = "Очная форма обучения:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelTitle.Location = new System.Drawing.Point(200, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(350, 36);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Таблица Bashkirov Студенты";
            // 
            // студентыBindingNavigator
            // 
            this.студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентыBindingNavigator.BindingSource = this.студентыBindingSource;
            this.студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem});
            this.студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентыBindingNavigator.Name = "студентыBindingNavigator";
            this.студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентыBindingNavigator.Size = new System.Drawing.Size(900, 25);
            this.студентыBindingNavigator.TabIndex = 0;
            this.студентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Позиция";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущая позиция";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кодСтудентаTextBox
            // 
            this.кодСтудентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Код студента", true));
            this.кодСтудентаTextBox.Location = new System.Drawing.Point(150, 117);
            this.кодСтудентаTextBox.Name = "кодСтудентаTextBox";
            this.кодСтудентаTextBox.ReadOnly = true;
            this.кодСтудентаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодСтудентаTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(150, 147);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Пол", true));
            this.полComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.полComboBox.Location = new System.Drawing.Point(150, 177);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(200, 21);
            this.полComboBox.TabIndex = 6;
            // 
            // датаРожденияDateTimePicker
            // 
            this.датаРожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата рождения", true));
            this.датаРожденияDateTimePicker.Location = new System.Drawing.Point(150, 207);
            this.датаРожденияDateTimePicker.Name = "датаРожденияDateTimePicker";
            this.датаРожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаРожденияDateTimePicker.TabIndex = 8;
            // 
            // родителиComboBox
            // 
            this.родителиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Родители", true));
            this.родителиComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.родителиComboBox.FormattingEnabled = true;
            this.родителиComboBox.Items.AddRange(new object[] {
            "Отец и Мать",
            "Мать",
            "Отец",
            "Нет"});
            this.родителиComboBox.Location = new System.Drawing.Point(150, 237);
            this.родителиComboBox.Name = "родителиComboBox";
            this.родителиComboBox.Size = new System.Drawing.Size(200, 21);
            this.родителиComboBox.TabIndex = 10;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(150, 267);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(200, 20);
            this.адресTextBox.TabIndex = 12;
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(150, 297);
            this.телефонMaskedTextBox.Mask = "+7(000)000-00-00";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.телефонMaskedTextBox.TabIndex = 14;
            // 
            // паспортныеДанныеMaskedTextBox
            // 
            this.паспортныеДанныеMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Паспортные данные", true));
            this.паспортныеДанныеMaskedTextBox.Location = new System.Drawing.Point(150, 327);
            this.паспортныеДанныеMaskedTextBox.Mask = "0000-000000";
            this.паспортныеДанныеMaskedTextBox.Name = "паспортныеДанныеMaskedTextBox";
            this.паспортныеДанныеMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.паспортныеДанныеMaskedTextBox.TabIndex = 16;
            // 
            // номерЗачёткиMaskedTextBox
            // 
            this.номерЗачёткиMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Номер зачётки", true));
            this.номерЗачёткиMaskedTextBox.Location = new System.Drawing.Point(150, 357);
            this.номерЗачёткиMaskedTextBox.Mask = "00000";
            this.номерЗачёткиMaskedTextBox.Name = "номерЗачёткиMaskedTextBox";
            this.номерЗачёткиMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.номерЗачёткиMaskedTextBox.TabIndex = 18;
            // 
            // датаПоступленияDateTimePicker
            // 
            this.датаПоступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата поступления", true));
            this.датаПоступленияDateTimePicker.Location = new System.Drawing.Point(150, 387);
            this.датаПоступленияDateTimePicker.Name = "датаПоступленияDateTimePicker";
            this.датаПоступленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаПоступленияDateTimePicker.TabIndex = 20;
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(150, 417);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(200, 20);
            this.группаTextBox.TabIndex = 22;
            // 
            // курсNumericUpDown
            // 
            this.курсNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Курс", true));
            this.курсNumericUpDown.Location = new System.Drawing.Point(150, 447);
            this.курсNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.курсNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.курсNumericUpDown.Name = "курсNumericUpDown";
            this.курсNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.курсNumericUpDown.TabIndex = 24;
            this.курсNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // кодСпециальностиComboBox
            // 
            this.кодСпециальностиComboBox.DataSource = this.специальностиBindingSource;
            this.кодСпециальностиComboBox.DisplayMember = "Наименование специальности";
            this.кодСпециальностиComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.кодСпециальностиComboBox.FormattingEnabled = true;
            this.кодСпециальностиComboBox.Location = new System.Drawing.Point(150, 477);
            this.кодСпециальностиComboBox.Name = "кодСпециальностиComboBox";
            this.кодСпециальностиComboBox.Size = new System.Drawing.Size(200, 21);
            this.кодСпециальностиComboBox.TabIndex = 26;
            this.кодСпециальностиComboBox.ValueMember = "Код специальности";
            this.кодСпециальностиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.студентыBindingSource, "Код специальности", true));
            // 
            // специальностиBindingSource
            // 
            this.специальностиBindingSource.DataMember = "Специальности";
            this.специальностиBindingSource.DataSource = this.studentsDataSet;
            // 
            // очнаяФормаОбученияCheckBox
            // 
            this.очнаяФормаОбученияCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.студентыBindingSource, "Очная форма обучения", true));
            this.очнаяФормаОбученияCheckBox.Location = new System.Drawing.Point(180, 507);
            this.очнаяФормаОбученияCheckBox.Name = "очнаяФормаОбученияCheckBox";
            this.очнаяФормаОбученияCheckBox.Size = new System.Drawing.Size(200, 24);
            this.очнаяФормаОбученияCheckBox.TabIndex = 28;
            this.очнаяФормаОбученияCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 30;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 35);
            this.button3.TabIndex = 31;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 35);
            this.button4.TabIndex = 32;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 35);
            this.button5.TabIndex = 33;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(600, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 35);
            this.button6.TabIndex = 34;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(600, 390);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 35);
            this.button7.TabIndex = 35;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // специальностиTableAdapter
            // 
            this.специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.СпециальностиTableAdapter = this.специальностиTableAdapter;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            this.tableAdapterManager.UpdateOrder = Students.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(labelTitle);
            this.Controls.Add(кодСтудентаLabel);
            this.Controls.Add(this.кодСтудентаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полComboBox);
            this.Controls.Add(датаРожденияLabel);
            this.Controls.Add(this.датаРожденияDateTimePicker);
            this.Controls.Add(родителиLabel);
            this.Controls.Add(this.родителиComboBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонMaskedTextBox);
            this.Controls.Add(паспортныеДанныеLabel);
            this.Controls.Add(this.паспортныеДанныеMaskedTextBox);
            this.Controls.Add(номерЗачёткиLabel);
            this.Controls.Add(this.номерЗачёткиMaskedTextBox);
            this.Controls.Add(датаПоступленияLabel);
            this.Controls.Add(this.датаПоступленияDateTimePicker);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(курсLabel);
            this.Controls.Add(this.курсNumericUpDown);
            this.Controls.Add(кодСпециальностиLabel);
            this.Controls.Add(this.кодСпециальностиComboBox);
            this.Controls.Add(очнаяФормаОбученияLabel);
            this.Controls.Add(this.очнаяФормаОбученияCheckBox);
            this.Controls.Add(this.студентыBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).EndInit();
            this.студентыBindingNavigator.ResumeLayout(false);
            this.студентыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.специальностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingNavigator студентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.TextBox кодСтудентаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.DateTimePicker датаРожденияDateTimePicker;
        private System.Windows.Forms.ComboBox родителиComboBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox паспортныеДанныеMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox номерЗачёткиMaskedTextBox;
        private System.Windows.Forms.DateTimePicker датаПоступленияDateTimePicker;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.NumericUpDown курсNumericUpDown;
        private System.Windows.Forms.ComboBox кодСпециальностиComboBox;
        private System.Windows.Forms.BindingSource специальностиBindingSource;
        private System.Windows.Forms.CheckBox очнаяФормаОбученияCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private StudentsDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private StudentsDataSetTableAdapters.СпециальностиTableAdapter специальностиTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

