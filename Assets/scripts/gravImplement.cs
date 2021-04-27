using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravImplement : MonoBehaviour
{

    public Rigidbody m_rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 gravity = new Vector3(customGravity.xG, customGravity.yG, 0);
        m_rb.AddForce(gravity, ForceMode.Acceleration);
    }
}
