//1. Добавил проверку на отсутствие деления на 0 при вычислении расчетных коэффициентов по организации.
//2. Привел все входные пользовательские значения к одному типу, исправил отображение для вещественных значения.
//3. Преобразовал в константу строку tempOptProtocolFile в запросах вида: var file = Global.Get<OptProtocolFile>(HttpContext.Session, TEMORARY_PROTOCOL_FILE + hiddenId + Global.GetUser(HttpContext).Id);
//4. Использовал boolean переменную для отображения изменения данных в таблице на фронте isCostValueUpdated
//5. Для улучшения читаемость в цикле использовал boolean для отображения ввода и событий isEventCheckingTab и isBeginReadingCell внутри таба if (isEventCheckingTab && isBeginReadingCell)
//6. Вынес в константу DEFAULT_TIME_FORMAT_STRING = 'HH:mm:ss';
//7. Вынес в константу вычисляемые значения в времени minutes = Math.floor((duration % (1000 * 60 * 60)) / (1000 * 60));
//8. Вынес в константу пустую строку EMPTY_STRING в updatedSelectedMissionz.length === EMPTY_STRING
//9. Вынес в системную константу 401 - UNAUTHRAZIED error.status === 401 стало error.status === UNAUTHRAZIED
//10. Вынес в константу отображаемое время  displayTime = '00:00:00'
//11. Улучшил читаемость кода, что если пауза, то ничего не отображать this.pausedTime = 0, стало this.pausedTime = NOTHING_VIEW
//12. Вынес в константу для обработчика события NO_INDEX, HAS_INDEX
