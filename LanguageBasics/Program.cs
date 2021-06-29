using System;

namespace LanguageBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu numarul exercitiului pe care doresti sa il executi (1,2,3): ");
            string exerciseString = Console.ReadLine();
            int exercise = 0;
            Int32.TryParse(exerciseString, out exercise);

            if (exercise == 1)
            {
                Class1 class1 = new Class1();
            }
            else if (exercise == 2)
            {
                Class2 class2 = new Class2();
            }
            else if (exercise == 3)
            {
                Class3 class3 = new Class3();

            }
            else if (exercise >3)
            {
                Console.WriteLine("Nu ai introdus numarul unui exercitiu.");
            }

            Console.ReadLine();
        }
    }

    public class Class1
    {
        public Class1()
        {
            int ok = 0;

            while (ok == 0)
            {
                Console.Write("Introdu un numar: ");
                string numberString = Console.ReadLine();

                if (numberString.Length >= 3 ) 
                { 
                    //Int32.TryParse(numberString, out number);
                    int number = Int32.Parse(numberString);
                    ok = 1;
                    int mirroredNumber = 0;

                    while (number > 0)
                    {
                        mirroredNumber = mirroredNumber * 10 + number % 10; 
                        number = number / 10;
                    }


                    Console.WriteLine("Numarul oglindit este: " + mirroredNumber);
                    double result = Math.Sqrt(mirroredNumber);
                    bool isSquare = result % 1 == 0;

                    if (isSquare)
                    {
                        Console.WriteLine("Numarul dat in oglinda este patrat perfect");
                    }
                    else
                    {
                        Console.WriteLine("Numarul dat in oglinda nu este patrat perfect");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Numarul contine mai putin de 3 cifre");

                }
            }
            Console.ReadLine();

        }


    }

    public class Class2
    {
        public Class2()
        {
            Console.Write("Cate numere doresti sa introduci ? \n");
            string numberString = Console.ReadLine();
            int number = Int32.Parse(numberString);

            Console.Write("Introdu lista de numere: \n");
            double[] array = new double[number];

            for (int i = 0; i < number; i++)
            {
                string numberFromListString = Console.ReadLine();
                double numberFromList = Double.Parse(numberFromListString);

                array[i] = numberFromList;
            }

            Console.Write("Numerele care nu sunt intregi din array sunt: ");
            double min = array[0];

            for (int i = 0; i < number; i++)
            {   if (array[i] != (int)array[i])
                {
                    Console.Write(array[i] + " ");
                }
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("Numarul minim din lista este : " + min);
            Console.ReadLine();

        }
    }

    public class Class3
    {
        public Class3()
        {
            string[] array = new string[3];
            Console.WriteLine("Introduceti 3 nume de persoane: ");

            for (int i = 0; i< 3; i++)
            {
                array[i] = Console.ReadLine();
                //afisare nume reale ?
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Numele " + array[i] + " contine : \n");
                while(array[i].Length > 0)
                {
                    int countCharacter = 0;
                    array[i] = array[i].ToLower();
                    Console.Write( array[i][0] + ": ");
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (array[i][0] == array[i][j])
                        { 
                            countCharacter++;
                        }
                    }
                    Console.Write(countCharacter + "\n");

                    //elimina acel caracter din string :
                    array[i]= array[i].Replace(array[i][0].ToString(), string.Empty);
                    
                }
                Console.ReadLine();
            }
            
            //Console.ReadLine() to hold the screen after the execution of the program
            Console.ReadLine();
        }
    }
}