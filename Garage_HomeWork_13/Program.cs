using Garage_HomeWork_13;




List<Student> students = new List<Student>
{
    new Student("Student1","Student11",19,11),
    new Student("Student2","Student22",20,22),
    new Student("Student3","Student33",21,33),
    new Student("Student4","Student44",23,44)

};
List<Employe> employes = new List<Employe>
{
    new Employe("Employe1","Employe11",25,"Position1"),
    new Employe("Employe2","Employe22",26,"Position2"),
    new Employe("Employe3","Employe33",27,"Position1"),
    new Employe("Employe4","Employe44",28,"Position2"),

};


int choice = 0;

while (choice != 4)
{
    Console.WriteLine("1- Add Student");
    Console.WriteLine("2- Add Employe");
    Console.WriteLine("3- Axtarish");
    Console.WriteLine("4- Cixish");

    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
    {
        Console.WriteLine("Yanlısh secim.");
    }

    switch (choice)
    {
        case 1:
            AddStudent();
            break;
        case 2:
            AddEmploye();
            break;
        case 3:
            SearchMenu();
            break;
    }
}



void AddStudent()
{
    Console.Write("Student Name:");
    string? name = Console.ReadLine();

    Console.Write("Student Surname:");
    string? surname = Console.ReadLine();

    byte age;
    Console.Write("Student Age:");
    while (!byte.TryParse(Console.ReadLine(), out age) || age <= 0)
    {
        Console.WriteLine("Age sehv daxil edilib.");
        Console.Write("Student Age:");
    }

    int grade;
    Console.Write("Student Grade:");
    while (!int.TryParse(Console.ReadLine(), out grade) || grade <= 0)
    {
        Console.WriteLine("Grade sehv daxil edilib.");
        Console.Write("Student Grade:");
    }

    try
    {
        students.Add(new Student(name!, surname!, age, grade));
        Console.WriteLine("Student elave edildi");
    }
    catch
    {
        Console.WriteLine("Name daxil edilmeyib.Student elave edilmedi");
    }
}

void AddEmploye()
{
    Console.Write("Employe Name:");
    string? name = Console.ReadLine();

    Console.Write("Employe Surname:");
    string? surname = Console.ReadLine();

    Console.Write("Employe Age:");
    byte age;
    while (!byte.TryParse(Console.ReadLine(), out age) || age <= 0)
    {
        Console.WriteLine("Age sehv daxil edilib.");
        Console.Write("Employe Age:");
    }

    Console.Write("Employe Position:");
    string? position = Console.ReadLine();


    try
    {
        employes.Add(new Employe(name!, surname!, age, position!));
        Console.WriteLine("Employe elave edildi");
    }
    catch when (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Name daxil edilmeyib.Employe elave edilmedi");
    }
    catch when (string.IsNullOrEmpty(position))
    {
        Console.WriteLine("Position daxil edilmeyib.Employe elave edilmedi");
    }

}

void SearchMenu()
{
    int searchChoice;

    do
    {
        Console.WriteLine("1- Search Employe");
        Console.WriteLine("2- Search Student");
        Console.WriteLine("3- Back");

        while (!int.TryParse(Console.ReadLine(), out searchChoice) || searchChoice < 1 || searchChoice > 3)
        {
            Console.WriteLine("Yanlish secim");
        }

        switch (searchChoice)
        {
            case 1:
                SearchEmployeByPosition();
                break;
            case 2:
                SearchStudentByGradeRange();
                break;
        }

    } while (searchChoice != 3);
}

void SearchEmployeByPosition()
{
    Console.Write("Position:");
    string? position = Console.ReadLine();

    var matchingEmployes = employes.Where(e => e?.Position.ToLower() == position?.ToLower()).ToList();

    if(matchingEmployes.Count > 0)
    {
        Console.WriteLine("Employes:");
        foreach (var employe in matchingEmployes)
        {
            Console.WriteLine($"{employe.Name} {employe.Surname}");
        }
    }
    else Console.WriteLine("Uygun Employe tapilmadi");
}

void SearchStudentByGradeRange()
{
    Console.Write("Minimum grade:");
    int minGrade;
    while (!int.TryParse(Console.ReadLine(), out minGrade) || minGrade < 0)
    {
        Console.WriteLine("Yanlıs qiymet daxil edilib");
        Console.Write("Minimum grade:");
    }

    Console.Write("Maximum grade:");
    int maxGrade;
    while (!int.TryParse(Console.ReadLine(), out maxGrade) || maxGrade < minGrade)
    {
        Console.WriteLine("Yanlıs qiymet daxil edilib");
        Console.Write("Maximum grade:");
    }

    var matchingStudents = students.Where(s => s.Grade >= minGrade && s.Grade <= maxGrade).ToList();

    if(matchingStudents.Count > 0)
    {
        Console.WriteLine("Students:");
        foreach (var student in matchingStudents)
        {
            Console.WriteLine($"{student.Name} - {student.Grade}");
        }
    }
    else { Console.WriteLine("Uygun student tapilmadi"); }
}