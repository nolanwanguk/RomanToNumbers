namespace RomanSolver
{
    public class Solver
    {
        static void Main(){}
        
        private readonly Dictionary<char, int> _roman = new()
            { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

        public int RomanToInt(string s)
        {
            var result = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var cur = _roman[s[i]];

                if (i != s.Length - 1)
                {
                    var next = _roman[s[i + 1]];

                    if (next > cur)
                    {
                        cur = next - cur;
                        i = i + 1;
                    }
                }

                result = result + cur;
            }

            return result;
        }
    }
}