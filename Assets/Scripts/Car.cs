using UnityEngine;

public class Car : MonoBehaviour
{
    public bool MoveForward;
    bool StopPointState = false;

    public Transform Parent;
    public GameObject[] Ruts;
    public GameManager GameManager;

    void Start()
    {
        
    }

    void Update()
    {
        if (!StopPointState)
        {
            transform.Translate(8f * Time.deltaTime * transform.forward);
        }
        if (MoveForward)
        {
            transform.Translate(15f * Time.deltaTime * transform.forward);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("StopPoint"))
        {
            StopPointState = true;
            GameManager.StopPoint.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Stop"))
        {
            MoveForward = false;
            Ruts[0].SetActive(false);
            Ruts[1].SetActive(false);
            transform.SetParent(Parent);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            GameManager.BringNewCar();
        }
        else if (collision.gameObject.CompareTag("Middle"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Car"))
        {
            Destroy(gameObject);
        }
    }
}
