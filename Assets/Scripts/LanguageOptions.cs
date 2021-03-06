﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml; //Needed for XML functionality
using System.Xml.Serialization; //Needed for XML Functionality
using System.IO;
using System.Text;
using System.Xml.Linq;

public class LanguageOptions : MonoBehaviour {
    public string TitleTag;

// Use this for initialization
void Start()
    {

        try
        {
            UpdateLanguage();
        }
        catch (Exception e)
        {
            UpdateLanguageMesh();
        }

    }

    public void UpdateLanguage() {
        if (PlayerPrefs.HasKey("language"))
        {
            
        } else
        {
            if(Application.systemLanguage == SystemLanguage.Portuguese)
            {
                //0 English - 1 Portuguese
                PlayerPrefs.SetInt("language", 1);
                
            } else
            {
                PlayerPrefs.SetInt("language", 0);
                
            }
        }
	}

    public void UpdateLanguageMesh()
    {
        if (PlayerPrefs.HasKey("language"))
        {
            
        }
        else
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese)
            {
                //0 English - 1 Portuguese
                PlayerPrefs.SetInt("language", 1);
                
            }
            else
            {
                PlayerPrefs.SetInt("language", 0);
                
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
