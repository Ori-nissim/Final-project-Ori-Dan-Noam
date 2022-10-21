using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Anubis : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject Eye;
    public Text Instruction1;// text will be " press E to enter" 
    public GameObject Glass;
    public GameObject BrokenGlass;
    // Start is called before the first frame update
    void Start()
    {
        BrokenGlass.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(Eye.transform.position, Eye.transform.forward, out hit))
        {
            if (hit.transform.gameObject.tag == "Anubis")
            {
                print("hit!!");
                Instruction1.gameObject.SetActive(true);
                Glass.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E)) //press " E "
                {
                    BrokenGlass.gameObject.SetActive(true);
                    Glass.gameObject.SetActive(false);
                }
            }
            else
            {
                Instruction1.gameObject.SetActive(false);
            }
        }
    }


}

