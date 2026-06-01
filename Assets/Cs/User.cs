using UnityEngine;

public class User : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void Start()
    {
        
    }

    // Update is called once per frame
   public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Debug.Log("좌측");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("우측");
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("점프!");
        }
    }
}
