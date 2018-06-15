using UnityEngine;

public class HeartContainer
{
    public int CurrentContainerFill = 4;


    public void AddHealth(int addedHealth)
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

    public void SubtractHealth(int subtractedHealth)
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

}
