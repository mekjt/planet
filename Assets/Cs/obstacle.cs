using System;
using Unity.Burst.Intrinsics;
using UnityEngine;


public class NewMonoBehaviourScript : MonoBehaviour
{
    public int obstacledam = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<User>();  
    }

    // Update is called once per frame
    void Update()
    {
        Hartparsant = HP - obstacledam;
        Console.WriteLine(HP);
    }
}
