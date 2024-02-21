//1. Определил константу для работы с месяцами. Например, Enumerable.Range(1, 12) перешло в  Enumerable.Range(JANUARY, DECEMBER)
//2. Определил константу для страню Например, в _totalGasSales[6].Data.Single(obj => obj.Year == x).Price); _totalGasSales[RUSSIA].Data.Single(obj => obj.Year == x).Price);
//3. Определил константу для расчета месячных значений. Например в capitalInvestment[CalcModelsUtils.CalcModelsStartYear] / 12 стало capitalInvestment[CalcModelsUtils.CalcModelsStartYear] / NUMBER_OF_MONTHS
//4. Определил константу для вывода серверных ошибок 500 стало SERVER_ERROR, 200 стало OK, 201 стало CREATED.
//5. Опредилил конастанту для поиска значений в БД. Было db.LoadTable<SRC_PARAMS>(x => x.ID == 14) стало db.LoadTable<SRC_PARAMS>(x => x.ID == INFLATION)
//6. Служебные ссылки перенес в констатнты https://homePage/platform стало в LINK_TO_PLATOFORM
//7. Опредилил константу для максимальной длины текста в ячейке TextSource.Length > 300 стало TextSource.Length > MAX_LENGTH
//8. Определил константу для возращаемых индексов FIRST_INDEX, NO_INDEX
//9. Опредилил константы для портов HOME_PORT, REMOTE_WORK_PORT
//10. Опредлил константы для первой строки при генерации Excel progressBar.Position = 1; progressBar.Position = FIRST_ROW
//11. Определил константу для видимых индексов вместо 0 стало VISIBLE_INDEX
//12. Определил констатнту для id = -1 как NO_POSITION