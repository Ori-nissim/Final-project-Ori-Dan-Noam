using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerHUD : MonoBehaviour
{
    public GameObject damageTaken;
    public TextMeshProUGUI healthCounter;
    private Animation dmgTakenAnimation;
    private float health = 100;

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

            health -= 10;
            healthCounter.SetText(health + "");
        }
    }
}
