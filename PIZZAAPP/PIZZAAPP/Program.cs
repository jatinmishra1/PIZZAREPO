var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozarella());

Console.WriteLine(pizza.Describe());

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients=new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}


public class Ingredient
{

}

//cheddar is an ingredient
public class Cheddar : Ingredient
{

}

//TomatoSauce is an ingredient
public class TomatoSauce : Ingredient
{

}

//Mozarella is an ingredient
public class Mozarella : Ingredient
{

}