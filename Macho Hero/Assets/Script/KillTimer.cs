using UnityEngine;
using System.Collections;

public class KillTimer : MonoBehaviour 
{
    public float time = 5;
	
	private void Update() 
    {
        time -= Time.deltaTime;
        if (time <= 0)
            Destroy(gameObject);
	}
}
