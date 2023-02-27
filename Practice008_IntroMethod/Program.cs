// Напишем функцию нахождения максимального числа из ряда данных
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if( arg2 > result ){
        result = arg2;
    }
    if( arg3 > result) {
        result = arg3;
    }
    return result;
}
int a1 = 110;
int b1 = 259;
int c1 = 134;

int a2 = 100;
int b2 = 125;
int c2 = 349;

int a3 = 105;
int b3 = 258;
int c3 = 234;

int max1 = Max( a1,b1,c1);
int max2 = Max( a2,b2,c2);
int max3 = Max( a3,b3,c3);

int result = Max(max1,max2,max3);

Console.WriteLine(result);
