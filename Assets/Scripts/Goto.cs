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
    public Animator vortex2Animator;
    public void startVortex1() {
        vortexAnimator.SetTrigger("StartVortex");
    }

    public void gotoMap1() {
        Debug.Log("gotoMap1");
        SceneManager.LoadScene("Map01");
    }
    public void gotoMap2() {
        Debug.Log("gotoMap2");
        SceneManager.LoadScene("Map02");
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
        vortex2Animator.SetTrigger("StartVortex");
    }

    public GameObject Demon1DialogueOverlay;
    public void DialogueWithDemon1() {
        Demon1DialogueOverlay.SetActive(true);
    }
    public void StopDialogueWithDemon1() {
        Demon1DialogueOverlay.SetActive(false);
    }

}
