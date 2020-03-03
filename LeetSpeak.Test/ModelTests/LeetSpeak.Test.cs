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
    public void Translate_ChangeOsTo0s_m00n()
    {
      Assert.AreEqual("m00n", LeetSpeak.Translate("moon"));
    }
    [TestMethod]
    public void Translate_ChangeCapIsTo1s_1ns0mnia()
    {
      Assert.AreEqual("1ns0mnia", LeetSpeak.Translate("Insomnia"));
    }
    [TestMethod]
    public void Translate_ChangeCapSsToZs_1nz0mnia()
    {
      Assert.AreEqual("1nz0mnia", LeetSpeak.Translate("Insomnia"));
    }
  }
}