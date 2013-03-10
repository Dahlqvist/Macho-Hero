using UnityEngine;
using System.Collections;


public class KillTimer : MonoBehaviour 
{

    public AudioClip sound;
    public GameObject particle;

    public float time = 5;

    private void Awake()
    {
        if (sound != null)
        {
            audio.Play();
        }
       

    }

	private void Update() 
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            if (particle != null)
            {
                GameObject SpawnLocation = (GameObject)Instantiate(particle, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
           
	}
}
