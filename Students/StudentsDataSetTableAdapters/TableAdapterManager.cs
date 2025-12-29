using System;
using System.Data;
using System.Data.SqlClient;

namespace Students.StudentsDataSetTableAdapters
{
    public partial class TableAdapterManager
    {
        public СтудентыTableAdapter СтудентыTableAdapter { get; set; }
        public СпециальностиTableAdapter СпециальностиTableAdapter { get; set; }
        public bool BackupDataSetBeforeUpdate { get; set; } = false;

        public enum UpdateOrderOption
        {
            InsertUpdateDelete = 0,
            UpdateInsertDelete = 1
        }

        public UpdateOrderOption UpdateOrder { get; set; } = UpdateOrderOption.InsertUpdateDelete;

        public virtual int UpdateAll(Students.StudentsDataSet dataSet)
        {
            if (dataSet == null)
            {
                throw new ArgumentNullException("dataSet");
            }
            if (dataSet.HasChanges() == false)
            {
                return 0;
            }

            string connectionString = null;
            if ((this.СтудентыTableAdapter != null) && (this.СтудентыTableAdapter.Connection == null))
            {
                throw new ArgumentException("Все адаптеры TableAdapterManager должны использовать одну и ту же строку подключения.");
            }
            if ((this.СтудентыTableAdapter != null) && (this.СтудентыTableAdapter.Connection != null))
            {
                connectionString = ((System.Data.SqlClient.SqlConnection)this.СтудентыTableAdapter.Connection).ConnectionString;
            }
            if ((this.СпециальностиTableAdapter != null) && (this.СпециальностиTableAdapter.Connection == null))
            {
                throw new ArgumentException("Все адаптеры TableAdapterManager должны использовать одну и ту же строку подключения.");
            }
            if ((this.СпециальностиTableAdapter != null) && (this.СпециальностиTableAdapter.Connection != null))
            {
                string specialityConnectionString = ((System.Data.SqlClient.SqlConnection)this.СпециальностиTableAdapter.Connection).ConnectionString;
                if (connectionString != null && connectionString != specialityConnectionString)
                {
                    throw new ArgumentException("Все адаптеры TableAdapterManager должны использовать одну и ту же строку подключения.");
                }
            }

            Students.StudentsDataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate)
            {
                backupDataSet = new Students.StudentsDataSet();
                backupDataSet.Merge(dataSet);
            }

            try
            {
                if ((this.СтудентыTableAdapter != null))
                {
                    this.СтудентыTableAdapter.Update(dataSet.Студенты);
                }
                if ((this.СпециальностиTableAdapter != null))
                {
                    this.СпециальностиTableAdapter.Update(dataSet.Специальности);
                }
                return 0;
            }
            catch (System.Exception updateException)
            {
                if (this.BackupDataSetBeforeUpdate)
                {
                    if (backupDataSet != null)
                    {
                        dataSet.Clear();
                        dataSet.Merge(backupDataSet);
                    }
                }
                throw updateException;
            }
        }
    }
}

