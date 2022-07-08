int max1=0;
int max2=0;

for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine("please Enter num:");
    int num=int.Parse( Console.ReadLine());
   if (num>=max1)
   {
   max2=max1;
   max1=num;
   }

   else{
    if (num>=max2)
    {
        max2=num;
    }
  }
}

System.Console.WriteLine( "max1= " + max1 + " " + "max2= " + max2 );



