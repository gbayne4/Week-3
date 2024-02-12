using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class CoinCalculator : MonoBehaviour
{
    TextMeshProUGUI coinsleft;
    TextMeshProUGUI score;
    public static int coins = 30;
    // Start is called before the first frame update
    void Start()
    {
        coinsleft = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        score = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //let you know when you finished
        string message = (coins <= 0) ? "You collected all the coins!" : "Coins Left:";
        coinsleft.text = message;

        string displayscore = (coins <= 0) ? "" : coins.ToString();
        //I changed it from loops to coins bc they were orginally supposed to look like loops but then it became late and I didnt have time to make them look like that
        score.text = displayscore;

    }
}
