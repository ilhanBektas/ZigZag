using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform _transformPlayer;
    Vector3 _fark;
    void Start()
    {
        _fark = transform.position - _transformPlayer.position;
    }

    void Update()
    {
        if (!PlayerMovement._isFall)
        {
            transform.position = _transformPlayer.position + _fark;
        }
        else
        {
            PlayerMovement._isFall = false;
            SceneManager.LoadScene(2);
            
        }
    }
}
