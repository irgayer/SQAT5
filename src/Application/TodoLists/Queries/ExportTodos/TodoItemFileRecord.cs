using SQAT5.Application.Common.Mappings;
using SQAT5.Domain.Entities;

namespace SQAT5.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
