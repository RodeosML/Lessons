//1. Перенес иницилизированные переменные ближе к используемому коду

var issueSuite = Global.Get<IssueSuite>(HttpContext.Session, "IssueSuite" + key);
if (newStatusId == Global.CurrentIssuesContext(HttpContext.Session).Manager(Global.GetUser(HttpContext)).CompleteIssueState.Id)
{
    issueSuite.Issue.ResolutionId = resolution;
    issueSuite.Issue.Resolution = Global.CurrentIssuesContext(HttpContext.Session).Manager(Global.GetUser(HttpContext)).GetIssueResolutions().First(x => x.Id == resolution);
}

//2. Перенес иницилизированные переменные ближе к используемому коду
var req = GetObject<Request>(reqId);
var oldMeetId = req.ItogMeetingId;
req.ItogMeetingId = meetId;
if (!meetId.HasValue)
    req.StatusId = (long)RequestStatuses.ItogZasedanie;
SaveObject(req);

//3. Перенес иницилизированные переменные ближе к используемому коду
string secretarFIO = "";
if (zasedanie.SecretaryName != "" && zasedanie.SecretaryName != null) //Фамилия должна быть первой, отчества может не быть
{
    string[] str2 = zasedanie.SecretaryName.Split(new string[] { " ", "." }, StringSplitOptions.None); str2 = str2.Where(t => t != "").ToArray();
    if (str2.Count() == 3) { secretarFIO = str2[1].Substring(0, 1) + "." + str2[2].Substring(0, 1) + ". " + str2[0]; } //Если все поля правильно заполнены должно сработать это условие
    else if (str2.Count() == 2) { secretarFIO = str2[1].Substring(0, 1) + "." + str2[0]; } //Есть люди без отчества
    else { secretarFIO = zasedanie.SecretaryName; } //На случай если не проходит ни одно условие, выводит то что изначально было записано как ФИО
}

//4. Перенес иницилизированные переменные ближе к используемому коду
TMyWord wordDoc = new TMyWord(stream, false);
wordDoc.wdAddParagraph("");
wordDoc.wdAddParagraph("");
wordDoc.wdAddParagraph("Секция ", null, 12, WdParagraphAlignment.wdAlignParagraphCenter);

//5. Перенес иницилизированные переменные ближе к используемому коду
var curRow = 11;
foreach (var grp in groups.Where(x => data.tasks.Any(y => x.Item2.Contains(y.Status))))
{
    var data2 = data.tasks.Where(x => grp.Item2.Contains(x.Status)).ToList();
    var startRow = ++curRow;
    ....
}

//6.Добавил в логи ошибок информацию, если одна из переменных не попадает в положительный интервал.

//7.Добавил проверку, используя подход try..catch при вычисленнии значений в модели.

//8.Нашел ошибку в коде, где не занулял значения агрегатов
for (var intSum = i; intSum < CalcModelsUtils.CalcModelsStartYear + CalcModelsUtils.CalcModelsYearCount; intSum++)
{
    //some code
    decimal res = 0;
    res += repaymentInterMid[intSum];
    //some code
    dYears.Add(intSum, res);
}


//9. Перенес иницилизированные переменные ближе к используемому коду
decimal findResult = retainedEarningsLossOtherReserves[CalcModelsUtils.CalcModelsStartYear - 1];
var monthlyRetainedEarningsLossOtherReserves = new Dictionary<int, Dictionary<int, decimal>>();
for (int i = 1; i < 4; i++)
{
    var dMonths = new Dictionary<int, decimal>();
    for (int j = 1; j < 13; j++)
    {
    }
}

//10. Перенес иницилизированные переменные ближе к используемому коду
const int GPNS_ID = 28;
if (company.Id == GPNS_ID)
{

    var totalRevenueResult = new CalcModelsResultData
    {
        Company = company.Id,
        ResultParam = "Выручка от реализации всего",
        Unit = "млн руб.",
    };
}

//11.Перенес иницилизированные переменные ближе к используемому коду
const int GPPER_ID = 29;
if (company.Id == GPPER_ID)
{
    //Тариф на оказание услуг переработки
    var tariffCoeff ....
}

//12. Добавил в логирование ошибики информацию отсутствия иницилизиации обязательных полей в профиле пользователя
//13. Используя инварианты добавил проверки в цикле на суммирование нужных значений (полезно для балансовых проверок, когда статей много)
//14. Попробовал использовать подход завершения работы с переменными:
public float CalculateAverage(int[] numbers)
{
    int total = 0;
    int count = 0;
    foreach (int num in numbers)
    {
        total += num;
        count++;
    }
    total = -1;
    count = -1;
    return (float)total / count;
}
//15. Использую подход завершения работы с переменными:
public object ValidateInput(string inputStr)
{
    if (int.TryParse(inputStr, out int result))
    {
        return result;
    }
    else
    {
        inputStr = "***ERROR***";
        return inputStr;
    }
}



