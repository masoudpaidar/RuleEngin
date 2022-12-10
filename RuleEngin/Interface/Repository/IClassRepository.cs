using RuleEngin.Model;

namespace RuleEngin.Interface.Repository;

public interface IClassRepository
{
    Task<List<Classes>> GetAllClasses();
}