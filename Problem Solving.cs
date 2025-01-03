using System;
using System.Collections.Generic;
public class Test
{
public static int operation (List<string> list){

int count=0;
	if(list is not null){
for(int i=0;i<list.Count;i++){
   if(list[i]=="++")
   count+=1;
   else if(list[i]=="--")
   count-=1;
   }}
   return count;

}

	public static void Main()
	{
	  

		List<string> list=new List<string>{"++", "++", "--", "++"};
		 Console.WriteLine(operation(list));
		
	}
}
