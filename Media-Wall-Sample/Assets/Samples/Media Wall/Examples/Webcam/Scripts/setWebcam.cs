using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setWebcam : MonoBehaviour
{
    public void SetWebcam(int i)
    {
        WebcamManager.Instance.deviceIndex = (ushort)i;
    }
}
