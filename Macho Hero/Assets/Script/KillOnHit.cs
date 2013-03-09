using UnityEngine;
using System.Collections;

public class KillOnHit : MonoBehaviour {

    //public MeshCollider mCollision;

    private void Awake()
    {
        //mCollision = GetComponent<MeshCollider>();
    }

    private void OnCollisionEnter()
    {
        Debug.Log("Hit");
        Destroy(gameObject);
    }
}
