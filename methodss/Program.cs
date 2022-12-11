


//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.


//IsNumber(21);
//static void IsNumber(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("bolunur");
//    }
//    else
//    {
//        Console.WriteLine("bolunmur");
//    }
//}

//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//SumUl(40, 2);
//static void SumUl(int n, int m)
//{

//    int sum = 0;

//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);
//    }
//    else
//    {
//        Console.WriteLine("Sert odenilmir");
//    }

//}



//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.


//var result = GetOddNums(5, 25);  

//Console.WriteLine(result);

//static int GetOddNums(int n, int m)
//{
//    int sum = 0;
//    for(int i = n; i < m; i++)
//    {
//        if(i % 2 == 1) 
//        {
//            sum += i;
//        }

//    }
//    return sum;
//}



//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.



//int[] arr = { 1, 2, 4, 11 };

//var result = arr[0];
//Console.WriteLine(result);
//static int[] GetArrItems(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 1)
//        {
//            sum += arr[i];
//        }

//    }
//    return sum;
//}


//5) Verilmish arrayin icindeki cut ededlerin sayini tapin

//int[] arr = { 1, 2, 4, 9 };
//GetArrI(arr);

//static void GetArrI(int[] arr)
//{
//    int count = 0;

//    for(int i=0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}


//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//static int GetOddNum(int n, int m)
//{
//    int count = 0;
//    for(int i=0; i < m; i++)
//    {
//        if(i % 2 ==0)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//var result = GetOddNum(2, 18);
//Console.WriteLine(result);

//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//int result = GetPlNum(2, 16);

//Console.WriteLine(result);
//static int GetPlNum(int n,int m)
//{
//    int sum = 0;
//    for(int i = n; i < m; i++)
//    {
//        if(i % 2 == 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.


//static int GetPlNums(int n,int m)
//{
//    int count = 0;
//    for(int i=n; i < m; i++)
//    {
//        if (i % 2 == 0) ;
//        {
//            count++;    
//        }
//    }
//    return count;   
//}

//var result = GetPlNums(1, 15);
//Console.WriteLine(result);

//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.



//int n = 1;
//int count = 0;


//if (n <= 0)
//{
//    Console.WriteLine("duzgun ede daxil edin");
//}
//else if (n == 1)
//{
//    Console.WriteLine("sade ve murekkeb deyil");
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0) ;
//        {
//            count++;
//        }
//    }
//    if (count > 2)
//    {
//        Console.WriteLine("murekkeb");

//    }
//    else
//    {
//        Console.WriteLine("sade");
//    }
//}


//10)n ededinin faktorialini hesablamaq.


//static int FactNum(int n)

//    int n = 9;

