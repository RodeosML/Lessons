//1 Комментарий TODO. Добавлен todo комментарий к старым методам API и необходимости перехать на новый после выхода обновления 
//TODO переехать на новый API после выхода обновления от 11.24 в Сфере
using System.IO;

AuthToken auth();

//2 Информационный комментарий
//Перевод ответов в балльную систему
var scoreQ12 = Q12 == "Да, в полном объёме" ? 10 : Q12 == "Да, частично" ? 5 : 1;
return scoreQ12;

//3 Представление намерений
// Мы пытаемся рекурсивно обойти список департаментов, выделяя внутри них отделы и центры и соотносить их с показателями эффективности

//4 Информационный комментарий
//Работаем с сгенирированными листами по кураторам
foreach (var kuratorName in curators)
{
    TaskCurator(workbook.Worksheet(kuratorName), result.Where(x => x.KuratorName == kuratorName));
}

//5 Предупреждение о последствиях
//Данные тесты необходимо проводить после отключения дополнительных связей с таблицей департаментов. Изолировано

//6 Информационный комментарий
//Оценка взаимодействия с исполнителем
int startScale = 1;
int finalScale = 10;
int startRow = 105;

for (int i = startScale; i <= finalScale; i++)
{
    ws.Cell(startRow + i, 3).Value = result.Count(x => x.Q3 == i);
    ws.Cell(startRow + i, 4).Value = result.Count(x => x.Q4 == i);
}

//7 Представление намерений
//Ответы для рекомендаций по отчету
int yes = 10;
int doubt = 5;
int no = 0;

//8 Предупреждение о последствиях
//Данный метод использовает только преднастроенного id и для конкретного департамента. Не стоит его переиспользвать. Много нюансов при расчетах

//9 Пояснение
//Выполняем замены в resultDoc.MainDocumentPart
foreach (var cur in newSheetsNames)
{
    CloneSheet(resultDoc, tamplateSheetName, cur);
}
resultDoc.Clone(stream);

//10 Пояснение
//Методы для копирования и работы с листами использующие OpenXMl
#region OpenXML
static WorksheetPart GetWorkSheetPart(WorkbookPart workbookPart, string sheetName)
{
    //Get the relationship id of the sheetname
    string relId = workbookPart.Workbook.Descendants<Sheet>()
        .Where(s => s.Name.Value.Equals(sheetName))
        .First()
        .Id;
    //more code
    return (WorksheetPart)workbookPart.GetPartById(relId);
}
static void CloneSheet(SpreadsheetDocument spreadsheetDocument, string sheetName, string clonedSheetName)
{
    WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
    WorksheetPart sourceSheetPart = GetWorkSheetPart(workbookPart, sheetName);
    Sheets sheets = workbookPart.Workbook.GetFirstChild<Sheets>();

   //more code

    ChangeBubbleChartSheetReference(clonedSheet, sheetName, clonedSheetName);

}

//11 TODO комментарий.

KeycloakToken getKeycloakToken()
{
    // TODO Задача временно на стопе, будет возобновлена на следующей неделе.
}

//12 TODO комментарий

//TODO Проверить цвет кнопок и окон, после получение редизайна компонентов. Срок 20.03.2024