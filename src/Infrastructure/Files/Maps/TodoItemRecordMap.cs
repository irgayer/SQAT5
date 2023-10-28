using System.Globalization;
using SQAT5.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace SQAT5.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
