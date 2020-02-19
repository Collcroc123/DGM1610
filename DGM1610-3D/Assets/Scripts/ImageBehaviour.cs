using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image coolImage;
    // Start is called before the first frame update
    void Start()
    {
        coolImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
