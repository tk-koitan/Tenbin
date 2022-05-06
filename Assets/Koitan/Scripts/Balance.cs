using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    [SerializeField]
    Transform leftPlateTf;
    [SerializeField]
    Transform rightPlateTf;
    [SerializeField]
    Transform armTf;
    [SerializeField]
    float angle;
    [SerializeField]
    Weight leftWeight;
    [SerializeField]
    Weight rightWeight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ws = leftWeight.GetWeigth() - rightWeight.GetWeigth();
        angle = Mathf.Lerp(angle, ws * 5, 0.01f);
        // äpìxçXêV
        armTf.rotation = Quaternion.Euler(0, 0, angle);
        leftPlateTf.rotation = Quaternion.Euler(0, 0, 0);
        rightPlateTf.rotation = Quaternion.Euler(0, 0, 0);
    }
}
