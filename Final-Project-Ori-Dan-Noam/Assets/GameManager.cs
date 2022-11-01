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

    private int moneyCount = 2;
    private int goldCount = 2;

    public bool shotsHasBeenFired = false; // to signal bank NPC to run

    public static GameManager Instance;

    void Awake()
    {
        blackScreenAnimator = blackScreen.GetComponent<Animator>();


        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    public void showTeamSelection()
    {
        print("clicked");
    }
    private void Update()
    {
        setCursorActive(false);

    }
    public void updateGold(int amount)
    {
        goldCount += amount;
        gold.SetText(goldCount + "");
    }

    public void updateMoney(int amount)
    {
        moneyCount += amount;
        money.SetText(moneyCount + "");
    }

    private void setCursorActive(bool state)
    {
        if (!state)
        {
            // lock and hide the cursor
            UnityEngine.Cursor.visible = false;
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            // show cursor
            UnityEngine.Cursor.visible = true;
            UnityEngine.Cursor.lockState = CursorLockMode.Confined;
        }
    }   
    public void firstSceneTransition()
    {
        int nextScenIndex = SceneManager.GetActiveScene().buildIndex;

        nextScenIndex = 1 - nextScenIndex;

        GameManager.Instance.moneyCount = moneyCount;

        blackScreenAnimator.Play("Fade");
        StartCoroutine(StartSceneTransition(nextScenIndex));//start parallel execution of function 
        //Invoke("shotsFired", 3f);
    }

    IEnumerator StartSceneTransition(int sceneIndex)
    {
        
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene("Bank");//index of scene 2
    }

    private void shotsFired()
    {
        shotsHasBeenFired = true;
    }
}
