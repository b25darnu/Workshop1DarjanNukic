using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField] Transform trackingTarget;

    void Update() {
        transform.position = new Vector3(
            trackingTarget.position.x,
            trackingTarget.position.y,
            transform.position.z
        );
    }
}
