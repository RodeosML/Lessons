//1. Последовательная загрузка черетежей в формате pdf на сервер.
//Ввиду того, что изначально задумывалось, что будет последовательная загрузка из-за веса файлов, поэтому использовали массив.
//Однако это ошибочно, переписал на стек

//Было, пример части кода с реализацией:
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

private List<DrawingToUpload> drawingsToUpload = new List<DrawingToUpload>();

public class DrawingToUpload
{
    public string drawingTitle { get; set; }
    public byte[] Data { get; set; }
}


public async Task AddDrawingToUpload(string fileName, byte[] fileData)
{
    DrawingToUpload newDrawingFile = new DrawingToUpload()
    {
        drawingTitle = fileName,
        Data = fileData
    };

    lock (drawingsToUpload)
    {
        drawingsToUpload.Add(newDrawingFile);

        if (drawingsToUpload.Count > 1)
        {
            drawingsToUpload.RemoveAt(0);
        }
    }
}

//стало, пример части кода с реализацией:
private Stack<DrawingToUpload> drawingsToUpload = new Stack<DrawingToUpload>();

public class DrawingToUpload
{
    public string Name { get; set; }
    public byte[] Data { get; set; }
}

public async Task AddDrawingToUpload(string fileName, byte[] fileData)
{
    DrawingToUpload newFile = new DrawingToUpload()
    {
        public string drawingTitle { get; set; }
        public byte[] Data { get; set; }
    };

    lock (drawingsToUpload)
    {
        drawingsToUpload.Push(newFile);

        if (drawingsToUpload.Count > 1)
        {
        drawingsToUpload.Pop();
        }
    }

}


//2.Использовался массив для передачи информации о прав доступа пользователей.
//В местах, где происходила проверка на налчие прав происходил цикл по массиву и возвращался true, если права есть.
//Можно заменить на Hash

//было:
int[] privillieage = new int[];

//стало:
HashSet<int> privillieage = new HashSet<int>();


//3.Примером ибезжания прямой индексации к объектам является цикл перебора foreach для отображения значений. К примеру, есть список организаций:
List<OrganizationInfo> organization = GetInfoOrganization();

foreach (OrganizationInfo organization in organizations)
{
    Console.WriteLine($"ID: {organizations.Id}, Title: {organizations.Title}");
}

//4.Примером использования вместо массивов более безопасного хранения является Dictionary:
public static Dictionary<int, string> CompanyVGO = new Dictionary<int, string>
        {               {1,"ООО \"Астрахань\""},
                        {2,"ООО \"Иркутск\""}
        };

//5.Использование списка объектов формирования данных для графика, вместо массивов:
for (var i = 0; i < CalcModelsUtils.CalcModelsYearCount; i++)
    result.Add(new ModelsResultChartData
    {
        Year = CalcModelsUtils.CalcModelsStartYear + i,
        GroupTotal = ratioDebtToEquity.Sum(x => x.Values[i + 1] ?? 0),
        GPNeftMinus = ebitdaMarg.Sum(x => x.Values[i + 1] ?? 0),
        GPNeftPlus = ebitda.Sum(x => x.Values[i + 1] ?? 0) / 1000,
    });
