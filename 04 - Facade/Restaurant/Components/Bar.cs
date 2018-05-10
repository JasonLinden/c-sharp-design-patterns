namespace _04___Facade.Restaurant.Components
{
    class Bar : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            //Go prep drink
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}
