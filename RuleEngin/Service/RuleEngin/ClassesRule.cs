using RuleEngin.Interface;
using RuleEngin.Interface.Repository;

namespace RuleEngin.Service.RuleEngin;

public class ClassesRule : IInsertToSqliteRul
{
    private readonly IClassRepository _classRepository;
    public ClassesRule(IClassRepository classRepository)
    {
        _classRepository = classRepository;
    }
    public async Task InsertDataToSqlite()
    {
        var result = await _classRepository.GetAllClasses();
        throw new NotImplementedException();
    }
}