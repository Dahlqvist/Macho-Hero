using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public Transform target;
    public Vector3 distance;
    public float speed;

    private void Awake()
    {
        camera.depthTextureMode = DepthTextureMode.Depth;
    }

    private void Start()
    {
        transform.position = target.position + distance;
        transform.LookAt(target.position);
    }

    public static float Integrate(float src, float dst, float speed, float time)
    {
        float alpha = 1.0f - Mathf.Pow(1.0f - speed, time);
        float newVal = src + (dst - src) * alpha;
        return newVal;
    }

    public static Vector3 Integrate(Vector3 src, Vector3 dst, float speed, float time)
    {
        return new Vector3(Integrate(src.x, dst.x, speed, time), Integrate(src.y, dst.y, speed, time), Integrate(src.z, dst.z, speed, time));
    }

    private void LateUpdate()
    {
        transform.position = Integrate(transform.position, target.position + distance, speed, Time.deltaTime);
    }
}
