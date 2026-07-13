using JetBrains.Annotations;
using UnityEngine;
using TMPro;

public class life : MonoBehaviour
{
    public TMP_Text lifescar;
    public User user;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        lifescar.text = "Hp:" + user.Hartparsant.ToString();//ToString은 정수 Hart를 문자열 str로 바꾸기 위해 존재하며 다른 기능도 있는 것으로 생각됨
    }
}
