// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

string s = Console.ReadLine();
int k = 0;
int s1 = 0;
for (int i = 0; i < s.Length; i++)
    if (char.IsDigit(s[i]))
    {
        k++;
        s1 += s[i] - 48;
    }
if (k == s.Length) System.Console.WriteLine(s1);
else System.Console.WriteLine("Не число");
