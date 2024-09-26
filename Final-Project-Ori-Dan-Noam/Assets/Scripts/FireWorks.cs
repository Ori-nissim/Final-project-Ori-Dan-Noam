using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class FireWorks : MonoBehaviour
{
    public GameObject fireWorks;
    // Start is called before the first frame update
    void Start()
    {
        print("111111111111");
        Invoke("StartFireWorks", 1f);
        print("22222222222222");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartFireWorks()
    {
        print("333333333333");
        yield return new WaitForSeconds(0);
        fireWorks.SetActive(true);


    }
}
