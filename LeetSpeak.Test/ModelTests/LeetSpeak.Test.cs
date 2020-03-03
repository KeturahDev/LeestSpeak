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
      Assert.AreEqual("sl33p", LeetSpeak.Translate("sleep"));
    }
    [TestMethod]
    public void Translate_ChangeTsTo7s_7im3()
    {
      Assert.AreEqual("7im3", LeetSpeak.Translate("time"));
    }
    [TestMethod]
    public void Translate_ChangeTsTo7s_m00n()
    {
      Assert.AreEqual("m00n", LeetSpeak.Translate("moon"));
    }
  }
}