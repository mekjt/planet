using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int obstacleDam = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        User user = collision.gameObject.GetComponent<User>();

        if (user != null)
        {
            user.Hartparsant -= obstacleDam;
        }
    }
}