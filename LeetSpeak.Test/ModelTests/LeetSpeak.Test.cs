using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTests
  {
    [TestMethod]
    public void Translate_ChangeEsTo3s_sl33p()
    {
      Assert.AreEqual("sl33p", eChange('sleep'))
    }
  }
}