using System;

// C# allows the use of pointers in a function or code block when it is 
// marked by the unsafe modifier. Can then use pointers just like C. 
// in C#    ptr=>something is ptr->something


namespace UnsafeCodeApplication {
   class TestPointer {
      public unsafe static void Main() {

        int var = 20;
        int* p = &var;
        
        Console.WriteLine("Data is: {0} " , var);
        Console.WriteLine("Data is: {0} " , p->ToString());
        Console.WriteLine("Address is: {0} " , (int)p);



         int[]  list = {10, 100, 200};
         fixed(int *ptr = list)
         
         /* let us have array address in pointer */
         for ( int i = 0; i < 3; i++) {
            Console.WriteLine("Address of list[{0}]={1}",i,(int)(ptr + i));
            Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
         }
         
         Console.ReadKey();
      }
   }


}