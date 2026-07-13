using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int obstacleDam = 1;

    private void OnCollisionEnter2D(Collision2D Polygon)
    {
        User user = Polygon.gameObject.GetComponent<User>();

        if (user != null)
        {
            user.Hartparsant -= obstacleDam;
        }
    }
}