using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    Sprite enter_img, exit_img;
    
    void Start()
    {
       exit_img = Resources.Load<Sprite>("CloseBtn/close"); 
       enter_img= Resources.Load<Sprite>("CloseBtn/close_highlight");

       this.GetComponent<Image>().sprite = exit_img; 
    }

    void OnEnable()
    {
        this.GetComponent<Image>().sprite = exit_img; 
    }

    public void EnterButton()
    {
        this.GetComponent<Image>().sprite = enter_img;
    }

    public void ExitButton()
    {
        this.GetComponent<Image>().sprite = exit_img;
    }
}
