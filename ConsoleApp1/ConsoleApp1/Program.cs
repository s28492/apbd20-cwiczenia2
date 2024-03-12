// See https://aka.ms/new-console-template for more information

static double GetAverage(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    
    //List<int> numbers = new List<int>(){1,2,3,4,5,6,7};
    
    return numbers.Average(); //hehe
}
int[] numbers = {1, 2, 3, 4, 5, 6};
Console.WriteLine(GetAverage(numbers));