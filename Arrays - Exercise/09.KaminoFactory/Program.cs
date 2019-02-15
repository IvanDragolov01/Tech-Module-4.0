using System;
using System.Linq;

namespace _09.KaminoFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			int length = int.Parse(Console.ReadLine());
			int[] sequence = new int[length];
			int longestSubsequence = -1;
			int longestSubIndex = -1;
			int longestSubSum = -1;
			int longestSubStart = -1;
			int index = 1;
			string input;

			while ((input = Console.ReadLine()) != "Clone them!")
			{
				int[] currentSequence = input
					.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				int currentLength = -1;
				int currentIndex = -1;
				int currentSubLength = -1;
				int currentSubIndex = -1;
				bool isOne = false;

				for (int i = 0; i < length; i++)
				{
					if (currentSequence[i] == 1 && isOne)
					{
						currentSubLength++;
					}
					else if (currentSequence[i] == 1)
					{
						isOne = true;
						currentSubIndex = i;
						currentSubLength = 1;
					}
					else if (currentSequence[i] == 0 && isOne)
					{
						if (currentSubLength > currentLength)
						{
							currentLength = currentSubLength;
							currentIndex = currentSubIndex;
						}

						isOne = false;
						currentSubLength = 0;
						currentSubIndex = 0;
					}
				}

				if (isOne)
				{
					if (currentSubLength > currentLength)
					{
						currentLength = currentSubLength;
						currentIndex = currentSubIndex;
					}
				}

				if (currentLength > longestSubsequence)
				{
					longestSubsequence = currentLength;
					longestSubIndex = currentIndex;
					longestSubSum = currentSequence.Sum();
					sequence = currentSequence;
					longestSubStart = index;
				}
				else if (currentLength == longestSubsequence)
				{
					if (currentIndex < longestSubIndex)
					{
						longestSubsequence = currentLength;
						longestSubIndex = currentIndex;
						longestSubSum = currentSequence.Sum();
						sequence = currentSequence;
						longestSubStart = index;
					}
					else if (currentIndex == longestSubIndex)
					{
						if (currentSequence.Sum() > longestSubSum)
						{
							longestSubsequence = currentLength;
							longestSubIndex = currentIndex;
							longestSubSum = currentSequence.Sum();
							sequence = currentSequence;
							longestSubStart = index;
						}
					}
				}

				index++;
			}

			Console.WriteLine($"Best DNA sample {longestSubStart} with sum: {longestSubSum}.");
			Console.WriteLine(string.Join(" ", sequence));
		}
	}
}
