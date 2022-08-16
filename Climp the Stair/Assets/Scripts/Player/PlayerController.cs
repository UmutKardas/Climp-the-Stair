using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private IncremantalData incremantalData;
    public int staminaLevel;
    public int speedLevel;
    public int incomeLevel;



    public float GetStaminaValue()
    {
        staminaLevel = PlayerPrefs.GetInt("staminaLevel");
        return incremantalData.staminaLevels[staminaLevel].stamina;
    }



    public float GetSpeedValue()
    {
        speedLevel = PlayerPrefs.GetInt("speedLevel");
        return incremantalData.speedLevels[speedLevel].speed;
    }



    public float GetIncomeValue()
    {
        incomeLevel = PlayerPrefs.GetInt("incomeLevel");
        return incremantalData.incomeLevels[incomeLevel].amout;
    }



    public void StaminaLevelUp()
    {
        staminaLevel++;
        PlayerPrefs.SetInt("staminaLevel", staminaLevel);
    }



    public void IncomeLevelUp()
    {
        incomeLevel++;
        PlayerPrefs.SetInt("incomeLevel", incomeLevel);
    }



    public void SpeedLevelUp()
    {
        speedLevel++;
        PlayerPrefs.SetInt("speedLevel", speedLevel);
    }
}
