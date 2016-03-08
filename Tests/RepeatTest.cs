using Xunit;
namespace  RepeatCount
{
  public class RepeatTest
  {

    [Fact]
    public void CountRepeats_ForI_1()
    {
      RepeatCounter test = new RepeatCounter("I", "i");
      Assert.Equal(1, test.CountRepeats());
    }

    [Fact]
    public void CountRepeats_ForIandIlovepie_1()
    {
      RepeatCounter test = new RepeatCounter("I", "i love pie");
      Assert.Equal(1, test.CountRepeats());
    }

    [Fact]
    public void CountRepeats_ForIlikepieireallydo_2()
    {
      RepeatCounter test = new RepeatCounter("i", "i love pie, i really do ");
      Assert.Equal(2, test.CountRepeats());
    }

    [Fact]
    public void CountRepeats_Forilikepielikealot_2()
    {
      RepeatCounter test = new RepeatCounter("like", "i like pie, LIKE a lot ");
      Assert.Equal(2, test.CountRepeats());
    }

    [Fact]
    public void CountRepeats_Forpiewithcomma_2()
    {
      RepeatCounter test = new RepeatCounter("pie", "i like pie, LIKE a lot. PIE is great. Pie: the  greatest thing ever.");
      Assert.Equal(3, test.CountRepeats());
    }

    public void CountRepeats_ForWordInsideWord_2()
    {
      RepeatCounter test = new RepeatCounter("cry", "I love to cry, but I hate crybabies.");
      Assert.Equal(1, test.CountRepeats());
    }


  }
}
