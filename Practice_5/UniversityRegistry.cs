namespace Practice_5;
class UniversityRegistry
{
    private List<UniversityMember> members;

    public void AddMember(UniversityMember m)
    {
        members.Add(m);
    }
    
    public void ExecuteAllDuties()
    {
        foreach (var m in members)
        {
            m.PerfomDuties();
        }
    }
    
    public List<string> GetMemberStatisctics()
    {
        List<string> allDuties = new List<string>(); 
        foreach (var m in members)
        {
            foreach (var action in m.ActionLog)
            {
                allDuties.Add(action);    
            }
            
        }
        return allDuties;
    }
}