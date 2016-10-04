using UnityEngine;
using System;

public class AnimateClock : MonoBehaviour {

    public Transform hours, minutes, seconds;

    private const float hoursToDegree = 360 / 12;
    private const float minutesToDegree = 360 / 60;
    private const float secondsToDegree = 360 / 60;

	void Update () {
        DateTime time = DateTime.Now;

        hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegree);
        minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegree);
        seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegree);
	}
}
