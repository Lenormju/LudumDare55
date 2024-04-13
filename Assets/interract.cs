using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interract : MonoBehaviour
{
    private Renderer objectRendererObject;
    private Renderer objectRendererDemon;

    private bool is_inter_ok;
    private bool is_parler_ok;

    public GameObject inter_object;
    public GameObject inter_demon;

    private GameObject to_outline;

    public int count_object_close = 0;

    public List<GameObject> currentObj;

    public GameObject DialogInterract;
    // Start is called before the first frame update
    void Start()
    {
        objectRendererObject = inter_object.GetComponent<Renderer>();
        objectRendererDemon  = inter_demon.GetComponent<Renderer>();
    }

    // Update is called once per frame
    public Goto scriptGoto;
    void Update()
    {
         if ((Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.Space)) ) && is_inter_ok)
         {
            string message = inter_object.GetComponent<InterractEffect>().get_message();
            Debug.Log(message);
            DialogInterract.GetComponent<SetDialog>().SetDialogMessage(message);
         }
         else if ((Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.Space)) ) && is_parler_ok)
         {
            scriptGoto.DialogueWithDemon1();
         }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Object")) 
        {
            count_object_close++;

            currentObj.Add(other.gameObject);
            foreach (GameObject obj in currentObj)
            {
                obj.GetComponent<Outline>().enabled = false;
            }
            to_outline = currentObj[currentObj.Count-1];
            to_outline.GetComponent<Outline>().enabled = true;

            objectRendererObject.enabled = true;
            objectRendererDemon.enabled = false;
            is_inter_ok = true;
            is_parler_ok = false;
            inter_object = currentObj[currentObj.Count-1];
        }
        if (other.CompareTag("Demon"))
        {
            objectRendererDemon.enabled = true;
            objectRendererObject.enabled = false;
            is_inter_ok = false;
            is_parler_ok = true;
            inter_demon = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        currentObj.Remove(other.gameObject);
        foreach (GameObject obj in currentObj)
        {
            obj.GetComponent<Outline>().enabled = false;
        }
        if(currentObj.Count>=1)
        {
            to_outline = currentObj[currentObj.Count-1];
            to_outline.GetComponent<Outline>().enabled = true;
            inter_object = currentObj[currentObj.Count-1];
        }

        if (other.CompareTag("Object")) // Remplacez "Player" par le tag de l'objet avec lequel vous souhaitez détecter la collision
        {
            count_object_close--;
            other.gameObject.GetComponent<Outline>().enabled = false;
            if (count_object_close<1)
            {
                objectRendererObject.enabled = false;
                is_inter_ok = false;
                inter_object = null;
            }
        }
        else if (other.CompareTag("Demon"))
        {
            objectRendererDemon.enabled = false;
            is_parler_ok = false;
            inter_demon = null;
        }
    }
}
