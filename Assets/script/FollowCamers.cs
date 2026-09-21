using UnityEngine;

public class FollowCamers : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -7);

    private void LateUpdate()
    {
        // TO DO here
        if (target == null) return;

        transform.position = target.position + offset;

    }
}
