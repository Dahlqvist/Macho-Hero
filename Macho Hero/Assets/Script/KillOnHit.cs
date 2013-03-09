using UnityEngine;
using System.Collections;

public class KillOnHit : MonoBehaviour {

  //  public Collider mCollision;

    private void Awake()
    {
       // mCollision = GetComponent<
    }

    private void OnCollisionEnter()
    {
        Debug.Log("Hit");
        Destroy(gameObject);
    }
}
