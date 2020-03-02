using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTests
  {
    [TestMethod]
    public void speak_ReturnsInput_Same()
    {
      Assert.AreEqual("input", LeetSpeak.speak("input"));
    }
  }
}