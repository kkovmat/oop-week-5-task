namespace Practice_5;
class Program
{
    static void Main()
    {
        UniversityMember professor = new Professor("professor1", "123");
        professor.PerfomDuties();
        professor.PerfomDuties();

        UniversityMember student = new UndergraduateStudent("student1", "235");
        student.PerfomDuties();

        UniversityMember graduateStudent = new GraduateStudent("graduate student1", "566");
        graduateStudent.PerfomDuties();
        graduateStudent.PerfomDuties();
        // graduateStudent.PerfomDuties();
        // graduateStudent.PerfomDuties();
        // graduateStudent.PerfomDuties();
        // graduateStudent.PerfomDuties();

        UniversityRegistry reg = new UniversityRegistry();
        reg.AddMember(professor);
        reg.AddMember(student);
        reg.AddMember(graduateStudent);
        reg.ExecuteAllDuties();
        
        List<string> duties = reg.GetMemberStatisctics();
        foreach (string duty in duties)
        {
            Console.WriteLine(duty);
        }
    }
}