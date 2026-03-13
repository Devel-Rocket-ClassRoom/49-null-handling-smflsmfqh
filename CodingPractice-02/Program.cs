using System;
using System.Collections.Generic;

// 1-1
{
    string name = null;
    name ??= "이름 없음";
    Console.WriteLine(name);
    name ??= "새 이름";
    Console.WriteLine(name);
    Console.WriteLine();
}

// 1-2
{
    string playerName = null;
    if (playerName == null)
    {
        playerName = "플레이어";
        Console.WriteLine(playerName);
    }
    Console.WriteLine();
}

// 1-3
{
    List<string> _items = null;
    _items ??= new List<string>();
    _items.Add("검");
    _items ??= new List<string>();
    _items.Add("방패");
    Console.WriteLine($"아이템 수: {_items.Count}");
    foreach( string item in _items ) { Console.WriteLine($"- {item}"); }
    Console.WriteLine();
}

// 2-1
{
    string message = null;
    int? length = message?.Length;
    Console.WriteLine($"길이: {length}");
    message = "안녕하세요";
    length = message?.Length;
    Console.WriteLine($"길이: {length}");
    Console.WriteLine();
}

// 2-2
{
    string text = null;
    if (text?.Length == null)
    {
        Console.WriteLine("텍스트가 없습니다.");
    }
    Console.WriteLine();
}

// 2-3
{
    string name = null;
    Console.WriteLine($"대문자: {name?.ToUpper()}");
    name = "hello";
    Console.WriteLine($"대문자: {name?.ToUpper()}");
    Console.WriteLine();
}

// 2-4
{
    string text = null;
    Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");
    text = "hello";
    Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");
    Console.WriteLine();
}

// 2-5
{
    List<string> items = null;
    int? length = items?.Count;
    Console.WriteLine($"아이템 수: {length}");
    items = new List<string>{ "apple", "banana" };
    length = items?.Count;
    Console.WriteLine($"아이템 수: {length}");
    Console.WriteLine();
}

// 2-6
{
    string text = null;
    char? firstChar = text?[0];
    Console.WriteLine($"첫 글자: {firstChar}");
    text = "hello";
    firstChar = text?[0];
    Console.WriteLine($"첫 글자: {firstChar}");
    Console.WriteLine();
}

// 3-1
{
    string message = null;
    int length = message?.Length ?? 0;
    Console.WriteLine($"길이: {length}");
    message = "hello";
    length = message?.Length ?? 0;
    Console.WriteLine($"길이: {length}");
    Console.WriteLine();
}

// 3-2
{
    List<string> names = null;
    Console.Write("이름 수: ");
    Console.WriteLine(names?.Count ?? 0);
    names = new List<string> { "kim", "kim", "kim" };
    Console.Write("이름 수: ");
    Console.WriteLine(names?.Count ?? 0);
    Console.WriteLine();
}

// 3-3
{
    string playerName = null;
    int? playerLevel = null;
    List<string> inventory = null;

    string displayName = playerName ?? "Unknown";
    int level = playerLevel ?? 1;
    int itemCount = inventory?.Count ?? 0;
    Console.WriteLine($"플레이어: {displayName}");
    Console.WriteLine($"레벨: {level}");
    Console.WriteLine($"인벤토리 아이템: {itemCount}");
}