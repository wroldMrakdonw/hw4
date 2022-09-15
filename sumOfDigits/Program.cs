// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int countOfDigits(int num){
    num = Math.Abs(num);
    if (num == 0){
        return 1;
    }
    else{
        int count = 0;
        while(num > 0){
            num /= 10;
            count++;
        }
        return count;
    }
}

int sumOfDigits(int num){
    int[] digits = new int[countOfDigits(num)];
    int n = num;
    int res = 0;
    for(int i = 0; n > 0; i++){
        digits[i] = n % 10;
        n /= 10;
    }
    for (int i = 0; i < digits.Length; i++) {
        res += digits[i];
    }
    return res;
}

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе {n} равна {sumOfDigits(n)}");