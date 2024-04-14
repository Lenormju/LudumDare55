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
    public Sprite angrySprite;
    public Image happyImage;
    public interract interraction;
    public Goto scriptGoTo;

    public void OnButtonClick(){
        if (Globals.InkStory.currentChoices.Count > 0){
            Choice choice = Globals.InkStory.currentChoices[index];
            Globals.InkStory.ChooseChoiceIndex(index);
            Globals.InkStory.Continue();
            
            if(Globals.ResultDemon != null){
                scriptGoTo.startDevortexisation();
                return;
            }
            
            if(!Globals.CreateResult(choice.tags, happyImage, angrySprite)){
                DisplayText.onClick.Invoke();
            }
        }
    }

    public void GoBack(){
        interraction.ActivateInterract();
    }
}
