using UnityEngine;
using UnityEngine.UI;

public class HeartContainer
{
    private Image _image;
    private int _currentContainerFill = 4;

    private static int _heartPiecesPerContainer = 4;
    private float _fillAmountPerHealth = 1.0f /_heartPiecesPerContainer;

    public int CurrentContainerFill
    {
        set 
        {
            if (value * _fillAmountPerHealth > 1)
            {
                _image.fillAmount = 1.0f;
                _currentContainerFill = 4;
            }
            else if (value * _fillAmountPerHealth < 0)
            {
                _image.fillAmount = 0f;
                _currentContainerFill = 0;
            }
            else
            {
                _image.fillAmount = (float)(value * _fillAmountPerHealth);
                _currentContainerFill = value;
            }
        }
        get 
        {
            return _currentContainerFill;
        }
    }

    public HeartContainer(Image image)
    {
        _image = image;
    } 

    public void AddHealth(int addedHealth)
    {
        this.CurrentContainerFill += addedHealth;
    }

    public void SubtractHealth(int subtractedHealth)
    {
        this.CurrentContainerFill -= subtractedHealth;
    }

}
