using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideRotManager : MonoBehaviour
{

    public Scrollbar scroll;

    public bool isInRight = true;

    public void OnClick()
    {
        if (scroll)
        {
            if (scroll.value >= .9)
            {
                if (isInRight)
                    customGravity.RS_inc++;
                else
                    customGravity.LS_inc++;
                scroll.value = 0;
            }
            else if (scroll.value <= .1)
            {
                if (isInRight)
                    customGravity.RS_inc++;
                else
                    customGravity.LS_inc++;

                scroll.value = 1;
            }
        }
    }

    public void test ()
    {
        customGravity.RS_inc++;
    }
}
