using UnityEngine;
using System.Collections;

public class MouseAim : MonoBehaviour {
    public Transform target;
    private Vector3 cursorPos;

    private void Awake()
    {
    }
	
	// Update is called once per frame
	private void Update () {
        transform.position = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
        
	}
}
