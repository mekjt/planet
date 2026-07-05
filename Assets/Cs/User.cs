using System;
using UnityEngine;
using UnityEngine.Android;//유니티 엔진 사용

public class User : MonoBehaviour //유저 클래스 생성
{
    public float Speed = 5f; // 이동 속도를 저장하는 변수, 기본값은 5
    public float JumpForce = 5f; // 점프할 때 사용할 힘, 기본값은 5
    private Rigidbody2D rb; // Rigidbody2D 컴포넌트를 저장할 변수
    public int Hartparsant = 10;
    public int MaxHartparsant = 20;


    public void Start() //공공의 클래스 시작생성 시작할떄 한번만 가동
    {
        rb = GetComponent<Rigidbody2D>(); // 이 오브젝트의 Rigidbody2D를 찾아 rb에 저장
    }

    public void Update() // 매 프레임마다 실행
    {
        
        //------------여기서부터 조작키
        if (Input.GetKey(KeyCode.A)) // a키를 눌렀을떄 안에 있는 코드를 실행함
        {
            rb.linearVelocity = new Vector2(-Speed, rb.linearVelocity.y);// 왼쪽으로 이동하고 Y축 속도(점프/낙하)는 유지
        }
        // D 키: 우측 이동 (기존 로그 출력에서 실제 이동 로직으로 변경)
        else if (Input.GetKey(KeyCode.D))// d키를 눌렀을떄 안에 있는 코드를 실행함
        {
            rb.linearVelocity = new Vector2(Speed, rb.linearVelocity.y);// 오른쪽으로 이동하고 Y축 속도(점프/낙하)는 유지
        }
        // 아무 키도 누르지 않을 때는 좌우 속도를 0으로 (미끄러짐 방지)
        else//또는 
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);// 좌우 이동을 멈추고 Y축 속도는 유지
        }

        // Space 키: 점프 (단발성 입력을 위해 GetKeyDown 사용)
        if (Input.GetKeyDown(KeyCode.Space) && GetIsGrounded()) //스페이스 키가 눌리고 유저가 땅에 접촉해있을때
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);// 현재 좌우 속도는 유지하고 위쪽 속도를 JumpForce로 설정
            Debug.Log("점프!");//디버그 로그에 점프 출력
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Hartparsant = (Hartparsant + 1);
        }
        //--------------------여기서 부터 체력
        if (Hartparsant <= 0)
        {
            Application.Quit();
        }
        if (Hartparsant > MaxHartparsant)
        {
            Hartparsant = MaxHartparsant;
        }
        



    }
    private bool GetIsGrounded()// 플레이어 아래로 레이저를 쏴서 Ground 땅 레이어가 있는지 확인
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("Ground"));
    }

}