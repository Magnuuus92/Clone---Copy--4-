using IStore;
using Microsoft.VisualBasic;
using Storage;
namespace Tests;

public class UnitTest1
{
    [Fact]
    public void AddIntIncreasesCount()
    {
        //ARRANGE
        var c = new Storage<int>();
        // ACT
        c.Add(42);

        //ASSERT
        Assert.Equal(1, c.Count);


    }
    [Fact]
    public void AddAndRmv()
    {
        //ARRANGE
        var c = new Storage<string>();
        //ACT
        c.Add("HELLO");
        c.Add("WORLD");
        c.Remove("WORLD");
        var removedWorld = c.GetAll().ToList();
        //ASSERT

        Assert.Equal(1, c.Count);
        Assert.DoesNotContain("World", removedWorld);
    }
}
public class RepositoryTests
{
    [Fact]
    public void AddThenGetAllReturned()
    {
        //arrange
        var repo = new Storage<string>();
        //act
        repo.Add("HELLO");
        repo.Add("WORLD");
        repo.Add("1");

        var all = repo.GetAll().ToList();
        //assert
        Assert.Contains("HELLO", all);
        Assert.Contains("WORLD", all);
        Assert.Contains("1", all);
        Assert.Equal(3, all.Count);
    }
    [Fact]
    public void Clear_Does_Clear()
    {
        //arrange
        var clearCheck = new Storage<string>();
        //act
        clearCheck.Add("RUBBISH");
        clearCheck.Add("Rubbishness");
        clearCheck.Clear();
        var clearCheckList = clearCheck.GetAll().ToList();

        //ASSERT
        Assert.DoesNotContain("RUBBISH", clearCheckList);
        Assert.Empty(clearCheckList);
    }
    [Fact]
    public void TestForImmutability()
    {
        //HER SLITER JEG, ER RETT MAPPE LINKET, OSV, hvordan
    }
}