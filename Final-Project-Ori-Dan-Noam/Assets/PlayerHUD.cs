using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    public GameObject damageTaken;
    private Animation dmgTakenAnimation;

    private void Awake()
    {
        dmgTakenAnimation = damageTaken.GetComponent<Animation>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "EnemyBullet")
        {
            damageTaken.SetActive(true);
            dmgTakenAnimation.Play();
        }
    }
}
