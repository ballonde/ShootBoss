using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBossFight : MonoBehaviour
{
    public GameObject bossTrigger;
    public Canvas bossCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bossTrigger.GetComponent<BossIA>().transformPlayer = other.transform;
            bossCanvas.gameObject.SetActive(true);
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
