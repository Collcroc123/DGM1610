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
        if(floatData--)
        {
            //https://forum.unity.com/threads/how-to-change-the-size-of-a-ui-image-from-code-trying-to-make-a-simple-healthbar-from-this.265024/
            //coolImage.rectTransform.sizeDelta = new Vector2(width, height);
        }
    }
}
