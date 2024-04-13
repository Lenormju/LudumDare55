using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto : MonoBehaviour
{
    bool diplomaOnce = false;
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

    public void gotoMap1() {
        Debug.Log("gotoMap1 ");
        SceneManager.LoadScene("Map01");
    }
    
    public static void goto_bureau() {
        SceneManager.LoadScene("MainScene");
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

}
