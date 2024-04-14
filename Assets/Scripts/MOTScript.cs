using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MOTScript : MonoBehaviour
{
    public List<Sprite> notesSprites;

    public List<GameObject> reviews;
    public List<TMP_Text> reviewsNames;
    public List<TMP_Text> reviewsDescriptions;
    public List<Image> reviewsNotes;
    public List<Image> reviewsAvatars;

    // Start is called before the first frame update
    void Start()
    {
        if(Globals.ResultDemons != null){
            for (int i = 0; i < Globals.ResultDemons.Count; i++)  {
                // Get Result
                var result = Globals.ResultDemons[i];
                Debug.Log($"adding review {result}");
                // Get review
                reviews[i].SetActive(true);
                // Name
                reviewsNames[i].text = result.Demon;
                // Description
                reviewsDescriptions[i].text = result.Review;
                // Note
                reviewsNotes[i].sprite = notesSprites[result.Rate -1];
                // Avatar
                reviewsAvatars[i].sprite = result.Image;
            }
           
        }
    }
}
