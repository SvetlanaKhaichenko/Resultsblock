# Инструкция к решению задачи
1. *Просим пользователя ввести массив из строк из терминала, через запятую.*
2. *Убираем лишние пробелы в данной строке, и записываем ее в массив.*
3. *Используем метод поиска массива и печати.*

 **В данной задаче использовано два метода:**

 **-Метод поиска массива;**

1. *Заводим счетчик, и проверяем каждый элемент массива. Если длина строки элемента массива меньше либо равна 3, прибавляем к счетчику плюс 1.*
2. *Проверяем счетчик, если после пункта 1, счет остался равным 0, то выводим сообщение "Массив не содержит строк меньше либо равным 3 символам".*
3. *Если пукнт 2 не выполняется, заводим новый массив строк равный массиву, введенному пользователем. И проверяем каждый элемент данного массива, если длина строки элемента массива соответствует условиям записываем ее в новый массив с тем же индексом.*
4. *Возвращаем найденный массив.*

**-Метод печати массива;**
 1. *Первый элемент массива печатаем с квадратной скобкой, при этом проверяем условие: если первый элемент равен NULL, то печатаем только квадратную скобку. Если нет, то печатаем элемент с квадратной скобкой.*
 2. *Те же действия, чо и в 1 пункте проделываем для остальных элементов массива до предпоследнего элемента.*
 3. *если последний элемент равен NULL, то печатаем только квадратную скобку. Если нет, то печатаем элемент с квадратной скобкой.*

