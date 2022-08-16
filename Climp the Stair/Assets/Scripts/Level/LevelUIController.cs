using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class LevelUIController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private IncremantalData incremantalData;
    [SerializeField] private MoneyController moneyController;
    [SerializeField] private GameObject staminaButton;
    [SerializeField] private GameObject incomeButton;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject speedButton;
    [SerializeField] private GameObject soGoodImage;
    [SerializeField] private TMP_Text staminaLevelText;
    [SerializeField] private TMP_Text incomeLevelText;
    [SerializeField] private TMP_Text speedLevelText;
    [SerializeField] private TMP_Text staminePriceText;
    [SerializeField] private TMP_Text incomePriceText;
    [SerializeField] private TMP_Text speedPricelText;
    private int staminaLevel;
    private int speedLevel;
    private int incomeLevel;
    private bool isTouchButton;



    void Start()
    {
        Time.timeScale = 1;
    }



    void Update()
    {
        SetLoadLevels();
        SetLevelText();
        SetPriceText();
        SetStaminaFinish();
        SetLevelButtonDeActive();
    }



    private void SetLevelButtonDeActive()
    {
        if (Input.GetMouseButton(0) && isTouchButton == false)
        {
            LevelButtonDeActive();
        }
    }



    private void LevelButtonActive()
    {
        staminaButton.SetActive(true);
        speedButton.SetActive(true);
        incomeButton.SetActive(true);
    }



    private void LevelButtonDeActive()
    {
        staminaButton.SetActive(false);
        speedButton.SetActive(false);
        incomeButton.SetActive(false);

    }



    private void SetLoadLevels()
    {
        staminaLevel = PlayerPrefs.GetInt("staminaLevel");
        incomeLevel = PlayerPrefs.GetInt("incomeLevel");
        speedLevel = PlayerPrefs.GetInt("speedLevel");
    }



    public float GetStaminaPriceValue()
    {
        return incremantalData.staminaLevels[staminaLevel].price;
    }



    public float GetSpeedPriceValue()
    {
        return incremantalData.speedLevels[speedLevel].price;
    }



    public float GetIncomePriceValue()
    {
        return incremantalData.incomeLevels[incomeLevel].price;
    }



    private void SetStaminaFinish()
    {
        if (playerDataTransmitter.GetStaminaFinish())
        {
            soGoodImage.SetActive(true);
            restartButton.SetActive(true);
            playerInputController.enabled = false;
            Time.timeScale = 0;
        }

        else
        {
            soGoodImage.SetActive(false);
            restartButton.SetActive(false);
        }
    }



    public void OnPointerDown()
    {
        isTouchButton = true;
        playerInputController.enabled = false;
    }



    public void OnPointerUp()
    {
        isTouchButton = false;
        playerInputController.enabled = true;
    }



    private void SetLevelText()
    {
        staminaLevelText.text = "LEVEL " + staminaLevel;
        incomeLevelText.text = "LEVEL " + incomeLevel;
        speedLevelText.text = "LEVEL " + speedLevel;
    }



    private void SetPriceText()
    {
        staminePriceText.text = GetStaminaPriceValue() + "$";
        incomePriceText.text = GetIncomePriceValue() + "$";
        speedPricelText.text = GetSpeedPriceValue() + "$";

    }



    public void StaminaButton(float staminaPrice)
    {
        staminaPrice = incremantalData.staminaLevels[staminaLevel].price;
        if (moneyController.money >= staminaPrice)
        {
            staminaLevel = PlayerPrefs.GetInt("staminaLevel");
            moneyController.money -= staminaPrice;
            PlayerPrefs.SetFloat("money", moneyController.money);
            playerDataTransmitter.StaminaLevelUp();
            playerDataTransmitter.GetCurrentStamina();
        }
    }



    public void IncomeButton(float incomePrice)
    {
        incomePrice = incremantalData.incomeLevels[incomeLevel].price;
        if (moneyController.money >= incomePrice)
        {
            incomeLevel = PlayerPrefs.GetInt("incomeLevel");
            moneyController.money -= incomePrice;
            PlayerPrefs.SetFloat("money", moneyController.money);
            playerDataTransmitter.IncomeLevelUp();
        }
    }



    public void SpeedButton(float speedPrice)
    {
        speedPrice = incremantalData.incomeLevels[speedLevel].price;
        if (moneyController.money >= speedPrice)
        {
            speedLevel = PlayerPrefs.GetInt("speedLevel");
            moneyController.money -= speedPrice;
            PlayerPrefs.SetFloat("money", moneyController.money);
            playerDataTransmitter.SpeedLevelUp();
        }
    }



    public void RestartButton()
    {
        SceneManager.LoadScene(0);

    }
}
