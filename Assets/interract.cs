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


    // Start is called before the first frame update
    void Start()
    {
        objectRendererObject = inter_object.GetComponent<Renderer>();
        objectRendererDemon  = inter_demon.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
         if ((Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.Space)) ) && is_inter_ok)
         {
            string message = inter_object.GetComponent<InterractEffect>().get_message();
            Debug.Log(message);
         }
         else if ((Input.GetKeyDown(KeyCode.E) || (Input.GetKeyDown(KeyCode.Space)) ) && is_parler_ok)
         {
            Debug.Log("AGROUGROU JE SUIS UN DEMON MECHANT ");
         }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Object")) // Remplacez "Player" par le tag de l'objet avec lequel vous souhaitez détecter la collision
        {
            objectRendererObject.enabled = true;
            objectRendererDemon.enabled = false;
            is_inter_ok = true;
            is_parler_ok = false;
            inter_object = other.gameObject;
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
        if (other.CompareTag("Object")) // Remplacez "Player" par le tag de l'objet avec lequel vous souhaitez détecter la collision
        {
            objectRendererObject.enabled = false;
            is_inter_ok = false;
            inter_object = null;
        }
        else if (other.CompareTag("Demon"))
        {
            objectRendererDemon.enabled = false;
            is_parler_ok = false;
            inter_demon = null;
        }
    }
}
