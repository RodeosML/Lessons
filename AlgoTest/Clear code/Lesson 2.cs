
//6.1
toggleVisibility - toggleVisibilityPassoword // параметр, сигнализирующий, что пароль исчезает

vcr - viewContainerTimer // ссылка на контейнер с таймером

hasEmployeeN - containNameEmployee // параметр, сигнализирующий, что содержится наименование сотрудника

getTimeRange - getTimeRangeOnMainProfile //запрос на получение диапазона значений в главном профиле

add - addRecord //функция добавления записей в список записей

//6.2
pixelColor //переменная, содержащая информацию о цвете определенного пикселя на изображении

databaseQuery //переменная, содержащая SQL-запрос для получения данных из базы данных

encryptionKey //переменная, содержащая ключ для шифрования и дешифрования данных, используемая в программе для обеспечения безопасности информации.

googleClientId //переменная содержащая ID пользователя, имеющего права на использование технологий Google

//6.3
public enum ActivityTypes
{
    Production = 11,
    Recycle = 12,
    Transport = 13,
    UGS = 14,
    GPNeft = 20,
    Energy = 30,
    Admin = 40,
    GroupGasprom = 50,
}


public enum FinFormTypes
{
    Balance = 1,
    Money = 2,
    FinResult = 3,
    ConsolBalance = 4,
    ConsolFinance = 5,
    ConsolMoney = 6,
}

public JsonResult AnalysisSeriesExportToXlsx([FromBody] DataSeriesForWsExport data, DateTime FromDate, DateTime DateTo, long TargetFilterId) {
    return exportFile;
}

//6.4
sw - stopWatchFile

IsRaw - emptyListEmployee

priv - privilegeForRole

tik - TimeInSeconds

compId - companyId