using System;
// Indexer allows an object to be indexed as an array
// when you define an indexer for a class, this behaves in a similar way to a virtual array.


namespace IndexerApplication {
   
   class IndexedNames {
      private string[] namelist = new string[size];
      static public int size = 10;
      
      public IndexedNames() {
         for (int i = 0; i < size; i++)
         namelist[i] = "N. A.";
      }
      
      
      // An indexer allows you to execute code when accesseing or 
      // setting a member of the index
      public string this[int index] {
         get {
            string tmp;
         
            if( index >= 0 && index <= size-1 ) {
               tmp = namelist[index];
            } else {
               tmp = "nothing";
            }
            
            return ( tmp );
         }
         set {
            if( index >= 0 && index <= size-1 ) {
               namelist[index] = value;
            }
         }
      }







   

      static void Main(string[] args) {
         IndexedNames names = new IndexedNames();
         // allows you to access members of the array from the class level 
         // using the object name.
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         
         for ( int i = 0; i < IndexedNames.size+1; i++ ) {
            Console.WriteLine(names[i]);
         }


         Console.WriteLine(); 

       
         Console.ReadKey();
      }
   }
}
