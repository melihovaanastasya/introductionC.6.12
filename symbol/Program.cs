// с помощью System.Linq;

символ с='а';
с='\u0064';
символ б = 'а';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString());
if (b>='0' && b<='9') System.Console.WriteLine("Это цифра");
if (b>='A' && b<='Z') System.Console.WriteLine("Это большая латиница");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("Это большая латиница");

if (Char.IsDigit(b)) System.Console.WriteLine("Это цифра");