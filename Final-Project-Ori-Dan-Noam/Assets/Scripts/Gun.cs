using System;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 150f;

    public Camera fpsCamera;
    public ParticleSystem muzzleFlash;
    public GameObject enviormentImpact;
    private AudioSource shootingSound;


    private void Awake()
    {
        shootingSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
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

        Target target = hit.transform.GetComponent<Target>();

        Debug.Log("Shooting" + hit);

            if (target != null)
            {
                Debug.Log("Target hit:" + target.name);
                target.TakeDamage(damage);
            }

            GameObject hitFX = Instantiate(enviormentImpact, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(hitFX, 2f);
        }
    }
    void stopMuzzleFlash()
    {
        muzzleFlash.gameObject.SetActive(false);
    }
}
