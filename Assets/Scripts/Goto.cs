using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto : MonoBehaviour
{
    public void goto_map01() {
        SceneManager.LoadScene("Map01");
    }
}
