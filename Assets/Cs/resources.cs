using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string resourcesname;
    public int reDamage = 1;

    public enum ResourcesType //열거형으로 광물의 타입(성질)을 표기함
    {
        Gold,
        Iron,
        Silver,
        Titanlum,
        vice
    }

    public ResourcesType resourcesType;
    public int resourceshp;
    public int resourcesdropcount;
    public void Mining()
    {
        resourceshp = resourceshp - reDamage;
        if(resourceshp <= 0) 
        {
            resourcesdropcount = 100;
            Console.WriteLine(resourcesdropcount);
            //여기 삭제 코드 넣어야 함
        }

    }

    
}
