using UnityEngine;

public class CameraFollowController : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    private Vector3 offset;
    [SerializeField] private float lerpValue;
    private Vector3 newPositionVector;



    void Start()
    {
        offset = transform.position - playerTransform.position;
    }



    void LateUpdate()
    {
        SetCameraFallow();
    }



    private void SetCameraFallow()
    {
        newPositionVector = Vector3.Lerp(transform.position, playerTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPositionVector;
    }
}
