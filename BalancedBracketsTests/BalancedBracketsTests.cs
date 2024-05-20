namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.

    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(true, true, "you did good");
    }
    [TestMethod]
    public void OnlyBracketsReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    }
    [TestMethod]
    public void WordsInsideBalancedBracketsReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
    }
    [TestMethod]
    public void EmptyBracketsBeforeWordReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
    }
    [TestMethod]
    public void OneWordInsideAndOneOutsideReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code"));
    }
    [TestMethod]
    public void OpenBracketFirstReturnsFalse() {
        string testStr = "][";
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(testStr));
    }
    [TestMethod]
    public void OnlyOpenBracketReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
    }
    [TestMethod]
    public void OpenBracketFirstInsideWordReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
    }
    [TestMethod]
    public void OneClosedReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
    }
    [TestMethod]
    public void BalancedBracketsInsideCurlyReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("{[]}"));
    }
    [TestMethod]
    public void EmptyBracketsPlusBackwardsBracketsReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]["));
    }
    [TestMethod]
    
    public void OpenClosedClosedClosedOpenOpenReturnsFalse() {

        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]][["));
    }
}
