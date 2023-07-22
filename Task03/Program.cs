// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

while(true) {
Console.WriteLine("Напишите целое число соответствующее дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1){
Console.WriteLine("Понедельник");
break;
}
if (day == 2){
Console.WriteLine("Вторник");
break;
}
if (day == 3){
Console.WriteLine("Среда");
break;
}
if (day == 4){
Console.WriteLine("Четверг");
break;
}
if (day == 5){
Console.WriteLine("Пятница");
break;
}
if (day == 6){
Console.WriteLine("Суббота");
break;
}
if (day == 7){
Console.WriteLine("Воскресение");
break;
}
Console.WriteLine("Такого дня недели нет");
break;
}