using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    bool doorState = false;

    Vector3 orgSize;

    bool doToogle = false;
    float toggleTime = 0;

    public float toggleAt = 5;

    public bool scaleInX = false;
    public bool scaleInY = false;

    public float scaleLimit = 0;

    // Start is called before the first frame update
    void Start()
    {
        orgSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp;
        if (doorState)
        {
            temp = transform.localScale;
            if (temp.x > scaleLimit && scaleInX)
                temp.x -= 1 * Time.deltaTime;
            if (temp.y > scaleLimit && scaleInY)
                temp.y -= 1 * Time.deltaTime;
            
            transform.localScale = temp;
        }
        else
        { 
            temp = transform.localScale;
            if (temp.x < orgSize.x && scaleInX)
                temp.x += 1 * Time.deltaTime;
            if (temp.y < orgSize.y && scaleInY)
                temp.y += 1 * Time.deltaTime;
            
            transform.localScale = temp;
        }

        if (doToogle)
        {
            if (toggleTime >= toggleAt)
            {
                toggleTime = 0;
                doToogle = false;
                doorState = !doorState;
            }
            else
            {
                toggleTime += 1 * Time.deltaTime;
            }
        }
    }

    public void toggleGate ()
    {
        doToogle = true;
        toggleTime = 0;
        doorState = !doorState;
    }

}
