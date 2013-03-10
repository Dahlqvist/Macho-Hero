using UnityEngine;
using System.Collections;

public class CameraCenterUpdater : MonoBehaviour 
{
    public CameraController cam;
    private void Awake()
    {
        GameObject a = new GameObject("Hello");
        a.transform.position = Vector3.up * 100;
        a.AddComponent<Light>();

        cam.target = a.transform;
    }
}
