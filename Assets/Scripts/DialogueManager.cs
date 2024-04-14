using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextAsset inkJson;
    public Button displayText;
    public interract interraction;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ok");
        Globals.InkStory = new Story(inkJson.text);
        Globals.InkStory.ChoosePathString("intro");
        displayText.onClick.Invoke();
        interraction.DeactivateInterract();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setVariable(string nom)
    {  
        Globals.InkStory.variablesState[nom] = true;
    }
}
