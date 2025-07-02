using UnityEngine;

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
    }
}
