using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.U2D;

public class InputHandler : MonoBehaviour
{
    public AudioSource audioSource;
    private Camera _mainCamera;


    private void Awake()
    {
        //find the camera
        _mainCamera = Camera.main;
    }

    public void Onclick(InputAction.CallbackContext context)
    {
        //return nothing when click anything else
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(pos: (Vector3)Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;


        //if click a gameobject with sew invoke it's sew
        if (rayHit.collider.tag == "sew" && rayHit.collider.gameObject.GetComponent<sew>().isGrey == true)
        {
            rayHit.collider.gameObject.GetComponent<sew>().isGrey = false;

            audioSource.Play();
        }

        if (rayHit.collider.tag == "sew" && rayHit.collider.gameObject.GetComponent<BoxCollider2D>().isTrigger == false)
        {
            rayHit.collider.gameObject.GetComponent<sew>().isGrey = true;

            audioSource.Play();
        }

        //if click a gameobject with ice_sew invoke it's ice_sew
        if (rayHit.collider.tag == "ice_sew" && rayHit.collider.gameObject.GetComponent<ice_sew>().isGrey == true)
        {
            rayHit.collider.gameObject.GetComponent<ice_sew>().isGrey = false;

            audioSource.Play();
        }

        if (rayHit.collider.tag == "ice_sew" && rayHit.collider.gameObject.GetComponent<PolygonCollider2D>().isTrigger == false)
        {
            rayHit.collider.gameObject.GetComponent<ice_sew>().isGrey = true;

            audioSource.Play();
        }


    }
}


