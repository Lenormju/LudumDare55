using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto : MonoBehaviour
{
    public void goto_map01() {
        SceneManager.LoadScene("Map01");
    }

    public GameObject MOTApp;
    public void openMOT() {
        MOTApp.SetActive(true);
    }

    public GameObject Demon1DialogueOverlay;
    public void DialogueWithDemon1() {
        Demon1DialogueOverlay.SetActive(true);
    }

}
