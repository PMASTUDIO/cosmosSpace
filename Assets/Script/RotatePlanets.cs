using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanets : MonoBehaviour {
    public float VelocityRotation = 1;
    public float starMass = 1000f;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void FixedUpdate () {
        this.GetComponent<Rigidbody>().transform.Rotate(new Vector3(0, VelocityRotation, 0));
    }
}