using System;

// 1
{
    int number = 0;
    string text = "";
    string nothing = null;
    Console.WriteLine(number);
    Console.WriteLine(text);
    Console.WriteLine(nothing);
    Console.WriteLine();
}

// 2
{
    string name = null;
    Console.WriteLine(name==null);
    Console.WriteLine();
}

// 3-1
{
    int? num1 = null;
    double? num2 = null;
    bool? Bool = null;
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    Console.WriteLine(Bool);
    Console.WriteLine();
}

// 3-2
{
    int? score = null;
    Console.WriteLine($"score.HasValue: {score.HasValue}");
    score = 95;
    Console.WriteLine($"score.HasValue: {score.HasValue}");
    Console.WriteLine($"score.Value: {score.Value}");
    Console.WriteLine();
}

// 3-3
{
    int? empty = null;
    if (empty.HasValue) { Console.WriteLine(empty.Value); }
    else { Console.WriteLine("값이 없습니다."); }
    Console.WriteLine();
}

// 3-4
{
    int? level = null;
    Console.WriteLine($"기본값 사용: {level.GetValueOrDefault()}");
    Console.WriteLine($"커스텀 기본값 사용: {level.GetValueOrDefault(1)}");
    level = 50;
    Console.WriteLine($"값이 있을 때: {level.GetValueOrDefault()}");
    Console.WriteLine();
}

// 3-5
{
    int number = 42;
    int? nullable = number;
    int back = (int)number;
    Console.WriteLine($"nullable: {nullable}");
    Console.WriteLine($"back: {back}");
    Console.WriteLine();
}

// 4-1
{
    string message = null;
    string result = message ?? "기본 메시지";
    Console.WriteLine(result);
    message = "안녕하세요";
    result = message ?? "기본 메시지";
    Console.WriteLine(result);
    Console.WriteLine();
}

// 4-2
{
    string input = null;
    string output;
    if (input == null)
    {
        output = "기본값";
    }
    else { output = input; }
    Console.WriteLine($"if문 결과: {output}");

    string input2 = null;
    string output2 = input2 ?? "기본값";
    Console.WriteLine($"?? 연산자 결과: {output2}");
    Console.WriteLine();
}

// 4-3
{
    int? score = null;
    int defaultScore = score ?? -1;
    int? health = null;
    int defaultHealth = health ?? default(int);
    Console.WriteLine($"점수: {defaultScore}");
    Console.WriteLine($"체력: {defaultHealth}");
    Console.WriteLine();
}

// 4-4
{
    string first = null;
    string second = null;   
    string third = "세 번째 값";
    Console.WriteLine($"{first ?? second ?? third}");
}

