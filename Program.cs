string [] array = {"hello", "2", "world", ":-)"};

void Print(string [] Array){
    for (int i=0; i<Array.Length; i++){
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

Print(array);