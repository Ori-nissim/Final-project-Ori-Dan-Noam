using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneGuideMessage : MonoBehaviour
{
    public float disappearAfter;
    public string message;
    public TextMeshProUGUI textObject;

    private void Awake()
    {
        textObject.color = Color.red;
        textObject.fontSize = 40;
        textObject.text = message;
        Destroy(textObject, disappearAfter);    
    }
}
