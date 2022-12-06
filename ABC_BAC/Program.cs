// ABC=>CAB, ABC=>CBA

логический тест (строка s1, строка s2)
{
    s1=s1.ToLower();
    s2=s2.ToLower();
    если (s1.Length!=s2.Length) вернуть false;
    char[] c1=s1.ToCharArray();
    char[] c2=s2.ToCharArray();
    Массив.Сортировка(c1);//ABC
    Массив.Сортировка(c2);//ABC
    s1 = новая строка (c1);
    s2 = новая строка (c2);
    вернуть s1==s2;
}

строка s1="ABcDe";
строка s2="EDbCa";

System.Console.WriteLine(Тест(s1,s2));