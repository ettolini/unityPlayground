using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private readonly Vector3 offset = new Vector3(0, 1, - 5);

    void Update()
    {
        transform.position = player.position + offset;
    }
}
