namespace TestProject1
{
    public class ExampleTests
    {

        public class Solution1
        {
            static public int[] TwoSum(int[] nums, int target)
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        var a = nums[i];
                        var b = nums[j];

                        if (a + b == target)
                        {
                            return new int[] { i, j };
                        }
                    }

                }

                return new int[] { -1, -1 };

            }
        }


        [Fact]
        public void Test0001()
        {
            Assert.Equal(Solution1.TwoSum(new int[] { 2,7,11,15 }, 9), new int[] { 0, 1 });
            Assert.Equal( Solution1.TwoSum(new int[]{ 2,3,4 }, 6), new int[]{ 0,2});
            Assert.Equal(Solution1.TwoSum(new int[] { 3,3 }, 6), new int[] { 0, 1});

        }


        public class Solution1791
        {
            public int FindCenter(int[][] edges)
            {
                List<int> possibles = new List<int>();

                var i1 = edges[0][0];
                var i2 = edges[0][1];
                var i3 = edges[1][0];
                var i4 = edges[1][1];

                possibles.Add(i1);
                possibles.Add(i2);
                if (possibles.Contains(i4))
                {
                    return i4;
                }
                else
                {
                    return i3;
                };

            }
        }


        [Fact]
        public void Test1791()
        {
            var edges = new int[][]
            {
                    new int[] { 1, 2 },
                    new int[] { 2, 3 },
                    new int[] { 4, 2 }
            };

            Assert.Equal( 2, (new Solution1791()).FindCenter(edges) );

            edges = new int[][]
            {
                    new int[] { 1, 2 },
                    new int[] { 5,1 },
                    new int[] { 1,3 },
                    new int[] { 1,4 }
            };

            Assert.Equal(1, (new Solution1791()).FindCenter(edges));

        }

        [Fact]
        public void Test0009()
        {
            bool IsPalindrome(int x)
            {
                var s = x.ToString();
                //var r = s.Reverse();
                //string res = "";
                //foreach (var item in r)
                //{
                //    res += item; 
                //}

                var res = new string(s.Reverse().ToArray());

                return (res == s);
            }


            Assert.False(IsPalindrome(1234));
            Assert.True(IsPalindrome(12221));
            Assert.False(IsPalindrome(-12221));
        }

        [Fact]
        public void Test0058()
        {
            int LengthOfLastWord(string s)
            {
                var things = s.Trim().Split(' ');
                var last = things[things.Count() -1];
                return last.Length;
            }

            Assert.Equal(7, LengthOfLastWord("the cat stopped "));
        }

        [Fact]
        public void Test0028()
        {
            int StrStr(string haystack, string needle)
            {
                if (needle.Length > haystack.Length)
                {
                    return -1;
                }

                for (int i = 0; i <= haystack.Length - needle.Length; i++)
                {
                    if (haystack.Substring(i, needle.Length) == needle)
                    {
                        return i;
                    }
                }

                return -1;
            }

            Assert.Equal(0, StrStr("sadbutsad", "sad"));
            Assert.Equal(-1, StrStr("leetcode", "leeto"));
            Assert.Equal(1, StrStr("leetcode", "eet"));
            Assert.Equal(0, StrStr("leetcode", "leetcode"));
            Assert.Equal(-1, StrStr("leetcode", "xxxeetcode"));


        }



    }
}