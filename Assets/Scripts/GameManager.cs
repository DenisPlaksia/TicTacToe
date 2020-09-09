using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public WinnerInfo _winnerInfo;
    public Player _player;
    public GameObject _winPanel;

    private void Start()
    {
        _winPanel.SetActive(false);
    }

    public void GameWin()
    {
        _winnerInfo.Winner = "You win!!!";
        Destroy(_player);
        _winPanel.SetActive(true);
    }
    

    public void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
