using UnityEngine;
using UnityEngine.UI;

public class WinnerInfo : MonoBehaviour
{
    Text text;
    string _winner;
    public string Winner
    {
        get
        {
            return _winner;
        }
        set
        {
            if(value != null)
            {
                _winner = value;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        ShowWinner();
    }
    void ShowWinner()
    {
        text.text = Winner;
    }
}
