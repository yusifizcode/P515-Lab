//Loop1();
//Loop2();

Thread thread1 = new Thread(Loop1);
Thread thread2 = new Thread(Loop2);


thread1.Start();
thread2.Start();



static void Loop1()
{
	for (int i = 0; i < 100; i++)
	{
		Console.Write(" A ");
	}
}

static void Loop2()
{
	for (int i = 0; i < 100; i++)
	{
		Console.Write(" B ");
	}
}