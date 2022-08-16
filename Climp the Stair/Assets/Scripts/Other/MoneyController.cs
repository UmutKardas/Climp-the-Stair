using System;
using UnityEngine;
using TMPro;
public class MoneyController : MonoBehaviour
{

    [SerializeField] private TMP_Text moneyText;
    public float money;



    void Start()
    {
        money = PlayerPrefs.GetFloat("money");
        money = (float)Math.Round(money, 2);
        moneyText.text = money + "$";
    }



    void Update()
    {
        money = PlayerPrefs.GetFloat("money");
        money = (float)Math.Round(money, 2);
        moneyText.text = money + "$";
    }
}
