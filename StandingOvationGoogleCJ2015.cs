using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//Console.WriteLine("enter x:");
		//int x = Convert.ToInt32(Console.ReadLine());
		newSO try1 = new newSO();
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(0);
		try1.populateList(10);

		try1.displayContents();
		if(!(try1.checkIfSolved()))
			try1.Solve();
		
		int totalneeded  = try1.totalI;
		try1.DisplayStats();

	}
}

public class newSO
{
	public newSO(){}
	public newSO(int g)
	{
		size = g;
	}
	public int totalI;
	int size;
	public IEnumerable<int> result;
	//public List<int> intList;
	List<int> intList = new List<int>();
	public void populateList(int g)
	{
		this.intList.Add(g);
	}
	public bool checkIfSolved()
	{
		bool bRet=true;
		//say we have 5 slots. 
		//the nth is content only if the sum of the previous (n-1) slots are equal to n
		//so, if we have 1 2 0 6
		//the 3rd slot has 6 people, since they are in the 3rd slot, they are content bc
		//the # in the slot don't matter to the slot, that number only matters to subsequent(later)
		//slots
		Console.WriteLine("check if solved:");
		int t=0;
		for(int n=0; n<intList.Count; n++)
		{
			int y = intList[n]; 
			Console.WriteLine("slot we are on now: " + n);
			Console.WriteLine("people per given slot: " + y);
			Console.WriteLine("running total: " + t+"\n");
			if(t<n && y>0)
			{
				Console.WriteLine("we have a problem, total is less than the slot, total is: " +t );
				Console.WriteLine("and the slot position is " + n +"\n");
				bRet = false;
				//Console.WriteLine(y);
			}
			t = t+ y;
			Console.WriteLine("people per given slot for this slot!: " + y+"\n");
			
		}
		if(bRet!=true)
			return false;
		else return true;
	}
	public void displayContents()
	{
		int gh = intList.Count;
		Console.WriteLine("total count:");
		Console.WriteLine(gh);
		Console.WriteLine("members:");
		for(int n=0; n<intList.Count; n++)
		{
			int y = intList[n]; 
			Console.WriteLine(y);
		}
	}
	
	public void Solve()
	{

		Console.WriteLine("solve:");
		int t=0;
		for(int n=0; n<intList.Count; n++)
		{
			int y = intList[n]; 
			//Console.WriteLine("slot we are on now: " + n);
			if(t<n)//if slot position is greater than people grand total...
			{
				//so at this point, let's add some to intList[0]
				intList[0] ++;//we need to increment the varible in a diffrent slot position by the diffrence. 
				Console.WriteLine("WE HAVE AN INCREMENT HEREEEE " + n);
				this.totalI ++;
				Console.WriteLine("Total Increments thus far " + this.totalI);
				//then, resend it? or, restart the process?
				//how about we check the "checkifSolved()"
				if((this.checkIfSolved()))
					break;
			}
			t = t+ y;
			
		}
	}
	
	public void DisplayStats()
	{

		Console.WriteLine("Total Increments(people needed) " + this.totalI);

	}
}
