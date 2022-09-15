int[] arr = new int[8];
for(int i = 0; i < 8; i++){
    arr[i] = new Random().Next(0,2);
}
void PrintArray(int[] col){
    for(int count = 0; count < col.Length; count++){
        System.Console.Write($"{col[count]}, ");
    }
}
PrintArray(arr);
System.Console.WriteLine();