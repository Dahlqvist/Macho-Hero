using UnityEngine;
using System.Collections;

public class ShipLife : MonoBehaviour {
    public string tag;

    private int life;

    private void Awake()
    {
        life = 10;
    }
	// Update is called once per frame
	void Update () {
	    if(life <= 0)
        {
            Application.LoadLevel("Menu");
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals(tag))
        {
            Debug.Log("TakeLife");
            life -= 1;
        }
    }
}
