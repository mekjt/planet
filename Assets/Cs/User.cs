using UnityEngine;

public class User : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 5f; // 점프 힘 제어를 위한 변수 추가
    private Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        // A 키: 좌측 이동
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.linearVelocity = new Vector2(-Speed, rb.linearVelocity.y);
        }
        // D 키: 우측 이동 (기존 로그 출력에서 실제 이동 로직으로 변경)
        else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(Speed, rb.linearVelocity.y);
        }
        // 아무 키도 누르지 않을 때는 좌우 속도를 0으로 (미끄러짐 방지)
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }

        // Space 키: 점프 (단발성 입력을 위해 GetKeyDown 사용)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
            Debug.Log("점프!");
        }

        // 현재 속도 로그 출력
        Debug.Log(rb.linearVelocity);
    }
}