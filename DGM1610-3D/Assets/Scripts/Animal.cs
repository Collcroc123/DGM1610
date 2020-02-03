using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int health;
    public float weight;
    public int lifespan;
    public int speed;
    public int size; //1=Small, 2=Medium, 3=Large, 4=Giant
    public bool canRun;
    public bool canSwim;
    public bool canFly;

    void Start()
    {
        //Randomize Code Lines: \/\/\/
        //https://answers.unity.com/questions/754495/generate-a-random-number-between-two-ranges.html
    }

    void Update()
    {
        
    }
}
/*
public class Cat : Animal
{
    int health = 80; 
    int speed = 20;
    bool canRun = true;
    bool canSwim = true;
    bool canFly = false;

    void Start()
    {
        float weight = Random.Range(5f, 30f);
        if (weight < 5)
        {
            size = 1;
            print("This animal's weight is Light");
        }
        else if (weight >= 5 && weight < 10)
        {
            size = 2;
            print("This animal's weight is Medium");
        }
        else if (weight >= 10 && weight < 20)
        {
            size = 3;
            print("This animal's weight is Heavy");
        }
        else if (weight >= 20 && weight <= 30)
        {
            size = 4;
            print("This animal's weight is Obese");
        }
        else
        {
            print("This animal's weight is out of bounds!");
        }

        int lifespan = Random.Range(2, 16);
        if (lifespan <= 5)
        {
            print("This animal died young");
        }
        else if (lifespan > 5 && lifespan <= 10)
        {
            print("This animal lived a decent life");
        }
        else if (lifespan > 10)
        {
            print("This animal lived a long and fufilling life");
        }
    }

    void Update()
    {
        
    }
}

public class Dog : Animal
{
    int health = 100;
    int speed = 10;
    bool canRun = true;
    bool canSwim = true;
    bool canFly = false;

    void Start()
    {
        float weight = Random.Range(5f, 150f);
        if (weight < 30)
        {
            size = 1;
            print("This animal's weight is Small");
        }
        else if (weight >= 30 && weight < 60)
        {
            size = 2;
            print("This animal's weight is Medium");
        }
        else if (weight >= 60 && weight < 100)
        {
            size = 3;
            print("This animal's weight is Large");
        }
        else if (weight >= 100 && weight <= 150)
        {
            size = 4;
            print("This animal's weight is Gigant");
        }
        else
        {
            print("This animal's weight is out of bounds!");
        }

        int lifespan = Random.Range(2, 16);
        if (lifespan <= 5)
        {
            print("This animal died young");
        }
        else if (lifespan > 5 && lifespan <= 10)
        {
            print("This animal lived a decent life");
        }
        else if (lifespan > 10)
        {
            print("This animal lived a long and fufilling life");
        }
    }

    void Update()
    {
        
    }
}

public class Bird : Animal
{
    int health = 50;
    int speed = 5;
    bool canRun = false;
    bool canSwim = true;
    bool canFly = true;
}
*/