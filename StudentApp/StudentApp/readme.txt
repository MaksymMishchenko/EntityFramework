﻿Задача:
Создать приложение, в котором студенты могут содержать список нескольких курсов, а курсы могут содержать список несколько студентов.
Создать модели таким образом, чтобы между сущностями установилась связь отношения многие к многим.

Решение:
+1. Установить EntityFramework.Core.SqlServer и EntityFramework.CoreTools;
+2. Создать модели сущностей;
+3. Создать класс контекста и подключиться к базе данных;
+4. Выполнить миграцию и апдейт;
+5. Добавить несколько студентов и курсов;
+6. Сформировать запрос получения всех студентов по определенному курсу;
+7. Сформировать запрос получения всех курсов со списком студентов;
+8. Вывести на консоль;
+9. Изменить курс у студента и сохранить изменения.
+10. Вывести информацию о курсе студента после изменения.
+11. Изменить курс у студента Alex;
+12. Удалить пользователя Boris из базы данных;
-13. Добавить в промежуточную таблицу и внести возможность добавления оценки и даты зачисления на курс студента;