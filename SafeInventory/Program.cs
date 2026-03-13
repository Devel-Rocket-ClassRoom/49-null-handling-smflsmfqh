using System;
using System.Collections.Generic;

List<string> player1Items = null;
List<string> player2Items = new List<string>();
List<string> player3Items = new List<string>{ "검", "방패", "포션" };

Console.Write($"=== 플레이어 1 ");
PrintItems(player1Items);
Console.Write($"=== 플레이어 2 ");
PrintItems(player2Items);
Console.Write($"=== 플레이어 3 ");
PrintItems(player3Items);

void PrintItems(List<string> items)
{
    
    if (items == null || items?.Count == 0)
    {
        Console.WriteLine(items == null ? "(인벤토리 없음)" : "(빈 인벤토리)");
    }
    else { Console.WriteLine("(아이템 보유)"); }
    Console.WriteLine($"아이템 수: {items?.Count ?? 0}");
    if (items != null && items.Count == 0)
    {
        Console.WriteLine($"첫 번째 아이템: 없음");
        Console.WriteLine($"마지막 아이템: 없음");
    }
    else
    {
        Console.WriteLine($"첫 번째 아이템: {items?[0] ?? "없음"}");
        Console.WriteLine($"마지막 아이템: {items?[2] ?? "없음"}");
    }
    Console.WriteLine();
}
