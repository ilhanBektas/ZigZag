using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    [SerializeField] GameObject _sonZemin;


    void Start()
    {
    for (int i = 0; i < 20; i++)
        {
            zeminSpawner();
        }
    }


    void Update()
    {
        

    }
     public void zeminSpawner()
    {
        Vector3 yön;
        if (Random.Range(0, 2) == 0)
        {
            yön = Vector3.forward;
        }
        else
        {
            yön = Vector3.left;
        }
        _sonZemin = Instantiate(_sonZemin, _sonZemin.transform.position + yön, _sonZemin.transform.rotation);
    }
}
