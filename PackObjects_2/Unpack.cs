using System;

class MainClass
{
	public static void Main () 
	{
		Int32 х = 5;
		Object о = х; // У п а ко в ка х : о у к а з ы в а е т на упакованный объ ект
		//Int16 у = (Int16)о; // Распаковка . а з а тем при ведение т и п а not ok Invalidcastexception
		Int16 z = (Int16)(Int32)о; // Распаковка . а з а тем при ведение т и п а ok
	}
}








