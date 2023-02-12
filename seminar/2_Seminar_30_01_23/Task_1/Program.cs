Console.Clear();

int num = new Random().Next(10, 100);
Console.WriteLine($"Num = {num}");
int num1 = num / 10; 
int num2 = num % 10; 
int max = num;
if(num1 > num2){
     max = num1;
}
Console.WriteLine($"Max = {max}");