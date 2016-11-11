using UnityEngine;
using System.Collections;

public class EarthCtrl : MonoBehaviour {

    private GameObject earth;
    private GameObject sun;


	void Start () {

        earth = GameObject.Find("Earth");
        sun = GameObject.Find("Sun");

	}
	

	void Update () {

        earth.transform.RotateAround(sun.transform.position, Vector3.up, 1.0f);

	}
}
