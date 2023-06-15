using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour
{
    public CameraController Cc;
    public Animator playerAnimator;
    void Update()
    {
        Debug.Log(Cc.directionVertical);
        if(Cc.directionVertical == true)
        {
            playerAnimator.SetBool("Direction", false);
        }
        else
        {
            playerAnimator.SetBool("Direction", true);
        }
    }
}
