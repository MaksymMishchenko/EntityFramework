﻿Задача:
Создать приложение для мобильных телефонов. Приложение должно содержать информацию о торговой марке, стоимость, производителя, страну производителя и штаб-квартиру.

Решение:
+1. Создать следующие модели:
  + MobilePhone со свойствами Id, Name, Cost, Manufacturer;
  + Manufacturer со свойствами Id, Name, Headquarters;
  + Headquarters со свойствами Id, Name, Country;
  + Country со свойствами Id, Name;
+2. Установить в проект EntityFrameworkSqlServer и EntityFrameworkCore.Tools;
+3. Создать класс DbContent и настроить подключение к базе данных;
+4. В DbContent добавить модели MobilePhone, Manufacturer, Country, Headquarters с помощью класса DbSet<> будем получать и устанавливать данные в базу.
+5. Сделать миграцию и апдейт базы;
+6. Добавить несколько телефонов, производителей, стран и штабквартир;
+7. Вытянуть данные из базы данных и вывести на консоль.
+8. Получить список телефонов по производителям используя метод Where() и Load();
+9. Получить весь список телефонов используя метод Load();
+10. Получить список телефонов по производителям используя метод Collection() и Reference();
