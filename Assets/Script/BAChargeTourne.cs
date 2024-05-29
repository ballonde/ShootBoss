using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BAChargeTourne : MonoBehaviour
{
    public List<Transform> listSphere = new List<Transform>();
    public bool isActive = false;
    public Vector3 directionCharge;
    // Update is called once per frame
    void Update()
    {
        if(isActive)
        {
            foreach (Transform t in listSphere)
            {
                t.RotateAround(transform.position, Vector3.up, -400 * Time.deltaTime);
            }
            transform.position = transform.position + directionCharge * 300 * Time.deltaTime;
        }
    }

    public void StartCharge(Transform transformPlayer)
    {
        foreach (Transform t in listSphere)
        {
            t.RotateAround(transform.position, Vector3.up, -400 * Time.deltaTime);
        }
        directionCharge=(transformPlayer.position-transform.position).normalized;

        transform.position = new Vector3(transform.position.x,transformPlayer.position.y+20,transform.position.z);
        transform.LookAt(transformPlayer);
        //isActive = true;
    }
}
