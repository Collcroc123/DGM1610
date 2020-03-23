using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public enum weaponsList
    {
        pistol,
        shotgun,
        sniper,
        assault_rifle,
        knife,
        grenade
    }

    public weaponsList currentWeapon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentWeapon)
        {
            case currentWeapon.pistol:
                break;
            case currentWeapon.shotgun:
                break;
            case currentWeapon.sniper:
                break;
            case currentWeapon.assault_rifle:
                break;
            case currentWeapon.knife:
                break;
            case currentWeapon.grenade:
                break;
            default:
                break;
        }
    }
}
