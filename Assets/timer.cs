using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer  : MonoBehaviour

{ 
    
    
    public Text timerText;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
          startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = (Mathf.RoundToInt( t/ 60)).ToString();
        string seconds = (t % 60).ToString();

        timerText.text = minutes + ":" + seconds;
        timerText.text += $"\nCoins collected {Coins.CoinSystem.CoinCountAsString()}/{Coins.CoinSystem.coinCount}";

     }
}
