using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySource : MonoBehaviour {

    public float gravity;

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            Vector3 difference = this.gameObject.transform.position - other.gameObject.transform.position;

            float dist = difference.magnitude;
            Vector3 gravityDirection = difference.normalized;
            Vector3 gravityVector = (gravityDirection * gravity) / (dist * dist);

            other.GetComponent<Rigidbody>().AddForce(gravityVector, ForceMode.Acceleration);

        }
    }
}

