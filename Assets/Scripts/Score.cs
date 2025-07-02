using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text _scoreText;
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        _scoreText.text = score.ToString();
    }
}
