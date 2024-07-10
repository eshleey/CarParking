using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("----Car Settings")]
    public GameObject[] Cars;
    public int HowManyCars;
    int ActiveCarIndex = 0;

    [Header("----Platform Settings")]
    public GameObject Platform1;
    public GameObject Platform2;
    public float[] RotationSpeeds;

    void Start()
    {
        /*for (int i = 0; i < HowManyCars; i++)
        {
            
        }*/
    }

    public void BringNewCar()
    {
        if (ActiveCarIndex < HowManyCars)
        {
            Cars[ActiveCarIndex].SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Cars[ActiveCarIndex].GetComponent<Car>().MoveForward = true;
            ActiveCarIndex++;
        }

        Platform1.transform.Rotate(new Vector3(0, 0, RotationSpeeds[0]), Space.Self);
    }
}
