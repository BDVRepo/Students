using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Students;

namespace Students.StudentsDataSetTableAdapters
{
    public partial class СпециальностиTableAdapter
    {
        private string _connectionString;

        public СпециальностиTableAdapter()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["StudentsConnectionString"].ConnectionString;
        }

        public bool ClearBeforeFill { get; set; } = true;

        private SqlConnection _connection;
        public object Connection 
        { 
            get 
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(_connectionString);
                }
                return _connection;
            }
            private set { _connection = value as SqlConnection; }
        }

        public virtual int Fill(Students.StudentsDataSet.СпециальностиDataTable dataTable)
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
            }
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM [Специальности]", _connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (ClearBeforeFill)
            {
                dataTable.Clear();
            }
            int returnValue = adapter.Fill(dataTable);
            return returnValue;
        }

        public virtual int Update(Students.StudentsDataSet.СпециальностиDataTable dataTable)
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
            }
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("SELECT * FROM [Специальности]", _connection);
            
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();

            return adapter.Update(dataTable);
        }
    }
}

