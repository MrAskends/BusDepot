using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusDepot
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                Main.connection.MySqlOpenConnection(); // Вызывает метод подключения к БД
                Main.connection.MySqlCreateDataBase(); // Вызывает метод создания БД
                Main.connection.MySqlCreateTables(); // Вызывает метод создания таблиц в БД
                Main.mainFormShowing = false;
                FormLogin loginForm = new FormLogin(); // Создание формы для логина
                loginForm.Show(); // Открытие второй формы (Логинига)
                this.Hide(); // Эту форму скрываем
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Выводим сообщение об ошбике
                Application.Exit();
            }
        }

        private void buttonFleet_Click(object sender, EventArgs e)
        {
            FormFleet fleetForm = new FormFleet(); // Создание формы для работы с автопарком
            fleetForm.Show(); // Открытие формы для работы с автопарком
            this.Hide();
        }

        private void buttonDrivers_Click(object sender, EventArgs e)
        {
            FormDrivers driversForm = new FormDrivers(); // Создание формы для работы с водителями
            driversForm.Show(); // Открытие формы для работы с водителями
            this.Hide();
        }
    }
}
