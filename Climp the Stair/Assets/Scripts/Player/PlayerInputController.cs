using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

    public bool IsTouch;



    void Update()
    {
        SetPlayerInput();
    }



    private void SetPlayerInput()
    {
        if (Input.GetMouseButton(0))
        {
            IsTouch = true;
        }

        else
        {
            IsTouch = false;
        }
    }
}
