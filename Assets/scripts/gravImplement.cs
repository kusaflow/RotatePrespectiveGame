using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravImplement : MonoBehaviour
{

    public Rigidbody m_rb;
    public float gravMul = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 gravity = new Vector3(customGravity.xG * gravMul, customGravity.yG * gravMul, 0);
        m_rb.AddForce(gravity, ForceMode.Acceleration);
    }
}
