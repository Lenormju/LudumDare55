using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;


public class PassScript : MonoBehaviour
{
    public List<TMP_Text> choices;
    public void OnButtonClick()
    {
        Debug.Log("Globals.InkStory.canContinue: "+Globals.InkStory.canContinue);
        Debug.Log("Globals.InkStory.currentChoices.Count: "+Globals.InkStory.currentChoices.Count);
        if(Globals.InkStory.canContinue){
            this.GetComponent<TMP_Text>().text = Globals.InkStory.Continue();
            if(Globals.InkStory.currentTags != null && Globals.InkStory.currentTags.Count > 0){
                var split = Globals.InkStory.currentTags[0].Split(':');
                Globals.ResultDemon = new Globals.Result(split[1],int.Parse(split[2]),split[3]);
                Debug.Log(Globals.ResultDemon);
            }
        }

        for(int i = 0; i < choices.Count ; i++){
            choices[i].text = "";
        }

        if (Globals.InkStory.currentChoices.Count > 0){            
            for(int i = 0; i < Globals.InkStory.currentChoices.Count ; i++){
                Choice choice = Globals.InkStory.currentChoices[i];
                choices[i].text = choice.text;
            }
        }
    }
}
