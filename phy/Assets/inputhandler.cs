using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.U2D;

public class inputhandler : MonoBehaviour
{
    private Camera _mainCamera;
    

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void Onclick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(pos: (Vector3)Mouse.current.position.ReadValue()));
        if(!rayHit.collider) return;


        if (rayHit.collider.tag == "sew" && rayHit.collider.gameObject.GetComponent<sew>().isGrey == true)
        {
           rayHit.collider.gameObject.GetComponent<sew>().isGrey = false;

            
        }

        if (rayHit.collider.tag == "sew" && rayHit.collider.gameObject.GetComponent<BoxCollider2D>().isTrigger == false)
        {
            rayHit.collider.gameObject.GetComponent<sew>().isGrey = true;


        }

        
    }
}
