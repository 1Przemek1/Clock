using UnityEngine;
using System.Collections;

public class DisplayDigital : MonoBehaviour {

    private const int OBJECT_PARTS = 7;
    public GameObject[] obj = new GameObject[OBJECT_PARTS];
    private int number;
    private bool[] visibleParts;// = new bool[OBJECT_PARTS];

    public void setNumber(int num)
    {
        number = num;
    }

    private void prepareVisibleParts() 
    {
        switch (number)                             //top, r-top, l-top, central, r-bottom, l-bottom, bottom
        {
            case 0:
                visibleParts = new bool[OBJECT_PARTS] { true, true, true, false, true, true, true };
                break;
            case 1:
                visibleParts = new bool[OBJECT_PARTS] { false, true, false, false, true, false, false };
                break;
            case 2:
                visibleParts = new bool[OBJECT_PARTS] { true, true, false, true, false, true, true };
                break;
            case 3:
                visibleParts = new bool[OBJECT_PARTS] { true, true, false, true, true, false, true };
                break;
            case 4:
                visibleParts = new bool[OBJECT_PARTS] { false, true, true, true, true, false, false };
                break;
            case 5:
                visibleParts = new bool[OBJECT_PARTS] { true, false, true, true, true, false, true };
                break;
            case 6:
                visibleParts = new bool[OBJECT_PARTS] { true, false, true, true, true, true, true };
                break;
            case 7:
                visibleParts = new bool[OBJECT_PARTS] { true, true, false, false, true, false, false };
                break;
            case 8:
                visibleParts = new bool[OBJECT_PARTS] { true, true, true, true, true, true, true };
                break;
            case 9:
                visibleParts = new bool[OBJECT_PARTS] { true, true, true, true, true, false, true };
                break;
        }
    }

    private void displayParts()
    {
        for (int i = 0; i < OBJECT_PARTS; ++i)
        {
            obj[i].SetActive(visibleParts[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        prepareVisibleParts();
        displayParts();
	}
}


