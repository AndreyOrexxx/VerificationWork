// Проверочная работа: 
 
string? yesNo = ""; 
while (yesNo.ToLower() != "yes" && yesNo.ToLower() != "no") 
{ 
  Console.Write("Будете вводить строки вручную? (yes/no): "); 
  yesNo = Console.ReadLine(); 
} 
 
string[] arreyStrings = new string[]  {}; 
 
if (yesNo.ToLower() == "yes") 
{ 
  int n = InputNumbers("Введите количество элементов массива: "); 
  arreyStrings = new string[n]; 
  for (int i = 0; i < arreyStrings.Length; i++) 
  { 
    Console.Write($" Введите {i+1} строку: "); 
    arreyStrings[i] = Console.ReadLine(); 
  } 
} 
else  
{ 
  arreyStrings = new string[]  {"hello", "2", "world", ":-)"}; 
} 
 
int lengthMax = 3; 
 
int numbersItems = CheckArrey(arreyStrings, lengthMax); 
 
string[] newArreyStrings = new string[numbersItems]; 
 
FillNewArrey(arreyStrings, newArreyStrings, lengthMax); 
 
Console.WriteLine($"{PrintArrey(newArreyStrings)}"); 
 
 
void FillNewArrey(string[] oldArrey, string[] newArrey, int lengthMax) 
{ 
  int temp = 0; 
  for (int i = 0; i < oldArrey.Length; i++) 
  { 
    if (oldArrey[i].Length <= lengthMax) 
    { 
      newArrey[temp] = oldArrey[i]; 
      temp++; 
    } 
  } 
} 
 
int CheckArrey(string[] array, int lengthMax) 
{ 
  int result = 0; 
  for (int i = 0; i < array.Length; i++) 
  { 
    if (array[i].Length <= lengthMax) result++; 
  } 
  return result; 
} 
 
string PrintArrey(string[] arrey) 
{  
  string result = string.Empty; 
  result = "[ "; 
  for (int i = 0; i < arrey.Length; i++) 
  { 
    result += $"{arrey[i],1}"; 
    if (i < arrey.Length - 1) result += ", "; 
  } 
  result += " ]"; 
  return result; 
} 
 
int InputNumbers(string input) 
{ 
  Console.Write(input); 
  int output = Convert.ToInt32(Console.ReadLine()); 
  return output; 
}

