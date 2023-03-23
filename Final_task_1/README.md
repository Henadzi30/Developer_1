# Итоговая проверочная работа.

## Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## hello", "2", "world", ":-)"] → ["2", ":-)"]
## ["1234", "1567", "-2", "computer science"] → ["-2"]
## ["Russia", "Denmark", "Kazan"] → []

#
**Решение**
#
1. Задаем целочисленную переменную, равную трем, для дальнейшего использования при сравнении элементов массива. Задаем сами массивы, данные по условию задачи (array1, array2, array3).
2. Создаем метод GetNeedArray для нахождения подходящих по условию задачи элементов массива и формирования нового массива. Для чего:
    * задаем переменную arrayLength, равную длине исходного массива;
    * отводим место в памяти для массива needArray;
    * задаем переменную elements, которая считает количество элементов массива, удовлетворяющих условию; 
    * при помощи цикла for перебираем элементы исходного массива array1, (2, 3), Элементы, удовлетворяющие условию (длина равна 3 или менее) сохраняются в needArray;
    * отводим место в памяти для массива desiredArray;
    * с помощью цикла for формируем массив необходимой длины, равной переменной elements;
    * метод GetNeedArray возвращает требуемый массив desiredArray.
3. Создаем метод PrintArray, который выдает результат работы метода GetNeedArray по типу:

    * если массив desiredArray пустой - печатается [];
    * если в массиве desiredArray имеются элементы - массив выводится на печать в консоль;
4. Создаем метод ResultTextProcessingMethod для корректного вывода исходного массива, и полученного  desiredArray в виде, приближенном к условиям задачи.
5. Инициируем работу программы с помощью обращения к методу ResultTextProcessingMethod
