namespace Tumakov13
{
    class Building
    {
        private static int numOfBuildings = 0;
        private int buildingNum;
        private int buildingHeight;
        private int numOfFloors;
        private int numOfAparts;
        private int numOfEntrances;

        public int BuildingNum
        {
            get
            {
                return buildingNum;
            }
        }

        public int BuildingHeight
        {
            get
            {
                return buildingHeight;
            }
        }

        public int NumOfFloors
        {
            get
            {
                return numOfFloors;
            }
        }

        public int NumOfAparts
        {
            get
            {
                return numOfAparts;

            }
        }

        public int NumOfEntrances
        {
            get
            {
                return numOfEntrances;
            }
        }

        public double CalculationFloorHeight()
        {
            return (double)buildingHeight / numOfFloors;
        }

        public int CalculationNumberOfApartmentsInEntrance()
        {
            return NumOfAparts / NumOfEntrances;
        }

        public int CalculationNumberOfApartmentsOnFloor()
        {
            return (NumOfAparts / NumOfEntrances) / numOfFloors;
        }

        private void ChangeNumOfBuilding()
        {
            numOfBuildings++;
        }
        public Building(int buildingHeight, int numOfFloors, int numOfAparts, int numOfEntrances)
        {
            this.buildingHeight = buildingHeight;
            this.numOfFloors = numOfFloors;
            this.numOfAparts = numOfAparts;
            this.numOfEntrances = numOfEntrances;
            buildingNum = numOfBuildings;
            ChangeNumOfBuilding();
        }
    }
}
