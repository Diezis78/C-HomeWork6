// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write($"Укажите сколько чисел Вы хотите ввести: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] MassiveNumbers = new int[M];

void InputNumbers(int M){
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    MassiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] MassiveNumbers)
{
  int count = 0;
  for (int i = 0; i < MassiveNumbers.Length; i++)
  {
    if(MassiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Число введенных Вами чисел больше нуля = {Comparison(MassiveNumbers)} ");