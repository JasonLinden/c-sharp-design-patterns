namespace _04___Facade.Restaurant.Components
{
    class HotPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            //Go prep the hot item
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}
