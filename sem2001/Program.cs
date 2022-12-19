int number = new Random().Next(10,100); // ot 10 do 99. 100 ne vkl

Console.WriteLine(number);

if (number / 10 > number % 10) Console.WriteLine(number / 10);
else Console.WriteLine(number % 10);

// Console.WriteLine(number / 10 > number % 10 ?
// number / 10 :
// number % 10);
