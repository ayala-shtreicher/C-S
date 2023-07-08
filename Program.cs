using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


        //public static string FindIntersection(string[] strArr)
        //{

        //    string result = string.Join(",", strArr[0].Split(',').Select(x => x.Trim()).Intersect(strArr[1].Split(",").Select(y => y.Trim())));
        //    return string.IsNullOrEmpty(result) ? "false" : result;
        //}

        //public static string QuestionsMarks(string str)
        //{
        //    int firstDigit = 0;
        //    int sumQuestionsMark = 0;
        //    bool isFirstDigit = true, isUpTo10 = false;

        //    foreach (char c in str)
        //    {
        //        if (Char.IsDigit(c))
        //        {
        //            if (!isFirstDigit)
        //            {
        //                if (firstDigit + (int)Char.GetNumericValue(c) == 10)
        //                {
        //                    isUpTo10 = true;
        //                    if (sumQuestionsMark != 3)
        //                    {
        //                        return "false";
        //                    }
        //                    else
        //                    {
        //                        sumQuestionsMark = 0;
        //                        firstDigit = (int)Char.GetNumericValue(c);
        //                    }
        //                }

        //            }
        //            isFirstDigit = false;
        //            firstDigit = (int)Char.GetNumericValue(c);
        //        }
        //        else if (c == '?' && !isFirstDigit)
        //            sumQuestionsMark++;
        //    }
        //    return isUpTo10 ? "true" : "false";
        //}

        //public static string FirstReverse(string str)
        //{

        //    char[] array = str.ToCharArray();
        //    Array.Reverse(array);
        //    return new string(array);
        //}

        //public static string CodelandUsernameValidation(string str)
        //{

        //    string isValidUser = "false";

        //    //Checking all criteria for the username validation
        //    if (str.Length > 4 && str.Length < 25
        //    && str.Substring(str.Length - 1, 1) != "_"
        //    && Regex.IsMatch(str, @"^[a-zA-Z0-9_]+$")
        //    && Regex.IsMatch(str.Substring(0, 1), @"^[a-zA-Z]+$"))
        //    {
        //        isValidUser = "true";
        //    }

        //    return isValidUser;

        //}

        //public static string TreeConstructor(string[] strArr)
        //{
        //    var childs = strArr.ToList().Select(i => i.Split(',')[0].Replace("(", string.Empty)).ToList();
        //    var parents = strArr.ToList().Select(i => i.Split(',')[1].Replace(")", string.Empty)).ToList();
        //    return childs.Distinct().Count() == strArr.Count() &&
        //          parents.GroupBy(p => p).Where(g => g.Count() > 2).Any() ? "false" : "true";
        //}

        //static int catalan(int n)
        //{
        //    int res = 0;

        //    if (n <= 1) { return 1; }

        //    for (int i = 0; i < n; i++)
        //        res += catalan(i) * catalan(n - i - 1);

        //    return res;
        //}

        //public static int BracketCombinations(int num)
        //{
        //    return catalan(num);
        //}







        //      function isOdd(c)
        //      {
        //          return parseInt(c) & 1;
        //      }


        //      function odd2(str)
        //      {
        //          let result = ""
        //        for (i = 0; i < str.length - 1; i++)
        //          {
        //              if (isOdd(str[i]) && isOdd(str[i + 1]))
        //                  result += (str[i]) + "-"
        //              else
        //                  result += str[i]
        //}
        //          result += str[str.length - 1];
        //          return result
        //      }

        //   public static string LongestWord(string sen) {

        //     // code goes here  
        //     return Regex.Replace(sen,@"(\p{P})","").Split(' ').OrderByDescending(i=>i.Length).First();

        //   }



        //     WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/age-counting");
        //     WebResponse response = (HttpWebResponse)request.GetResponse();

        //     using (var dataStream = response.GetResponseStream())
        //     {
        //       var reader = new StreamReader(dataStream);
        //       var json = reader.ReadToEnd();

        //       var ageCount =  GetAgeCount(json);

        //       Console.WriteLine(ageCount);
        //     }

        //     response.Close();
        //   } 

        //   public static int GetAgeCount(string json)
        //   {
        //     json = json.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "");
        //     var content = json.Replace(@"{""data"":""", "").Replace("}", "");
        //     var contentArr = content.Split(',');
        //     var ageCounter = 0;

        //     foreach(var item in contentArr)
        //     {
        //       if(item.IndexOf("age=")> -1)
        //       {
        //         var age = int.TryParse(item.Split('=').Last(), out var parseAge) ? parseAge : 0;
        //         if(age >= 50) ageCounter++;
        //       }
        //     }

        //     return ageCounter;
        //   } 
        // }





        //        string input = "aabbbggyaa";
        //        string result = "";

        //        int count = 1;
        //for (int i = 1; i<input.Length; i++)
        //{
        //    if (input[i] == input[i - 1])
        //    {
        //        count++;
        //    }
        //    else
        //    {
        //        result += count.ToString() + input[i - 1];
        //        count = 1;
        //    }
        //}

        //// Add the count and letter for the last sequence
        //result += count.ToString() + input[input.Length - 1];
    }
}
