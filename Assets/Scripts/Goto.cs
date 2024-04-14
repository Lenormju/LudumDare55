using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto : MonoBehaviour
{
    public GameObject MOTAppButton;
    public void Start() {
        if ((MOTAppButton != null) && diplomaOnce)
        {
            MOTAppButton.SetActive(true);
        }
    }

    public void gotoCredits() {
        SceneManager.LoadScene("Credits");
    }

    public AudioSource ouchSound;
    public void touchCactus() {
        ouchSound.Play();
    }

    public AudioSource miaouSound;
    public void touchCat() {
        miaouSound.Play();
    }

    public void gotoMainScene() {
        SceneManager.LoadScene("MainScene");
    }

    static bool diplomaOnce = false;
     public void interactWithDiploma() {
        if (!diplomaOnce)
        {
            diplomaOnce = true;
            vortexAnimator.SetTrigger("StartVortex");
        }
    }

    public Animator vortexAnimator;
    public void startVortex1() {
        vortexAnimator.SetTrigger("StartVortex");
    }

    static public int mapToGo = 1;
    public void gotoMap() {
        if (mapToGo == 1) {
            Debug.Log("gotoMap1");
            SceneManager.LoadScene("Map01");
            mapToGo = 2;
        } else if (mapToGo == 2) {
            Debug.Log("gotoMap2");
            SceneManager.LoadScene("Map02");
            mapToGo = 3;
        } else if (mapToGo == 3) {
            Debug.Log("gotoMap3");
            SceneManager.LoadScene("Map03");
            mapToGo = 4;
        } else if (mapToGo == 4) {
            Debug.Log("gotoCredits");
            gotoCredits();
        }
        
    }

    public void gotoBureau() {
        Debug.Log("gotoBureau");
        SceneManager.LoadScene("MainScene");
    }
    
    public void startDevortexisation() {
        vortexAnimator.SetTrigger("StartVortex");
    }

    public GameObject MOTApp;
    public void openMOT() {
        MOTApp.SetActive(true);
    }

    public void closeMOT() {
        MOTApp.SetActive(false);
        vortexAnimator.SetTrigger("StartVortex");
    }

    public GameObject Demon1DialogueOverlay;
    public void DialogueWithDemon1() {
        Demon1DialogueOverlay.SetActive(true);
    }
    public void StopDialogueWithDemon1() {
        Demon1DialogueOverlay.SetActive(false);
    }

}
