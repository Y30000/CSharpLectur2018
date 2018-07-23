/*
1. 6~15
2. 연속동일문자 나오지 않게 
3. 적어도 하나의 소문자   *
4. 적어도 하나의 대문자   *
5. 적어도 하나의 특수문자 
6. 공백 제외            *
*/

using System;
using System.Text.RegularExpressions;

class MainClass {
  public static bool CheckPassword(string str){

    /*
    bool capital_check = false, small_check, special_check;

    for(int i = 0; i < str.Length; ++i){

      if(str[i] == ' ')
        return false;

      if(i < str.Length-1)
        if(str[i] == str[i+1])
          return false;
      }

      if( false == capital_check && str[i] >= 'A' && str[i] <= 'Z')
        capital_check = true;
      if( false == small_check && str[i] >= 'a' && str[i] <= 'z')
        small_check = true;
      if( false == special_check && (str[i] >= '!' && str[i] <= '/') || (str[i] >= ':' && str[i] <= '@') || (str[i] >= '[' && str[i] <= '`') ||  (str[i] >= '{' && str[i] <= '~')  )
        special_check = true;
      

    }
    return capital_check && small_check && special_check
    */

    if(str.Length < 6 || str.Length > 15)
      return false;

    if(false == Regex.IsMatch(str,@"[A-Z]"))
      return false;
// Console.WriteLine("A");
    if(false == Regex.IsMatch(str,@"[a-z]"))
      return false;
// Console.WriteLine("a");
//  if(false == Regex.IsMatch(str,@"[^a-zA-Z]"))
    if(false == Regex.IsMatch(str,@"!@#$%^&*()?/>.<,:;'\\|}]{[_~`+=\"-))
      return false;
// Console.WriteLine("!");
    if(true == Regex.IsMatch(str,@"\s"))
      return false;
// Console.WriteLine(" ");

    for(int i = 0; i < str.Length; ++i){
      if(i < str.Length-1)
        if(str[i] == str[i+1])
          return false;
      }
    return true;
    }
    
  public static void Main (string[] args) {
    Console.WriteLine(CheckPassword("Abcdefghijk!") == true);
    Console.WriteLine(CheckPassword("Abcde") == false);             //6자리 미만
    Console.WriteLine(CheckPassword("Abccefghijk!") == false);      //c가 연속됨
    Console.WriteLine(CheckPassword("ABCDEFGHIJK!") == false);      //소문없음
    Console.WriteLine(CheckPassword("abcdefghijk!") == false);      //대문없음
    Console.WriteLine(CheckPassword("Abcdefghijk") == false);       //특수없음
    Console.WriteLine(CheckPassword("Abcdefghijk !") == false);     //공백

    Console.WriteLine(CheckPassword("Abcdefdfdfdghijk!") == false); //15자리 초과
    Console.WriteLine(CheckPassword("") == false);                  //6자리 미만
    Console.WriteLine(CheckPassword("Abcdefghijk\\") == true);
  }
}