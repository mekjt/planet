using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class User : MonoBehaviour
{
    public float Speed = 0f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   public void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.linearVelocity = new Vector2(-Speed, rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("우측");
        }
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("점프!");
        }
        Debug.Log(rb.linearVelocity);
    }
}
