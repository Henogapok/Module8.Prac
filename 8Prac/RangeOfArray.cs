using System;
using System.Security.Cryptography.X509Certificates;

public class RangeOfArray
{ 
	private static Random rand = new Random();
    private int[] arr = null;
    private int minInd, maxInd;

	public RangeOfArray(int minIndex, int maxIndex)
	{
		this.minInd = minIndex;
		this.maxInd = maxIndex;
		arr = new int[maxInd - minInd+1];
		for (int i = 0; i < arr.Length; i++)
			arr[i] = rand.Next(20);
	}
	public int this[int index]
	{
		get
		{
			if(index < minInd || index > maxInd)
			{
				throw new IndexOutOfRangeException("Введен некорректный индекс");
			}
			else
			{
                return arr[index - minInd];
            }
		}
		set
		{
			arr[index - minInd] = value;
		}
	}
	public void showArr()
	{
		foreach(int x in arr)
			Console.Write(x + " ");
		Console.WriteLine();
	}
}
