namespace Tumakov13
{
    class DifferentBuildings
    {
        private Building[] buildingsArray = new Building[10];

        public Building[] BuildingsArray
        {
            get
            {
                return buildingsArray;
            }
        }

        public Building this[int index]
        {
            get
            {
                return buildingsArray[index];
            }
        }

        public void AddingBuildingToArray(Building building)
        {
            buildingsArray[building.BuildingNum] = building;
        }
    }
}
