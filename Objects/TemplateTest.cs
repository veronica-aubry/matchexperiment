using Xunit;
namespace  RepeatCount
{
  public class RepeatTest
  {
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

  }
}
