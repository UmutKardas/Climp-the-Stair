using UnityEngine;
using System;
using TMPro;

public class PlayerIncomeController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private MoneyController moneyController;
    [SerializeField] private TMP_Text moneyIncomeText;
    [SerializeField] private Animation incomeAnimation;
    private float playerIncome;
    public float playerMoney = 0;



    public void SetPlayerIncome()
    {
        playerMoney = moneyController.money;
        playerIncome = playerDataTransmitter.GetIncomeValue();
        playerMoney += playerIncome;
        playerMoney = (float)Math.Round(playerMoney, 2);
        PlayerPrefs.SetFloat("money", playerMoney);
        SetMoneyIncomeText();
    }



    private void SetMoneyIncomeText()
    {
        moneyIncomeText.text = "$" + playerDataTransmitter.GetIncomeValue();
        incomeAnimation.Play();
    }

}
