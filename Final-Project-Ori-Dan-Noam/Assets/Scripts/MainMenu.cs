using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void startRobbers ()
    {

        int nextScenIndex = SceneManager.GetActiveScene().buildIndex;

        nextScenIndex = 1 - nextScenIndex;

        SceneManager.LoadScene("Street");//index of scene 2

    }

    public void startPolice()
    {
        // TODO
    }
}
