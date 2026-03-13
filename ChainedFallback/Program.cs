using System;

string userSetting = null;
string profileSetting = "프로필 유저";
string globalSetting = null;
string defaultValue = "Player";

string userServer = null;
string profileServer = null;
string globalServer = null; 
string defaultServer = "localhost";

string userLanguage = "English";
string profileLanguage = "Korean";
string globalLanguage = "Japanese";
string defaultLanguage = "Korean";

int? userVolume = null;
int? profileVolume = null;
int? globalVolume = 70;
int? defaultVolume = 50;

string playerName = userSetting ?? profileSetting ?? globalSetting ?? defaultValue;
string serverAddress = userServer ?? profileServer ?? globalServer ?? defaultServer;
string LanguageSetting = userLanguage ?? profileLanguage ?? globalLanguage ?? defaultLanguage;
int? volumeSetting = userVolume ?? profileVolume ?? globalVolume ?? defaultVolume;

string cash = null;

Console.WriteLine("=== 설정 결정 ===");
Console.WriteLine($"플레이어 이름: {playerName} (프로필 설정에서 가져옴)");
Console.WriteLine($"서버 주소: {serverAddress} (기본값에서 가져옴)");
Console.WriteLine($"언어: {LanguageSetting} (사용자 설정에서 가져옴)");
Console.WriteLine($"볼륨: {volumeSetting} (전역 설정에서 가져옴)");
Console.WriteLine();
Console.WriteLine("=== 캐시 저장 (??=) ===");
Console.WriteLine($"캐시 저장 전: {cash}");

cash ??= playerName;
Console.WriteLine($"첫 번째 ??= 적용 후: {cash}");
cash ??= playerName;
Console.WriteLine($"두 번째 ??= 적용 후: {cash}");
Console.WriteLine();
Console.WriteLine("=== 최종 설정 ===");
Console.WriteLine($"플레이어 이름: {playerName} ");
Console.WriteLine($"서버 주소: {serverAddress} ");
Console.WriteLine($"언어: {LanguageSetting} ");
Console.WriteLine($"볼륨: {volumeSetting} ");