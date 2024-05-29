using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public Slider sliderBarHealth;
    public float maxHealth=1000;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(sliderBarHealth.value!=(health/10)) {
            sliderBarHealth.value = (health / 10);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
