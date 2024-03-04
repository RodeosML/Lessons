//1 Связывание во время написания кода. Мы должны уведомлять пользователя о том, что задача уже была ранее закреплена на окне. И выводить соответствующую ошибку.
currentUser.PinnedMissions ??= new List<Mission>();
if (currentUser.PinnedMissions.Contains(mission))
{
    return ResultType.Failure("Задача уже прикреплена");
}


//2 Связывание во время компиляции кода.
//Данный тип связывания я использую ввиду того, что мы предварительно оглашаем список компаний по которым будем рассчитывать значения в калькуляторе

using System.Reflection;

private const long TGK_ID = 110;
private const long OGK_ID = 109;
private const long UN_ENERGY_CO_ID = 111;
private const long MOS_ENERGY_ID = 108;

//много кода

if (company.Id == MOS_ENERGY_ID)
{
    //много кода
}

//много кода

//3 Связывание во время выполнения программы. При создании тенанты (наименование организации) должны проверять вводимое наименование на оригинальность.
//Необходимо в рантайме определять оригинальность и выдывать соответствующее сообщение об этом пользователю.
//Нужно выводить именно то наименование, которое хранится в Бд
RuleFor(x => x.Title)
            .NotEmpty()
            .MustAsync(BeUniqueTitle)
                .WithMessage("'{PropertyName}' must be unique.")
                .WithErrorCode("Unique");
