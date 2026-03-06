using G_Net_34_OOP05.Part01.UsingQ02;
using G_Net_34_OOP05.Part01.UsingQ04;
using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

namespace G_Net_34_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q01
            /*What is an interface in C#? 
             * Why do we use interfaces instead of depending on concrete classes directly?
             * Mention at least three benefits of using interfaces.*/
            //An interface defines a contract that a class must follow. It specifies what a class can do, not how it does it.
            //Enable polymorphism without inheritance,Remove tight coupling between classes,Enable multiple inheritance (behavior),Interfaces allow coding against behavior, not classes.
            //(Loose Coupling),(Support Polymorphism),(Solve Problem Multiple Implementation).

            #endregion
            #region Q02
            #region a
            //a) What is the problem with this design?
            //Method Name Conflict.
            //There is a naming collision/ambiguity. Since both interfaces have a method with the same signature void Greet(),
            //we cannot provide a different implementation for each one using the usual method.


            //Both interfaces have a method called Greet() — how does the class handle it currently?
            //The class uses Implicit Implementation. This means that the method public void Greet() executes the 'contract' of both interfaces at the same time with the same code, so I can't separate them.
            #endregion
            #region b
            //How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
            //Using Explicit Implementation.
            //Definition:Explicit Interface Implementation means implementing interface members in a way that they are accessible only through the interface reference.
            ////Note:I Solve it in Folder UsingQ02.

            #endregion
            #region c
            ////c) After applying your fix, can you call Greet() directly on a Translator object(e.g.translator.Greet()) ? Why or why not? How do you call each version ?
            ////No,Because explicit implementation makes the method private to the class and only accessible through the interface reference.



            ////By casting the object to the specific interface type:
            ////1) Refrence and Object of Translator
            //Translator t01 =new Translator();
            //// t01.Greet();  Compile Error
            //((IEnglishSpeaker)t01).Greet();


            ////2)Refernce of Interface   object of Translator
            //IEnglishSpeaker t02=new Translator();
            //t02.Greet();
            //IArabicSpeaker t03=new Translator();
            //t03.Greet();
            #endregion
            #endregion
            #region Q03
            /*Explain the difference between a shallow copy and a deep copy. When would you use each one? What is the risk of using a shallow copy when the object has reference-type fields?*/
            //Difference:
            //1)Reference Fields:  Shallow->Shared     ::Deep->Duplicated
            //2)Safety :        Shallow->Risky     ::Deep->Safe
            //3)Performance :        Shallow->Fast     ::Deep->Slower
            //4)Memory Usage :        Shallow->Lower     ::Deep->Higher


            // When to Use:
            //Shallow → object is immutable, no nested reference state, performance is critical
            //Deep → objects must be isolated, modifications should not affect original.


            //Risk for using Shallow  when the object has reference-type fields:
            //Data Corruption
            //Two objects, same inner references  Changing inner object affects both copies.



            #endregion
            #region Q04
            /*Look at the following code and determine the output. Explain why?*/
            ////Go to Folder UsingQ04 in Folder Part01
           

            //Employee e01 = new Employee()
            //{
            //    Title = "Dev",
            //    Dept = new DepartMent { Name = "IT" }
            //};
            //Employee e02=e01.ShallowCopy();
            //Console.WriteLine($"Employee1 =>{e01}");
            //Console.WriteLine($"Employee2 =>{e02}");
            //e02.Title = "QA";
            //e02.Dept.Name = "Testing";
            //Console.WriteLine("After Change :");
            //Console.WriteLine($"Employee1 =>{e01}");
            //Console.WriteLine($"Employee2 =>{e02}");
            //Why 
            /*
             * 
             * Shallow copy creates a new Employee, but Dept is still shared. Title is independent (string is immutable → new reference), but Department.Name change affects both
             */
            #endregion
            #endregion


        }
    }
}
