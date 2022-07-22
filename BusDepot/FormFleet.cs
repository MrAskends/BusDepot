using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusDepot
{
    public partial class FormFleet : Form
    {
        public FormFleet()
        {
            InitializeComponent();
            Main.fleetFormClosing = false;
        }

        private void FormFleet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.fleetFormClosing)
            {
                Application.Exit();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show(); // Показываем главную форму
            Main.fleetFormClosing = true;
            this.Close();
        }

        private void FormFleet_Shown(object sender, EventArgs e)
        {
            List<Bus> fleet = new List<Bus>(); // Создаем список объектов типа Bus
            fleet = Main.connection.MySqlGetFleet(); // Получаем автопарк из бд
            for (int i = 0; i < fleet.Count; i++) 
            {
                listBoxFleet.Items.Add(fleet[i].id + " | " + fleet[i].brand + " | " + fleet[i].number + " | " + fleet[i].route); // Заполняем листбокс
            }
        }

        private void buttonAddBus_Click(object sender, EventArgs e)
        {
            if(!watermarkTextBoxAddBrand.Visible) // Если текстбокс скрыт
            {
                if (textBoxChangeBrand.Visible) // Если текстбокс виден
                {
                    MessageBox.Show("Сначала закончите изменение данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    watermarkTextBoxAddBrand.Visible = true; // Показываем текстбокс для бренда
                    watermarkTextBoxAddNumber.Visible = true; // Показываем текстбокс для номера
                    watermarkTextBoxAddRoute.Visible = true; // Показываем текстбокс для маршрута
                }
            }
            else
            {
                if (CheckDataCorrectness(watermarkTextBoxAddBrand.Text, watermarkTextBoxAddNumber.Text, watermarkTextBoxAddRoute.Text)) // Если данные корректны
                {
                    Bus newBus = new Bus(); // Создаем объект класса для нового автобуса
                    newBus.brand = watermarkTextBoxAddBrand.Text; // Записываем в него новую марку
                    newBus.number = watermarkTextBoxAddNumber.Text; // Записываем в него новый номер
                    newBus.route = watermarkTextBoxAddRoute.Text; // Записываем в него новый маршрут
                    Main.connection.MySqlAdd(newBus); // Добавляем автобус в автопарк
                    listBoxFleet.Items.Clear(); // Очищаем листбокс
                    listBoxFleet.Items.Add("ID | Марка | Гос.Номер | Маршрут"); // Добавляем начальное значение
                    List<Bus> fleet = new List<Bus>(); // Создаем список объектов типа Bus
                    fleet = Main.connection.MySqlGetFleet(); // Получаем обновленный автопарк из бд
                    for (int i = 0; i < fleet.Count; i++)
                    {
                        listBoxFleet.Items.Add(fleet[i].id + " | " + fleet[i].brand + " | " + fleet[i].number + " | " + fleet[i].route); // Заполняем листбокс
                    }
                    MessageBox.Show("Автобус добавлен в автопарк.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    watermarkTextBoxAddBrand.Clear(); // Очищаем текстбокс для бренда
                    watermarkTextBoxAddNumber.Clear(); // Очищаем текстбокс для номера
                    watermarkTextBoxAddRoute.Clear(); // Очищаем текстбокс для маршрута
                    watermarkTextBoxAddBrand.Visible = false; // скрываем текстбокс для бренда
                    watermarkTextBoxAddNumber.Visible = false; // скрываем текстбокс для номера
                    watermarkTextBoxAddRoute.Visible = false; // скрываем текстбокс для маршрута
                }
            }
        }

        private bool CheckDataCorrectness(string brand, string number, string route) // Метод проверки корректности введенных данных
        {
            if (brand == "" || number == "" || route == "") // Проверка на пустые поля ввода данных
            {
                MessageBox.Show("Одно из полей не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (brand.Length < 2) // Проверка на длину марки
            {
                MessageBox.Show("Марка не может быть короче 2-х символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (number.Length < 8) // Проверка на длину Гос.Номера
            {
                MessageBox.Show("Гос.Номер не может быть короче 8-и символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in brand) // Проверка введенных символов в поле для ввода марки
            {
                if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Марка может состоять только из букв.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (watermarkTextBoxAddBrand.Visible || textBoxChangeBrand.Visible) // Если текстбоксы видно
            {
                MessageBox.Show("Сначала закончите предыдущее действие.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (listBoxFleet.SelectedIndex == -1) // Если не выбран ни один элемент
                    MessageBox.Show("Вы не выбрали ни один автобус.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить выбранный автобус из автопарка?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Main.connection.MySqlRemove(Main.bus); // Берем выбранный автобус и удаляем из бд
                        listBoxFleet.Items.RemoveAt(listBoxFleet.SelectedIndex); // Удаляем автобус из списка
                        MessageBox.Show("Автобус удален из автопарка.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Удаление автобуса из автопарка отменено.", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void listBoxFleet_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (listBoxFleet.SelectedIndex == 0) // Если выбирается первый элемент
            {
                listBoxFleet.SelectedIndex = -1; // Снимаем с него выделение
                return;
            }
            else
            {
                if (listBoxFleet.SelectedIndex > 0 && !textBoxChangeBrand.Visible) // Если выбранный элемент не первая строка
                {
                    string[] data = new string[4]; // Создаем строку для хранения 4-х полей данных
                    data = Convert.ToString(listBoxFleet.SelectedItem).Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries); // Разбиваем строку полученную из листбокса на слова и записываем в массив
                    Main.bus.id = Convert.ToInt32(data[0]); // Записываем id в поле объекта
                    Main.bus.brand = data[1]; // Записываем brand в поле объекта
                    Main.bus.number = data[2]; // Записываем number в поле объекта
                    Main.bus.route = data[3]; // Записываем route в поле объекта
                }
            }

        }

        private void buttonChangeData_Click(object sender, EventArgs e)
        {
            if (!textBoxChangeBrand.Visible) // Если текстбоксы скрыты
            {
                if (watermarkTextBoxAddBrand.Visible) // Если текстбокс виден
                {
                    MessageBox.Show("Сначала закончите добавление автобуса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (listBoxFleet.SelectedIndex == -1) // Если не выбран ни один элемент
                        MessageBox.Show("Вы не выбрали ни один автобус.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        textBoxChangeBrand.Text = Main.bus.brand; // Заполняем текстбокс действующим значением brand
                        textBoxChangeNumber.Text = Main.bus.number; // Заполняем текстбокс действующим значением nubmer
                        textBoxChangeRoute.Text = Main.bus.route; // Заполняем текстбокс действующим значением route
                        textBoxChangeBrand.Visible = true; // Показываем текстбокс для бренда
                        textBoxChangeNumber.Visible = true; // Показываем текстбокс для номера
                        textBoxChangeRoute.Visible = true; // Показываем текстбокс для маршрута
                    }
                }
            }
            else // Если текстбокс не скрыт
            {
                if (CheckDataCorrectness(textBoxChangeBrand.Text, textBoxChangeNumber.Text, textBoxChangeRoute.Text)) // Если данные корректны
                {
                    if (MessageBox.Show("Вы уверены, что хотите изменить данные по выбранному автобусу?", "Изменение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Main.bus.brand = textBoxChangeBrand.Text; // Меняем бренд на новый в объекте автобус
                        Main.bus.number = textBoxChangeNumber.Text; // Меняем номер на новый в объекте автобус
                        Main.bus.route = textBoxChangeRoute.Text; // Меняем маршрут на новый в объекте автобус
                        Main.connection.MySqlChange(Main.bus); // Меняем данные про автобус в автопарке
                        int i = 0; // Создаем переменную счетчик
                        string busID = "0"; // Создаем строку которая будет хранить id автобуса
                        while (Main.bus.id != Convert.ToInt32(busID)) // Пока id автобуса не равен обновляемому id 
                        {
                            i++; // Инкрементируем переменную
                            busID = Convert.ToString(listBoxFleet.Items[i]).Remove(Convert.ToString(listBoxFleet.Items[i]).IndexOf(' ')); // Перезаписываем переменную новым id
                        }
                        listBoxFleet.Items[Convert.ToInt32(i)] = Main.bus.id + " | " + Main.bus.brand + " | " + Main.bus.number + " | " + Main.bus.route; // Записываем обновленные данные в листбокс автопарка
                        MessageBox.Show("Данные по выбранному автобусу изменены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxChangeBrand.Clear(); // Очищаем текстбокс для бренда
                        textBoxChangeNumber.Clear(); // Очищаем текстбокс для номера
                        textBoxChangeRoute.Clear(); // Очищаем текстбокс для маршрута
                        textBoxChangeBrand.Visible = false; // скрываем текстбокс для бренда
                        textBoxChangeNumber.Visible = false; // скрываем текстбокс для номера
                        textBoxChangeRoute.Visible = false; // скрываем текстбокс для маршрута
                    }
                    else
                    {
                        MessageBox.Show("Изменение данных выбранного автобуса отменено.", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
