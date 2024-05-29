using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speedBullet=300f;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+(direction.normalized * speedBullet * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("toouch");
        if (other.GetComponent<BossHealth>())
        {
            other.GetComponent<BossHealth>().TakeDamage(30);
        }
        Destroy(gameObject);
    }
}
