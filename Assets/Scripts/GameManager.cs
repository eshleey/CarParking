using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("----Car Settings")]
    public GameObject[] Cars;
    public GameObject[] CarCanvasSprites;
    public Sprite GreenCarSprite;
    public GameObject StopPoint;
    public int HowManyCars;
    int RemainingCarNumber;
    int ActiveCarIndex = 0;
    public TextMeshProUGUI RemainingCar;

    [Header("----Platform Settings")]
    public GameObject Platform1;
    public GameObject Platform2;
    public float[] RotationSpeeds;

    void Start()
    {
        /* RemainingCarNumber = HowManyCars;
        RemainingCar.text = RemainingCarNumber.ToString();

        for (int i = 0; i < HowManyCars; i++)
        {
            CarCanvasSprites[i].SetActive(true);
        } */
    }

    public void BringNewCar()
    {
        StopPoint.SetActive(true);

        if (ActiveCarIndex < HowManyCars)
        {
            Cars[ActiveCarIndex].SetActive(true);
        }

        /* CarCanvasSprites[ActiveCarIndex - 1].GetComponent<Image>().sprite = GreenCarSprite;

        RemainingCarNumber--;
        RemainingCar.text = RemainingCarNumber.ToString(); */
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
