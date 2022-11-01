using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorExplotion : MonoBehaviour
{
    public GameObject explosion;
    Animator doorAnimator;
    public Camera fpsCamera;

    public Text instruction;
    private AudioSource sound;
    private bool hasExploded = false;
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        if (!hasExploded)
        {
            RaycastHit hit;

            if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, 2))
            {
                if (hit.transform.tag == "Door")
                {
                    instruction.gameObject.SetActive(true);

                    if (Input.GetKey(KeyCode.E))
                    {
                       
                        doorAnimator.SetBool("Start", true);
                        sound.PlayDelayed(2.8f);
                        Invoke("stopInstructions", 3f);
                    }
                }

            }
            else
                instruction.gameObject.SetActive(false);

        }

    }

    void stopInstructions()
    {
        hasExploded = true;
    }
    /* private void OnTriggerEnter(Collider other)
     {
         animator.SetBool("Start", true);
         Instruction.gameObject.SetActive(true);
         sound.PlayDelayed(5f);
         //StartCoroutine(Explode());
         StartCoroutine(TextDelay());
         Instruction.gameObject.SetActive(false);

     }

     IEnumerator TextDelay()
     {
         yield return new WaitForSeconds(2);
         Instruction.gameObject.SetActive(false);
     }

     */
    IEnumerator Explode()
    {
        instruction.gameObject.SetActive(false);
        sound.Play();
        yield return new WaitForSeconds(1);
        explosion.SetActive(true);
       
        
    }
  
    
}
