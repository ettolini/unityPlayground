using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public FollowPlayer camera;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            camera.enabled = false;

        }
    }
}
