using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86;

public class TakeBomb : MonoBehaviour
{

    public Camera fpsCamera;
    public Text instruction;
    public GameObject bomb;

    private bool isBombObtained = false;
    private void Update()
    {
        if (!isBombObtained)
        {
            RaycastHit hit;

            if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, 2))
            {
                if (hit.transform.tag == "Takeable")
                {
                    instruction.gameObject.SetActive(true);

                    if (Input.GetKey(KeyCode.E))
                    {
                        bomb.SetActive(false);
                        instruction.text = " Bomb Obtained! Get to the Vault door!";
                        Invoke("BombObtained", 3f);  // show instruction for 3 second and disappear
                    }
                }

            }
            else
                instruction.gameObject.SetActive(false);

        }

    }
    private void BombObtained()
    {
        isBombObtained = true;
        instruction.gameObject.SetActive(false);

    }


}
