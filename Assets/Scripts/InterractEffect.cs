using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class InterractEffect : MonoBehaviour
{
    public string message;
    bool already_interacted = false;
    public GameObject ink_story;
    public string variable_name;
    public bool has_a_purpose = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public string get_message()
    {
        already_interacted = true;
        if (has_a_purpose)
        {
            ink_story.GetComponent<DialogueManager>().setVariable(variable_name);
        }
        return message;
    }

    public bool first_interract()
    {
        return !already_interacted;
    }
}
