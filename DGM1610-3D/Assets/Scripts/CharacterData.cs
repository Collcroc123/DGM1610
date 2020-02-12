using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    public int life;
    public int stamina;
    public int currentAmmo;
    public int fullAmmo;
    public Light flashLight;

    void Start()
    {
        life = 10;
        stamina = 10;
        fullAmmo = 5;
        currentAmmo = fullAmmo;
    }

    void Update()
    {
        if (currentAmmo > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                currentAmmo--;
                print("PEW! " + currentAmmo);
            }
        }
        else if (currentAmmo == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                print("Click...");
            }
        }

        if (Input.GetKeyDown("r"))
        {
            currentAmmo = fullAmmo;
            print("Cha-Chink! "+currentAmmo);
        }

        if (Input.GetKeyDown("f"))
        {
            if (flashLight.enabled == false)
            {
                flashLight.enabled = true;
                print("Let there be light!");
            }
            else
            {
                flashLight.enabled = false;
                print("Be gone, light!");
            }
            
        }
    }
}
