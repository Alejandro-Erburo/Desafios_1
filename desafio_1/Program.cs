using System;
using System.Globalization;
using System.Text;
using System.Security.Cryptography;

//Desafios 2

public class Functions
{
    //desafio 1
    public float AbsoluteValue(float a)
    {
        if (a < 0)
        {
            return a * (-1);
        }
        else
        {
            return a;
        }
    }
    
    //desafio 2
    public void Candidate(string candidate)
    {
        candidate = candidate.ToUpper();
        
        switch (candidate)
        {
            case "A":
                Console.WriteLine("Usted ha votado por el partido rojo");
                break;
            case "B":
                Console.WriteLine("Usted ha votado por el partido verde");
                break;
            case "C":
                Console.WriteLine("Usted ha votado por el partido azul");
                break;
            default:
                Console.WriteLine("Opción errónea");
                break;
        }
    }
    
    //desafio 3
    public void Day(string day)
    {
        day = day.ToUpper();
        switch (day)
        {
            case "LUNES":
                Console.WriteLine("Hoy comienza la semana. ¡Ánimo!");
                break;
            case "VIERNES":
                Console.WriteLine("¡Ya casi termina!");
                break;
            case "SABADO":
            case "DOMINGO":    
                Console.WriteLine("¡Siiii! ¡Fin de semana!");
                break;
            case "MARTES":
            case "MIERCOLES": 
            case "JUEVES":
                Console.WriteLine("¡Vamos que se puede!");
                break;
            default:
                Console.WriteLine("No es un dia valido");
                break;
        }
    }
    
    //desafio 4
    public int PositiveSum(int a)
    {
        int sum = 0;
        
        while (a > 0)
        {
            sum += a;
            Console.WriteLine("Ingrese otro valor positivo");
            string newValue = Console.ReadLine();
            
            if (!int.TryParse(newValue, out a))
            {
                Console.WriteLine("Entrada inválida. Se finaliza la suma.");
                break;
            }
        }
        Console.WriteLine("el valor ingresado es menor o igual a cero");
        return sum;
    }
    
    //desafio 5
    public int Sum2Dice(int rolls)
    {
        Random rnd = new Random();
        int sum = 0;
        int dice1 = 0;
        int dice2 = 0;
        
        for (int i = 0; i < rolls; i++)
        {
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            sum += dice1 + dice2;
        }
        return sum;
    }

    public List<int> FaceCounter(int rolls)
    {
        Random rnd = new Random();
        int dice = 0;
        List<int> result = new List<int>();
        int face1 = 0;
        int face2 = 0;
        int face3 = 0;
        int face4 = 0;
        int face5 = 0;
        int face6 = 0;
        
        for (int i = 0; i < rolls; i++)
        {
            dice = rnd.Next(1, 7);
            switch (dice)
            {
                case 1:
                    face1++;
                    break;
                case 2:
                    face2++;
                    break;
                case 3:
                    face3++;
                    break;
                case 4:
                    face4++;
                    break;
                case 5:
                    face5++;
                    break;
                case 6:
                    face6++;
                    break;
            }
        }
        
        result.Add(face1);
        result.Add(face2);
        result.Add(face3);
        result.Add(face4);
        result.Add(face5);
        result.Add(face6);
        
        return result;
    }
    
    //desafio 6
    public bool IsAPangram(string text)
    {

        text = NormalizeText(text);
        string alphabet = "abcdefghijklmnñopqrstuvwxyz";
        
        foreach (char letra in alphabet)
        {
            bool found = false;

            foreach (char c in text)
            {
                if (c == letra)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return false;
            }
        }
        return true;
    }

    public string NormalizeText(string text)
    {
        text = text.ToLower();
        string normalize = text.Normalize(NormalizationForm.FormD);
        StringBuilder normalizeText = new StringBuilder();

        foreach (char c in normalize)
        {
            UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);

            if (category != UnicodeCategory.NonSpacingMark)
            {
                normalizeText.Append(c);
            }
        }

        return normalizeText.ToString().Normalize(NormalizationForm.FormC);
    }
    
    //desafio 7

    public List<List<int>> LotteryBoard()
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        while (numbers.Count < 15)
        {
            int number = random.Next(1, 100);

            if (!numbers.Contains(number))
            {
                numbers.Add(number);
            }
        }
        
        List<List<int>> board = new List<List<int>>();
        board.Add(numbers.GetRange(0,5));
        board.Add(numbers.GetRange(5,5));
        board.Add(numbers.GetRange(10,5));

        return board;
    }
}
class Program
{
    static void Main()
    {
        Functions f = new Functions();

        //DESAFIOS 1
        
        //desafio 1
        Console.WriteLine("Hello World!");

        //desafio 2

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

        //DESAFIOS 2
        
        //desafio 1
        Console.WriteLine(f.AbsoluteValue(52)); // Devuelve 52
        Console.WriteLine(f.AbsoluteValue(-52)); // Devuelve también 52
        Console.WriteLine();

        //desafio 2
        Console.WriteLine("Candidate:");
        f.Candidate("A");
        Console.WriteLine("Candidate:");
        f.Candidate("F");

        //desafio 3
        Console.WriteLine("Day:");
        f.Day("lunes");
        f.Day("viernes");
        f.Day("domIngo");
        f.Day("MartEs");
        f.Day("hola");
        Console.WriteLine();

        //desafio 4
        Console.WriteLine("Positive Sum:");
        Console.WriteLine("Ingrese un numero positivo:");
        int a = int.Parse(Console.ReadLine());
        int sum = f.PositiveSum(a);
        Console.WriteLine("Suma total: " + sum);
        Console.WriteLine();

        //desafio 5
        Console.WriteLine("Sum 2 Dice:");
        Console.WriteLine(f.Sum2Dice(10));
        Console.WriteLine();
        Console.WriteLine("Cantidad de veces que sale cada cara en un dado");
        Console.WriteLine(f.FaceCounter(30));
        Console.WriteLine();

        //desafio 6
        Console.WriteLine("Pangram:");
        string text1 = "José compró una vieja zampoña en Perú. Excusándose, Sofía tiró su whisky al desagüe de la banqueta";
        Console.WriteLine(f.IsAPangram(text1));
        Console.WriteLine();
        Console.WriteLine("Pangram:");
        string text2 = "Compañera usted sabe que puede contar conmigo no hasta dos ni hasta diez sino contar conmigo.";
        Console.WriteLine(f.IsAPangram(text2));
        Console.WriteLine();

        //desafio 7
        Console.WriteLine("Lottery Board:");

        var board = f.LotteryBoard();

        foreach (var row in board)
        {
            Console.WriteLine(string.Join(",", row));
        }
    }
}