using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mvt : MonoBehaviour
{
    public float vitesse;
    public SpriteRenderer perso;
    public Rigidbody2D rb;
    float zpos;

    // Start is called before the first frame update
    void Start()
    {
        zpos = this.gameObject.GetComponent<Transform>().position.z;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    float oldPositionX;
void Update()
    {
        float old_x = transform.position.x;
        if (Input.GetMouseButton(1))
        {
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = zpos;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * vitesse);
        }
        else
        {
            float deplacementHorizontal = Input.GetAxis("Horizontal");
            float deplacementVertical = Input.GetAxis("Vertical");

            Vector3 deplacement = new Vector3(deplacementHorizontal, deplacementVertical, 0) * vitesse * Time.deltaTime;
            transform.Translate(deplacement);
        }
        float new_x = transform.position.x;
        if(new_x > old_x)
        {
           perso.flipX=false;
        }
        else if (new_x < old_x)
        {
            perso.flipX=true;
        }
    }

    
}
