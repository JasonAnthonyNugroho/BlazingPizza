namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            // Temporary mock data for demonstration purposes
            var pizzas = new Pizza[]
            {
                new Pizza { Name = "Margherita", Description = "Classic cheese and tomato", Vegetarian = true, Vegan = false, Price = 9.99m },
                new Pizza { Name = "Pepperoni", Description = "Spicy pepperoni with mozzarella", Vegetarian = false, Vegan = false, Price = 12.99m },
                new Pizza { Name = "Veggie Delight", Description = "Mixed vegetables with a tangy sauce", Vegetarian = true, Vegan = true, Price = 11.49m }
            };

            // Return pizzas as a task
            return Task.FromResult(pizzas);
        }
    }
}
