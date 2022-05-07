## Итоговая проверочная работа.

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Декомпозиция задачи
1. Формируем водной массив руками пользователя или используется уже заготовленный при старте программы.
2. Находим необходимый размер выходного нового массива исходя из значений имеющегося массива
3. В новый созданный массив присваиваем значения удовлетворяющие условиям поставленной задачи
4. Вывод нового массива в консоль
5. Оптимизация алгоритма с применением методов, рекурсии и т.д. 
6. Тестирование и исправление

Главный алгоритм
Используется цикл for для всех значений имеющегося массива, внутри которого проверяется условие: размер длины значения ячейки имеющегося массива меньше или равно трем и если результат условия удовлетворен, то записываем в новую ячейку нового массива это значение. Значения длины ячейки могут принимать значения от 0 включительно. 
