using System;

int?[] scores = { 3, null, 7, null, 5 };
int proceedMatch = 0;
int totalScore = 0;
double average = 0;

Console.WriteLine("=== 경기 상태 ===");
for (int i = 0; i < scores.Length; i++)
{
    if (scores[i].HasValue)
    {
        proceedMatch++;
        totalScore += scores[i].Value;
        Console.WriteLine($"경기 {i + 1}: {scores[i].Value}점 (진행 완료)");
    }
    else { Console.WriteLine($"경기 {i + 1}: 미진행"); }
}
Console.WriteLine();
Console.WriteLine("=== 전체 점수 (미진행 = -1) ===");
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"경기 {i + 1}: {scores[i].GetValueOrDefault(-1)}");
}
Console.WriteLine();
average = totalScore / (double)proceedMatch;
Console.WriteLine("=== 통계 ===");
Console.WriteLine($"진행된 경기 수: {proceedMatch}");
Console.WriteLine($"총점: {totalScore}");
Console.WriteLine($"평균: {average:F1}");