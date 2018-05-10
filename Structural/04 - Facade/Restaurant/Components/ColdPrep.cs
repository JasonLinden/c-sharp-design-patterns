namespace _04___Facade.Restaurant.Components
{
    internal class ColdPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            //Go prep the cold item
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}
