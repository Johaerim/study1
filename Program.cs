//Console.WriteLine("숫자 입력: ");
//int input = int.Parse(Console.ReadLine());

//if(input%2==0)
//{
//    Console.WriteLine("짝수임");
//}

//Console.WriteLine(DateTime.Now.Year);

//if(DateTime.Now.Hour<12)
//{
//    Console.WriteLine("오전입니다.");
//}
//if(DateTime.Now.Hour>=12)
//{
//    Console.WriteLine("오후입니다.");
//}


//Console.Write("숫자 입력 : ");    //if else문 이용하여 짝홀 
//int input = int.Parse(Console.ReadLine());

//if(input%2==0)
//{
//    Console.WriteLine("짝수입니다.");
//}
//else
//{
//    Console.WriteLine("홀수입니다.");
//}


//if(DateTime.Now.Hour<11)
//{
//    Console.WriteLine("아침먹어");
//}
//else
//{
//  if(DateTime.Now.Hour<15)
//    {
//        Console.WriteLine("점심먹어");
//    }
//  else
//    {
//        Console.WriteLine("저녁먹어");
//    }

//}


//학점
//double score = 3.6;

//if(score==4.5)
//{
//    Console.WriteLine("천재");
//}
//else if(score>=4.2)
//{
//    Console.WriteLine("교수님의 사랑");
//}

//Console.WriteLine("숫자 입력: ");

//int input = int.Parse(Console.ReadLine());

//switch (input % 2)
//{
//    case 0:
//        Console.WriteLine("짝수");
//        break;
//    case 1:
//        Console.WriteLine("홀수");
//        break;
//}

//string input = Console.ReadLine();
//int number = int.Parse(input);

//Console.WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");

//Console.Write("입력: ");
//String line = Console.ReadLine();

//if(line.Contains("안녕"))
//{
//    Console.WriteLine("안녕하세요.");
//}
//else
//{
//    Console.WriteLine("^^");
//}





//ConsoleKeyInfo info = Console.ReadKey();
//switch(info.Key)
//{
//    case ConsoleKey.UpArrow:
//        Console.WriteLine("위로 이동.");
//        break;
//    case ConsoleKey.RightArrow:
//        Console.WriteLine("오른쪽은로 이동.");
//        break;
//    case ConsoleKey.DownArrow:
//        Console.WriteLine("아래로 이동.");
//        break;

//    case ConsoleKey.LeftArrow:
//        Console.WriteLine("왼쪽으로 이동.");
//        break;
//    default:
//        Console.WriteLine("다른 키를 누름.");
//        break;
//}




//계절
//Console.WriteLine("숫자 입력: ");
//int input = int.Parse(Console.ReadLine());

//switch(input)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine("겨울");
//        break;

//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("봄");
//        break;

//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("여름");
//        break;

//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("가을");
//        break;


//}


//중첩조건문을 논리연산자로 하나의 if 조건문을 작성
//Console.WriteLine("숫자 입력: ");
//int x=int.Parse(Console.ReadLine());

//if((x>10)||(x<20))
//{

//    Console.WriteLine("조건에 맞습니다.");
//}


//배열

//int[] intArray = { 52, 283, 23, 213, 234 };

//intArray[0] = 0;

//Console.WriteLine(intArray[0]);
//Console.WriteLine(intArray[1]);
//Console.WriteLine(intArray[2]);
//Console.WriteLine(intArray[3]);



//int i = 0;
//int[] intArray = { 52, 273, 21, 443, 12 };

//while(i<intArray.Length)
//{
//    Console.WriteLine(i + "번째 출력: " + intArray[i]);
//    i++;  //탈출을 위해 변수를 더함.
//}




//do while 반복문

//string input;

//do
//{
//    Console.WriteLine("입력(exit을 입력하면 종료): ");
//    input = Console.ReadLine();
//} while (input != "exit");






//for 반복문

//int output = 1;

//for(int i=1; i<=20;i++)
//{
//    output *= i;
//}

//Console.WriteLine(output);


//long start = DateTime.Now.Ticks;
//long count = 0;

//while(start+(10000000)>DateTime.Now.Ticks)
//{
//    count++;
//}

//Console.WriteLine(count + "만큼 반복했습니다.");






//역 for 반복문

//int[] intArray = { 1, 2, 3, 4, 5, 6 };

//for (int i =intArray.Length - 1; i >= 0;i--)
//{
//    Console.WriteLine(intArray[i]);
//}




//foreach 문
//string[] array = { "사과", "배", "포도", "딸기", "바나나" };

//foreach(string item in array)
//{
//    Console.WriteLine(item);
//}




//foreach문과 var키워드

//string[] array = { "사과", "배", "포도", "딸기", "바나나" };

//foreach(var item in array)
//{
//    Console.WriteLine(item);
//}





//중첩 반복문 별 피라미드

//for(int i=0; i<10; i++)
//{
// for(int j=0; j<i+1 ; j++)
    
//        Console.Write('*');
//        Console.Write('\n');

    
//}




// for(int i=0;i<10;i++)
// {
//     for (int j = 0; j < 10-i; j++)
//         Console.Write(' ');

//     for(int j=0; j<i+1;j++)
//     Console.Write('*');
//     Console.Write('\n');

    
// }

string input="감자 고구마 토마토";
string[] inputs= input.Split(new char[] {' '});

foreach(var item in inputs)
{
    Console.WriteLine(item);
}