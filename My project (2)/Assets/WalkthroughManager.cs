using UnityEngine;

public class WalkthroughStarter : MonoBehaviour
{
    public Transform walkthroughStartPoint;
    public GameObject xrRig;

    public void StartWalkthrough()
    {
        xrRig.transform.position = walkthroughStartPoint.position;
        xrRig.transform.rotation = walkthroughStartPoint.rotation;
    }
}

