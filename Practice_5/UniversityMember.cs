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

    public UniversityMember(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
    }
    
    virtual public void PerfomDuties()
    {
        if (actionLog.Count >= 5)
        {
            throw new Exception("Readched a daily limit of 5 duties.");
        }
    }

}