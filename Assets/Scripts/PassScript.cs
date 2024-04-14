using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;
using TMPro;


public class PassScript : MonoBehaviour
{
    public List<Button> choices;
    public Sprite angrySprite;
    public Image happyImage;
    public void OnButtonClick()
    {
        if(Globals.InkStory.canContinue){
            this.GetComponent<Button>().GetComponentInChildren<TMP_Text>().text = Globals.InkStory.Continue();

            var isCreated = Globals.CreateResult(Globals.InkStory.currentTags, happyImage, angrySprite);
        }

        for(int i = 0; i < choices.Count ; i++){
            choices[i].GetComponentInChildren<TMP_Text>().text = "";
        }

        if (Globals.InkStory.currentChoices.Count > 0){            
            for(int i = 0; i < Globals.InkStory.currentChoices.Count ; i++){
                Choice choice = Globals.InkStory.currentChoices[i];
                choices[i].GetComponentInChildren<TMP_Text>().text = choice.text;
            }
        }
    }
}
