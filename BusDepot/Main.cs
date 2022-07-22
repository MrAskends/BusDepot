using System.Collections.Generic;

namespace BusDepot
{
    static class Main
    {

        public static DataBase connection; // Создаем объект класса DataBase

        public static User user; // Создаем объект класса User

        public static Bus bus; // Создаем объект класса Bus

        public static Driver driver; // Создаем объект класса Driver

        public static bool loginFormClosing; // Флаг для отлавливания закрытия окна логина

        public static bool mainFormShowing; // Флаг для отлавливания открытия главного окна

        public static bool mainFormFirstShowing; // Флаг для отлавливания первого открытия главного окна

        public static bool fleetFormClosing; // Флаг для отлавливания закрытия окна автопарка

        public static bool driversFormClosing; // Флаг для отлавливания закрытия окна водителей


        static Main() // Singleton класса
        {
            connection = new DataBase("localhost", 3306, "root", "", "bus_depot");
            user = new User();
            bus = new Bus();
            driver = new Driver();
            loginFormClosing = false;
            mainFormShowing = false;
            mainFormFirstShowing = false;
            fleetFormClosing = false;
            driversFormClosing = false;
        }

    }
}
