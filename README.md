# <center> <font size="6" color="#fa8e47" face="serif"> ***Итоговая проверочная работа 1 блока обучения*** </font> </center> 
## <center><font color="green" size="5"> **Задача** </font></center>
<hr />Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам.  
<br/>Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
<br/>[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
<br/>[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
<br/>[“Russia”, “Denmark”, “Kazan”] → []

## <center><font color="yellow" size="4">Условия решения</font></center>
1. > Создать репозиторий на GitHub
2. > Нарисовать блок-схему алгоритма
3. > Снабдить репозиторий текстовым описанием 
4. > Написать программу, решающую поставленную задачу
5. > Использовать контроль версий (каждый этап в отдельном коммите)
## <center><font color="red" size="4">Описание решения</font></center>

* Даём выбор пользователю - ввести массив строк вручную, либо автоматически (пользуемся функцией switch case).
* Задаём массив строк (автоматически или вручную, см. выше).
* Задаем числовую переменную = 3, для выполнения условия задачи по поиску строк.
* Вводим длину заданного массива.
* Далее вводим новый пустой массив строк с указанной длиной для дальнейшей записи в него результатов поиска
* Используем цикл перебора элементов начального строкового массива от 0 и до конца, и записываем строки, удовлетворяющие условию поиска (число символов <=3) в новый результирующий массив строк.
* Выводим результат в консоль, на экран.