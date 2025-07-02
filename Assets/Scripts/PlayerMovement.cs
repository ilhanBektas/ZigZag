using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 yön;
    [Header("Player Settings")]
    [SerializeField] float speed;

    void Start()
    {
        yön = Vector3.forward;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if (yön.x == 0)
            {
                yön = Vector3.left;
            }
            else
            {
                yön = Vector3.forward;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * speed;
        transform.position += hareket;
    }
}
