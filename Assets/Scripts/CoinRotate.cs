using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotateSpeed = 1;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
