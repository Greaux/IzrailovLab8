using System; 
using System.IO; 
using System.Text;
using System.Security.Cryptography;

public class Program 
{ 
public static void Main() 
{ 
int x = 1; 
int Time1st = 0; 
int Time2nd = 0; 
int Time3rd = 0; 
int Pay1st = 0; 
int Pay2st = 0; 
int Pay3st = 0; 
int PayAll1st = 0; 
int PayAll2st = 0; 
int PayAll3st = 0; 
string Name1 = ""; 
string Name2 = ""; 
string Name3 = ""; 
string path = @"C:\Users\Greaux\Desktop\Log.txt";
string path2 = @"C:\Users\Greaux\Desktop\Mining.txt";
string str = "Serbo";
int max = 0;
int spam = 1;

while (x > 0) 
{

Console.WriteLine("Enter 1st surname"); 
Name1 = Console.ReadLine(); 
Console.WriteLine("Enter 1st time"); 
Time1st = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter Pay/1h"); 
Pay1st = Convert.ToInt32(Console.ReadLine()); 
if ((Name1 == "Serbo") || (Name1 == "Meleshko") || (Name1 == "Gladisheva")) 
{ 
PayAll1st = Time1st * Pay1st * 2; 
} 
else 
{ 
PayAll1st = Time1st * Pay1st; 
} 
using (MD5 md5hash = MD5.Create())
{

byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(str));
StringBuilder sBuilder = new StringBuilder();
for (int i = 0; i < data.Length; i++)
sBuilder.Append(data[i].ToString("x2"));
str = sBuilder.ToString();
}

Console.WriteLine("Enter 2st surname"); 
Name2 = Console.ReadLine(); 
Console.WriteLine("Enter 1st time"); 
Time2nd = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter Pay/1h"); 
Pay2st = Convert.ToInt32(Console.ReadLine()); 
if ((Name2 == "Serbo") || (Name2 == "Meleshko") || (Name2 == "Gladisheva")) 
{ 
PayAll2st = Time2nd * Pay2st * 2; 
} 
else 
{ 
PayAll2st = Time2nd * Pay2st; 
} 

Console.WriteLine("Enter 3st surname"); 
Name3 = Console.ReadLine(); 
Console.WriteLine("Enter 1st time"); 
Time3rd = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter Pay/1h"); 
Pay3st = Convert.ToInt32(Console.ReadLine()); 
if ((Name3 == "Serbo") || (Name3 == "Meleshko") || (Name3 == "Gladisheva")) 
{ 
PayAll3st = Time3rd * Pay3st * 2; 
} 
else 
{ 
PayAll3st = Time3rd * Pay3st; 
} 

Console.WriteLine("№"); 
Console.WriteLine("1" + " | Surname: " + Name1 + " | Time: " + Time1st + " | Pay: " + Pay1st + " | PayAll: " + PayAll1st); 
Console.WriteLine("2" + " | Surname: " + Name2 + " | Time: " + Time2nd + " | Pay: " + Pay2st + " | PayAll: " + PayAll2st); 
Console.WriteLine("3" + " | Surname: " + Name3 + " | Time: " + Time3rd + " | Pay: " + Pay3st + " | PayAll: " + PayAll3st); 

if (!File.Exists(path)) 
{ 
FileStream fs = File.Create(path); 
TextWriter tw = new StreamWriter(path); 
tw.WriteLine("1" + " | Surname: " + Name1 + " | Time: " + Time1st + " | Pay: " + Pay1st + " | PayAll: " + PayAll1st); 
tw.WriteLine("2" + " | Surname: " + Name2 + " | Time: " + Time2nd + " | Pay: " + Pay2st + " | PayAll: " + PayAll2st); 
tw.WriteLine("3" + " | Surname: " + Name3 + " | Time: " + Time3rd + " | Pay: " + Pay3st + " | PayAll: " + PayAll3st); 
tw.Close(); 
} 
else if (File.Exists(path)) 
{ 
TextWriter tw = new StreamWriter(path); 
tw.WriteLine("Next try"); 
tw.WriteLine("1" + " | Surname: " + Name1 + " | Time: " + Time1st + " | Pay: " + Pay1st + " | PayAll: " + PayAll1st); 
tw.WriteLine("2" + " | Surname: " + Name2 + " | Time: " + Time2nd + " | Pay: " + Pay2st + " | PayAll: " + PayAll2st); 
tw.WriteLine("3" + " | Surname: " + Name3 + " | Time: " + Time3rd + " | Pay: " + Pay3st + " | PayAll: " + PayAll3st); 
tw.Close(); 
} 

if (!File.Exists(path)) 
{ 
FileStream fs = File.Create(path2); 
TextWriter tw = new StreamWriter(path2); 
tw.WriteLine(str); 
tw.Close(); 
} 
else if (File.Exists(path2)) 
{ 
TextWriter tw = new StreamWriter(path2); 
tw.WriteLine(str); 
tw.Close(); 
} 

if ((PayAll1st == 777))
{
Console.WriteLine("The " + Name1 + " is blessed!");
}
if ((PayAll1st == 666))
{
Console.WriteLine("The " + Name1 + " is CURSED!");
}

if ((PayAll2st == 777))
{
Console.WriteLine("The " + Name2 + " is blessed!");
}
if ((PayAll2st == 666))
{
Console.WriteLine("The " + Name2 + " is CURSED!");
}
if ((PayAll3st == 777))
{
Console.WriteLine("The " + Name3 + " is blessed!");
}
if ((PayAll3st == 666))
{
Console.WriteLine("The " + Name3 + " is CURSED!");
}

if (spam < 5)
{
spam += 1;
}
else if ((spam == 5))
{
if (PayAll1st >= PayAll2st && x >= PayAll3st)
max = PayAll1st;
else if (PayAll2st >= PayAll1st && PayAll2st >= PayAll3st )
max = PayAll2st;
else if (PayAll3st >= PayAll1st && PayAll3st >= PayAll2st)
max = PayAll3st;
Console.WriteLine("Buy our CRYPTOLOCKER only for:" + max);
spam = 0;
}


Console.WriteLine("\n if you want to try again write 1, else write 0");
x = Convert.ToInt32(Console.ReadLine()); 
} 
} 
}
