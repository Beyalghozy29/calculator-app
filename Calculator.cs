class Calculator
{
	static void Main (string[] args)
	{
		int a = 10;
		int b = 6;
		
	Console.WriteLine("Hasil penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
	Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
	
	Console.WriteLine("\n Tekan sembarang key yang keluar");
	Console.ReadKey();
	}
	
	static in penambahan (int a, int b)
	{
		return a + b;
	}
	static in pengurangan (int a, int b)
	{
		return a - b;
	}
}