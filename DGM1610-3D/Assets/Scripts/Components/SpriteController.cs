using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
    SpriteRenderer characterSprite;

    // Start is called before the first frame update
    void Start()
    {
        characterSprite = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        characterSprite.color = Color.green;
    }

    private void OnDisable()
    {
        characterSprite.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            characterSprite.color = Color.blue;
        }
        if (Input.GetKeyDown("s"))
        {
            characterSprite.color = Color.yellow;
        }
    }
}
