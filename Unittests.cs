global using Xunit;


using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CaesarCipherTests
{
    [TestMethod]
    public void CaesarKodar_ShiftBy3_UpperCase()
    {
        // Arrange
        string input = "HELLO";
        string expectedOutput = "KHOOR";

        // Act
        string actualOutput = CaesarKodar(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void CaesarKodar_ShiftBy3_LowerCase()
    {
        // Arrange
        string input = "world";
        string expectedOutput = "zruog";

        // Act
        string actualOutput = CaesarKodar(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void CaesarKodar_NoShift_SpecialCharacters()
    {
        // Arrange
        string input = "!@#$%";
        string expectedOutput = "!@#$%";

        // Act
        string actualOutput = CaesarKodar(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}
