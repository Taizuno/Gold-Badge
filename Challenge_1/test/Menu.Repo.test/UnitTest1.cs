namespace Menu.Repo.test;

public class MenuRepo_Tests
{
    private readonly Menu_Repo _mrepo;
    private Menu _menu;
public MenuRepo_Tests()
{
    _mrepo = new Menu_Repo();
    _menu = new Menu("Burger", "sandwich", "meat. cheese, bread", 10.0);
    _mrepo.AddItemToMenu(_menu);
}
    [Fact]
    public void AddItemToMenu_True()
    {
        var menu = new Menu("Salad", "salad", "Lettuce", 8.0);
        var expectingTrue = _mrepo.AddItemToMenu(menu);
        Assert.True(expectingTrue);
    }

    public void ViewMenu_True()
    {
        var menu = new Menu("Hotdog", "Wienner","meat",9.0);
        var menu1 = new Menu("Hotdog", "Wienner","meat",9.0);
        var menu2 = new Menu("Hotdog", "Wienner","meat",9.0);

        _mrepo.AddItemToMenu(menu);
        _mrepo.AddItemToMenu(menu1);
        _mrepo.AddItemToMenu(menu2);
        int expected = 4;
        int actual = _mrepo.ViewMenu().Count;

        Assert.Equal(expected, actual);
    }
    public void RemoveItemFromMenu_True()
    {
        var expected = _mrepo.RemoveItemFromMenu(_menu);
        Assert.True(expected);
    }
}