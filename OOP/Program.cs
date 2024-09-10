Faculty science = new Faculty() { Id = Guid.NewGuid(), NoOfDepartment = 11, Name = "Science" };
Faculty arts = new Faculty() { Id = Guid.NewGuid(), NoOfDepartment = 15, Name = "Arts" };
Faculty law = new Faculty() { Id = Guid.NewGuid(), NoOfDepartment = 1, Name = "Law" };

Department csc = new Department { Id = Guid.NewGuid(), FacultyID = science.Id, NoOfYears = 5, Name = "Computer Science" };
Department mic = new Department { Id = Guid.NewGuid(), FacultyID = science.Id, NoOfYears = 4, Name = "Micro Biology" };
Department phy = new Department { Id = Guid.NewGuid(), FacultyID = science.Id, NoOfYears = 4, Name = "Physics" };

Lecturer onifade = new Lecturer()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = csc.Id, Name = "Onifade Williams", Rank = "Senior",
    Title = "P.Hd"
};
Lecturer farad = new Lecturer()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = phy.Id, Name = "Owolabi Farad", Rank = "Junior",
    Title = "Dr."
};
Lecturer peters = new Lecturer()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = mic.Id, Name = "Peters Taiwo", Rank = "Junior",
    Title = "Dr."
};

Student shittu = new Student()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = csc.Id, Name = "Shittu Sulaimon", Age = 16, Level = 300
};
Student simons = new Student()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = phy.Id, Name = "Simons Peter", Age = 19, Level = 100
};
Student charmaine = new Student()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = phy.Id, Name = "Adeola Charmaine", Age = 23, Level = 400
};

Course csc222 = new Course()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = csc.Id, LecturerID = onifade.Id,
    Name = "Foundations of computer science", CourseCode = 222, Level = 200, Unit = 3, Status = "Required"
};
Course phy102 = new Course()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = phy.Id, LecturerID = farad.Id,
    Name = "Mechanics", CourseCode = 102, Level = 100, Unit = 3, Status = "Required"
};
Course csc511 = new Course()
{
    Id = Guid.NewGuid(), FacultyID = science.Id, DepartmentID = csc.Id, LecturerID = onifade.Id,
    Name = "Systems Programming", CourseCode = 511, Level = 500, Unit = 4, Status = "Compulsory"
};

shittu.GetStudentData();
simons.GetStudentData();
onifade.GetLecturerData();


class Faculty {
    public Guid Id;
    public int NoOfDepartment;
    public string Name;
}

class Department {
    public Guid Id;
    public Guid FacultyID;
    public int NoOfYears;
    public string Name;
}

class Lecturer {
    public Guid Id;
    public Guid FacultyID;
    public Guid DepartmentID;
    public string Name;
    public string Rank;
    public string Title;
    
    public void GetLecturerData()
    {
        Console.WriteLine($"The Lecturer with the Id : {Id}, Faculty Id : {FacultyID}, Department Id : {DepartmentID}");
        Console.WriteLine($"His name is : {Name}, Academic Rank: {Rank}, Title : {Title}");
    }

    private void Teach()
    {
        Console.WriteLine("--Teaching--");
    }
}

class Student {
    public Guid Id;
    public Guid FacultyID;
    public Guid DepartmentID;
    public string Name;
    public int Level;
    public int Age;

    public void GetStudentData()
    {
        Console.WriteLine($"The Student with the Id : {Id}, Faculty Id : {FacultyID}, Department Id : {DepartmentID}");
        Console.WriteLine($"His name is : {Name}, Level : {Level}, Age : {Age}");
    } 
    private void Study()
    {
        Console.WriteLine("--Studying--");
    }
}

class Course {
    public Guid Id;
    public Guid FacultyID;
    public Guid DepartmentID;
    public Guid LecturerID;
    public string Name;
    public int CourseCode;
    public int Level;
    public int Unit;
    public string Status;
}