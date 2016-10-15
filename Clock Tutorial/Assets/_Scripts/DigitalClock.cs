using UnityEngine;
using System;

public class DigitalClock : MonoBehaviour {

    public GameObject HourBig;
    public GameObject HourSmall;
    public GameObject MinutesBig;
    public GameObject MinutesSmall;
    public GameObject SecondsBig;
    public GameObject SecondsSmall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        DateTime time = DateTime.Now;

        HourBig.GetComponent<DisplayDigital>().setNumber((int)(time.Hour / 10));
        HourSmall.GetComponent<DisplayDigital>().setNumber(time.Hour % 10);

        MinutesBig.GetComponent<DisplayDigital>().setNumber((int)(time.Minute / 10));
        MinutesSmall.GetComponent<DisplayDigital>().setNumber(time.Minute % 10);

        SecondsBig.GetComponent<DisplayDigital>().setNumber((int)(time.Second / 10));
        SecondsSmall.GetComponent<DisplayDigital>().setNumber(time.Second % 10);
	}
}
