using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private float playerRotateSpeed;
    [SerializeField] private float playerMovementSpeed;
    private Rigidbody playerRigidbody;
    public float time = 0.2f;



    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }



    private void FixedUpdate()
    {
        SetPlayerMovement();
    }



    private void SetPlayerMovement()
    {
        if (playerDataTransmitter.GetIsTouch())
        {
            playerRigidbody.velocity = Vector3.up * playerMovementSpeed * Time.fixedDeltaTime;
            time -= Time.fixedDeltaTime;

            if (time <= 0)
            {
                time = 0.6f;
            }

        }
    }



    public void SetPlayerRotete()
    {
        transform.Rotate(new Vector3(0f, 10f, 0) * playerRotateSpeed);
    }
}
