using RuleEngin.Interface;

namespace RuleEngin.Service;

public class ClassService : IClassService
{
    public async Task GetPmSqliteFileService()
    {
        var ruleType = typeof(IInsertToSqliteRul);
        var rule = this.GetType().Assembly.GetTypes()
            .Where(a => ruleType.IsAssignableFrom(a) && !a.IsInterface)
            .Select(a => Activator.CreateInstance(a) as IInsertToSqliteRul);
        await Task.WhenAll(rule.Select(a=> a.InsertDataToSqlite()));
    }
}