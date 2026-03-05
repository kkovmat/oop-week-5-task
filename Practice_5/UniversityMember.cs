namespace Practice_5;
class UniversityMember
{
    private string name;
    private string memberId;
    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be empty.");
            }
            name = value;            
        }
    }
    public string MemberId
    {
        get => memberId;
        private set
        {
            memberId = value;
        }
    }
    protected List<string> actionLog;
    public List<string> ActionLog
    {
        get => actionLog;
        private set
        {
            Console.WriteLine($"{name}:{value.Count}");
            if (value.Count >= 5)
            {
                throw new Exception("Reached a daily limit of 5 duties.");
            }
            actionLog = value;
        }
    } 

    public UniversityMember(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
        ActionLog = [];
    }
    
    virtual public void PerfomDuties()
    {
        Console.WriteLine($"{name}: {ActionLog.Count}");
        ActionLog.Add("Some action");
    }

}