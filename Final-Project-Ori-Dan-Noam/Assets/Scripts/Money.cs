using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

    public GameManager gameManager;
    private AudioSource pickupSound;

    private void Awake()
    {
        pickupSound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Crew")
        {
            pickupSound.Play();
            gameManager.updateMoney(Random.Range(100,1000));
            Destroy(gameObject, 0.5f);
        }

    }
}
