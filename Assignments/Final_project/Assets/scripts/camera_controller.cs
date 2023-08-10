using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{

    

        public Transform target;
         public float damping;
        public Vector3 offset;

        private Vector3 _velocity = Vector3.zero;
        //public PlayerController player;






    void FixedUpdate()
    {
        Vector3 movePosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref _velocity, damping);
    }

}
