using UnityEngine;

public class camerafollower : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(0,0, Random.Range(-8, -3));
    }
    
    void LateUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;
        
        // transform.LookAt(target);
    }

}