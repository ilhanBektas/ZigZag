using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    GameObject mainMenu;
    Button QuitButon;
    Button PlayButon;

    void Awake()
    {
        
    mainMenu = GameObject.Find("MainMenu");
    QuitButon = GameObject.Find("QuitButon").GetComponent<Button>();
    PlayButon = GameObject.Find("PlayButon").GetComponent<Button>();
        
    }
    void Start()
    {
        mainMenu.SetActive(true);
        QuitButon.onClick.AddListener(QuitGame);
        PlayButon.onClick.AddListener(PlayGame);
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
