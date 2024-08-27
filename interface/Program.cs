// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

食べ物 a = new タラ();
食べ物 b = new マグロ();

食べる(a);
食べる(b);

static void 食べる(食べ物 food)
{
    Console.WriteLine(food.getName() + "を食べる");
}

public interface 食べ物 {
  string getName();
}
public class タラ : 食べ物 {
  public string getName() {
    return "タラ";
  }
}
public class マグロ : 食べ物 {
  public string getName() {
    return "マグロ";
  }
}
