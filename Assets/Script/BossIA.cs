using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIA : MonoBehaviour
{
    public BALaser atkLaser;
    public BAChargeTourne baCharge;
    public BASphereMine sphereMine;
    public BossHealth health;


    public Transform transformPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //transformPlayer=
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            atkLaser.StartLaser();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            baCharge.StartCharge(transformPlayer);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            sphereMine.Explosion();
        }
    }
}
