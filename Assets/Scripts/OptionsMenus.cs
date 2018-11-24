using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetLanguage(int id)
    {
        PlayerPrefs.SetInt("language", id);
        GameObject[] tags = GameObject.FindGameObjectsWithTag("TextTraduce");
        foreach(GameObject tag in tags)
        {
            tag.GetComponent<LanguageOptions>().UpdateLanguage();
        }
    }
}
