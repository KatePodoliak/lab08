using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab08
{
    public partial class Form1 : Form
    {
        string str = "", sql;
        public Form1()
        {
            InitializeComponent();
            cmbCommand.Items.Add("Insert");
            cmbCommand.Items.Add("Delete");
            cmbCommand.Items.Add("Update");
            cmbCommand.SelectedIndex = 0;
            textBoxSet.Visible = false;
            textBoxWhere.Visible = false;
            btnDoCmd.Enabled = false;
            btnDoSelect.Enabled = false;
            btnDoJoin.Enabled = false;
        }

        //соединить
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (DBserverUtils.connectingDB(0))
            {
                labelInfo.Text = "Connection...\nConnection successful!\nDatabase: " + DBserverUtils.catalog;
                btnDoCmd.Enabled = true;
                btnDoSelect.Enabled = true;
                btnDoJoin.Enabled = true;
            }
            else
            {
                labelInfo.Text = "Connection...\nConnection failed!\n";
                btnDoCmd.Enabled = false;
                btnDoSelect.Enabled = false;
                btnDoJoin.Enabled = false;
            }
        }
        //отсоединить
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (DBserverUtils.connectingDB(1))
                labelInfo.Text = "Connection failed!\n";
            btnDoCmd.Enabled = false;
            btnDoSelect.Enabled = false;
            btnDoJoin.Enabled = false;
        }

        //выбор команды: добавление, изменение и удаление записи
        private void btnDoCmd_Click(object sender, EventArgs e)
        {
            str = "Input valid parameters!";
            try
            {
                switch (cmbCommand.Text)
                {
                    case "Insert":
                        sql = "INSERT " + textBoxTableCmd.Text + "(" + textBoxFields.Text + ")" + "VALUES(" + textBoxValuesCmd.Text + ")";
                        break;
                    case "Delete":
                        sql = "DELETE FROM " + textBoxTableCmd.Text + " WHERE " + textBoxWhere.Text;
                        break;
                    case "Update":
                        sql = "UPDATE " + textBoxTableCmd.Text + " SET " + textBoxSet.Text + " WHERE " + textBoxWhere.Text;
                        break;
                    default:
                        break;
                }
                SqlConnection conn = DBserverUtils.getDBсonnection();
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                sql = "SELECT" + " * " + "FROM" + " " + textBoxTableCmd.Text;
                DataSet data = DBserverUtils.getData(sql);
                dgwData.DataSource = data.Tables[0];
            }
            catch
            {
                MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //вывод таблицы
        private void btnDoSelect_Click(object sender, EventArgs e)
        {
            str = "Input valid parameters!";
            try
            {
                if (textBoxTable.Text.Length == 0)
                    str = "Input name of table!";
                sql = "SELECT" + " * " + "FROM" + " " + textBoxTable.Text;
                DataSet ds = DBserverUtils.getData(sql);
                dgwData.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //выполнения связывания таблиц
        private void btnDoJoin_Click(object sender, EventArgs e)
        {
            str = "Input valid parameters!";
            try
            {
                sql = "SELECT " + textBoxFieldsJoin.Text + " FROM " + textBoxTable1.Text + " JOIN " + textBoxTable2.Text + " ON " + textBoxON.Text;
                DataSet ds = DBserverUtils.getData(sql);
                dgwData.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //изменение выбора операции
        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCommand.Text)
            {
                case "Insert":
                    label10.Text = "Fields:";
                    label11.Text = "Values:";
                    textBoxFields.Visible = true;
                    textBoxValuesCmd.Visible = true;
                    textBoxSet.Visible = false;
                    textBoxWhere.Visible = false;
                    break;
                case "Delete":
                    label10.Text = "Set:";
                    label11.Text = "Where:";
                    textBoxFields.Visible = false;
                    textBoxValuesCmd.Visible = false;
                    textBoxSet.Visible = true;
                    textBoxWhere.Visible = true;
                    break;
                case "Update":
                    label10.Text = "Set:";
                    label11.Text = "Where:";
                    textBoxFields.Visible = false;
                    textBoxValuesCmd.Visible = false;
                    textBoxSet.Visible = true;
                    textBoxWhere.Visible = true;
                    break;
            }
        }
    }
}
