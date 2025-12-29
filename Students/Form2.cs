using System;
using System.Windows.Forms;

namespace Students
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Первая запись
            студентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Предыдущая запись
            студентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Добавить новую запись
            студентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Последняя запись
            студентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Следующая запись
            студентыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Удалить текущую запись
            студентыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Сохранить изменения
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Загрузка данных в таблицу Студенты
            this.студентыTableAdapter.Fill(this.studentsDataSet.Студенты);
            // Загрузка данных в таблицу Специальности
            this.специальностиTableAdapter.Fill(this.studentsDataSet.Специальности);
        }
    }
}

