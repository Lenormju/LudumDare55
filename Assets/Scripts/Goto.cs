using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto : MonoBehaviour
{

    public void interactWithDiploma() {
        Debug.Log("TODO: activate the vortex");
    }

    public Animator vortexAnimator;
    public void startVortex1() {
        vortexAnimator.SetTrigger("StartVortex");
    }

    public void gotoMap1() {
        Debug.Log("gotoMap1 ");
        SceneManager.LoadScene("Map01");
    }

    public GameObject MOTApp;
    public void openMOT() {
        MOTApp.SetActive(true);
    }

    public void closeMOT() {
        Debug.Log("MOT closed");
        MOTApp.SetActive(false);
    }

    public GameObject Demon1DialogueOverlay;
    public void DialogueWithDemon1() {
        Demon1DialogueOverlay.SetActive(true);
    }

}
