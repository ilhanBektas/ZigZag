using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 yön;

    public ZeminSpawner zeminSpawnerscripti;
    public static bool _isFall;
    
    [Header("Player Settings")]
    [SerializeField] float speed;
    [SerializeField] float eklenecekSpeed;

    void Start()
    {
        yön = Vector3.forward;
    }

    void Update()
    {
        if (transform.position.y <= 0.5f)
        {
            _isFall = true;
            
        }
         if (_isFall)
            {
            return;
            }
       
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
                speed += eklenecekSpeed * Time.deltaTime;
            }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * speed;
        transform.position += hareket;
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            collision.gameObject.AddComponent<Rigidbody>();
            zeminSpawnerscripti.zeminSpawner();
            StartCoroutine(ZeminiSil(collision.gameObject));
            Score.score = Score.score + 1;
        }
    }

    IEnumerator ZeminiSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    }
}
