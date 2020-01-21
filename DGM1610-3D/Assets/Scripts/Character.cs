using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int life;
    public int stamina;
    public int currentAmmo;
    public int fullAmmo;
    public Light lightOne;
    public Light lightTwo;
    public Light lightThree;
    public Light lightFour;
    public Light lightFive;
    public Light lightSix;
    private bool lightOn = false;

    void Start()
    {
        //GetComponent<Light>();
        print("Hello World!");
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
            if (lightOn == false)
            {
                lightOne.intensity = 1;
                lightTwo.intensity = 1;
                lightThree.intensity = 1;
                lightFour.intensity = 1;
                lightFive.intensity = 1;
                lightSix.intensity = 1;
                print("Let there be light!");
                lightOn = true;
            }
            else
            {
                lightOne.intensity = 0;
                lightTwo.intensity = 0;
                lightThree.intensity = 0;
                lightFour.intensity = 0;
                lightFive.intensity = 0;
                lightSix.intensity = 0;
                print("Be gone, light!");
                lightOn = false;
            }
            
        }
    }
}
