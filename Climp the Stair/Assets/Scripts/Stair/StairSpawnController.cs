using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairSpawnController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private CylinderMovementController cylinderMovementController;
    [SerializeField] private GameObject prefabStair;
    [SerializeField] private GameObject lastStair;
    [SerializeField] private float stairYIncrease;
    [SerializeField] private float stairRotateSpeed;
    [SerializeField] private float lerpValue;
    private float time;
    private float currentTime;



    void Update()
    {
        SetTimeValue();
        SetSpawnStair();
    }



    private void SetTimeValue()
    {
        time = playerDataTransmitter.GetSpeedValue();

    }



    private void SetSpawnStair()
    {
        if (currentTime <= 0)
        {
            currentTime = time;

            if (playerDataTransmitter.GetIsTouch())
            {
                prefabStair = Instantiate(prefabStair);
                Vector3 stairNewVector = new Vector3(lastStair.transform.position.x, lastStair.transform.position.y + stairYIncrease, lastStair.transform.position.z);
                prefabStair.transform.position = Vector3.Lerp(transform.position, stairNewVector, lerpValue);
                SetFunctionCall();
                prefabStair.transform.Rotate(new Vector3(0f, 10f, 0) * stairRotateSpeed);
                lastStair = prefabStair;
            }
        }

        else
        {
            currentTime -= Time.deltaTime;
        }
    }



    private void SetFunctionCall()
    {
        playerDataTransmitter.SetPlayerRotete();
        playerDataTransmitter.GetPlayerIncome();
        cylinderMovementController.SetCylinderMovement();
    }
}