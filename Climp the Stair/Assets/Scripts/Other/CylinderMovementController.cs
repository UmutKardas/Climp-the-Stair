using UnityEngine;

public class CylinderMovementController : MonoBehaviour
{

    [SerializeField] private float cylinderYIncrease;
    [SerializeField] private float lerpValue;



    public void SetCylinderMovement()
    {
        Vector3 cylinderNewVector = new Vector3(transform.position.x, transform.position.y + cylinderYIncrease, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, cylinderNewVector, lerpValue);
    }
}
