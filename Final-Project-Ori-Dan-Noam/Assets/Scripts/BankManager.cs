using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    public GameObject alarms;
    private AudioSource alarmsSound;
    public GameManager gameManager;
    public GameObject blackScreen;
    private Animator blackScreenAnimator;

    private void Awake()
    {
        alarmsSound = GetComponent<AudioSource>();
        alarms.SetActive(false);

        blackScreenAnimator = blackScreen.GetComponent<Animator>();
        blackScreenAnimator.Play("Fade");
        gameManager.updateMoney( 300 );
    }
    void Start()
    {
        
        Invoke("startAlarms", 6f);
    }

    // Update is called once per frame

    private void startAlarms()
    {
        alarmsSound.Play();
        alarms.SetActive(true);
    }
    
}
