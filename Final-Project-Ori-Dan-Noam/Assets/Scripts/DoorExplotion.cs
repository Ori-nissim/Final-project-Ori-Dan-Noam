using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86;

public class DoorExplotion : MonoBehaviour
{
    public GameObject explosion;
    Animator animator;
    public Text Instruction;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        
    }
    /*void update()
    {
        print("out");
        if (Input.GetKeyDown(KeyCode.P)) //prass " P "
        {
            print("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            animator.SetBool("Start", true);
            animator.SetInteger("play1",1);
            //sound.Play();
        }
    }*/
    private void OnTriggerEnter(Collider other)
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
    IEnumerator Explode()
    {
        print("XXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Instruction.gameObject.SetActive(false);
        yield return new WaitForSeconds(2);
        explosion.SetActive(true);
       
        sound.Play();
        
    }
    /* private void OnTriggerExit(Collider other)
     {
         animator.SetBool("IsOpening", false);
         sound.PlayDelayed(0.6f);
     }*/
    // Update is called once per frame

}
