using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string resourcesname;

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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
