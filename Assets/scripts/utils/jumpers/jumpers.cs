using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        float Angle = transform.rotation.eulerAngles.z;
        float forceVal = 1000;

        float yG = Mathf.Cos(Mathf.Deg2Rad * Angle) * forceVal;
        float xG = Mathf.Sin(Mathf.Deg2Rad * Angle) * forceVal * -1;

        Vector3 finalF = new Vector3(xG, yG, 0);

        if (collision.rigidbody)
        {
            Debug.Log(Angle);
            collision.rigidbody.AddForce(finalF, ForceMode.Acceleration);
        }
    }

}
