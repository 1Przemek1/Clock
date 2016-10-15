using UnityEngine;
using System.Collections;

public class ButtonsScript : MonoBehaviour {

    public GameObject analogClock;
    public GameObject analogNumbers;
    public GameObject digitalClock;

	public void selectAnalogClock()
    {
        digitalClock.SetActive(false);
        analogClock.SetActive(true);
        analogNumbers.SetActive(true);
    }

    public void selectDigitalClock()
    {
        digitalClock.SetActive(true);
        analogClock.SetActive(false);
        analogNumbers.SetActive(false);
    }

}
