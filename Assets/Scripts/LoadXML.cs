using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Linq;
using UnityEngine.SceneManagement;

public class LoadXML : MonoBehaviour {

    void XmlLanguagesLoader()
    {
        XElement xmlHolder = XElement.Load("Assets/Resources/cosmos-language.xml");

        IEnumerable<XElement> languages = xmlHolder.Elements();

        XElement texts = null;

        foreach (var lang in languages)
        {
            if (PlayerPrefs.GetInt("language") == 1 && lang.Name == "pt-BR")
            {
                texts = lang;
            } else if(PlayerPrefs.GetInt("language") == 0 && lang.Name == "en-US")
            {
                texts = lang;
            }
        }

        foreach(var text in texts.Elements())
        {
            if(text.FirstAttribute.Value == "uranos")
            {
                Debug.Log(text.Value);
            }
        }

    }

    // Use this for initialization
    void Start () {
        XmlLanguagesLoader();
    }
	
	// Update is called once per frame
	void Update () {

    }


}
