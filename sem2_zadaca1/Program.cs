//программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("тут нету этой третьей цифры -> " + anyNumberText[2]);
}
else {
  Console.WriteLine( "-> тут нету этой третьей цифры");
}
Console.Clear();

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
