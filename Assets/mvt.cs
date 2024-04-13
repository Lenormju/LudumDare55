using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mvt : MonoBehaviour
{
    public float vitesse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        float deplacementVertical = Input.GetAxis("Vertical");

        Vector3 deplacement = new Vector3(deplacementHorizontal, deplacementVertical, 0) * vitesse * Time.deltaTime;
        transform.Translate(deplacement);
    }

    
}
