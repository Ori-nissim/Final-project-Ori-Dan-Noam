using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gold;
    public TextMeshProUGUI money;

    public GameObject blackScreen;
    private Animator blackScreenAnimator;

    private int moneyCount = 0;
    private int goldCount = 0;

    private
     void Awake()
    {
        // start mission time - TODO 
        blackScreenAnimator = blackScreen.GetComponent<Animator>();
    }
    // Update is called once per frame
    public void updateGold()
    {
        
    }

    public void updateMoney(int amount)
    {
        moneyCount += amount;
        money.SetText(moneyCount + "");
    }

    public void firstSceneTransition()
    {
        int nextScenIndex = SceneManager.GetActiveScene().buildIndex;

        nextScenIndex = 1 - nextScenIndex;

        blackScreenAnimator.Play("Fade");
        StartCoroutine(StartSceneTransition(nextScenIndex));//start parallel execution of function 

    }

    IEnumerator StartSceneTransition(int sceneIndex)
    {
        
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(sceneIndex);//index of scene 2
    }
}
