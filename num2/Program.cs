int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

//int sum = 0;

summary(m, n, 0);

void summary(int m, int n, int s){
    
    if(m > n){
        Console.WriteLine(s);
        return;
    }
    s += (m++);
    summary(m, n, s);
}