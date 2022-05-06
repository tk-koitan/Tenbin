using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    [SerializeField]
    Transform armTf;
    float weight;
    [SerializeField]
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        JointAngleLimits2D limit = new JointAngleLimits2D();
        float z = armTf.eulerAngles.z;
        if (z > 180f)
        {
            z -= 360f;
        }
        limit.max = z;
        limit.min = z;
        hj.limits = limit;
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
