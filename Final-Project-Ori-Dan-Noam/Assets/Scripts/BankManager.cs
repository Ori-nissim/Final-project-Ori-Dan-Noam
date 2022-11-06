using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    public GameObject alarms;
    private AudioSource alarmsSound;

    public GameObject blackScreen;
    private Animator blackScreenAnimator;

    public GameManager gameManager;

    private void Awake()
    {
        alarmsSound = GetComponent<AudioSource>();
        alarms.SetActive(false);

        blackScreenAnimator = blackScreen.GetComponent<Animator>();
        blackScreenAnimator.Play("Fade");

    }
    void Update()
    {

        if (gameManager.shotsHasBeenFired)
        {
            Invoke("startAlarms", 0f);
        }
    }
    

    // Update is called once per frame

    private void startAlarms()
    {
        alarmsSound.Play();
        alarms.SetActive(true);
    }
    
}
