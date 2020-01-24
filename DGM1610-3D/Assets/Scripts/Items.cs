using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    bool increaseSize;
    bool healsPlayer;
    bool savesGame;
}

public class Health : Items
{
    bool healsPlayer = true;
    bool increaseSize = false;
    bool savesGame = false;
}

public class Powerup : Items
{
    bool healsPlayer = false;
    bool increaseSize = true;
    bool savesGame = false;
}

public class Checkpoint : Items
{
    bool healsPlayer = false;
    bool increaseSize = true;
    bool savesGame = true;
}