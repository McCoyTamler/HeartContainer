using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System;

[TestFixture]
public class HeartContainer_Test
{
    [TestCase(1, 1)]
    [TestCase(4, 4)]
    [TestCase(5, 4)]
    [TestCase(544, 4)]
    public void test_AddHealthToHeartContainer(int healthToAdd, int correctFillAmount)
    {
        HeartContainer heartContainer = new HeartContainer();

        heartContainer.AddHealth(healthToAdd);
        Assert.AreEqual(heartContainer.CurrentContainerFill, correctFillAmount);
    }

    [TestCase(1, 0)]
    [TestCase(4, 0)]
    public void test_subtractHealthToHeartContainer(int healthToSubtract, int correctFillAmount)
    {
        HeartContainer heartContainer = new HeartContainer();

        heartContainer.SubtractHealth(healthToSubtract);
        Assert.AreEqual(heartContainer.CurrentContainerFill, correctFillAmount);
    }

    [TestCase(1, 0)]
    [TestCase(4, 0)]
    public void test_setHealthToHeartContainer(int value, int correctFillAmount)
    {
        HeartContainer heartContainer = new HeartContainer();

        heartContainer.SetHealth(value);
        Assert.AreEqual(heartContainer.CurrentContainerFill, correctFillAmount);
    }

}

internal class HeartContainer
{
    public int CurrentContainerFill;


    internal void AddHealth(int addedHealth)
    {
        if (addedHealth + this.CurrentContainerFill > 4)
        {
            this.CurrentContainerFill = 4;
        }
        else
        {
            this.CurrentContainerFill += addedHealth;
        }

    }

    internal void SubtractHealth(int subtractedHealth)
    {
        if (this.CurrentContainerFill - subtractedHealth < 0)
        {
            this.CurrentContainerFill = 0;
        }
        else
        {
            this.CurrentContainerFill -= subtractedHealth;
        }

    }

    internal void SetHealth(int value)
    {
        throw new NotImplementedException();
    }
}
