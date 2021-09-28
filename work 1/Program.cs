



/** palindrome plus reverese**/
/** INCLUDES STRING TO CHAR CONVERSION AND LENGTH OF STRING **/

//using System;

//namespace work_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the string which you wnat to reverse");
//            string a;
//            a=Console.ReadLine();
//            int w = a.Length;
//            int k=0, y = 0;
//            char[] b = new char[w];
//            char[] c = new char[w];
//            Console.Write("the length is {0} \n", w);
//            for(int i=0,j=w-1;i<=w-1;i++)
//            {
//                b = a.ToCharArray();
//                Console.WriteLine("{0}", a[j]);
//                c[i] = b[j];


//                j--;

//            }

//            for (int i = 0; i <= w - 1; i++)
//            {


//                if (b[i] == c[i])
//                {
//                    k++;
//                    y++;
//                }
//                else
//                {
//                    k++;
//                }
//            }

//                if(k==y)
//                {
//                    Console.WriteLine("the string is a palindrome");
//                }
//                else
//                {
//                    Console.WriteLine("nah its not budd");
//                }
//            }


//        }
//    }

/** program to find the missing number**/

/** using System;
namespace missing
{
class miss
{
  
  public static void Main(string [] args)
  {
      int[] p =new int[10] ;
      int y=1;
      Console.WriteLine("entre the elements  from 1 to 10");
      for (int  i= 0; i < 10; i++)
      {
          p[i] = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("the entered numbers are");

      for(int i=0;i<10;i++)
      {
          
          if (y == p[i])
          {
              Console.WriteLine("{0}", p[i]);
              y++;
          }
          else
          {
              
              Console.WriteLine("oops you missed  the number {0} ", y);
              //Console.WriteLine("{0}", p[i]);
              y = y + 2;                }

      }
  }

}
}
**/



//using System;
//namespace upper
//{ 
//    class upper
//    {
//   static void Main(string[] args)
//        {
//            Console.WriteLine("enter the string");
//string a = Console.ReadLine();
//string first= a.ToUpper();
//Console.WriteLine("enter teh second string");
//string b = Console.ReadLine();
//string second = b.ToUpper();
//string final = string.Concat(first, second); /** string concat using STRING.CONCAT(FIRSTVARIABLE , SECONDVARIABLE)

//string final = $"the final string is {first}  {second}"; // string interpolation method
//Console.WriteLine("{0}", final);

//        string exam = Console.ReadLine();
//        Console.WriteLine("the string is {0}",exam);

//        Console.WriteLine("enter the char whose index you want to calculate");
//        char c = Convert.ToChar(Console.ReadLine());
//        int i= exam.IndexOf (c);
//        string f = exam.Substring(i);
//        Console.WriteLine("the index position is {0} and the substring is {1}", i, f);
//    }
//}

//}


/** SWITCH EXAMPLE**/
//using System;
//namespace stringex
//    {
//        class sx
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the num from 1. to 4. ");
//            int day = Convert.ToInt32(Console.ReadLine());
//            switch(day)
//            {

//                case 1:

//                    Console.WriteLine("Monday");
//                break;


//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;


//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;

//                case 4:
//                    Console.WriteLine("Thursday");
//                    break;

//                default:
//                    Console.WriteLine("Friday");
//                    break;

//            }


//        }
//    }

//    }



/**ARRAY EXAMPLE INCLUDING SORTING AND FOREACH**/

//using System;
//namespace arrays
//{
//    class example
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("enter the number of elements you wana enter in the array");
//            int w = Convert.ToInt32(Console.ReadLine());
//            string[] cars = new string[w];
//            Console.WriteLine("enter the array elements");

//            for(int i=0;i<w;i++)
//            {
//                cars[i]=Console.ReadLine() ;
//            }
//            Console.WriteLine("the sorted array is");
//            Array.Sort(cars); /**CODE FOR SORTING AN ARRAY**/
//            foreach (string i in cars)/**CODE FOR FOREACH**/
//            {
//                Console.WriteLine(i);

//            }



//        }

//    }

//}

// OBJECT CREATION AND ALLOCATION OF FIELDS AND METHODS INSIDE THE CLASS USING THE OBJECTS

//using System;
//using System.Linq;
//namespace exlinq
//{
//    class exlin
//    {
//        static void Main(string[] args)
//        {

//            first obj = new first();
//            second qj = new second();
//            obj.elixer();
//            qj.elixer();
//            Console.WriteLine(obj.color);
//        }
//    }


//    class first
//    {
//       public string color = "red";
//        public  void elixer ()
//        {
//            Console.WriteLine("hello world ");
//        }

//    }


//    class second
//    {
//        public void elixer()
//        {
//            Console.WriteLine("HELLO WORLD ");
//        }

//    }
//}



// CONSTRUCTOR

//using System;
//namespace constr
//    {

//    class amount
//    {

//        string car = "alfaromeo";
//        public amount()    //namer of constructor must mach the class name and it cannot have a return type
//        {
//            Console.WriteLine("the car is {0}", car);
//        }

//        public amount(string djan)
//        {
//            string car = djan;
//            Console.WriteLine("the car is {0}", car);
//        }

//    }

//    class excel
//    {
//        static void Main(string[] args)
//        {
//            amount a = new amount(); // condtructor is called when the object is created
//            amount w = new amount("aston martin");
//            amount c= new amount("redbull");
//        }
//    }

//    }


//C# PROPERTIES

//using System;
//namespace prope
//{
//    class car
//    {
//        private string color;

//        public string Color
//        {
//            get { return color; }
//            set { color = value; } // value is a keyword which we assigned to the property


//        }
//    }

//    class main
//    {
//        static void Main(string[] args)
//        {
//            car c = new car();
//            c.Color = "red";
//            Console.WriteLine(" the color is "+ c.Color);
//        }
//    }
//}



//C# PROPERTIES VIA SHORTHAND
//using System;
//namespace trial
//{
//    class test
//    {

//        public string Name
//        {
//            get; set;
//        }
//    }

//    class test1
//    {
//        static void Main(string [] args)
//        {
//            test o = new test();
//            o.Name = "amar";
//            Console.WriteLine("the name is " + o.Name);
//        }

//    }

//}


// PRINTING THE STAR IN THE SHAPE OF A RIGHT ANGLED TRIANGLE
//using System;
//namespace test
//{
//    class test1
//    {
//        public test1()
//        {
//            int w;
//            Console.WriteLine("enter the number of rows you need");

//            w = Convert.ToInt32(Console.ReadLine());
//            for(int i=0;i<w;i++)
//            {
//                Console.Write(" \n");
//                for (int j=0;j<=i;j++)
//                {

//                    Console.Write( " * ");// to print in the same line use Console.Write instead of Console.WriteLine
//                }
//            }
//        }


//    }


//    class test2
//    {

//        static void Main(string[] args)
//        {

//            test1 obj = new test1();


//        }

//    }
//}

// Example for INHERITENCE
//using System;
//namespace inheritence
//{

//    class Vehicle
//    {
//        public string color="red";
//        public string Model="mustang";
//        public string Make="Ford";

//        public void details()
//        {
//            Console.WriteLine("the car colour is {0} ", color);
//            Console.WriteLine("the car model is {0} ", Model);
//        }

//    }


//    class Car : Vehicle
//    {
//        public void dent()
//        {
//            Console.WriteLine("the car make is {0}", Make);
//        }

//    }

//    class prime
//    {
//        static void Main(string [] args)
//        {
//            Car obj = new Car();
//            obj.details(); // the object of the car class can access the method  and the fields in Vehicle class as it inherit the vehicle class
//            obj.dent();
//        }

//    }

//}


//EXAMPLE FOR POLYMORPHISM
//using System;
//namespace poly
//{

//    class animals
//    {
//        public virtual void sound()
//        {
//            Console.WriteLine("the animal sound");
//        }
//    }

//   class pig:animals
//    {
//        public override void sound ()
//        {
//            Console.WriteLine("uff uff");

//        }
//    }


//    class cow : animals
//    {

//        public override void sound()
//        {
//            Console.WriteLine("brr brr");
//        }
//    }

//    class program
//    {
//        static void Main(string [] args)
//        {

//            animals a = new animals();
//            animals p = new pig();
//            animals c = new cow();

//            a.sound();
//            p.sound();
//            c.sound();
//        }


//    }
//}




//Example abstraction
//using System;
//namespace program
//{
//    abstract class program
//    {
//        public abstract void animalsound();
//        public string color = "red";
//        public void Promo()
//        {
//            Console.WriteLine("Hello friend");
//            Console.WriteLine("the color is {0}", color);

//        }
//    }


//    class animal : program
//    {
//        public override void animalsound()
//        {
//            Console.WriteLine("the sound of the animal is zzzzzzzz");
//        }

//    }


//    class mainprg
//    {
//       public static void Main(string[] args)
//        {
//            animal ani = new animal();
//            ani.animalsound();
//            ani.Promo();
//        }
//    }

//}


// EXAMPLE INTERFACES

//using System;
//namespace program
//{
//    interface animal
//    {
//        void animalsound();// if any of the method of the interface whose definition is missing in the class, it will show error 
//        void animalcolor();
//    }

//    interface group
//    {
//        void gender();
//    }



//    class pig:animal,group
//    {
//        public void animalsound()
//        {
//            Console.WriteLine("the sound is zzzzz");

//        }

//        public void animalcolor()
//        {
//            Console.WriteLine("the color is brown");
//         }


//        public void gender()
//        {
//            Console.WriteLine("the gender is male");
//        }

//    }
//    class program
//    {

//        static void Main(string[] args)
//        {
//            pig obj = new pig();

//            obj.animalcolor();
//            obj.gender();
//            obj.animalsound();

//        }


//    }

//}

//ALICE AND BOB BALL PLAYING WINNER FINDER CODE

//using System;
//namespace alicebob
//{
//    class tricky
//    {  

//        public void Answers(int n)
//        {
//            if(n!=0)
//            { int i = n;
//                int k = 0;
//               w: if(i!=0 || i< 0)
//                switch(k)
//                {

//                    case 0:
//                        Console.WriteLine("alices turn");
//                            int f = Convert.ToInt32(Console.ReadLine());
//                       i= i-f;
//                            if(i==0 || i<0)
//                            {
//                                Console.WriteLine("the winner is alice");
//                                goto t;
//                            }
//                        k = 1;
//                            break;
//                    case 1:
//                        Console.WriteLine("bobs turn");
//                            int p = Convert.ToInt32(Console.ReadLine());
//                            i=i-p;
//                            if (i == 0 || i<0)
//                            {
//                                Console.WriteLine("the winner is bob");
//                                goto t;
//                            }
//                            k = 0;
//                        break;

//                }goto w;
//            t: Console.WriteLine("the end");


//            }
//        }



//        public static void Main(string [] args)
//        {
//            Console.WriteLine("enter the number of balls in the lot");
//            int N = Convert.ToInt32(Console.ReadLine());
//            tricky t = new tricky();
//            t.Answers(N);
//        }

//    }


//}



//the fuckest problem completed like a boss , but need to ptimise more
//using System;
//using System.Linq;
//namespace tricky
//{
//    class trickster
//    {




//        static void Main(string[] args)
//        {

//            Console.WriteLine("enter the number of elements in the array");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int[] arr = new int[n];
//            int[] flag1 = new int[n];
//            int[] flag2 = new int[n];
//            int sum,length,flagy,flagn;

//            Console.WriteLine("enter the array elements");


//            for(int i=0;i<n;i++)
//            {

//                arr[i] = Convert.ToInt32(Console.ReadLine());

//            }
//            Array.Sort(arr);

//            int z = arr[n - 1] + arr[n - 2];
//            int p = 1;

//          x: if( Math.Pow(2,p)< z)
//            {
//                p++;
//                goto x;
//            }
//            int q=(p - 1);//maximum the pow can go for this array;

//            int[] brr = new int[q];

//          for(int r=0;r<q;r++)
//            {
//                brr[r]= Convert.ToInt32(Math.Pow(2, r+1));

//            }
//            Console.WriteLine("the power values stored array is");
//            for (int r = 0; r < q; r++)
//            {
//                Console.WriteLine(brr[r]);
//            }



//            for(int i=0;i<n;i++)
//            {
//                flagy = 0;
//                for(int j=0;j<n;j++)
//                {
//                    length = brr.Length;
//                    sum = 0;
//                    int r = 0;
//                    if (i==j)
//                    {
//                        if (i == n - 1)
//                        {
//                            break;
//                        }
//                        else
//                        {
//                            j = j + 1;
//                            sum = arr[i] + arr[j];
//                            goto g;
//                        }
//                    }
//                    sum = arr[i] + arr[j];
//                    g: while(length>0)
//                    {
//                        if(brr[r]==sum)
//                        {
//                            Console.WriteLine("the element {0} have a match", i + 1);
//                            length--;
//                            r++;
//                            flagy = 1;
//                        }
//                        else
//                        {
//                            Console.WriteLine("no match");
//                            length--;
//                            r++;
//                        }


//                        if(flagy==1)
//                        {
//                            flag1[i]= i+1;

//                        }
//                    }
//                }
//            }



//            flag1 = flag1.Where(e => e != 0).ToArray();
//            int k;
//            k = flag1.Length;
//            Console.WriteLine("the final array is");
//            int v = 0;
//            while (k!=0)
//            {
//                Console.WriteLine("the flag value is " + flag1[v]);
//                int w = flag1[v];
//                Console.WriteLine( arr[w-1]);
//                k--;
//                v++;

//            }

//            //Console.WriteLine("the flag values");
//            //for (int i = 0; i < n; i++)
//            //{
//            //    Console.WriteLine(flag1[i]);
//            //}
//        }


//    }


//}


//using System;
//using System.Linq;
//namespace challenge
//{

//    class challengeaccepted
//    {




//        static void Main(string[] args)
//        {

//            for(byte b = 0; b <= 255; b++)
//            {
//                Console.WriteLine(b);
//                if(b==255)
//                {
//                    Console.WriteLine("target");

//                }
//            }


//        }
//    }
//} 




//sum of the prime numbers
//using System;

//namespace optimus
//{


//    class a
//    {
//        public void finder(int e)
//        {
//            int sum = 0;
//            Console.WriteLine("reached");
//            for(int i=2;i<=e;i++)
//            {
//               int count = 0;
//                for(int j=1;j<=i;j++)
//                {
//                    if(i%j==0)
//                    {
//                        count++;
//                    }
//                }
//                if(count==2)
//                {
//                    Console.WriteLine("the prime value is {0}",i);
//                    sum = sum + i;

//                }

//            }



//            total(sum);



//        }
//        public void total(int x)
//        {
//            Console.WriteLine("the sum of the values are {0}", x);
//            Console.WriteLine("wanna chcek the sum obtained is a prime number press 1 if yes and 0 is not");
//            int q = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(q);
//            if(q==1)
//            {
//                singlecheck(x);
//            }
//        }



//        public void singlecheck(int p)
//        { int count = 0;int i = 1;
//            while(i<=p)
//            {if (p % i == 0)
//                {
//                    count++;
//                        }
//                i++;
//            }

//            if(count==2)
//            {
//                Console.WriteLine("yes {0} is also a prime",p);  

//            }
//            else
//                    {
//                Console.WriteLine("{0} is not a prime", p);
//            }
//        }

//    }

//    class b
//    {

//        static void Main()
//        {
//            a obj = new a();
//            Console.WriteLine("enter the number");
//            int f = Convert.ToInt32(Console.ReadLine());
//            obj.finder(f);



//        }



//    }






//}


//date and day when month day and year given

//using System;
//namespace datefinder
//{

//    class dateandday
//    {

//        static void Main(string[] args)
//        {

//            Console.WriteLine("enter the month ");
//            int month = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the day ");
//            int day = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the year ");
//            int year = Convert.ToInt32(Console.ReadLine());

//            DateTime v = new DateTime(year, month, day);
//            Console.WriteLine("the date is {0}", v);
//           Console.WriteLine( v.DayOfWeek);

//        }

//    }

//}




//creating anagram

//using System;
//namespace anna{


//    class anagram
//    {
//        static void Main()
//        {
//             Console.WriteLine("enter the  first string");
//            string first = Console.ReadLine();
//            Console.WriteLine("enter the  Second string");
//            string second = Console.ReadLine();
//            int len = first.Length;
//            int len1 = second.Length;
//            char[] arr = new char[len];
//            char[] brr = new char[len1];
//            char[] crr = new char[len1];
//            int j = 0, k = 0, l = 0;
//            //for (int i= 0;i < first.Length;i++)
//            //{
//            //    Console.WriteLine(first[i]);

//            //}

//            foreach(char i in first)
//             {
//                if (j < len)
//                {

//                    arr[j] = i;
//                    j++;
//                }
//            }

//            foreach (char w in second)
//            {
//                if (k < len1)
//                {

//                    brr[k] = w;
//                    k++;
//                }
//            }



//            for(int i=0;i<len;i++)
//            {

//                for(int w=0;w<len1;w++)
//                {

//                    if(arr[i]==brr[w])
//                    {
//                        crr[l]= brr[w];
//                        Console.WriteLine(crr[l]);

//                        l++;


//                    }
//                }

//            }

//            for(int i=0;i<len1;i++)
//            {
//                for(int p=0;p<crr.Length;p++)
//                {

//                }
//            }


//            //for (int i = 0; i < crr.Length; i++)
//            //{

//              //  Console.WriteLine(crr[i]);
//           // }
//            //Console.WriteLine("whats happening");
//            foreach (char z in crr)
//            {

//              Console.WriteLine(z);
//                  }

//            //Console.WriteLine("thug");

//        }

//    }


//}

//creating the first DELEGATE




//using System;

//namespace systemati{
//    class animal {

//        public animal() 
//        {
//            Console.WriteLine("constructor is {0}");
//        }


//        public void hush()
//        {
//            Console.WriteLine("elemental");

//        }
//    }


//    class dog:animal
//    {

//          public dog (string x)
//        {
//            Console.WriteLine(x);


//        }

//    }

//    class Cat:animal
//    {
//        public void ch(char c)
//        {
//            Console.WriteLine(c);
//        }

//    }
//    class sys
//    {
//        static void Main (String [] args)
//        {
//            animal o = new dog("antman"); //constructor of the animal is called each time when we create the object
//            animal f = new Cat();//constructor of the animal class will be called again
//           // animal a = new animal("ddd");

//        }



//    }

//}


//GENERIC EXAMPLE 


//using System;
//namespace genericexample
//{
//    class gen<T> where T:notnull // the constarint can be Class(which is a reference type constarint), struct(all variable type constarints),notnull,and many more 
//    {





//        public T add(T vaariable)
//        {
//            Console.WriteLine("executed value is {0}", vaariable);
//            return vaariable;
//        }


//    }

//    class barricade {
//        static void Main(string[] args)
//        {
//            gen<string> obj = new gen<string>();
//            obj.add("hello fuckers");
//            gen<int> obj1 = new gen<int>();
//            obj1.add(11);

//        }

//    }


//}




////COLLECTION GENERIC <LIST> EXAMPLE



//using System;
//using System.Collections.Generic;
//namespace sys
//{
//    class explorer
//    {
//        static void Main(string [] args)
//        {
//            Console.WriteLine("enter the list of elements using LIST ");
//            var listname = new List<int>(); // another method is List<int> listname= new List<int>();
//            listname.Add(1);
//            listname.Add(2);
//            listname.Add(3);
//            listname.Add(4);

//            foreach(int i in listname )
//            {
//                Console.WriteLine(i);
//            }

//        }


//    }
//}



//ADDING OBJECTS OF A CLASS IN THE LIST


//using System;
//using System.Collections.Generic;
//namespace listexample
//{
//    class Con
//    {
//        public int id;
//        public string name;
//      }

//    class major
//    {
//        static void Main(string[] args)
//        {

//            //DIFFERENT WAYS OF WRITING OBJECTS

//            //var obj = new List<Con>()
//            //{
//            //    new Con(){id=1, name="amar"},
//            //    new Con(){id=1, name="amar"}

//            //};

//            //var obj = new Con();// object of class Con
//            //obj.id = 1;
//            //obj.name = " amar";

//            //    var obj = new Con()
//            //    {
//            //        id = 1,
//            //        name = "ghost"
//            //};


//            //var on = new Con();//object of the class Con
//            //on.id = 1;
//            //on.name = "amar";
//            //Console.WriteLine("the id is ", on.id);



//            List <Con> obj = new List<Con>() // var obj= new List<Con>();
//            {
//                new Con(){id=1,name="amar" },
//                new Con(){ id=2,name="arjun"}


//            };

//            Console.WriteLine("the enetred values are");
//           foreach(Con num in obj)
//            {
//                //obj.ForEach(num => Console.WriteLine(num.id + ", "));
//                Console.WriteLine(num.name);
//                Console.WriteLine(num.id);
//            }
//        }

//    }


//}




//ADDING AN ARRAY IN A LIST


//using System;
//using System.Collections.Generic;

//namespace major
//{
//    class major
//    {
//        static void Main(string[] args)
//        {

//            var arr = new string[3]{"amar", "arjun","sruthy"};


//            var volvo = new List<string>();
//            volvo.AddRange(arr); // adding the values of the array arr into the list volvo

//            var lap = new List<string>();
//            lap.AddRange(volvo);

//            Console.WriteLine("the final array is");
//            foreach (string num in lap)
//            {
//                Console.WriteLine(num);


//            }


//        }


//    }

//}


//Accessing a list using LINQ  via foreach

//using System;
//using System.Collections.Generic;
//namespace linqmethodexample
//{
//    class example
//    {

//        static void Main(string [] args )
//        {
//            var w = new string[5] {"12","233","344","566", "787" };// string[] w = new string[10]; is another way to declare an array

//            var exampleofcollectiongenericclass= new List<string>();


//            exampleofcollectiongenericclass.AddRange(w);
//            exampleofcollectiongenericclass.ForEach(love => Console.WriteLine(love + ','));


//        }


//    }


//}


// insertion , removing and checking elemnts in the list


using System;
using System.Collections.Generic;
namespace operations
{

   

    class name
    {

        static void Main(string[] args)
        {
            var Listclass = new List<string>() { "amar","rajeev", "willpower"};

            Listclass.ForEach(num => Console.WriteLine(num + " "));
            Console.WriteLine("vales youi need to insert inot the list");
            string f = Console.ReadLine();
              Listclass.Insert(0, f);
            Console.WriteLine("which index element to reemove from the list");
            var e =Convert.ToInt32( Console.ReadLine());
            Listclass.RemoveAt(e);
            Console.WriteLine("checking the element to find out  whther its in the list class");
            var check = Console.ReadLine();
           Console.WriteLine( Listclass.Contains(check));
            foreach( var num in Listclass)
            {
                Console.WriteLine(num);

            }

            
        
        }
    }
}