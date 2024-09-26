using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerHUD : MonoBehaviour
{
    public GameObject damageTaken;
    public TextMeshProUGUI healthCounter;
    private Animator dmgTakenAnimation;
    private float health = 100;

    private void Awake()
    {
        dmgTakenAnimation = damageTaken.GetComponent<Animator>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "EnemyBullet")
        {
            print("player hit");
            dmgTakenAnimation.Play("dmgTaken");

            health -= 10;
            healthCounter.SetText(health + "");
        }
    }
}
