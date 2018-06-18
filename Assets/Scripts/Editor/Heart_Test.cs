using UnityEngine;
using UnityEngine.UI;
using NUnit.Framework;

public class HeartContainer_Test
{
    public class Test_AddHealth
    {
        [TestCase(1, 4)]
        [TestCase(4, 4)]
        [TestCase(544, 4)]
        public void test_AddHealthToHeartContainer(int healthToAdd, int correctFillAmount)
        {
            Image image = new GameObject().AddComponent<Image>();
            Heart heart = new Heart(image);

            heart.AddHealth(healthToAdd);
            Assert.AreEqual(correctFillAmount, heart.CurrentContainerFill);
        }
    }
    public class Test_SubtractHealth
    {
        [TestCase(1, 3)]
        [TestCase(4, 0)]
        [TestCase(55, 0)]
        public void test_subtractHealthToHeartContainer(int healthToSubtract, int correctFillAmount)
        {
            Image image = new GameObject().AddComponent<Image>();
            Heart heartContainer = new Heart(image);

            heartContainer.SubtractHealth(healthToSubtract);
            Assert.AreEqual(correctFillAmount, heartContainer.CurrentContainerFill);
        }
    }
}
