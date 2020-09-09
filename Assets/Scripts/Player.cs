using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public InfoText _infoText;
    public Text[] _buttonText;
    public GameManager _gameManager;

    string X = "X";
    string O = "O";

    // Check winner conbination
    void CheckWinner()
    {
        if ((_buttonText[0].text == X && _buttonText[1].text == X && _buttonText[2].text == X)
            || (_buttonText[0].text == O && _buttonText[1].text == O && _buttonText[2].text == O))
        {
            _gameManager.GameWin();
        }

        if ((_buttonText[3].text == X && _buttonText[4].text == X && _buttonText[5].text == X)
            || (_buttonText[3].text == O && _buttonText[4].text == O && _buttonText[5].text == O))
        {
            _gameManager.GameWin();
        }

        if ((_buttonText[6].text == X && _buttonText[7].text == X && _buttonText[8].text == X)
            || (_buttonText[6].text == O && _buttonText[7].text == O && _buttonText[8].text == O))
        {
            _gameManager.GameWin();
        }

        if ((_buttonText[0].text == X && _buttonText[3].text == X && _buttonText[6].text == X)
            || (_buttonText[0].text == O && _buttonText[3].text == O && _buttonText[6].text == O))
        {
            _gameManager.GameWin();
        }

        if ((_buttonText[1].text == X && _buttonText[4].text == X && _buttonText[7].text == X)
            || (_buttonText[1].text == O && _buttonText[4].text == O && _buttonText[7].text == O))
        {
            _gameManager.GameWin();
        }

        if ((_buttonText[2].text == X && _buttonText[5].text == X && _buttonText[8].text == X)
            || (_buttonText[2].text == O && _buttonText[5].text == O && _buttonText[8].text == O))
        {
            _gameManager.GameWin();
        }

        if ((_buttonText[0].text == X && _buttonText[4].text == X && _buttonText[8].text == X)
            || (_buttonText[0].text == O && _buttonText[4].text == O && _buttonText[8].text == O))
        {
            _gameManager.GameWin();
        }

        if ((_buttonText[2].text == X && _buttonText[4].text == X && _buttonText[6].text == X)
            || (_buttonText[2].text == O && _buttonText[4].text == O && _buttonText[6].text == O))
        {
            _gameManager.GameWin();
        }
    }
    // Set Button X or O
    public void SetButton(Button button)
    {
        button.GetComponentInChildren<Text>().text = _infoText.GetInfo();
        if (_infoText._id == 1)
        {
            _infoText._id = 0;
        }
        else
        {
            _infoText._id = 1;
        }
        _infoText.SetInfo(_infoText._id);
        button.interactable = false;
        CheckWinner();
    }
}
