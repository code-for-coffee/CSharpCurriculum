// 1. we are 'using' libraries of features in our application
using System;
using System.Collections.Generic;

// 2. Each application is organized in a 'namespace';
// this application is called HeyThereHey
namespace HeyThereHey
{
  // 3. A 'class' is a blueprint; we define our 'program'
  // they are re-usable blueprints!
  class Program
  {
    // 4. below is one of our programs abilities
    // these are defined as 'methods'; or actions (verbs)
    // 5. static: the state stays the same
    // 6. void: our method returns nothing! but sometimes they
    // can return things to us
    static void Main(string[] args)
    {
      // 7. We're defining a 'variable' (a place in memory)
      // named 'heyThere'. It is asigned a value using '='
      // and that value is "hey there hey"
      var heyThere = "hey world hey";
      // 8. we call on the 'Console' class (another blueprint!)
      // to use its ability of 'WriteLine'. Methods accept arguments
      // (such as variables) and do things with them. They accept arguments
      // inside of the '()'
      Console.WriteLine(heyThere); // 9. ';' tells C# to STOP
    } // end static void Main
  } // end class Program
} // end namespace HeyThereHey


