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

// Attempted
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
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

// https://leetcode.com/problems/longest-substring-without-repeating-characters/

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

#region 88. Merge Sorted Array

//int[] nums1 = { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
//int[] nums2 = { 1, 2, 2 };
////int index = 0;
//// if (n == 0) return;
//var temporary = new List<int>();
//foreach (int item in nums2)
//    if (item != 0) 
//        temporary.Add(item);

//Array.Reverse(nums1);

//for (int i = 0; i < temporary.Count; i++)
//{
//    nums1[i] = temporary[i];
//}

//Array.Sort(nums1);
////return;

#endregion 88. Merge Sorted Array

#region 66. Plus One

//int[] digits = { 9, 9, 9, 9 };
//var temporary = new List<int>();
//foreach (var item in digits)
//    temporary.Add(item);
//temporary.Reverse();
//temporary[0] += 1;

//for (int i = 0; i < temporary.Count; i++)
//{
//    if (temporary[i] == 10 && i < temporary.Count - 1)
//    {
//        temporary[i] = 0;
//        temporary[i + 1] += 1;
//        continue;
//    }
//    if (temporary[i] == 10 && i == temporary.Count - 1)
//    {
//        temporary[i] = 0;
//        temporary.Add(1);
//    }

//}
//temporary.Reverse();
//digits = temporary.ToArray();

#endregion 66. Plus One

// Attempted Time Limit Exceeded
#region 880. Decoded String at Index "Why is everyone saying it's difficult. Seems pretty easy" runs code - TLE...... OH I see

//string s = "yyuele72uthzyoeut7oyku2yqmghy5luy9qguc28ukav7an6a2bvizhph35t86qicv4gyeo6av7gerovv5lnw47954bsv2xruaej";
//int k = 123365626;
//string temp;
//int Check = 0;
//var temporary = new List<char>(k);

//foreach (var iteminstring in s)     // Захожу в строку с условием для перебора
//{
//    if (iteminstring >= '0' && iteminstring <= '9')     // Находим число
//    {
//        Check = iteminstring - 48;   // Convert to Int :D
//        temp = string.Empty;    // Обнуляем временную строку,для записи того, что нужно умножить
//        foreach (char iteminlist in temporary)      // Заполняем временную строку
//            temp += iteminlist;
//        for (int i = 0; i < Check - 1; i++)     // Заходим в цикл для умножения (количество циклов - равно сумме умножения)
//        {
//            foreach (char item in temp)     // Перебираем временную строку, чтобы записать её в основную
//            {
//                temporary.Add(item);
//                if (temporary.Count >= k)       // Условие выхода, чтобы не записывать лишнее
//                    break;
//            }
//        }
//    }
//    else
//        temporary.Add(iteminstring);        // добавляем символ в строку

//    if (temporary.Count >= k)
//        break;  // return
//}

#endregion 880. Decoded String at Index "Why is everyone saying it's difficult. Seems pretty easy" runs code - TLE...... OH I see

#region 125. Valid Palindrome
//string s = "A man, a plan, a canal: Panama";
//s = s.ToLower();
//string temporary1 = string.Empty;

//foreach (char item in s)
//    if (item >= 'a' && item <= 'z' || item >= '0' && item <= '9')
//        temporary1 += item;

//string temporary2 = new string(temporary1.ToCharArray()
//                                .Reverse()
//                                .ToArray());
//if (temporary1 == temporary2)
//    Console.WriteLine("true"); // return true;
//else
//    Console.WriteLine("false"); // return false;
#endregion 125. Valid Palindrome

#region 169. Majority Element
//Array.Sort(nums);
//int temp = nums[0];
//int counter = 0;
//float temporary = nums.Length / 2;
//foreach (var item in nums)
//{
//    if (counter - 1 >= temporary)
//        break;
//    if (temp == item)
//    {
//        counter++;
//    }
//    else
//    {
//        counter = 1;
//        temp = item;
//    }
//}
// return temp;

////return nums.OrderBy(x => x).ToList()[nums.Length / 2];
////return nums.OrderBy(x => x).Skip(nums.Length / 2).Take(1).First();
////int ReturnMostFoundItem1(int[] array) => array.OrderBy(x => x).ToList()[array.Length / 2];
////int ReturnMostFoundItem2(int[] array) { return array.OrderBy(x => x).ToList()[array.Length / 2]; }
#endregion 169. Majority Element

#region 190. Reverse Bits

/// <summary>
/// 190. Reverse Bits
///Easy
///Topics
///Companies
///Reverse bits of a given 32 bits unsigned integer.
///Note:
///Note that in some languages, such as Java, there is no unsigned integer type. In this case, both input and output will be given as a signed integer type. They should not affect your implementation, as the integer's internal binary representation is the same, whether it is signed or unsigned.
///In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 2 above, the input represents the signed integer -3 and the output represents the signed integer -1073741825.
/// </summary> 

//uint n = 43261596;
//uint result = 0;
//string temporary = Convert.ToString(n, 2);
//int delta = 32 - temporary.Length;
//for (int i = 0; i < temporary.Length; i++)
//{
//    if (temporary[i] == '1')
//        result += Convert.ToUInt32(Math.Pow(2, i + delta));
//}
//Console.WriteLine(result); //return result;

//
//var temporary = Convert.ToString(n, 2).Select(x => (x == '1')?true:false);
//int delta = 32 - temporary.Count();
//foreach (var item in temporary.Select((x, i) => new { x, i }))
//    if (item.x)
//        result += Convert.ToUInt32(Math.Pow(2, item.i + delta));
//

#endregion 190. Reverse Bits

#region 1323. Maximum 69 Number
//int num = 9669;
//string temp = num.ToString();
//string temporary = string.Empty;
//bool check = false;
//foreach (char item in temp)
//{
//    if (!check && item == '6')
//    {
//        temporary += '9';
//        check = true;
//    }
//    else
//        temporary += item;
//}
//return Convert.ToInt32(temporary);
#endregion 1323. Maximum 69 Number

#region 492. Construct the Rectangle
//int area = 122122;

//int temp = (int)Math.Sqrt(area) + 1;
//double result = 0;
//int[] array = new int[2];
//while (true)
//{
//    result = (double)area / temp;
//    if (result % 1 == 0)
//        break;
//    else
//        temp--;
//}
//if (result > temp)
//{
//    array[0] = (int)result;
//    array[1] = temp;
//}
//else
//{
//    array[0] = temp;
//    array[1] = (int)result;
//}
//foreach (int i in array)
//    Console.WriteLine(i);
#endregion 492. Construct the Rectangle

// Attempted 2 Out of memory
#region 880. Decoded String at Index

//string s = "yyuele72uthzyoeut7oyku2yqmghy5luy9qguc28ukav7an6a2bvizhph35t86qicv4gyeo6av7gerovv5lnw47954bsv2xruaej"; int k = 123365626; // Input Data

//string[] wordsTemporary = s.Split(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' });
//string[] words = new string[wordsTemporary.Length];

//for (int i = 0, j = 0; i < wordsTemporary.Length; i++)
//{
//    if (wordsTemporary[i].Length != 0)
//    {
//        words[j] = wordsTemporary[i];
//        j++;
//    }
//}

//bool previosCharIsDigit = false;
//int temporaryMultipler = 0;
//List<string> temporaryNumbers = new List<string>();

//foreach (char c in s)
//{
//    if (char.IsDigit(c))
//    {
//        if (previosCharIsDigit == false)
//        {
//            previosCharIsDigit = true;
//            temporaryMultipler = c - 48;
//        }
//        else
//        {
//            temporaryMultipler *= c - 48;
//        }
//    }
//    else
//    {
//        if (previosCharIsDigit == true)
//        {
//            previosCharIsDigit = false;
//            temporaryNumbers.Add(temporaryMultipler.ToString());
//            temporaryMultipler = 0;
//        }
//    }
//}
//if (temporaryMultipler != 0)
//{
//    temporaryNumbers.Add(temporaryMultipler.ToString());
//}

//int[] numbers = new int[temporaryNumbers.Count];

//for (int i = 0; i < temporaryNumbers.Count; i++)
//{
//    numbers[i] = Int32.Parse(temporaryNumbers[i]);
//}

//StringBuilder targetString = new StringBuilder();
//StringBuilder temporaryTargetString = new StringBuilder();

//int wordIndex = 0;
//int wordIndexChecker = -1;
//if (numbers.Length > 0)
//{
//    while (true)
//    {
//        if (wordIndexChecker != wordIndex)
//        {
//            targetString.Append(words[wordIndex]);
//            if (targetString.Length >= k)
//            {
//                break;
//            }
//            wordIndexChecker = wordIndex;
//        }

//        temporaryTargetString.Clear();
//        temporaryTargetString.Append(targetString);

//        for (int i = 1; i <= numbers[wordIndex] - 1; i++)
//        {
//            targetString.Append(temporaryTargetString);
//            if (targetString.Length >= k)
//            {
//                break;
//            }
//        }
//        wordIndex++;
//    }
//}
//else
//{
//    Console.WriteLine(s[k - 1]);
//}

//Console.WriteLine(targetString[k - 1]);


#endregion 880. Decoded String at Index

#region 8. String to Integer (atoi)

//string s = "  +  413"; // Input

//s = s.Trim();
//bool checkTakeNumber = false;
//var temporary = new List<int>();
//var temp = string.Empty;
//int checkminus = 1;
//Int64 check = 0;
//int result = 0;
//int counterPlus = 0;
//int counterMinus = 0;
//foreach (var c in s)
//{
//    if (!char.IsDigit(c))
//    {
//        if (c == '-' && !checkTakeNumber)
//        {
//            counterMinus++;
//        }
//        else if (c == '+' && !checkTakeNumber)
//        {
//            counterPlus++;
//        }
//        else if (c == ' ' && !checkTakeNumber && counterMinus > 0 || counterPlus > 0)
//        {
//            break;
//        }
//        else if (c == ' ' && !checkTakeNumber)
//        {
//            continue;
//        }
//        else
//        {
//            break;
//        }
//    }
//    else if (char.IsDigit(c))
//    {
//        checkTakeNumber = true;
//        temporary.Add((int)char.GetNumericValue(c));
//    }
//    else if (checkTakeNumber)
//    {
//        break;
//    }
//}

//if (counterPlus > 0 && counterPlus == counterMinus)
//    return 0;
//if (counterPlus > 1)
//    return 0;
//if (counterMinus > 1)
//    return 0;

//foreach (int c in temporary)
//    temp += c;

//foreach (var c in s)
//    if (c == '-')
//    {
//        checkminus = -1;
//        break;
//    }

//int max = 2147483647;
//int min = -2147483648;

//temp = Regex.Replace(temp, @"^0+(?=\d+$)", "");

//if (temp == string.Empty)
//{
//    result = 0;
//    return result;
//}
//else if (temp.Length <= 10)
//{
//    check = checkminus * Convert.ToInt64(temp);
//}
//else
//{
//    if (checkminus == -1)
//        return min;
//    else
//        return max;
//}

//if (check <= min)
//{
//    return min;
//}

//if (check >= max)
//{
//    return max;
//}

//result = Convert.ToInt32(temp);

//if (counterMinus > 0)
//    return result * checkminus;
//else
//    return result;

#endregion 8. String to Integer (atoi)

#region 7. Reverse Integer
//int x = 123;

//Int64 check = 2147483647;
//Int64 max = 2147483647;
//Int64 min = -2147483648;
//var temporary = new List<int>();
//string tempstring = x.ToString();
//if (x < 0)
//{
//    tempstring = tempstring.Substring(1);
//}

//foreach (int i in tempstring)
//    temporary.Add(i - 48);

//temporary.Reverse();

//tempstring = string.Empty;
//foreach (int i in temporary)
//    tempstring += i;

//if (x < 0)
//    check = -1 * Convert.ToInt64(tempstring);
//else
//    check = Convert.ToInt64(tempstring);

//if (max < check || check < min)
//    return 0;
//else if (x < 0)
//    return -1 * Convert.ToInt32(tempstring);
//else
//    return Convert.ToInt32(tempstring);

#endregion 7. Reverse Integer

#region 11. Container With Most Water

//int[] height = { 1, 2, 4, 3 };

//int Max = 0;
//int i = 0, j = height.Length - 1;

//while (i != j)
//{
//    GetMax();

//    if (height[i] >= height[j])
//        while (i != j)
//        {
//            if (height[i] > height[j])
//            {
//                j--;
//                GetMax();
//            }
//            else if (height[i] == height[j])
//            {
//                GetMax();
//                i++;
//                break;
//            }
//            else break;
//        }

//    if (height[j] >= height[i])
//        while (i != j)
//        {
//            if (height[j] > height[i])
//            {
//                i++;
//                GetMax();
//            }

//            else if (height[i] == height[j])
//            {
//                GetMax();
//                j--;
//                break;
//            }
//            else break;
//        }
//}
//void GetMax()
//{
//    if (height[i] < height[j])
//    {
//        if (height[i] * (j - i) > Max)
//            Max = height[i] * (j - i);
//    }
//    else
//    {
//        if (height[j] * (j - i) > Max)
//            Max = height[j] * (j - i);
//    }
//}

//Console.WriteLine(Max);

#endregion 11. Container With Most Water

#region 10. Regular Expression Matching

//string s = "mississippi", p = "mis*is*ip*.";
//if (s.Length == 1 && s == p || p == ".") Console.WriteLine("true"); // return true;
//if (s == p) Console.WriteLine("true"); // return true;
//char temp = s[0];
//bool result = true;
//for (int i = 0, j = 0; i < s.Length; i++)
//{
//    if (j >= p.Length)
//    {
//        result = false;
//        break;
//    }
//    if (p[j] == '*')
//    {
//        if (p[j-1] == '.')
//        {
//            continue;
//        }
//        if (s[i] == temp)
//        {
//            continue;
//        }
//        else
//        {
//            result = false;
//            break;
//        }
//    }
//    if (s[i] == p[j] || p[j] == '.')
//    {
//        temp = s[i];
//        j++;
//        continue;
//    } 
//    else
//    {
//        result = false;
//        break;
//    }
//}

//if (result) Console.WriteLine("true");
//else Console.WriteLine("false");
#endregion

#region 29. Divide Two Integers
//int dividend = 10, divisor = 3;
//int result = 0;

//if (dividend == 2147483647 && divisor == -1) return -2147483647;
//if (dividend <= -2147483647 && divisor == -1) return 2147483647;
//if (dividend >= 2147483647 && divisor == 1) return 2147483647;
//if (dividend <= -2147483648 && divisor == 1) return -2147483648;

//if (dividend > 0 && divisor > 0)
//    while (dividend > 0)
//    {
//        dividend -= divisor;
//        result++;
//        if (result == 2147483647) return result;
//    }
//else if (dividend < 0 && divisor < 0)
//    while (dividend < 0)
//    {
//        dividend -= divisor;
//        result++;
//        if (result == 2147483647) return result;
//    }
//else if (dividend > 0)
//    while (dividend > 0)
//    {
//        dividend += divisor;
//        result--;
//    }
//else if (dividend < 0)
//    while (dividend < 0)
//    {
//        dividend += divisor;
//        result--;
//    }

//if (dividend != 0)
//    if (result > 0)
//        result--;
//    else
//        result++;

//return result;

#endregion


#region 3110. Score of a String

//string s = "hello";
//int score = 0;
//int temp = 0;
//for (int i = 0; i < s.Length - 1; i++)
//    {
//    temp = s[i] - s[i + 1];
//    if (temp > 0) score += temp;
//    else score -= temp;
//    }
//Console.WriteLine(score);

#endregion 3110. Score of a String

#region 645. Set Mismatch Attempted
//int[] nums = { 2, 2 };
//int[] result = new int[2];
//for(int i = 1; i < nums.Length; i++)
//{
//    if (nums[i] == nums[i - 1])
//    {
//        result[0] = nums[i];
//        result[1] = nums[i] + 1;
//    }
//}
//foreach(int i in result)
//    Console.WriteLine(i);
#endregion 645. Set Mismatch Attempted

#region 387. First Unique Character in a String
////string s = "leetcode";

////Dictionary<char, int> charCount = new Dictionary<char, int>();

////foreach (char c in s)
////{
////    if (charCount.ContainsKey(c))
////        charCount[c]++;
////    else
////        charCount[c] = 1;
////}

////for (int i = 0; i < s.Length; i++)
////    if (charCount[s[i]] == 1)
////        return i;
////return -1;
#endregion 387. First Unique Character in a String

#region 3005. Count Elements With Maximum Frequency
//int[] nums = { 6, 13, 15, 15, 11, 6, 7 , 12 , 4 , 11  };

//Dictionary<int, int> charCount = new Dictionary<int, int>();

//foreach (int c in nums)
//{
//    if (charCount.ContainsKey(c))
//        charCount[c]++;
//    else
//        charCount[c] = 1;
//}

//int check = 0;
//int result = 0;

////var sortedValues = charCount.Values.OrderByDescending(v => v);
////foreach (int value in sortedValues)
////{
////    if (check == 0) 
////    {
////        check = value;
////        result += value;
////        continue;
////    }
////    if (check != value) break;
////    else result += value;
////}

//List<int> temp = new List<int>();
//foreach (int value in charCount.Values)
//{
//    temp.Add(value);
//}
//temp.Sort();
//temp.Reverse();
//foreach (int value in temp)
//{
//    if (check == 0)
//    {
//        check = value;
//        result += value;
//        continue;
//    }
//    if (check != value) break;
//    else result += value;
//}
//Console.WriteLine(result);
#endregion 3005.Count Elements With Maximum Frequency


#region 1207. Unique Number of Occurrences
//int[] arr = { 26, 2, 16, 16, 5, 5, 26, 2, 5, 20, 20, 5, 2, 20, 2, 2, 20, 2, 16, 20, 16, 17, 16, 2, 16, 20, 26, 16 };

//Dictionary<int, int> charCount = new Dictionary<int, int>();

//foreach (int c in arr)
//{
//    if (charCount.ContainsKey(c))
//        charCount[c]++;
//    else
//        charCount[c] = 1;
//}

//int check = 0;

//List<int> temp = new List<int>();
//foreach (int value in charCount.Values)
//{
//    temp.Add(value);
//}
//temp.Sort();
//foreach (int value in temp)
//{
//    if (check == 0)
//    {
//        check = value;
//        continue;
//    }
//    if (check == value) Console.WriteLine("false");//break;
//    else check = value;
//}
//Console.WriteLine("true");

#endregion 1207. Unique Number of Occurrences

#region 268. Missing Number

//int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

//Array.Sort(nums);
//if (nums[0] != 0) return 0;
//int temp = nums[0];
//foreach (int number in nums)
//{
//    if (number == temp) continue;
//    else if (number - temp == 2) return number - 1;
//    else temp = number;
//}
//return temp + 1;

#endregion 268. Missing Number

#region 231. Power of Two
//int n = 8;
//int[] arr = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824 };
//Console.WriteLine(arr.Contains(n)); 
#endregion

#region 2073. Time Needed to Buy Tickets

//int k = 2;
//int[] tickets = { 2, 3, 2 };

//int counter = 0;
//while (true) 
//{
//    for (int i = 0; i < tickets.Length; i++)
//    {
//        if (tickets[i] > 0)
//        {
//            tickets[i] -= 1;
//            counter++;
//            if (tickets[k] == 0)
//                Console.WriteLine(counter);
//        }
//        else
//            continue;
//    }
//}

#endregion