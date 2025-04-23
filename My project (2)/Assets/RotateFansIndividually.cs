using UnityEngine;

public class RotateFansIndividually : MonoBehaviour
{
    public float rotationSpeed = 200f;

    void Update()
    {
        foreach (Transform fan in transform)
        {
            fan.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
