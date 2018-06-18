using UnityEngine.UI;

public class Heart
{
    # region Class Attributes
    private Image _image;
    private int _currentHeartPieces = 4;

    private static int _maxHeartPiecesPerContainer = 4;
    private float _fillAmountPerHeartPiece = 1.0f /_maxHeartPiecesPerContainer;

    public int CurrentContainerFill
    {
        set
        {
            _image.fillAmount = (float)(value * _fillAmountPerHeartPiece);
            _currentHeartPieces = value;

        }
        get
        {
            return _currentHeartPieces;
        }
    }
    # endregion

    public Heart(Image image)
    {
        _image = image;
    } 

    public void AddHealth(int addedHealth)
    {
        if (addedHealth + CurrentContainerFill > _maxHeartPiecesPerContainer)
        {
            CurrentContainerFill = _maxHeartPiecesPerContainer;
        }
        else
        {
            this.CurrentContainerFill += addedHealth;
        }
    }
    public void SubtractHealth(int subtractedHealth)
    {
        if (CurrentContainerFill - subtractedHealth < 0)
        {
            CurrentContainerFill = 0;
        }
        else
        {
            this.CurrentContainerFill -= subtractedHealth;
        }
    }
}
