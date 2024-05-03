using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 0.01f; 
    public Vector3 offset = new Vector3(0, 0, -10);


    void LateUpdate()
        
    {
        transform.position = new Vector3(0, 0, -10);
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
        if (transform.position.y > -0.1f)
        {
            transform.position = new Vector3(transform.position.x, -0.1f, transform.position.z);
        }
    }
}
