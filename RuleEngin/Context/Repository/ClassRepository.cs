using RuleEngin.Interface.Repository;
using RuleEngin.Model;

namespace RuleEngin.Context.Repository;

public class ClassRepository : IClassRepository
{
    public async Task<List<Classes>> GetAllClasses()
    {
        var classes = new List<Classes>
        {
            new Classes
            {
                ClassCaption = "A",
                ClassName = "A",
                ClassType = "A"
            },
            new Classes
            {
                ClassCaption = "B",
                ClassName = "B",
                ClassType = "B"
            },
            new Classes
            {
                ClassCaption = "C",
                ClassName = "C",
                ClassType = "C"
            },
            new Classes
            {
                ClassCaption = "D",
                ClassName = "D",
                ClassType = "D"
            },
            new Classes
            {
                ClassCaption = "E",
                ClassName = "E",
                ClassType = "E"
            }
        };
        await Task.Delay(2000);
        return classes;
    }
}