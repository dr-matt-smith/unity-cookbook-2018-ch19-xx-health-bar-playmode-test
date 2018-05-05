using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

[TestFixture]
public class PlayerPlayModeTest 
{

    [UnityTest]
    public IEnumerator PlayerTestWithEnumeratorPasses() 
    {
        // Arrange
        Image healthBarFiller = GameObject.Find("image-health-bar-filler").GetComponent<Image>();
        Resources.Load<GameObject> ("healthbar");
//        PlayerManager playerManager = GameObject.FindWithTag("MainCamera").GetComponent<PlayerManager>();
        float expectedResult = 0.9f;

        // Act
  //      playerManager.ReduceHealth(0.1f);

        yield return null;

        // Assert
        Assert.AreEqual(expectedResult, healthBarFiller.fillAmount);
        LogAssert.Expect(LogType.Log, "health = 0.9");
    }


}
