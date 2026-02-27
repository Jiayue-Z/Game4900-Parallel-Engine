using AOTADev;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.CoinCount += 1;
            Debug.Log("Coin collected!");
            Debug.Log("Coin collected: " + playerController.CoinCount);
            Destroy(gameObject);
        }
    }
}
