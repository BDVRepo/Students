using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            try
            {
                this.Validate();
                this.студентыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.studentsDataSet);
                MessageBox.Show("Изменения успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                // Обработка ошибок базы данных
                if (sqlEx.Message.Contains("FK_Оценки_Студенты") || sqlEx.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show(
                        "Невозможно удалить студента, так как у него есть связанные записи в таблице 'Оценки'.\n\n" +
                        "Сначала удалите все оценки этого студента, а затем попробуйте удалить студента снова.",
                        "Ошибка удаления",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Ошибка при сохранении данных:\n\n" + sqlEx.Message,
                        "Ошибка базы данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Произошла ошибка при сохранении:\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

