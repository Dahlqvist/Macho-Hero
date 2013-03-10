using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public Rigidbody bulletTemplate;
    public Vector3 aimDirection;
    public float speed;
    public float bulletForce = 4;
    public int fireRate = 5;
    public LineRenderer aimRenderer;

    private float bulletTimer;
    private NavMeshAgent agent;

    private void Awake()
    {
        aimRenderer = GetComponent<LineRenderer>();
        bulletTimer = -1;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (bulletTimer > 0)
            bulletTimer -= Time.deltaTime;

        Camera cam = Camera.main;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 500, Color.yellow);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, cam.farClipPlane))
        {
            
            Debug.DrawRay(hit.point, hit.normal, Color.yellow);
            aimDirection = hit.point + new Vector3(0,2,0) - transform.position;
            Debug.DrawRay(transform.position, aimDirection, Color.blue);

            aimRenderer.enabled = true;
            aimRenderer.SetPosition(0, transform.position);
            //aimRenderer.SetPosition(1, hit.point);
            aimRenderer.SetPosition(1, transform.position + aimDirection);

            if (Input.GetMouseButton(0) && bulletTimer <= 0)
            //if (Input.GetMouseButton(0))
            {
                Rigidbody body = Instantiate(bulletTemplate, transform.position + aimDirection.normalized, Quaternion.LookRotation(aimDirection)) as Rigidbody;
                body.AddForce(aimDirection.normalized * bulletForce, ForceMode.Impulse);
                bulletTimer = 1 / (float)fireRate;
                audio.Play();
               
            }
        }
        else
        {
            aimRenderer.enabled = false;
        }
        //speed.z = (Input.GetAxis("Vertical"));
        //speed.x = (Input.GetAxis("Horizontal"));
        //transform.position += new Vector3(speed.x, 0, speed.z);
        //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
        if(Input.GetKey(KeyCode.W))
        {
            agent.destination = transform.position + aimDirection.normalized;
        }
        if (Input.GetKey(KeyCode.S))
        {
            agent.destination = transform.position - aimDirection.normalized;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 temp = aimDirection.normalized;
            float temp2 = temp.x;
            temp.x = -temp.z;
            temp.z   = temp2;
            agent.destination = transform.position + (temp);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Vector3 temp = aimDirection.normalized;
            float temp2 = temp.x;
            temp.x = -temp.z;
            temp.z = temp2;
            agent.destination = transform.position - (temp);
        }
    }
}