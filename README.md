# gbEkzam1
# **Фильтрация массива строк в зависимости от длины**
![block-schema](https://github.com/SivolonskySergey/gbEkzam1/blob/main/%D0%B1%D0%BB%D0%BE%D0%BA%20%D1%81%D1%85%D0%B5%D0%BC%D0%B0.jpg)
## Алгоритм

На вход функция **lessThan3Char(int length, int maxLength = 3)** принимает:

1. Обязательный параметр число (**int**), которое явлется длиной (**length**) стартового массива;
2. Необязательный параметр **int maxLength** который задан по умолчанию и равен - 3;

После того как задана длина, формируется пустой массив **startArray** соответсвующей длины (**length**)

После того как массив (**startArray**)сформирован, происходит заполнение с помощью метода **fillArray(int length, string[] arrToFill)**.

Метод **fillArray()** принимает на вход два значения:

1. *int length* - длина пустого массива;
2. *string[] arrToFill* - пустой массив строк;

> **fillArray** Заполняет массив значениями введеными пользователем в терминале! Количество строк будет равно >  значению **length**

![fillArr](https://github.com/SivolonskySergey/gbEkzam1/blob/main/%D0%B1%D0%BB%D0%BE%D0%BA%20%D1%81%D1%85%D0%B5%D0%BC%D0%B0.jpg)

После заполнения массива происходит формирование длины нового отсортированного массива **newLength**. С помощью цикла **for** на основании того сколько строк начального массива имеют длину меньше либо равную **maxLength**.

Как только длина нового массива **newLength** полностью сформирована, происходит создание нового массива с длиной равной **newLength**, и последующее его заполнение строками длина которых не превышает **maxLength**, также с помощью функции **for**.

В конечном итоге в консоль выводится начальный **startArr** и результирующий массив **resultArray**.
![Вывод результата](https://github.com/SivolonskySergey/gbEkzam1/blob/main/pictures/Screenshot_2022-11-14_23-56-58.png)





