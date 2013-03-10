using UnityEngine;
using System.Collections;

public class KillOnHit : MonoBehaviour {

    public GameObject unit;
    
    public string tag;

    private void Awake()
    {
        //mCollision = GetComponent<MeshCollider>();
        //GameObject go = GameObject.FindGameObjectWithTag("Killerworks");
        //killer = go.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.collider.tag.Equals(tag))
        {
            Debug.Log("Hit " + tag);
           // Debug.Log("Hit Enemy");
            if (unit != null)
            {
                GameObject SpawnLocation = (GameObject)Instantiate(unit, transform.position, Quaternion.identity);
               // audio.Play();
            }
             Destroy(gameObject);
        }
        
    }

}
