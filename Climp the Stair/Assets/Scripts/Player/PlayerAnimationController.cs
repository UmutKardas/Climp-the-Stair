using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private Animator playerAnimator;



    void Update()
    {
        SetPlayerRunning();
    }



    private void SetPlayerRunning()
    {
        if (playerDataTransmitter.GetIsTouch())
        {
            playerAnimator.SetBool("Running", true);
        }

        else
        {
            playerAnimator.SetBool("Running", false);
        }
    }
}
