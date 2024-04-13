using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;
using TMPro;

public class ChoiceScript : MonoBehaviour
{
    public int index;
    public Button DisplayText;

    public void OnButtonClick(){
        Debug.Log($"Click on choice {index} !");
        Debug.Log("Globals.InkStory.currentChoices.Count: "+Globals.InkStory.currentChoices.Count);
        if (Globals.InkStory.currentChoices.Count > 0){
            Choice choice = Globals.InkStory.currentChoices[index];
            Globals.InkStory.ChooseChoiceIndex(index);
            Globals.InkStory.Continue();
            if(choice.tags != null && choice.tags.Count > 0){
                var split = choice.tags[0].Split(':');
                Globals.ResultDemon = new Globals.Result(split[1],int.Parse(split[2]),split[3]);
                Debug.Log(Globals.ResultDemon);
            }else{
                DisplayText.onClick.Invoke();
            }
        }
    }
}
