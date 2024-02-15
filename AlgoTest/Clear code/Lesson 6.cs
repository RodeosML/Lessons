
validateOrganizationRevenue - isCorrectRevenueForOrganization //Проверка принадлежности выручки к компании

loadDrawing - loadDrawingByEmployee //Загружает чертеж по конкретному сотруднику

loadDataOrg - getOrganizationInfo //Метод для получение информации по организации

delete - deleteProfile //Метод удаления информации о пользователи

getGasVolume - getGasVolumeInCubMeters //Уточнил информацию о использованных единицах измерения

export - exportToExcel //Уточнил, что документ экспортируется в эксель

calcMonthlyValues - calcMonthlyRevenueValues //Метод рассчитывает выручку по месяцам, избавился от путающей абстракции

selectIcon - showSelectIconInProfile //Сделал название более информативным с точки зрения окружения данной функции

perfomOperationAdd - addValueInProfileOrganization //Неинформативное название добавления значений в профиль организации

getProfile - getProfileOrganization //Уточнил, что мы получаем профиль организации

uniqueValue - seekUniqueIdOrganization //Поиск уникального индетификатора в списке организаций

searchForItemInListAndReturnMultipleMatches - seekItemInList //разбил на несколько функций, так как одна функция делает одно действие, а также с учетом унифкации перешел к seek