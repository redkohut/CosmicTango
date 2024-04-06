using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Wallet : MonoBehaviour
{
    private static int _money;
    private static TextMeshProUGUI _walletInfo;

    public static int Money
    {
        get { return _money; }
        set
        {
            _money = value;
            DisplayMoney();
            PlayerPrefs.SetInt("money", _money);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _money = PlayerPrefs.GetInt("money");
        _walletInfo = GetComponent<TextMeshProUGUI>();
        DisplayMoney();
    }

    private static void DisplayMoney()
    {
        _walletInfo.text = _money.ToString();
    }
}
