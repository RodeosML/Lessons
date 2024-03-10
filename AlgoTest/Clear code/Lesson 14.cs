//Задание 3.1.
//Мне на работе часто приходиться осуществлять генерацию отчетов в excel. Ввиду этого есть целые блоки кода, которые относятся к разной смысловой
//составляющей отчета. Для быстрой ориентации какая строчка кода гененирует его нужно расставлять комментарии. Это помогает в будущем перестраивать отчеты быстрее или улучшать их работу. Вот примеры:
//3.1.1.
//Подписи под общей оценкой "ОЦЕНЕНО.."
var countTask = curInfo.Select(x => x.Num).Count();
var cellForAdd = ws.Cell(6, 3).CreateRichText();

//3.1.2.
//Отбираем по КТНЦ
var data3 = curInfo.Where(x => x.RespText == respondent).ToList();
var startrow = ++currow;
var no = 0;
ws.Cell(startrow, 1).Value = respondent;
ws.Range(startrow, 1, startrow, 12).Merge();
ws.Range(startrow, 1, startrow, 12).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
ws.Range(startrow, 1, startrow, 12).Style.Font.FontSize = 14;
ws.Range(startrow, 1, startrow, 12).Style.Font.Bold = true;
ws.Range(startrow, 1, startrow, 12).Style.Font.FontColor = XLColor.White;
ws.Range(startrow, 1, startrow, 12).Style.Fill.BackgroundColor = XLColor.Gray

//3.1.3 Данная часть кода объясняет как именно используются методы для копирования графиков, написанных на OpenXML.
 var tempFN = HttpContext.Current.Server.MapPath("~/Templates/Reports/" + guid.ToString() + ".xlsx");
using (var mainDoc = SpreadsheetDocument.Open(HttpContext.Current.Server.MapPath("~/Templates/Reports/Survey.xlsx"), false))
using (var resultDoc = SpreadsheetDocument.Create(HttpContext.Current.Server.MapPath("~/Templates/Reports/" + guid.ToString() + ".xlsx"), SpreadsheetDocumentType.Workbook))
{

    //Копирование частей из исходного документа в новый документ
    foreach (var part in mainDoc.Parts)
        resultDoc.AddPart(part.OpenXmlPart, part.RelationshipId);

    //Выполняем замены в resultDoc.MainDocumentPart
    foreach (var cur in newSheetsNames)
    {
        CloneSheet(resultDoc, tamplateSheetName, cur);
    }
    resultDoc.Clone(stream);
}

FileInfo fi = new FileInfo(tempFN);
if (fi.Exists) fi.Delete();

//3.1.4 Когда мы разрабатывали программный продукт, копирующий расчеты в эксель крайне важно было сохранять истинное название используемых
//переменных на русском языке, чтобы оперативно вносить изменения по коду. Пример такого комментария:

//Погашение долгосрочной задолженности
var repaymentOfLongPeriod = Enumerable.Range(CalcModelsUtils.CalcModelsStartYear, CalcModelsUtils.CalcModelsYearCount)
   .ToDictionary(x => x,
//more code ...)

//3.1.5 Примером разделения смысловой составляющей по коду:

//3 этап Операционный цикл
result.Add(new CalcModelsResultData
{
 Company = company.Id,
 ResultParam = "Изменение торговой ДЗ",
 Unit = "млн руб."
};

//3.1.6
//Информируем о превышении допустимых значений рабочих дней
if (department.Mark_Days == true)
{
    ws.Cell(row, 3).Style.Fill.BackgroundColor = XLColor.Red;
}

//3.1.7 Описание идеи с рекурсивным обходом и дальнейшей связью по ходу кода:
//Перебираем все дочерние узлы (рекурсивный запрос). Groups - используем для группировки с уровнями
if (department.Children != null && department.Children.Any())
{
    foreach (var child in department.Children)
    {
        WriteHierarchyToExcel(ws, new List<DepartmentInfo> { child as DepartmentInfo }, startRow, ref row, groups);
    }

    groups.Add(new Tuple<int, int>(startRow, row - 1));

    startRow = row;
}
#endregion

//Задание 3.2.
//3.2.1. Лишний комментарий
//Было:
//Сметы для задач
[HttpGet]
public IActionResult GenerateExcel(long key)
{
    return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "report1.xlsx");
}
//Стало
[HttpGet]
public IActionResult CreateEstimateReport(long key)
{
    return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "report1.xlsx");
}

//3.2.2. Убрал лишний комментарий
//Было:
//Стилизуем строки
ws.Range(row, 1, row, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
ws.Range(row, 1, row, 3).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

//Стало
ws.Range(row, 1, row, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
ws.Range(row, 1, row, 3).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

//3.2.3. Убрал комментарий и изменил на понятные консатнты:
//Было:
//Обязательные параметры (диаметр, рабочее давление, климатическое исполнение, тип установки, тип присоединения)
var mainParamValueIds = new Dictionary<long, long>();
var mainParameterIds = new List<long> { 1, 7, 10, 16, 1002};
var mainParameterIds = new List<long> { 1, 7, 10, 16, 1002};

//Стало:
var mainParamValueIds = new Dictionary<long, long>();
var mainParameterIds = new List<long> { DIAMETR, PRESSURE, CLIMATE_DESIGN, INSTALLIATION_TYPE, CONNECT_TYPE};
var mainParameterIds = new List<long> { DIAMETR, PRESSURE, CLIMATE_DESIGN, INSTALLIATION_TYPE, CONNECT_TYPE };

//3.2.4.
//Было
//Проверка на наличие параметра в 2023 году
if ((organ.params & DISTRIB) && (year == 2023))

//Стало
//Имеет ли организация значение "нужных" параметров по трнаспортировке по 2023 году 
if (organ.isTransportValue())

//3.2.5.
//Было
//Проверка на наличие выручки по текущему году
if (CUR_YEAR && organ.revenue > 0)

//стало
//Проверка на наличие выручки у организации в текущем году
if (organ.isHaveRevenueInCurYear());