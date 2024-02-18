//3.1
class Program
{
    public class Main
    {
        static void main(string[] args)
        {
            Industry oil = Industry.getOilIndustryInfo(new Oil("Нефтяная отрасль"));
            Industry gas = Industry.getGasIndustryInfo(new Gas("Газовая отрасль"));
            Industry electricity = Industry.getElectricityInfo(new Electricity("Электроэнергетика"));
        }
    }

    public class Industry
    {
        private string businessSector;

        private Industry(string businessSector)
        {
            businessSector = businessSector;
        }

        public static Industry getOilIndustryInfo(Oil oil)
        {
            return new Industry(oil.getOilTotalExport() + "экспортировала 1000000 барелей");
        }

        public static Industry getGasIndustryInfo(Gas gas)
        {
            return new Industry(gas.getGasCapitalExpences() + "1 трлн рублей");
        }

        public static Industry getElectricityInfo(Electricity electricity)
        {
            return new Industry(electricity.getElectricityProduction() + "1 ГВт за 1 день");
        }

        public string getBusinessSectorInfo()
        {
            return businessSector;
        }
    }

    public class Oil
    {
        private string totalExport;

        public Oil(string oilTotalExport)
        {
            totalExport = oilTotalExport;
        }

        public string getOilTotalExport()
        {
            return totalExport;
        }
    }

    public class Gas
    {
        private string capitalExpences;

        public Gas(string gasCapitalExpences)
        {
            capitalExpences = gasCapitalExpences;
        }

        public string getGasCapitalExpences()
        {
            return capitalExpences;
        }
    }

    public class Electricity
    {
        private string production;

        public Electricity(string electricityProduction)
        {
            production = electricityProduction;
        }

        public string getElectricityProduction()
        {
            return production;
        }
    }

}

//3.2
//Интерфейсы - ControlCenter, ProductFactory
//Абстрактный класс - InductryBase, UnitsMeasurementBase