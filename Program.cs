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

