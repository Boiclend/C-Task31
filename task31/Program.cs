// Описать класс призма: объём, высота, количество граней, длинна сторон, площадь основания.
// Реализовать get- и set-методы для работы с элемент-данными класса.
// Организовать выбор (меню) входные и выходные данные. Защитить элемент-данные призмы от внешних кодов.

class Prizma
{
    private double height;
    private double vol;
    private double length_side;
    private double space_base;
    private int number_grain;

    public Prizma(double h, double lside, int num, double sbase)
    {
        height = h;
        length_side = lside;
        space_base = sbase;
        number_grain = num;
    }

    public void SetHeight(double h)
    {
        if (h > 0.0)
        {
            height = h;
        }
        else
        {
            height = 1.0;
        }
    }

    public void SetLength(double length)
    {
        if (length > 0.0)
        {
            length_side = length;
        }
        else
        {
            length_side = 1.0;
        }
    }

    public void SetNumberGrain(int num)
    {
        if (num > 3)
        {
            number_grain = num;
        }
        else
        {
            number_grain = 3;
        }
    }

    public void SetBase(double baseValue)
    {
        if (baseValue > 10.0)
        {
            space_base = baseValue;
        }
        else
        {
            space_base = 10;
        }
    }

    public double GetHeight()
    {
        return height;
    }

    public int GetNumGrain()
    {
        return number_grain;
    }

    public double GetBase()
    {
        return space_base;
    }

    public double GetLengthSide()
    {
        return length_side;
    }

    public double GetVol()
    {
        return vol = space_base * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        char key;
        bool exitProgram = false;
        Prizma prism = new Prizma(1.0, 1.0, 3, 10.0);
        while (!exitProgram)
        {
            Console.WriteLine("Выберите действие:\n" + "0 - выход; 1 - показать высоту призмы;\n"
                + "2 - показать количество боковых граней; 3 - показать площадь основания;\n"
                + "4 - показать длину сторон призмы; 5 - показать обьем призмы\n"
                + "6 - установить высоту призмы; 7 - установить длину сторон призмы;\n"
                + "8 - установить количество граней; 9 - задать площадь основания;\n");
            key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (key)
            {
                case '0':
                    exitProgram = true;
                    break;
                case '1':
                    Console.WriteLine("Высота = " + prism.GetHeight());
                    break;
                case '2':
                    Console.WriteLine("Количество боковых граней = " + prism.GetNumGrain());
                    break;
                case '3':
                    Console.WriteLine("Основание = " + prism.GetBase());
                    break;
                case '4':
                    Console.WriteLine("Длина сторон = " + prism.GetLengthSide());
                    break;
                case '5':
                    Console.WriteLine("обьем = " + prism.GetVol());
                    break;
                case '6':
                    {
                        double height;
                        Console.Write("Введите высоту: ");
                        height = Convert.ToDouble(Console.ReadLine());
                        prism.SetHeight(height);
                        break;
                    }
                case '7':
                    {
                        double length;
                        Console.Write("Введите длину: ");
                        length = Convert.ToDouble(Console.ReadLine());
                        prism.SetLength(length);
                        break;
                    }
                case '8':
                    {
                        int num;
                        Console.Write("Введите количество боковых граней: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        prism.SetNumberGrain(num);
                        break;
                    }
                case '9':
                    {
                        double baseValue;
                        Console.Write("Введите основание: ");
                        baseValue = Convert.ToDouble(Console.ReadLine());
                        prism.SetBase(baseValue);
                        break;
                    }
            }
        }
        Console.ReadLine();
    }
}



