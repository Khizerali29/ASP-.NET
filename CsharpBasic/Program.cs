//                                            How to print Predefined
//int a;
//for(a = 1; a <= 10; a++)
//{
//    Console.WriteLine(a);
//}
//Console.WriteLine("Next Value of a will be : " + a);

//                                             How to take input From User

//Console.WriteLine("Please Enter Your Name Below");
//String name = Console.ReadLine();
//Console.WriteLine("Your Name is : " + name);


//                                             TASK


//Console.WriteLine("Enter Variable a : ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Variable b : ");
//int b = Convert.ToInt32(Console.ReadLine());
//if( a > b)
//{
//    Console.WriteLine("a is greater than b ");
//}
//else if( b > a )
//{
//    Console.WriteLine("b is greater than a ");
//}
//else
//{
//    Console.WriteLine("Both are Equal");
//}

//                              Print Table


//Console.WriteLine(" Enter any Nummber of your choice ");
//int a = Convert.ToInt32(Console.ReadLine());
//int i;
//for (i = 1 ; i <= 10; i++)
//{
//    int b = a * i;
//    Console.WriteLine( a + " * " + i + " = " + b);
//}


//                               Factorial

//Console.WriteLine("Write any number to print Factorial");
//int a = Convert.ToInt32(Console.ReadLine());
//int fact = 1 ;
//for (int i = 1; i <= a; i++)
//{
//    fact = fact * i;
//}
//Console.WriteLine(fact);


//                              Delegates

//public delegate void add(int a, int b); // delegate method
//class testing
//{
//    public void addnum(int x , int y)        // Simple Method
//    {
//        Console.WriteLine(x*y);
//    }
//}
////                             Main CLass
//class Program
//{
//    static void Main (string[] args)
//    {
//        testing tes = new testing();      // Creating object of class
//        add ad = new add(tes.addnum);     // Creating object of Method
//        tes.addnum(10, 20);

//        add ad1 = new add(tes.addnum);
//        tes.addnum(10, 40);
//    }
//}

//                             Generics

//class genrics<K>
//{
//    public K a; 
//    public K b;
//}
//class Program
//{
//    static void Main (string[] args)
//    {
//        genrics<int> gen = new genrics<int>();
//            gen.a = 1;

//        Console.WriteLine(gen.a);
//    }
//}


//                                ARRAY (Non - Genric)

//using System.Collections;

//class Program
//{
//    static void Main(string[] args)
//    {
//        //int[] array = new int[4];                     // BY Using Array
//        //array[0] = 1;
//        //array[1] = 2;
//        //array[2] = 3;
//        //array[3] = 4;
//        //Console.WriteLine(array[3]);

//        //ArrayList array = new ArrayList();              // By Using Array List ( Dynamically )
//        //array.Add(1);
//        //array.Add(2);
//        //array.Add("Syed");
//        //array.Add(4);
//        //array.Add("Khizer");
//        //array.Add(5.5);
//        //array.Add("Ali");

//        //foreach(var item in array)
//        //{
//        //    Console.WriteLine(item);
//        //}


//        //Hashtable ht = new Hashtable();                //    By Using HashTable
//        //ht.Add("Name","Khizer");
//        //ht.Add("Age", 22);
//        //ht.Add("Status", "Single");
//        //ht.Add("Height", "6ft");

//        //Console.WriteLine(ht["Name"]);

//        //foreach (var ht2 in ht.Keys)
//        //{
//        //    Console.WriteLine(ht2 + " : " + ht[ht2]);
//        //}



//    }
//}


//                                                C# OOP CONCEPTS

//                                                CLASS AND METHODS

//using CsharpBasic;

//class Program
//{
//    static void Main (string[] args)
//    {
//        Employee emp = new Employee();
//        Console.WriteLine(emp.Id = 1);
//        Console.WriteLine( emp.Name = "Khizer");
//        Console.WriteLine(emp.age = 22);
//        Console.WriteLine(emp.Dept = "IT");
//        Console.WriteLine(emp.Salary = 60000);
//        emp.work();

//        Employee emp2 = new Employee();
//        Console.WriteLine(emp.Id = 1);
//        Console.WriteLine(emp.Name = "Huzaifa");
//        Console.WriteLine(emp.age = 23);
//        Console.WriteLine(emp.Dept = "CS");
//        Console.WriteLine(emp.Salary = 70000);
//        emp.work();
//    }
//}

//                                                      Inheritance

//class Program
//{
//    static void Main (string[] args)
//    {

//    }
//}

//                                                      PolyMorphism

//class overload                                                 // Over-Loading Concept
//{
//    public void add(int a, int b)
//    {
//        int c = a + b;
//        Console.WriteLine(c);
//    }
//    public void add(double a,double b)
//    {
//        double c = a + b;
//        Console.WriteLine(c);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        overload overload = new overload();
//        overload.add(2, 3);
//    }
//}

// Over - Riding Concept
//class dog                                              
//{                                              
//    public void eat()
//    {
//        Console.WriteLine("Dog Eats Bones");
//    }
//}  
//class lion : dog
//{
//    public void eat()
//    {
//        Console.WriteLine("Lion Eats Meat");
//    }
//}
//class Program
//{
//    static void Main (string[] args)
//    {
//       dog dog = new dog();
//       dog.eat();

//      lion lion = new lion();
//      lion.eat();
//    }
//}

//                                                        Absrtraction

//abstract class abs
//{
//    public abstract void add();

//    public void sub()
//    {
//        Console.WriteLine("Hello");
//    }
//}
//class abc : abs
//{
//    public override void add()
//    {
//        int a = 1;
//        int b = 2;
//        int c = a + b;
//        Console.WriteLine(c);
//    }
//}

//abstract class employee
//{
//    public abstract void id();
//    public abstract void name();

//    public abstract void age();
//    public abstract void city();
//}
//class empO : employee
//{
//    public override void age()
//    {
//        Console.WriteLine("25");
//    }

//    public override void city()
//    {
//        Console.WriteLine("Karachi");
//    }

//    public override void id()
//    {
//        Console.WriteLine("1");
//    }

//    public override void name()
//    {
//        Console.WriteLine("Khizer");
//    }
//}

//class Program
//{
//    static void Main (string[] args)
//    {
//          //abc ab = new abc();
//          //ab.add();
//          //ab.sub();

//        empO emp = new empO();
//        emp.id();
//        emp.name();
//        emp.age();
//        emp.city();
//    }
//}


//                                                      Encapsulation

//class Employee
//{
//    private String FirstName;
//    private int Age;
//    private String City;

//    public string FirstName1 { get => FirstName; set => FirstName = value; }        // By clicking right  button quick and then
//    public int Age1 { get => Age; set => Age = value; }


//    //public string firstname
//    //{
//    //    get { return FirstName; }
//    //    set { FirstName = value; }
//    //}
//    //public int age
//    //{
//    //    get { return Age; }
//    //    set { Age = value; }
//    //}

//}

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            Console.WriteLine(emp.FirstName1 = "Khizer");
//            Console.WriteLine(emp.Age1 = 21);
//        }
//    }


//                                                         InterFace

//interface InterfaceOne
//{
//    public void Add();
//}
//interface InterfaceTwo 
//{
//    public void Add();
//}

//class info : InterfaceOne, InterfaceTwo
//{

//    void InterfaceOne.Add()                             // Explicit Method
//    {
//        Console.WriteLine("Hello");
//    }

//    void InterfaceTwo.Add()
//    {
//        Console.WriteLine("Bye");
//    }
//    //public void Add()                                  // Implicit Method
//    //{
//    //    Console.WriteLine("Bye");
//    //}
//}

//class Program
//{
//    static void Main (string[] args)
//    {
//        info inf = new info();
//        InterfaceOne io = inf;
//        InterfaceTwo io2 = inf;
//        io.Add();
//        io2.Add();
//    }
//}


