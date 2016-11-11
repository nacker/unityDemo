﻿using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 100);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 100);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 100);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 100);
        }

    }
}
