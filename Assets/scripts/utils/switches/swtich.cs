using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swtich : MonoBehaviour
{
    public List<door> doorList;

    public float timer = 0; 

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
            timer -= 1 * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && timer <= 0)
        {
            for (int i =0; i<doorList.Count; i++)
            {
                doorList[i].toggleGate();
                timer = 6;
            }
        }
    }
}
