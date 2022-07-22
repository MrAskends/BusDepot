using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BusDepot
{
    class DataBase
    {
        public string host { get; set; } // Поле для хранения Хоста
        public int port { get; set; } // Поле для хранения Порта
        public string userName { get; set; } // Поле для хранения Имени пользователя (БД)
        public string password { get; set; } // Поле для хранения Пароля пользователя (БД)
        public string dbName { get; set; } // Поле для хранения Названия БД

        public MySqlConnection connection; // Объект класса mysql

        public DataBase(string host, int port, string userName, string password, string dbName) // Конструктор класса
        {
            this.host = host;
            this.port = port;
            this.userName = userName;
            this.password = password;
            this.dbName = dbName;
            this.connection = new MySqlConnection("server=" + host + ";port=" + password + ";userName=" + userName + ";password=" + password);
        }

        public void MySqlOpenConnection() // Метод подключения к БД
        {
            if (this.connection.State == System.Data.ConnectionState.Closed) // Если не мы подключены к БД
            {
                connection.Open(); // То подключаемся
            }
        }

        public void MySqlCloseConnection() // Метод отключения от БД
        {
            if (this.connection.State == System.Data.ConnectionState.Open) // Если мы подключены к БД
                connection.Close(); // То отключаемся
        }

        public void MySqlCreateDataBase() // Метод создания БД
        {
            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bus_depot", connection); // Команда создания БД, если она еще не создана
            cmd.ExecuteNonQuery(); // Выполнение команды
            connection.ChangeDatabase(dbName); // Выбор БД с которой будет работать программа
        }
        public void MySqlCreateTables() // Метод создания таблиц в БД
        {
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS drivers (" +
                "id integer not null auto_increment primary key," +
                "name text not null," +
                "surname text not null," +
                "experience integer not null," +
                "route text not null" +
                ")", connection); // Команда создания таблицы водителей, если она еще не создана
            cmd.ExecuteNonQuery(); // Выполнение команды
            cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS fleet (" +
                "id integer not null auto_increment primary key," +
                "brand text not null," +
                "number text not null," +
                "route text not null" +
                ")", connection); // Команда создания таблицы автопарка, если она еще не создана
            cmd.ExecuteNonQuery(); // Выполнение команды
        }

        public bool MySqlLoginUser(User user) // Метод логининга пользователя
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM logistician WHERE login=@uL AND password=@uP", connection); // Команда поиска пользователя в БД
            cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = user.login; // Замена параметра @uL в команде
            cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = user.password; // Замена параметра @uP в команде 
            MySqlDataReader reader = cmd.ExecuteReader(); // Создание ридера, который получает ответ от БД
            if (reader.HasRows) // Если ответ имеет строки то
            {
                reader.Read(); // Считываем строку
                user.userid = Convert.ToInt32(reader.GetValue(0)); // Заполнение поля userid из полученной строки
                user.login = Convert.ToString(reader.GetValue(1)); // Заполнение поля login из полученной строки
                user.password = ""; // Очищаем пароль, чтобы не хранить его в оперативной памяти
                reader.Close(); // Закрытие запроса
                return true; // Пользователь найден
            }
            else
            {
                reader.Close(); // Закрытие запроса
                return false; // Пользователь не найден
            }
        }

        public List<Bus> MySqlGetFleet() // Метод получения автопарка из БД
        {
            List<Bus> fleet = new List<Bus>(); // Создаем список объектов типа Bus 
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM fleet", connection); // Команда получения автопарка из БД
            MySqlDataReader reader = cmd.ExecuteReader(); // Создание ридера, который получает ответ от БД
            while (reader.Read()) // Считываем строки
            {
                Bus tmpBus = new Bus(); // Создаем объект класса типа Bus
                tmpBus.id = Convert.ToInt32(reader.GetValue(0)); // Записываем id полученного автобуса
                tmpBus.brand = Convert.ToString(reader.GetValue(1)); // Записываем brand полученного автобуса
                tmpBus.number = Convert.ToString(reader.GetValue(2)); // Записываем number полученного автобуса
                tmpBus.route = Convert.ToString(reader.GetValue(3)); // Записываем route полученного автобуса
                fleet.Add(tmpBus); // Добавляем автобус в список автопарка
            }
            reader.Close(); // Закрытие запроса
            return fleet; // Возвращаем полученный список
        }

        public List<Driver> MySqlGetDrivers() // Метод получения водителей из БД
        {
            List<Driver> drivers = new List<Driver>(); // Создаем список объектов типа Driver 
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Drivers", connection); // Команда получения водителей из БД
            MySqlDataReader reader = cmd.ExecuteReader(); // Создание ридера, который получает ответ от БД
            while (reader.Read()) // Считываем строки
            {
                Driver tmpDriver = new Driver(); // Создаем объект класса типа Driver
                tmpDriver.id = Convert.ToInt32(reader.GetValue(0)); // Записываем id полученного автобуса
                tmpDriver.name = Convert.ToString(reader.GetValue(1)); // Записываем name полученного автобуса
                tmpDriver.surname = Convert.ToString(reader.GetValue(2)); // Записываем surname полученного автобуса
                tmpDriver.experience = Convert.ToInt32(reader.GetValue(3)); // Записываем experience полученного автобуса
                tmpDriver.route = Convert.ToString(reader.GetValue(4)); // Записываем route полученного автобуса
                drivers.Add(tmpDriver); // Добавляем автобус в список автопарка
            }
            reader.Close(); // Закрытие запроса
            return drivers; // Возвращаем полученный список
        }

        public void MySqlAdd(Bus newBus) // Метод вставки автобуса в автопарк
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fleet (brand, number, route) VALUES (@bB, @bN, @bR)", connection); // Команда добавления нового автобуса в таблицу
            cmd.Parameters.Add("@bB", MySqlDbType.VarChar).Value = newBus.brand; // Замена параметра @bB в команде
            cmd.Parameters.Add("@bN", MySqlDbType.VarChar).Value = newBus.number; // Замена параметра @bN в команде
            cmd.Parameters.Add("@bR", MySqlDbType.VarChar).Value = newBus.route; // Замена параметра @bR в команде
            cmd.ExecuteNonQuery(); // Выполнение команды
        }

        public void MySqlAdd(Driver newDriver) // Метод вставки водителя в таблицу
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO drivers (name, surname, experience, route) VALUES (@dN, @dSN, @dE, @dR)", connection); // Команда добавления нового водителя в таблицу
            cmd.Parameters.Add("@dN", MySqlDbType.VarChar).Value = newDriver.name; // Замена параметра @dN в команде
            cmd.Parameters.Add("@dSN", MySqlDbType.VarChar).Value = newDriver.surname; // Замена параметра @dSN в команде
            cmd.Parameters.Add("@dE", MySqlDbType.Int32).Value = newDriver.experience; // Замена параметра @dE в команде
            cmd.Parameters.Add("@dR", MySqlDbType.VarChar).Value = newDriver.route; // Замена параметра @dR в команде
            cmd.ExecuteNonQuery(); // Выполнение команды
        }

        public void MySqlRemove(Bus deletedBus) // Метод удаления автобуса из автопарка
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM fleet WHERE id=@bID", connection); // Команда удаления автобуса из автопарка
            cmd.Parameters.Add("@bID", MySqlDbType.Int32).Value = deletedBus.id; // Замена параметра @bID в команде
            cmd.ExecuteNonQuery(); // Выполнение команды
        }

        public void MySqlRemove(Driver deletedDriver) // Метод удаления Водителя из таблицы
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM drivers WHERE id=@dID", connection); // Команда удаления водителя из таблицы
            cmd.Parameters.Add("@dID", MySqlDbType.Int32).Value = deletedDriver.id; // Замена параметра @dID в команде
            cmd.ExecuteNonQuery(); // Выполнение команды
        }

        public void MySqlChange(Bus newDataBus) // Метод изменения данных автобуса в таблице
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE fleet SET brand=@bB, number=@bN, route=@bR WHERE id=@bID", connection); // Команда изменения данных автобуса в таблице
            cmd.Parameters.Add("@bB", MySqlDbType.VarChar).Value = newDataBus.brand; // Замена параметра @bB в команде
            cmd.Parameters.Add("@bN", MySqlDbType.VarChar).Value = newDataBus.number; // Замена параметра @bN в команде
            cmd.Parameters.Add("@bR", MySqlDbType.VarChar).Value = newDataBus.route; // Замена параметра @bR в команде
            cmd.Parameters.Add("@bID", MySqlDbType.Int32).Value = newDataBus.id; // Замена параметра @bID в команде
            cmd.ExecuteNonQuery(); // Выполнение команды
        }

        public void MySqlChange(Driver newDataDriver) // Метод изменения данных водителя в таблице
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE drivers SET name=@dN, surname=@dSN, experience=@dE, route=@dR WHERE id=@dID", connection); // Команда изменения данных водителя в таблице
            cmd.Parameters.Add("@dN", MySqlDbType.VarChar).Value = newDataDriver.name; // Замена параметра @dN в команде
            cmd.Parameters.Add("@dSN", MySqlDbType.VarChar).Value = newDataDriver.surname; // Замена параметра @dSN в команде
            cmd.Parameters.Add("@dE", MySqlDbType.Int32).Value = newDataDriver.experience; // Замена параметра @dE в команде
            cmd.Parameters.Add("@dR", MySqlDbType.VarChar).Value = newDataDriver.route; // Замена параметра @dR в команде
            cmd.Parameters.Add("@dID", MySqlDbType.Int32).Value = newDataDriver.id; // Замена параметра @dID в команде
            cmd.ExecuteNonQuery(); // Выполнение команды
        }

    }
}
