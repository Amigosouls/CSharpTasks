using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static CSharpTasks.Attributes;

namespace CSharpTasks
{
    
    public class Attributes
    {
        [AttributeUsage(AttributeTargets.Class
        | AttributeTargets.Constructor
        | AttributeTargets.Method
        | AttributeTargets.Property
        | AttributeTargets.Field,
        AllowMultiple = true

        )]

        public class Developer : Attribute
        {
            private string developerName;
            private string devDesig;
            public static  DateTime date = new DateTime();
            private string issueDate;

            public Developer(string devname , string devdesg)
            {
                this.developerName = devname;
                this.devDesig = devdesg;
               
            }
            public string devname
            {
                get
                {
                    return this.developerName;
                }
                
            } 
            public string Desig
            {
                get
                {
                    return this.devDesig;
                }
            }
            public string BugDate
            {
                get
                {
                    return date.ToLongDateString();
                }
            }

        }
       

    }
    [Developer("Sriaknth", "Junior Developer")]
    public class Testing
    {
        
        private string testerName;
        [Developer("Amigo", "Senior Developer")]
        public string TesterName { get { return testerName; } set { testerName = value; } }

        [Developer("Sharon", "Technical Lead")]
        public void welComeDev()
        {
            Console.WriteLine("Developer is Sharon");
        }
        [Developer("Vignesh", "Project Manager ")]
        public Testing()
        {
            Console.WriteLine("Im from constructor of Tester");
        }
    }
    public class AttributeMain
    {
        static void Main(string[] args)
        {
            //Attributes main = new Attributes();
            getAttributes(typeof(Testing));
            

        }

        public static void getAttributes(Type type)
        {
            Console.WriteLine("For Methods the Attributes are..");
            MethodInfo[] methods = type.GetMethods();
            for (int i = 0; i < methods.GetLength(0); i++)
            {
                object[] attribArray = methods[i].GetCustomAttributes(true);

                foreach (Attribute item in attribArray)
                {
                    if (item is Developer)
                    {
                        Developer atribObj = (Developer)item;
                        Console.WriteLine($"Method Name:{methods[i].Name} \n Dev Name: {atribObj.devname} Designation:{atribObj.Desig} Creation Time:{atribObj.BugDate}");
                    }
                }
            }
            Console.WriteLine("For Constructor the Attributes are..");
            ConstructorInfo[] constructs = type.GetConstructors();
            for (int i = 0; i < constructs.GetLength(0); i++)
            {
                object[] attribArray = constructs[i].GetCustomAttributes(true);

                foreach (Attribute item in attribArray)
                {
                    if (item is Developer)
                    {
                        Developer atribObj = (Developer)item;
                        Console.WriteLine($"Constructor Name:{constructs[i].Name} \n Dev Name: {atribObj.devname} Designation:{atribObj.Desig} Creation Time:{atribObj.BugDate}");
                    }
                }
            }

            Console.WriteLine("For Properties the Attributes are..");
            PropertyInfo[] property = type.GetProperties();
            for (int i = 0; i < property.GetLength(0); i++)
            {
                object[] attribArray = property[i].GetCustomAttributes(true);

                foreach (Attribute item in attribArray)
                {
                    //Console.WriteLine(item.ToString());
                    if (item is Developer)
                    {
                        Developer atribObj = (Developer)item;
                        Console.WriteLine($"Property Name:{property[i].Name} \n Dev Name: {atribObj.devname} Designation:{atribObj.Desig} Creation Time:{atribObj.BugDate}");
                    }
                }
            }

            Console.WriteLine("For Class the Attributes are..");
            foreach (Developer obj in type.GetCustomAttributes(true))
            {
                Developer attributes = obj;
                if (attributes != null)
                {
                    Console.WriteLine(attributes.devname);
                    Console.WriteLine(attributes.BugDate);
                    Console.WriteLine(attributes.Desig);
                }
            }

            //Reflection class...
           Reflection reflection = new Reflection();
            Console.WriteLine("Math Class Methods...");
            reflection.showMethods(typeof(Math));
            Console.WriteLine("===================================================================");
            Console.WriteLine("Methods of Current Class");
            reflection.showMethods(typeof(Reflection));
            Console.WriteLine("====================================================================");
            reflection.MetaData(typeof(Reflection));

           // Indexer.showEmp();
        
        }   
    }

    public class Reflection
    {
        public int number = 20;
        public string name = "Arun";
        public float fraction = 2.5f;
        public decimal currency = 54625.34m;
        public double astrounit = 422341.234;

        public void SayHello(string name)
        {
            Console.WriteLine("Hello"+name);
        }
        public void sayBye(string name)
        {
            Console.WriteLine("Bye"+name);
        }
        public void showMethods(Type type)
        {
            
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Name:"+method.Name);
                Console.WriteLine("Return Type:"+method.ReturnType);
                Console.WriteLine("Declaring Type"+method.DeclaringType);
            }
        }
        public void MetaData(Type type)
        {
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine("Name:" + field.Name);
                Console.WriteLine("Return Type:" + field.FieldType);
                Console.WriteLine("Declaring Type:" + field.DeclaringType);
                Console.WriteLine("Is Public:" + field.IsPublic);
                Console.WriteLine("Module:" + field.Module);
            }
        }
    }
    //class EmployeeDet
    //{
    //    public string empName;
    //    public string empAge;
    //    public string role;
    //    private EmployeeDet[] employees = new EmployeeDet[10] ;
    //    public EmployeeDet this[int index]
    //    {
    //        get
    //        {
    //            return employees[index];
    //        }
    //        set
    //        {
    //            employees[index].empName = value[0].empName;
    //            employees[index].empAge = value[0].empAge;
    //            employees[index].role = value[0].role;
    //        }
    //    }
        
    //}

    //static class Indexer
    //{
    //    public static void showEmp()
    //    {
    //        EmployeeDet employeeDet = new EmployeeDet();
    //       // employeeDet[0] = object{"Arun"};
    //        employeeDet[0].empAge = "22";
    //        employeeDet[0].role = "Trainee";
    //        employeeDet[1].empName = "Srikanth";
    //        employeeDet[1].empAge = "20";
    //        employeeDet[1].role = "Developer";
    //        employeeDet[2].empName = "Shar0n";
    //        employeeDet[2].empAge = "21";
    //        employeeDet[2].role = "Tester";

    //        Console.WriteLine(employeeDet[0]);
    //    }
    //}

}
