using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{

    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private PlayerIncomeController playerIncomeController;
    [SerializeField] private PlayerStaminaController playerStaminaController;



    public float GetStaminaValue()
    {
        return playerController.GetStaminaValue();
    }



    public float GetSpeedValue()
    {
        return playerController.GetSpeedValue();
    }



    public float GetIncomeValue()
    {
        return playerController.GetIncomeValue();
    }



    public void StaminaLevelUp()
    {
        playerController.StaminaLevelUp();
    }



    public void IncomeLevelUp()
    {
        playerController.IncomeLevelUp();
    }



    public void SpeedLevelUp()
    {
        playerController.SpeedLevelUp();
    }



    public bool GetIsTouch()
    {
        return playerInputController.IsTouch;
    }



    public void SetPlayerRotete()
    {
        playerMovementController.SetPlayerRotete();
    }



    public void GetPlayerIncome()
    {
        playerIncomeController.SetPlayerIncome();
    }



    public void GetCurrentStamina()
    {
        playerStaminaController.SetCurrentStamina();
    }



    public bool GetStaminaFinish()
    {
        return playerStaminaController.staminaIsFinish;
    }
}
