using UnityEngine;
using System.Collections;



public class PlayerSpareParts : MonoBehaviour {

    public string tag;
    private int spareParts;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(spareParts >= 5)
        {
            Application.LoadLevel("Menu");
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals(tag))
        {
            Debug.Log("SparePart");
            spareParts += 1;
        }
    }
}
