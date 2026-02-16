using UnityEngine;

public class Receiver : MonoBehaviour
{
    public void OnCalled(string message)
    {
        Debug.Log(message);
    }
}
