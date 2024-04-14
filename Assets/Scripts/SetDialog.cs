using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetDialog : MonoBehaviour
{
    public float lifeTime = 5.0f;
    float current_life = 0.0f;
    string to_print_message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (current_life>0)
        {
            current_life -= Time.deltaTime;
        }
        else
        {
            to_print_message = "";
        }
        this.gameObject.GetComponent<TMP_Text>().text = to_print_message;
    }

    public void SetDialogMessage(string message)
    {
        current_life = lifeTime;
        to_print_message = message;
    }
}
