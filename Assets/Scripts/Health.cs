using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float healthMax;
    public float decay;
    public Slider slider;
    public bool destroyOnDeath = false;

    public float health { get; set; }

    void Start()
    {
        health = healthMax;
    }

    void Update()
    {
        AddHealth(-Time.deltaTime * decay);
        if (slider != null)
        {
            slider.value = health / healthMax;

        }

        if (health <= 0)
        {
            if (destroyOnDeath) GameObject.Destroy(gameObject);
        }
    }

    public void AddHealth(float amount)
    {
        this.health += amount;
        this.health = Mathf.Clamp(health, 0, healthMax);
    }
}
