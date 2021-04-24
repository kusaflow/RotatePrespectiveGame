using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customGravity : MonoBehaviour
{

    public static float gravVal = -9.81f;
    public static float camZRot = 0;
    public Rigidbody m_rb;

    public Scrollbar scroll_R;
    public Scrollbar scroll_L;

    public static float xG = 0;
    public static float yG = 0;

    void FixedUpdate()
    {
        camZRot = 180 * scroll_R.value + 180 * scroll_L.value;

        Debug.Log(camZRot);
        Vector3 gravity = new Vector3(0, gravVal);
        m_rb.AddForce(gravity, ForceMode.Acceleration);
    }
}
