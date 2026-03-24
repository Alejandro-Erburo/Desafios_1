//Desafio 1

Console.WriteLine("Hello World!");

//Desafio 2

string texto = "Esto es un texto";
Console.WriteLine(texto);

//desafio 3

bool on = true;
Console.WriteLine("Encendido: ", on);

//desafio 4

string pi = "3.1416";
Console.WriteLine(Convert.ToSingle(pi));

//desafio 5

int number = -5;
if (number > 0)
    Console.WriteLine("El número es positivo");
else
    Console.WriteLine("El número es negativo");

//desafio 6
//number ya estaba definida en el ejercicio anterior
//y tambien valia -5

if (number > 0)
    Console.WriteLine("El número es positivo");
else if (number < 0)
    Console.WriteLine("El número es negativo");
else
    Console.WriteLine("El número es cero");
    
//desafio 7

string nombre = "Juan";
int edad = 30;
Console.WriteLine("Hola, me llamo " + nombre + " y tengo " + edad + " años.");

//desafio 8

for (int i = 0; i <= 5; i++)
    Console.WriteLine("El valor de i es: " + i);

//desafio 9

string text = "Hola mundo";
Console.WriteLine(text[0]);
Console.WriteLine(text[text.Length - 1]);

//desafio 10

List<int> list = new List<int> { 1, 2, 3 };
list.Add(4);
Console.WriteLine(String.Join(", ", list.ToArray()));

//desafio 11

for(int i = 0; i < list.Count; i++)
    Console.WriteLine(list[i]);
    