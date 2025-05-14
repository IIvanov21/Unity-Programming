using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class DataTypes : MonoBehaviour
{
    /*
     * int,float,double,strings, char, bool,long 
     * arrays, objects, lists
     * int you can store numbers up to 2,147,483,647
     * long you can store numbers up to 9,223,372,036,854,775,807
     */

    //Primitive Data types
    int wholeNumber = 1;
    float decimalNumber = 2.5f;
    double decimalNumber2 = 2.5;
    string name = "myName";
    char singleCharacter= 'a';
    bool aTrueOrFalseValue = false;
    bool isPlayerActive = false;

    //Collection of data
    int []wholeNumbers;//Example of an array
    List<int> wholeNumbers2;

    GameObject exampleGameObjectl;

    string firstName, lastName;
    int age;
    float playerSpeed = 5f;

    PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firstName = "Ivo";
        lastName = "Ivanov";
        age = 26;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            Debug.Log("My name is " + firstName + " " + lastName + ". My age is " + age + ".");
            Debug.Log($"My name is {firstName} {lastName}. My age is {age}.");
        }

        playerSpeed=GetPlayerSpeed();
    }

    void DoSomething()
    {
        Debug.Log("Hi!");
        /*
         Anything between the brackets is part of this function
         
         
         */

    }

    float GetPlayerSpeed()
    {
        return 20f;
    }

    float GetPlayerSpeedTwo()
    {
        return playerSpeed;
    }
}
