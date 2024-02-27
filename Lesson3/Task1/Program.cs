double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;  //numenator - числитель, denumenator - знаменатель
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
 Console.WriteLine(result);
 

