using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1
{
    class Captcha
    {
        public int[] Input { get; set; }

        public Captcha(string input)
        {
            Input = ParseInput(input);
        }

        public int SolveCaptcha()
        {
            int last = Input.Last();
            int sum = 0;

            foreach (var i in Input)
            {
                if (last == i)
                {
                    sum += i;
                }

                last = i;
            }

            return sum;
        }

        public int SolveCaptcha2()
        {
            int sum = 0;

            for (var i = 0; i < Input.Length / 2; i++)
            {
                int current = Input[i];
                int opposite = Input[(Input.Length)/2 + i];

                sum += current == opposite ? current*2 : 0;
            }

            return sum;
        }

        private int[] ParseInput(String input)
        {
            return input.Select(Convert.ToInt32).Select(i => i-48).ToArray();
        }
    }
}
