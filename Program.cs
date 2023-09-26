#region 1. Two Sum
//int[] TwoSum(int[] nums, int target)
//{
//    //var temporary = new List<int>(nums);

//    ////temporary = temporary.Where(x => x <= target).ToList();

//    //for (int i = 0; i < temporary.Count; i++) 
//    //{
//    //    for (int j = i + 1; j < temporary.Count; j++)
//    //    {
//    //        if (temporary[i] + temporary[j] == target) 
//    //        {
//    //           return new int[] { i, j };
//    //        }
//    //    }
//    //}
//    //return new int[0];


//    var Temporary = new List<int>();
//    foreach (var item in nums)
//        if (item < target)
//            Temporary.Add(item);
//    //Temporary.Sort();

//    var Output = new List<int>();
//    int Sum = 0;
//    foreach (var item in Temporary)
//    {
//        if (Sum + item <= target)
//        {
//            Sum += item;
//            Output.Add(item);
//        }
//    }

//    return Output.Select(x => nums.ToList().IndexOf(x)).ToArray();


//}

//int[] nums = { 3, 2, 4 };

//foreach (var temp in TwoSum(nums, 6))
//    Console.WriteLine(temp);
#endregion 1. Two Sum

#region 9. Palindrome Number
//bool IsPalindrome(int x)
//{
//    string temporary = x.ToString();
//    string solution = String.Join("", temporary.Reverse());
//    return solution == temporary;
//}

#endregion 9. Palindrome Number

#region 13. Roman to Integer

//string s = "MCMXCIV";
//string temporary = string.Empty;
//int temp = 0;
//bool Check = false;

//Dictionary<string, int> roman = new Dictionary<string, int>()
//{
//    { "M", 1000 },
//    { "CM", 900 },
//    { "D", 500 },
//    { "CD", 400 },
//    { "C", 100 },
//    { "XC", 90 },
//    { "L", 50 },
//    { "XL", 40 },
//    { "X", 10 },
//    { "IX", 9 },
//    { "V", 5 },
//    { "IV", 4 },
//    { "I", 1 }
//};

//for (int i = 0; i < s.Length; i++) 
//{
//    foreach (var year in roman)
//        if (s[i].ToString() == year.Key)
//            temp += year.Value;
//}

//for (int i = 0; i < s.Length; i++)
//{
//    if (Check) 
//    {
//        Check = false;
//        i++;
//        //continue;
//    }
//    if (i < s.Length -  1)
//        temporary = s[i] + "" + s[i + 1];
//    {
//        foreach (var item in roman)
//            if (temporary == item.Key)
//            {
//                temp += item.Value;
//                Check = true;
//                break;
//            }
//        if (!Check) 
//        {
//            foreach (var item in roman)
//                if (s[i].ToString() == item.Key)
//                {
//                    temp += item.Value;
//                    break;
//                }
//        }
//    }
//}

//List<string> romansplit = Enumerable.Range(0, s.Length)
//            .Select(x => x < s.Length - 1 && roman.ContainsKey(s.Substring(x, 2)) ?
//                s.Substring(x, 2) :
//                s.Substring(x, 1))
//            .ToList();
//foreach (var item in romansplit)
//    Console.WriteLine(item);

//while (s != "")
//{
//    Check = false;
//    if (s.Length >= 2) 
//    {
//        temporary = s[0] + "" + s[1];
//        foreach (var item in roman)
//            if (temporary == item.Key)
//            {
//                temp += item.Value;
//                s = s.Substring(2);
//                Check = true;
//                break;
//            }
//        if (Check)
//            continue;
//        else 
//        {
//            temporary = s[0].ToString();
//            foreach (var item in roman)
//                if (temporary == item.Key)
//                {
//                    temp += item.Value;
//                    s = s.Substring(1);
//                    break;
//                }
//        }
//    }
//    else
//    {
//        temporary = s[0].ToString();
//        foreach (var item in roman)
//            if (temporary == item.Key)
//            {
//                temp += item.Value;
//                s = s.Substring(1);
//                break;
//            }
//    }
//}

//Console.WriteLine(temp);

#endregion 13. Roman to Integer

#region 14. Longest Common Prefix
//string[] strs = { "ab", "a" };
//Array.Sort(strs);
//int count = strs[0].Length;
//string temporary = string.Empty;
//string result = string.Empty;

//bool Check = true;

//if (strs.Length == 0) Console.WriteLine($"break + {result}"); // return

//for (int i = 0; i < count; i++)
//{
//    string str = strs[0];
//    char temp = str[0];
//    {
//        foreach (string x in strs)
//        {
//            if (temp == x[0])
//                continue;
//            else
//            {
//                Check = false;
//                Console.WriteLine($"break + {result}"); // return
//            }
//        }
//        if (Check)
//        {
//            result += temp;
//            for (int j = 0; j < strs.Length; j++)
//            {
//                temporary = strs[j];
//                temporary = temporary.Substring(1);
//                strs[j] = temporary;
//            }

//        }
//    }
//}

//Console.WriteLine(result); // return

#endregion 14. Longest Common Prefix

#region 4. Median of Two Sorted Arrays

//var list1 = new List<int> { 1, 2, 4 };
//var list2 = new List<int> { 1, 3, 4 };

//var result = new List<int>();

//foreach (var item in list1)
//    result.Add(item);

//foreach (var item in list2)
//    result.Add(item);

//result.Sort();

// if (result.Count %2 == 0)
//{
//    Console.WriteLine("чет");
//    float x = ((float)result[(result.Count / 2) - 1] + (float)result[result.Count / 2]) / 2;
//    Console.WriteLine($"return {x}");   //return
//}
//else
//{
//    Console.WriteLine("нечет");
//    double x = (result[result.Count / 2]);
//    Console.WriteLine($"return {x}");   //return
//}

//foreach (var item in result)
//    Console.WriteLine(item); 

#endregion 4. Median of Two Sorted Arrays

#region 20. Valid Parentheses (не закончил)

//string s = "()[]{}";

//int check1left = 0;
//int check1right = 0;
//int check2left = 0;
//int check2right = 0;
//int check3left = 0;
//int check3right = 0;

//foreach (char item in s)
//{
//    if (item == '(') { check1left++; continue; }
//    if (item == ')') { check1right++; continue; }
//    if (item == '[') { check2left++; continue; }
//    if (item == ']') { check2right++; continue; }
//    if (item == '{') { check1left++; continue; }
//    if (item == '}') { check1right++; continue; }
//}

//if (check1left == check1right && check2left == check2right && check3left == check3right) Console.WriteLine("true");
//else Console.WriteLine("false");

#endregion

#region 26. Remove Duplicates from Sorted Array
//int[] nums = { 1, 1, 2 };
//var list = new List<int>();
//list.Add(nums[0]);

//foreach (int i in nums)
//    if (i != list[list.Count - 1])
//        list.Add(i);

//for (int i = 0; i < list.Count; i++)
//    nums[i] = list[i];

//Console.WriteLine($"k   " + nums.Length); // return

#endregion 26. Remove Duplicates from Sorted Array

#region 27. Remove Element

//int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
//int val = 2;

//var list = new List<int>();

//foreach (int x in nums)
//    if (x != val) list.Add(x);

//for (int i = 0; i < list.Count; i++)
//    nums[i] = list[i];

//Console.WriteLine(list.Count);  // return

#endregion 27. Remove Element

#region 28. Find the Index of the First Occurrence in a String


//if (haystack.Length < needle.Length) //return -1;     //return

//    using System.Data.SqlTypes;

//string haystack = "mississippi";
//string needle = "issip";

//----------------------------------------------old

//int temp = -1;
//int index = 0;
//bool Check = false;
//int counter = 0;
//foreach (char c in haystack)
//{
//temp++;
//if (counter < needle.Length)
//{
//if (c == needle[counter])
//{
//if (!Check)
//index = temp;
//Check = true;
//counter++;
//}
//else
//{
//counter = 0;
//Check = false;
//}
//}
//else { Check = true; break; }
//}

//if (Check)
//Console.WriteLine(index);
//else
//Console.WriteLine("-1");

//---------------------------------------------- old

//int temporary = haystack.IndexOf(needle);
//Console.WriteLine(temporary);    // return


#endregion 28. Find the Index of the First Occurrence in a String

#region 3. Longest Substring Without Repeating Characters
using System.Net.Http.Headers;

https://leetcode.com/problems/longest-substring-without-repeating-characters/

// ---------------------------------------------- old
//foreach (char c in s)
//{
//    foreach (char c2 in max)
//        if (c2 == c)
//        {
//            temporary.Add(max.Length);
//            max = string.Empty;
//        }
//    max += c;
//    if (max.Length == s.Length)
//        temporary.Add(max.Length);
//}
//temporary.Sort();
//if (max.Length > temporary[temporary.Count - 1])
//    temporary.Add(max.Length);
// ---------------------------------------------- old

//string input = "pwwkew";
//string max = string.Empty;
//int result = 0;
//bool check = false;

//while (input != string.Empty)
//{
//    foreach (char ci in input)
//    {
//        if (max == string.Empty && input != string.Empty) 
//        {
//            max += input[0];
//            continue;
//        }

//        foreach (char cm in max)
//        {
//            if (ci == cm)
//            {
//                if (max.Length > result)
//                    result = max.Length;
//                max = string.Empty;
//                input = input.Substring(1);
//                check = true;
//            }
//        }
//        if (check) 
//        { 
//            check = false;
//            break;
//        }
//        if (max != string.Empty && max[max.Length - 1] != ci && input != string.Empty)
//        { 
//            max += ci;
//            continue; 
//        }
//    }
//}

//Console.WriteLine(result);   //  return

#endregion 3. Longest Substring Without Repeating Characters

#region 389. Find the Difference

//string a = "abcd";
//string b = "abcde";

//int x = 0;
//int y = 0;

//foreach (char c in a)
//    x += (int)c;

//foreach (char c in b)
//    y += (int)c;

//Console.WriteLine((char)Math.Abs(x - y));   // return

#endregion 389. Find the Difference

#region 35. Search Insert Position

////Input: nums = [1,3,5,6], target = 5 

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] < target) continue;
//    if (nums[i] >= target) return i;
//}
//return nums.Length;

#endregion 35. Search Insert Position

#region 58. Length of Last Word

//string s = "   fly me   to   the moon  ";
//var temporary = new List <char>();
//int counter = 0;

//foreach (char item in s)
//    temporary.Add(item);
//temporary.Reverse();

//while (true)
//{
//    if (temporary[0] == ' ')
//        temporary.RemoveAt(0);
//    else
//        break;
//}

//foreach (char item in temporary)
//    if (item != ' ')
//        counter++;
//    else 
//        break;

//Console.WriteLine(counter);
//return counter;

#endregion 58. Length of Last Word

#region 69. Sqrt(x)

//int x = 8;
//double temp = Math.Sqrt(x);
//double result = temp - temp % 1;
//return (int)result;

#endregion 69. Sqrt(x)

#region 70. Climbing Stairs

//int n = 10;
////if (n == 1) return 1;
////if (n == 2) return 2;
//var temporary = new List<int>();

//temporary.Add(1);

//if (n > 2) 
//{
//    temporary.Add(1);
//    for (int i = 1; i < n; i++)
//        temporary.Add(temporary[i] + temporary[i - 1]);
//}

//Console.WriteLine(temporary[n]);  //  return;

#endregion 70. Climbing Stairs