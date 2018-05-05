using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayerUnitTest 
{
    [Test]
    public void DefaultHealthOne()
    {
        // Arrange 
        Player player = new Player();
        float expectedResult = 1;

        // Act
        float result = player.GetHealth();

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void GetHealthCorrectAfterReducedByPointOne()
    {
        // Arrange 
        Player player = new Player();
        float expectedResult = 0.9f;

        // Act
        player.ReduceHealth(0.1f);
        float result = player.GetHealth();

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void GetHealthCorrectAfterReducedByHalf()
    {
        // Arrange 
        Player player = new Player();
        float expectedResult = 0.5f;

        // Act
        player.ReduceHealth(0.5f);
        float result = player.GetHealth();

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void CheckEventFiredWhenAddHealth()
    {
        // Arrange
        Player player = new Player();
        bool eventFired = false;

        // register anonymous 
        // adapted from:
        // http://www.philosophicalgeek.com/2007/12/27/easily-unit-testing-event-handlers/
        Player.OnHealthChange += delegate
        {
            eventFired = true;
        };

        // Act
        player.AddHealth(0.1f);

        // Assert
        Assert.IsTrue(eventFired);
    }

    [Test]
    public void CheckEventFiredWhenReduceHealth()
    {
        // Arrange
        Player player = new Player();
        bool eventFired = false;

        // register anonymous 
        // adapted from:
        // http://www.philosophicalgeek.com/2007/12/27/easily-unit-testing-event-handlers/
        Player.OnHealthChange += delegate
        {
            eventFired = true;
        };

        // Act
        player.ReduceHealth(0.1f);

        // Assert
        Assert.IsTrue(eventFired);
    }

    //[UnityTest]
    //public IEnumerator PlayerTestWithEnumeratorPasses() 
    //{
    //    yield return null;
    //}
}
