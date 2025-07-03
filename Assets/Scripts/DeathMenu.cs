using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    
    GameObject deathMenu;
    Button tryAgain;
    Button quit;
    void Awake()
    {
        deathMenu = GameObject.Find("DeathMenu");
        tryAgain = GameObject.Find("TryAgainButon").GetComponent<Button>();
        quit = GameObject.Find("QuitButon").GetComponent<Button>();
    }
    void Start()
    {
        deathMenu.SetActive(true);
        quit.onClick.AddListener(QuitGame);
        tryAgain.onClick.AddListener(PlayGame);
    }
    void QuitGame()
    {
        Application.Quit();
    }
    void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
