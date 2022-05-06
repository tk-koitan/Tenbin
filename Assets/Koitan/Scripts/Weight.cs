using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KoitanLib;

public class Weight : MonoBehaviour
{
    float weight;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        KoitanDebug.Display($"èdó  = {weight}kg\n");
    }

    private void FixedUpdate()
    {
        weight = 0;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
        if (rb.velocity.magnitude < 2f)
        {
            weight += rb.mass;
        }
    }

    public float GetWeigth()
    {
        return weight;
    }
}
