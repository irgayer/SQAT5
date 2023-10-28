using SQAT5.Application.TodoLists.Queries.ExportTodos;

namespace SQAT5.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
