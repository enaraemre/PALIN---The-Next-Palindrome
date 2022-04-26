using System;
public class Test
{
    public static void Main()
    {
        int testCaseCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < testCaseCount; i++)
        {
            string num = Console.ReadLine().TrimEnd();
            char[] revNum = num.ToCharArray();
            int n = num.Length;
            for (int j = 0; j < n / 2; j++)
            {
                revNum[n - j - 1] = revNum[j];
            }
            if (String.Compare(new string(revNum), num) > 0)
            {
                Console.WriteLine(new string(revNum));
                continue;
            }           
            int mid = (n - 1) / 2;
            for (int j = mid; j >= 0; j--)
            {
                if (revNum[j] != '9')
                {
                    revNum[j]++;
                    break;
                }
                else
                    revNum[j] = '0';
            }
            for (int j = 0; j < n / 2; j++)
            {
                revNum[n - j - 1] = revNum[j];
            }
            string ans = new string(revNum);
            if (revNum[0] == '0')
            {
                revNum[0] = '1';
                ans = new string(revNum) + "1";
            }
            Console.WriteLine(ans);
        }
    }
}