using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour {

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void VoltarMenuPrincipal()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void reloadScene1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void reloadScene2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
