using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "OUB12";
    public bool canRun = true;

    // Start is called before the first frame update
    void Start()
    {
        if (a + b == c)
        {
            print("That is true.");
        }

        if (password == "OUB12")
        {
            print("This is the correct password.");
        }

        if (canRun)
        {
            print("We can run.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
