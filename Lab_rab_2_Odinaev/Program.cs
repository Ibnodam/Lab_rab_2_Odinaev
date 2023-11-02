    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y: ");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine(x>=-1 && x<=1 && y>=-1 && y<=1 && y>=x+1 && y<=x+1 && y>=-x+1 && y<=x-1 && y<=-x-1);

//////// Задание №2
//////// а) Условие при котором скорости равны
//double protonMass = 1; // т.к. по условию масса протона в 4 раза меньше массы альфа-частицы при сокращении получим 1.
//double alphaMass = 4;
//double q_proton = 1; // заряд протона
//double q_alpha = 2;
//double B = 4; // Произвольное значение вектора магнитной индукции
//double V_proton = 3; //Значение скорости взято произвольно т.к в данном случае скорости будут равны
//double V_alpha = 3;
//double radius_proton = (protonMass * V_proton) / (q_proton * B); // Находим радиус протона
//double radius_alpha = (alphaMass * V_alpha) / (q_alpha * B); // Находим радиус альфа-частицы
//if ((radius_alpha / radius_proton) > 1)
//{
//    Console.WriteLine("а) radius_alpha > radius_proton");

//}
//else if ((radius_alpha / radius_proton) < 1)
//{
//    Console.WriteLine("а) radius_alpha < radius_proton");
//}
//else
//{
//    Console.WriteLine("а) radius_alpha = radius_proton");
//}
//////// б) Условие при котором энергии равны
//double W_proton = 4; // Энергия протона
//double W_alpha = 4;
//double radius_proton_b = ((Math.Sqrt(2 * W_proton * protonMass)) / (q_proton * B)); // Нахождение радиуса протона по другой формуле
//double radius_alpha_b = ((Math.Sqrt(2 * W_alpha * alphaMass)) / (q_alpha * B));
//if ((radius_alpha_b / radius_proton_b) > 1)
//{
//    Console.WriteLine("б) radius_alpha > radius_proton");

//}
//else if ((radius_alpha_b / radius_proton_b) < 1)
//{
//    Console.WriteLine("б) radius_alpha < radius_proton");
//}
//else
//{
//    Console.WriteLine("б) radius_alpha = radius_proton");
//}



////////////////// Задание 3

//////////Console.Write("Введите x:");
//////////double x = double.Parse(Console.ReadLine());


//////////switch (n)
//////////{
//////////    case 1:
//////////        {

//////////            double y = 0;
//////////            double a = 6;
//////////            double b = 32;
//////////            double z = Math.Exp(1.5 * a * x);
//////////            if (x < Math.Log(a)) y = 3.5 * a - 7.3 * b * x + (Math.Sin((z * x) * (z * x) * (z * x)));
//////////            else if (Math.Log(a) <= x && x >= b * b) y = Math.Pow(a, b) - Math.Cos(a + z * x);
//////////            else if (x > b) y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - (x * x);
//////////            Console.WriteLine($"y={y:F2}");
//////////        }
//////////        break;
//////////    case 2:
//////////        {

//////////            double y = 0;
//////////            double a = 3;
//////////            double b = 6;
//////////            double z = Math.Exp(1.5 * a * x);
//////////            if (x < Math.Log(a)) y = 3.5 * a - 7.3 * b * x + (Math.Sin((z * x) * (z * x) * (z * x)));
//////////            else if (Math.Log(a) <= x && x >= b * b) y = Math.Pow(a, b) - Math.Cos(a + z * x);
//////////            else if (x > b) y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - (x * x);
//////////            Console.WriteLine($"y={y:F2}");
//////////        }
//////////        break;
//////////    case 3:
//////////        {

//////////            double y = 0;
//////////            double a = 2.7;
//////////            double b = 1.8;
//////////            double z = Math.Exp(1.5 * a * x);
//////////            if (x < Math.Log(a)) y = 3.5 * a - 7.3 * b * x + (Math.Sin((z * x) * (z * x) * (z * x)));
//////////            else if (Math.Log(a) <= x && x >= b * b) y = Math.Pow(a, b) - Math.Cos(a + z * x);
//////////            else if (x > b) y = Math.Sqrt(Math.Abs(Math.Tan(a) - x)) - (x * x);
//////////            Console.WriteLine($"y={y:F2}");
//////////        }
//////////        break;

//////////}

