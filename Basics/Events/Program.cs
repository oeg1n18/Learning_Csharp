using System;

// Events are actions such as Key Press, clicks, Mouse Movements;
// or some occurance such as a system generated notification 

// events are declared in the class and associated with the event 
// handlers using a delagate within the same or some other class


namespace SampleApp {
   public delegate string MyDel(string str);
	
   class EventProgram {
      event MyDel MyEvent;
		
      public EventProgram() {
         this.MyEvent += new MyDel(this.WelcomeUser);
      }
      public string WelcomeUser(string username) {
         return "Welcome " + username;
      }
      static void Main(string[] args) {
         EventProgram obj1 = new EventProgram();
         string result = obj1.MyEvent("Tutorials Point");
         Console.WriteLine(result);
      }
   }
}
