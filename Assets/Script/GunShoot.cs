using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public Camera cameraP;
    private GameObject vfx;
    public GameObject effectToSpawn;
    public PlayerMovement playerMove;
    public Transform positionShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




    }
    public void Shoot()
    {
        Ray ray = cameraP.ScreenPointToRay(Input.mousePosition);
        bool cast = Physics.Raycast(ray, out RaycastHit hit, 3000);
        Vector3 hitPosition = hit.point;
        //Vector3 hitPosition = cast ? hit.point : transform.position + (-transform.up) * 300;

        if (cast)
        {
            vfx = Instantiate(effectToSpawn, positionShoot.position, Quaternion.identity);
            vfx.transform.rotation = playerMove.transform.rotation;

            vfx.transform.localScale = vfx.transform.localScale * 3;
            vfx.GetComponent<BulletMovement>().direction = hitPosition - positionShoot.position;
            // Do something with the object that was hit by the raycast.
        }
    }
}
