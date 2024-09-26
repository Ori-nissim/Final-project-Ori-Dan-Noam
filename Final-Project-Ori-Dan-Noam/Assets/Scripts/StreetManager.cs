using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StreetManager : MonoBehaviour
{
    public TextMeshProUGUI startingInstruction;

    public GameObject blackScreen;
    private Animator blackScreenAnimator;
    private void Awake()
    {
        blackScreenAnimator = blackScreen.GetComponent<Animator>();
        blackScreenAnimator.Play("Fade");

    }

    private void Start()
    {
        Invoke("hideInstructions", 4f);
    }
    void hideInstructions()
    {
        startingInstruction.enabled = false;
    }
}
