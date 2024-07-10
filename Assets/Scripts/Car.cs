using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public bool MoveForward;
    public Transform Parent;
    public GameObject[] Ruts;
    public GameManager GameManager;

    void Start()
    {
        
    }

    void Update()
    {
        if (MoveForward)
        {
            transform.Translate(15f * Time.deltaTime * transform.forward);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stop"))
        {
            MoveForward = false;
            Ruts[0].SetActive(false);
            Ruts[1].SetActive(false);
            transform.SetParent(Parent);
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
