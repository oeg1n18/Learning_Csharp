using System;

using System.Threading;

/*
Threads are lightweight processes that run seemingly concurrently there are 3 states of a thread
Unstarted -- the thread is created but not started
Ready State -- The thread is ready to run on the 
Not runnable state -- Is in sleep mode/ wait method has been called/ Blocked by I/O operations.

*/

namespace MultithreadingApplication {
   class ThreadCreationProgram {
      public static void CallToChildThread() {
         try {
            Console.WriteLine("Child thread starts");
            
            // do some work, like counting to 10
            for (int counter = 0; counter <= 10; counter++) {
               Thread.Sleep(500);
               Console.WriteLine(counter);
            }
            
            Console.WriteLine("Child Thread Completed");
         } catch (ThreadAbortException e) {
            Console.WriteLine("Thread Abort Exception");
         } finally {
            Console.WriteLine("Couldn't catch the Thread Exception");
         }
      }
      static void Main(string[] args) {
         ThreadStart childref = new ThreadStart(CallToChildThread);
         Console.WriteLine("In Main: Creating the Child thread");
         
         Thread childThread = new Thread(childref);
         childThread.Start();
         
         //stop the main thread for some time
         Thread.Sleep(2000);
         
         //now abort the child
         Console.WriteLine("In Main: Aborting the Child thread");
         
         childThread.Abort();
         Console.ReadKey();
      }
   }
}