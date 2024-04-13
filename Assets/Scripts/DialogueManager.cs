using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextAsset inkJson;

    // Start is called before the first frame update
    void Start()
    {
        Globals.InkStory = new Story(inkJson.text);
        Globals.InkStory.ChoosePathString("choices");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
