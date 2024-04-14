using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterractEffect : MonoBehaviour
{
    public string message;
    bool already_interacted = false;

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
        return message;
    }

    public bool first_interract()
    {
        return !already_interacted;
    }
}
