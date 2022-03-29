using UnityEngine;

namespace Coins
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other) {
            Coins.CoinSystem.PickUp();
            Destroy(gameObject);
        }
    }
}
