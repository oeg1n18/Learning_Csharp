using System;

// an attribute is a declarative tag that is used to convey information at runtime
// Attributes are used for adding metadata, such as compiler instruction
// the dotnet framework provides two types of attributes
// pre-defined and custom built attributes
// the parameter vaildon specifies the language elements on which the attribute can be placed
// the parameter allowmultiple makes the attribute multiuse if true
// the parameter Inherited if true lets the attribute be inherited into the derived class


// the "conditional" attribute, means the execution of the code is dependent on the 
// specified value of the preprocessor identifier.


using System.Diagnostics;


namespace attri {
public class Myclass {
   [Conditional("DEBUG")]
   
   public static void Message(string msg) {
      Console.WriteLine(msg);
   }
}


class Test {
   static void function1() {
      Myclass.Message("In Function 1.");
      function2();
   }
   static void function2() {
      Myclass.Message("In Function 2.");
   }

    public static void Main() {
      Myclass.Message("In Main function.");
      function1();
      Console.ReadKey();
   }
}

// Obsolete is an attribute that marks a program entity that should not be used. 
// it enables you to inform the compiler to discard a arget element. 
// for example, when a new method is being used in a class but you still 
// want to keep the old method.




// ======== Creating Custom Attributes ==============
// This bug shows information about the bug, who found it and when 
//
[AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]

public class DeBugInfo : System.Attribute {
   private int bugNo;
   private string developer;
   private string lastReview;
   public string message;
   
   public DeBugInfo(int bg, string dev, string d) {
      this.bugNo = bg;
      this.developer = dev;
      this.lastReview = d;
   }
   public int BugNo {
      get {
         return bugNo;
      }
   }
   public string Developer {
      get {
         return developer;
      }
   }
   public string LastReview {
      get {
         return lastReview;
      }
   }
   public string Message {
      get {
         return message;
      }
      set {
         message = value;
      }
   }
}


[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
class Rectangle {
   //member variables
   protected double length;
   protected double width;
   public Rectangle(double l, double w) {
      length = l;
      width = w;
   }
   [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
   
   public double GetArea() {
      return length * width;
   }
   [DeBugInfo(56, "Zara Ali", "19/10/2012")]
   
   public void Display() {
      Console.WriteLine("Length: {0}", length);
      Console.WriteLine("Width: {0}", width);
      Console.WriteLine("Area: {0}", GetArea());
   }
}

}


