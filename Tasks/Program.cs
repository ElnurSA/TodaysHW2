//using Tasks;

//2.1

//int[] arr1 = { 1, 2, 3, 4, 5, 6 };

//CustomMath customMath = new();
//customMath.OddCalculator(arr1);

//2.2

//CustomMath customMath = new();
//customMath.OddOrEven(0);

//2.3

//CustomMath customMath = new();

//int[] arr = { 1, 2, 3, 4, 5, 6, 8 };

//customMath.SquareRootOfSum(arr);

//2.4

//CustomMath customMath = new();
//customMath.Multiplier(5);


using Tasks;

Employee employee1 = new()
{
    id = 1,
    name = "Elnur",
    surname = "Safiyev",
    address = "Sahil",
    email = "elnurms@code.edu.az",
    age = 19

};

Employee employee2 = new()
{
    id = 2,
    name = "Vagif",
    surname = "Aliyev",
    address = "Yasamal",
    email = "Vagifms@code.edu.az",
    age = 29

};

Employee employee3 = new()
{
    id = 3,
    name = "Vugar",
    surname = "Mammadov",
    address = "Bineqedi",
    email = "Vugarms@code.edu.az",
    age = 39

    
};

Employee[] employees = { employee1, employee2, employee3 };

// 3.1



//static void AgeChecker(int n, Employee[] employees)
//{


//    foreach (var employee in employees)
//    {
//        if(employee.age > n)
//        {
//            Console.WriteLine($"Id : {employee.id} - Name : {employee.name} - Surname : {employee.surname} - Address : {employee.address} - email : {employee.email} - Age : {employee.age}");
//        }
//    }
//}

//AgeChecker(20, employees);

//3.2

//static void Between20And30(Employee[] employees)
//{
//    int count = 0;
//    foreach(var employee in employees)
//    {
//        if(employee.age >= 20 && employee.age <= 30)
//        {
//            count += 1;
//        }
//    }
//    Console.WriteLine(count);
//}

//Between20And30(employees);

//3.3

//static void SumOfEmployeeAge(Employee[] employees)
//{
//    int sum = 0;
//    foreach(var employee in employees)
//    {
//        sum += employee.age;
//    }

//    Console.WriteLine(sum);
//}

//SumOfEmployeeAge(employees);

//3.4