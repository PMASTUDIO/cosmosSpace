using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescObjects : MonoBehaviour {

	public GameObject cameraAR;
	public GameObject[] description;

	// Update is called once per frame
	public void ButtonPress () {

        for (int i = 0; i < description.Length; i++)
        {
            description[i].SetActive(true);
        }

        cameraAR.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
	}

    public void ButtonOut ()
    {
        for(int i = 0; i < description.Length; i++)
        {
            description[i].SetActive(false);
        }
        
        cameraAR.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
    }
    
}