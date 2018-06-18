using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using NUnit.Framework;
using System;

//[TestFixture]
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
            HeartContainer heartContainer = new HeartContainer(image);

            heartContainer.AddHealth(healthToAdd);
            Assert.AreEqual(correctFillAmount, heartContainer.CurrentContainerFill);
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
            HeartContainer heartContainer = new HeartContainer(image);

            heartContainer.SubtractHealth(healthToSubtract);
            Assert.AreEqual(correctFillAmount, heartContainer.CurrentContainerFill);
        }
    }
}
