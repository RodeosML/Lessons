//3.1
CreateEnergyCalcModel - EnergyCompanyModel
WorkspaceController - Workplace
GetWsUnitById - GetWorkplaceId
IndicatorItem - Indicator
IndicatorDataPoint - IndicatorValue

//3.2
add - new //ранее добавление сущности было с использованием add, иногда create - идем к унификации new

open - show //окна, которые открываются с только с модальным окно будут show, а новые open

stateStore - saveSettings //сохранение любых пользовательских параметров ранее использовалось как stateStore, однако из-за этого каждый раз приходилось дописывать каких настроек, поэтому идем к унификации

search / find - seek //любой поиск данных

open - navigateTo //открытие папок, доступа к данным было с помощью open, однако этот же термин использовался и на клиенте. В связи с этим имеет смысл перейти к navigateTo для клиентской части

utils - specialSettings //utils использовался, как для использования расширенных функций библиотек, так и в для параметров настроек, что противоречит унификации

log - history //log использовался для отображения всего цикла работы системы, а также для отображения истории посещений 