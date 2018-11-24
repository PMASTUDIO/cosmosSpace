using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

    public Transform sunPosition;
    public Vector3 axis;
    public float angle;
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(sunPosition.position, axis, angle);
	}
}
