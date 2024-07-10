using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Car;

    [Header("----Platform Settings")]
    public GameObject Platform1;
    public GameObject Platform2;
    public float[] RotationSpeeds;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Car.GetComponent<Car>().MoveForward = true;
        }

        Platform1.transform.Rotate(new Vector3(0, 0, RotationSpeeds[0]), Space.Self);
    }
}
