using LeetcodeDemo.Models;

public class Solution
{
    public static void Main(string[] args)
    {
        var solution = new Leetcode242();

        string s1 = "anagram";
        string t1 = "nagaram";
        Console.WriteLine($"Is Anagram: {solution.IsAnagram(s1, t1)}"); // 输出 true

        string s2 = "rat";
        string t2 = "car";
        Console.WriteLine($"Is Anagram: {solution.IsAnagram(s2, t2)}"); // 输出 false
    }
}
