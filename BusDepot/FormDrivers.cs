using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusDepot
{
    public partial class FormDrivers : Form
    {
        public FormDrivers()
        {
            InitializeComponent();
            Main.driversFormClosing = false;
        }

        private void FormDrivers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.driversFormClosing)
            {
                Application.Exit();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show(); // Показываем главную форму
            Main.driversFormClosing = true;
            this.Close();
        }
        private void FormDrivers_Shown(object sender, EventArgs e)
        {
            List<Driver> drivers = new List<Driver>(); // Создаем список объектов типа Drivers
            drivers = Main.connection.MySqlGetDrivers(); // Получаем водителей из бд
            for (int i = 0; i < drivers.Count; i++)
            {
                listBoxDrivers.Items.Add(drivers[i].id + " | " + drivers[i].name + " | " + drivers[i].surname + " | " + drivers[i].experience + " | " + drivers[i].route); // Заполняем листбокс
            }
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            if (!watermarkTextBoxAddName.Visible) // Если текстбокс скрыт
            {
                if (textBoxChangeName.Visible) // Если текстбокс виден
                {
                    MessageBox.Show("Сначала закончите изменение данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    watermarkTextBoxAddName.Visible = true; // Показываем текстбокс для имени
                    watermarkTextBoxAddSurname.Visible = true; // Показываем текстбокс для фамилии
                    watermarkTextBoxAddExperience.Visible = true; // Показываем текстбокс для стажа работы
                    watermarkTextBoxAddRoute.Visible = true; // Показываем текстбокс для маршрута
                }
            }
            else
            {
                if (CheckDataCorrectness(watermarkTextBoxAddName.Text, watermarkTextBoxAddSurname.Text, watermarkTextBoxAddExperience.Text, watermarkTextBoxAddRoute.Text)) // Если данные корректны
                {
                    Driver newDriver = new Driver(); // Создаем объект класса для нового водителя
                    newDriver.name = watermarkTextBoxAddName.Text; // Записываем в него имя
                    newDriver.surname = watermarkTextBoxAddSurname.Text; // Записываем в него фамилию
                    newDriver.experience = Convert.ToInt32(watermarkTextBoxAddExperience.Text); // Записываем в него стаж работы
                    newDriver.route = watermarkTextBoxAddRoute.Text; // Записываем в него маршрут
                    Main.connection.MySqlAdd(newDriver); // Добавляем водителя в таблицу
                    listBoxDrivers.Items.Clear(); // Очищаем листбокс
                    listBoxDrivers.Items.Add("ID | Имя | Фамилия | Стаж работы | Маршрут"); // Добавляем начальное значение
                    List<Driver> drivers = new List<Driver>(); // Создаем список объектов типа Driver
                    drivers = Main.connection.MySqlGetDrivers(); // Получаем обновленный список водителей из бд
                    for (int i = 0; i < drivers.Count; i++)
                    {
                        listBoxDrivers.Items.Add(drivers[i].id + " | " + drivers[i].name + " | " + drivers[i].surname + " | " + drivers[i].experience + " | " + drivers[i].route); // Заполняем листбокс
                    }
                    MessageBox.Show("Водитель добавлен в список.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    watermarkTextBoxAddName.Clear(); // Очищаем текстбокс для имени
                    watermarkTextBoxAddSurname.Clear(); // Очищаем текстбокс для фамилии
                    watermarkTextBoxAddExperience.Clear(); // Очищаем текстбокс для стажа работы
                    watermarkTextBoxAddRoute.Clear(); // Очищаем текстбокс для маршрута
                    watermarkTextBoxAddName.Visible = false; // скрываем текстбокс для имени
                    watermarkTextBoxAddSurname.Visible = false; // скрываем текстбокс для фамилии
                    watermarkTextBoxAddExperience.Visible = false; // скрываем текстбокс для стажа работы
                    watermarkTextBoxAddRoute.Visible = false; // скрываем текстбокс для маршрута
                }
            }
        }

        private bool CheckDataCorrectness(string name, string surname, string experience, string route) // Метод проверки корректности введенных данных
        {
            if (name == "" || surname == "" || experience == "" || route == "") // Проверка на пустые поля ввода данных
            {
                MessageBox.Show("Одно из полей не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (name.Length < 2) // Проверка на длину имени
            {
                MessageBox.Show("Имя не может быть короче 2-х символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (surname.Length < 2) // Проверка на длину фамилии
            {
                MessageBox.Show("Фамилия не может быть короче 2-х символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in experience) // Проверка введенных символов в поле для ввода стажа работы
            {
                if (!Char.IsNumber(c))
                {
                    MessageBox.Show("Стаж работы может состоять только из цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (Convert.ToInt32(experience) > 99) // Проверка на стаж работы
            {
                MessageBox.Show("Стаж работы не может быть больше 99-и", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToInt32(experience) < 0) // Проверка на стаж работы
            {
                MessageBox.Show("Стаж работы не может быть меньше 0-я", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in name) // Проверка введенных символов в поле для ввода имени
            {
                if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Имя может состоять только из букв.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            foreach (char c in surname) // Проверка введенных символов в поле для ввода фамилии
            {
                if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Фамилия может состоять только из букв.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (watermarkTextBoxAddName.Visible || textBoxChangeName.Visible) // Если текстбоксы видно
            {
                MessageBox.Show("Сначала закончите предыдущее действие.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (listBoxDrivers.SelectedIndex == -1) // Если не выбран ни один элемент
                    MessageBox.Show("Вы не выбрали ни одного водителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить выбранного водителя из списка?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Main.connection.MySqlRemove(Main.driver); // Берем выбранного водителя и удаляем из бд
                        listBoxDrivers.Items.RemoveAt(listBoxDrivers.SelectedIndex); // Удаляем водителя из списка
                        MessageBox.Show("Водитель удален из списка.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Удаление водителя из списка отменено.", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void listBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDrivers.SelectedIndex == 0) // Если выбирается первый элемент
            {
                listBoxDrivers.SelectedIndex = -1; // Снимаем с него выделение
                return;
            }
            else
            {
                if (listBoxDrivers.SelectedIndex > 0 && !textBoxChangeName.Visible) // Если выбранный элемент не первая строка
                {
                    string[] data = new string[5]; // Создаем строку для хранения 5-и полей данных
                    data = Convert.ToString(listBoxDrivers.SelectedItem).Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries); // Разбиваем строку полученную из листбокса на слова и записываем в массив
                    Main.driver.id = Convert.ToInt32(data[0]); // Записываем id в поле объекта
                    Main.driver.name = data[1]; // Записываем name в поле объекта
                    Main.driver.surname = data[2]; // Записываем surname в поле объекта
                    Main.driver.experience = Convert.ToInt32(data[3]); // Записываем experience в поле объекта
                    Main.driver.route = data[4]; // Записываем route в поле объекта
                }
            }

        }

        private void buttonChangeData_Click(object sender, EventArgs e)
        {
            if (!textBoxChangeName.Visible) // Если текстбоксы скрыты
            {
                if (watermarkTextBoxAddName.Visible) // Если текстбокс виден
                {
                    MessageBox.Show("Сначала закончите добавление водителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (listBoxDrivers.SelectedIndex == -1) // Если не выбран ни один элемент
                        MessageBox.Show("Вы не выбрали ни одного водителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        textBoxChangeName.Text = Main.driver.name; // Заполняем текстбокс действующим значением name
                        textBoxChangeSurname.Text = Main.driver.surname; // Заполняем текстбокс действующим значением surname
                        textBoxChangeExperience.Text = Convert.ToString(Main.driver.experience); // Заполняем текстбокс действующим значением experience
                        textBoxChangeRoute.Text = Main.driver.route; // Заполняем текстбокс действующим значением route
                        textBoxChangeName.Visible = true; // Показываем текстбокс для имени
                        textBoxChangeSurname.Visible = true; // Показываем текстбокс для фамилии
                        textBoxChangeExperience.Visible = true; // Показываем текстбокс для стажа работы
                        textBoxChangeRoute.Visible = true; // Показываем текстбокс для маршрута
                    }
                }
            }
            else // Если текстбокс не скрыт
            {
                if (CheckDataCorrectness(textBoxChangeName.Text, textBoxChangeSurname.Text, textBoxChangeExperience.Text, textBoxChangeRoute.Text)) // Если данные корректны
                {
                    if (MessageBox.Show("Вы уверены, что хотите изменить данные по выбранному водителю?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Main.driver.name = textBoxChangeName.Text; // Меняем имя на новую в объекте водитель
                        Main.driver.surname = textBoxChangeSurname.Text; // Меняем фамилию на новую в объекте водитель
                        Main.driver.experience = Convert.ToInt32(textBoxChangeExperience.Text); // Меняем стаж работы на новый в объекте водитель
                        Main.driver.route = textBoxChangeRoute.Text; // Меняем маршрут на новый в объекте водитель
                        Main.connection.MySqlChange(Main.driver); // Меняем данные про водителя в списке
                        int i = 0; // Создаем переменную счетчик
                        string driverID = "0"; // Создаем строку которая будет хранить id водителя
                        while (Main.driver.id != Convert.ToInt32(driverID)) // Пока id водителя не равен обновляемому id 
                        {
                            i++; // Инкрементируем переменную
                            driverID = Convert.ToString(listBoxDrivers.Items[i]).Remove(Convert.ToString(listBoxDrivers.Items[i]).IndexOf(' ')); // Перезаписываем переменную новым id
                        }
                        listBoxDrivers.Items[Convert.ToInt32(i)] = Main.driver.id + " | " + Main.driver.name + " | " + Main.driver.surname + " | " + Main.driver.experience + " | " + Main.driver.route; // Записываем обновленные данные в листбокс водителей
                        MessageBox.Show("Данные по выбранному водителю изменены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxChangeName.Clear(); // Очищаем текстбокс для имени
                        textBoxChangeSurname.Clear(); // Очищаем текстбокс для фамилии
                        textBoxChangeExperience.Clear(); // Очищаем текстбокс для стажа работы
                        textBoxChangeRoute.Clear(); // Очищаем текстбокс для маршрута
                        textBoxChangeName.Visible = false; // скрываем текстбокс для имени
                        textBoxChangeSurname.Visible = false; // скрываем текстбокс для фамилии
                        textBoxChangeExperience.Visible = false; // скрываем текстбокс для стажа работы
                        textBoxChangeRoute.Visible = false; // скрываем текстбокс для маршрута
                    }
                    else
                    {
                        MessageBox.Show("Изменение данных выбранного водителя отменено.", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
