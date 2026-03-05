namespace Practice_5;
class Professor : UniversityMember
{
    public Professor(string name, string memberId) : base(name, memberId) {}

    public override void PerfomDuties()
    {
        actionLog.Add("Lecture delivered");
    }
    public void ConductResearch(string topic)
    {
        actionLog.Add("Research conducted");
    }
}

class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name, string memberId) : base(name, memberId) {}

    public override void PerfomDuties()
    {
        actionLog.Add("Lab work completed");
    }
}

class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent(string name, string memberId) : base(name, memberId) {}

    public override void PerfomDuties()
    {
        base.PerfomDuties();
        actionLog.Add("Thesis research update");
    }
}