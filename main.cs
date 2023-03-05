using System;
using System.Text.RegularExpressions;
class Program {
  public static void Main (string[] args) {
    string email = "moshtkov@gmail.com fsnfns moshtkov@gmail.c mosh_tkov@gma_il.com sfgdgdf";
    Regex regex1 = new Regex(@"\w[a-zA-Z_]{0,20}@+\w[a-zA-Z_]{0,20}\.+\w[a-zA-z]{1,20}");
    Match emailMatch1 = regex1.Match(email);
    while(emailMatch1.Success)
    {
      Console.WriteLine("Index: "+emailMatch1.Index);
      emailMatch1 = emailMatch1.NextMatch();
    }
    string date1 = "00:00:00 23:59:59 56:67:78";
    Regex regex2 = new Regex(@"([0-1][0-9]|[2][0-3]):[0-5][0-9]:[0-5][0-9]");
    Match matchDate1 = regex2.Match(date1);
    while(matchDate1.Success)
    {
      Console.WriteLine("Index: "+matchDate1.Index);
      matchDate1 = matchDate1.NextMatch();
    }
    string date2 = "Edit the Expression & Text to see matches. 25.05.1989 Roll over matches or the expression for details. PCRE & JavaScript flavors of RegEx are supported. Validate your expression with Tests mode. The side bar includes a Cheatsheet, 02.03.2023 full Reference, and Help. You can also Save & Share with the Community and view patterns you create or favori.";
    Regex regex3 = new Regex(@"(?<=\s|^)((0?[1-9]|[12][0-9]|3[0])\.(04|06|09|11)|(0?[1-9]|[12][0-9]|3[01])\.(01|03|05|07|08|10|12)|(0?[1-9]|[12][0-9]])\.(03))\.([0-1][0-9]\d\d|20([0-1]\d|2[0-3]))");
    Match matchDate2 = regex3.Match(date2);
    while(matchDate2.Success)
    {
      Console.WriteLine("Index: "+matchDate2.Index);
      matchDate2 = matchDate2.NextMatch();
    }
  }
}