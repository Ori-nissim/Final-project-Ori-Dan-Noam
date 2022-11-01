using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Come : MonoBehaviour
{
    private AudioSource playerSound;
    private void Awake()
    {
        playerSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
            playerSound.Play();
    }
}
