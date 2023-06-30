using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace kursovaja
{
    public partial class RecoveryForm : Form
    {
        private string NameBD;
        private string PathBackup;

        public RecoveryForm()
        {
            InitializeComponent();
            addingBD_ComboBox();
        }

        private void addingBD_ComboBox()
        {
            string connectString = "server=localhost;port=3306;username=root;password=mysql;";
            MySqlConnection myConnection = new MySqlConnection(connectString);
            string query = "show databases";
            myConnection.Open();

            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DB_ComboBox.Items.Add(reader.GetString(0));
            }

            reader.Close();
            myConnection.Close();
        }

        private void OkButtonPath_Click(object sender, EventArgs e)
        {
            if (DB_ComboBox.Text == "")
            {
                MessageBox.Show("Не выбрана бд");
                return;
            }

            if (TextBoxPathBackup.Text == "")
            {
                MessageBox.Show("Нет каталога бэкапа");
                return;
            }

            this.PathBackup = TextBoxPathBackup.Text;
            this.NameBD = DB_ComboBox.Text;

            string commands = $@"D:
                                 cd D:\Ampps\mysql\bin
                                 mysqldump -uroot -pmysql --lock-all-tables {NameBD} < {PathBackup}.sql
                                 mysqlcheck -u root -p --auto-repair {NameBD}";
            
            try
            {
                createProcess(commands);
                MessageBox.Show("Восстановление завершено");
            }
            catch
            {
                MessageBox.Show("Ошибка при восстановлении");
            }

            this.Close();
        }

        private void CatalogButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();

            DialogResult result = openFileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextBoxPathBackup.Text = openFileDlg.FileName;
            }
        }

        void createProcess(string commands)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            process.Start();

            using (StreamWriter pWriter = process.StandardInput)
            {
                if (pWriter.BaseStream.CanWrite)
                {
                    foreach (var line in commands.Split('\n'))
                        pWriter.WriteLine(line);
                }
            }
        }
    }
}
