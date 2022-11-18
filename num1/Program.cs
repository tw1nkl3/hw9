int n = Convert.ToInt32(Console.ReadLine());

void func (int num)
{
    if (num < 0){
        Console.WriteLine("invalid input");
        Environment.Exit(-1);
    }
    if (num == 0) return;
    Console.Write(num + " ");
    func (num - 1);
}

func(n);