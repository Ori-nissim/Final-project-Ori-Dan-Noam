using System;
using UnityEngine;

public class Gun_CopSide : MonoBehaviour
{
    public float damage = 10f;
    public float range = 150f;

    public GameManager gameManager;
    public Camera fpsCamera;
    public ParticleSystem muzzleFlash;
    public GameObject enviormentImpact;
    public GameObject humanImpact;

    public BankRobber robberMale;
    public BankRobber robberFemale;  

    private AudioSource shootingSound;
    private GameObject impactEffect;

    private void Awake()
    {
        shootingSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            gameManager.shotsHasBeenFired = true;
        }
    }

    private void Shoot()
    {
        muzzleFlash.gameObject.SetActive(true);
        muzzleFlash.Play();
        shootingSound.Play();
        Invoke("stopMuzzleFlash", 0.15f);

        RaycastHit hit;

        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
        Agent target = hit.transform.GetComponent<Agent>();
        

            if (target != null)
            {
                target.takeDamage(damage);
            }
                if (hit.transform.gameObject.tag == "Cop")
                { 
                    impactEffect = humanImpact;
                    robberMale.target = hit.transform.gameObject;
                    robberFemale.target = hit.transform.gameObject;
                }
                else
                    impactEffect = enviormentImpact;

                GameObject hitFX = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(hitFX, 2f);
        
        }

    }
    void stopMuzzleFlash()
    {
        muzzleFlash.gameObject.SetActive(false);
    }
}
