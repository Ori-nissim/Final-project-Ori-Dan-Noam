
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PortalToFinish : MonoBehaviour
{

    public GameManager gameManager;
    //public GameObject Eye;

    

    private void OnTriggerEnter(Collider other)
    {
        int nextScenIndex = SceneManager.GetActiveScene().buildIndex;

        nextScenIndex = 2 - nextScenIndex;

        SceneManager.LoadScene("FinishTheGame");//index of scene 2
    }
    //StartCoroutine(StartSceneTransition(nextScenIndex));//start parallel execution of function 

              
    


    IEnumerator StartSceneTransition(int sceneIndex)
    {
        /*
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            GlobalManager.gold = CoinMotion.numCoins;//save coints to global object
        }

        animator.SetTrigger("StartFadeIn");
        */
        yield return new WaitForSeconds(0.8f);//delay of 3 seconds
        SceneManager.LoadScene(sceneIndex);//index of scene 2
    }
}

