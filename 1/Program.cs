// Красивый код какой он?

const Double pi = 3.1415;        // не используем кириллицу, Double - является типом платформы dotnet, 
                                 // тип описываем с маленькой буквы
int k_BackingField;              // использование нижнего подчерквания не особо приветствуется
void set_MyProperty(int value)  // наименование метода с маленькой буква не правильно
{
    k_BackingField = value;
}
int get_MyProperty()            // наименование метода с маленькой буква не правильно
{
    return k_BackingField;
}
int MyProperty { get; set; }  // не понятно что отражает

string label = "";              //111
string adress = String.Empty;   // 222 - используем такую запись



// Пример 1
double a = 1, b = -26, c = 120;
var d = b * b - b - 4 * a * c;
double x1 = (-b + Math.Sqrt(d)) / (2 * a);
double x2 = (-b + Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"*1 = {x1} *2 = {x2}");

// Пример 2
a = 2; b = 1; c = -3;
d = b * b - b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b + Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"*1 = {x1} *2 = {x2}");

// Пример 3
a = 1; b = 1; c = -6;
d = b * b - b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b + Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"*1 = {x1} *2 = {x2}");

// все скопировали 

public Roots Solve(double a, double b, double c)
{
    var d = b * b - 4 * a * c;
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    return new Roots { X1 = x1, x2 = x2 };

}