
Console.WriteLine("Welcome to my little calculator 3000!");
Console.WriteLine("Please entry A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please entry B:");
int b = Convert.ToInt32(Console.ReadLine());
int c;
Console.WriteLine("Please entry number for select:");
Console.WriteLine("1 - <+>");
Console.WriteLine("2 - <->");
Console.WriteLine("3 - <*>");
Console.WriteLine("4 - </>");
int var = Convert.ToInt32(Console.ReadLine());
    switch (var)
    {
<<<<<<< HEAD
        case 1: c = a + b; Console.WriteLine("result:" + c); break;
        /*case 2: c = a - b; Console.WriteLine("result:" + c); break;*/
=======
        /*case 1: c = a + b; Console.WriteLine("result:" + c); break;*/
        case 2: c = a - b; Console.WriteLine("result:" + c); break;
>>>>>>> get_sub
        /*case 3: c = a * b; Console.WriteLine("result:" + c); break;*/
        /*case 4: c = a / b; Console.WriteLine("result:" + c); break;*/
        default: Console.WriteLine("Этот ввод не определен"); break;
    }