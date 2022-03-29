using System;
using UnityEngine;

namespace Coins
{
    public class CoinSystem : MonoBehaviour
    {
        static int coinCollected = 0;
        public static int coinCount;

        private void Start() => coinCount =  (GameObject.FindGameObjectsWithTag("Coin")).Length+1;
        public static void PickUp() => coinCollected++;
        public static string CoinCountAsString() => Convert.ToString(coinCollected);
    }
}
