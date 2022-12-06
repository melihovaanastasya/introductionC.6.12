// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s=Console.ReadLine();
int k=0;
for (int i=0;i<s.Length;i++)
if (s[i]==(char)46) break;
else k++;
System.Console.WriteLine(k);
