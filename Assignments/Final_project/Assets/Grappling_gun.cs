using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappling_gun : MonoBehaviour
{

    public AudioSource sound_player;

    public AudioSource sound_player2;
    public AudioClip clip;
    public AudioClip clip2;
    private Vector2 mouse_position_up;
    private Vector2 mouse_position_down;
    public float time_set_new_hook = 0;
    public bool time_is_running = false;
    public float random_angle_y = 0f;
    public float random_angle_x = 0f;
    [Header("Scripts Ref:")]
        public Grappling_Rope grappleRope;

        [Header("Layers Settings:")]
        [SerializeField] private bool grappleToAll = false;
        [SerializeField] private int grappableLayerNumber = 0;

        [Header("Main Camera:")]
        public Camera m_camera;

        [Header("Transform Ref:")]
        public Transform gunHolder;
        public Transform gunPivot;
        public Transform firePoint;

        [Header("Physics Ref:")]
        public SpringJoint2D m_springJoint2D;
        public Rigidbody2D m_rigidbody;

        [Header("Rotation:")]
        [SerializeField] private bool rotateOverTime = true;
        [Range(0, 60)] [SerializeField] private float rotationSpeed = 4;

        [Header("Distance:")]
        [SerializeField] private bool hasMaxDistance = false;
        [SerializeField] private float maxDistnace = 20;

        private enum LaunchType
        {
            Transform_Launch,
            Physics_Launch
        }

        [Header("Launching:")]
        [SerializeField] private bool launchToPoint = true;
        [SerializeField] private LaunchType launchType = LaunchType.Physics_Launch;
        [SerializeField] private float launchSpeed = 1;

        [Header("No Launch To Point")]
        [SerializeField] private bool autoConfigureDistance = false;
        [SerializeField] private float targetDistance = 3;
        [SerializeField] private float targetFrequncy = 1;

        [HideInInspector] public Vector2 grapplePoint;
        [HideInInspector] public Vector2 grappleDistanceVector;

        private void Start()
        {
  
            grappleRope.enabled = false;
            m_springJoint2D.enabled = false;
            

        }

        private void Update()
        {


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SetGrapplePoint();
            if (grappleRope.enabled = true)
            {
                sound_player2.PlayOneShot(clip2);
                random_angle_x = Random.Range(-1, 1);
                random_angle_y = Random.Range(-1, 1);
                grappleRope.enabled = false;
                m_springJoint2D.enabled = false;
                grappleRope.enabled = true;
                m_springJoint2D.enabled = true;
                time_set_new_hook = Random.Range(0, 1f);

            }
            else
            {
                sound_player2.PlayOneShot(clip2);
                random_angle_x = Random.Range(-1, 1);
                random_angle_y = Random.Range(-1, 1);
                grappleRope.enabled = true;
                m_springJoint2D.enabled = true;
                time_set_new_hook = Random.Range(0, 1f);

            }
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {


            if (time_set_new_hook >= 0)
            {
                time_set_new_hook -= Time.deltaTime;

            }
            if (time_set_new_hook <= 0)
            {

                if (grappleRope.enabled = true)
                {
                    sound_player.PlayOneShot(clip);
                    random_angle_x = Random.Range(-1, 1);
                    random_angle_y = Random.Range(-1, 1);
                    grappleRope.enabled = false;
                    m_springJoint2D.enabled = false;
                    time_set_new_hook = Random.Range(0, 1f);
                    SetGrapplePoint();
                }
                else
                {
                    sound_player.PlayOneShot(clip);
                    random_angle_x = Random.Range(-1, 1);
                    random_angle_y = Random.Range(-1, 1);
                    grappleRope.enabled = false;
                    m_springJoint2D.enabled = false;
                    time_set_new_hook = Random.Range(0, 1f);
                    SetGrapplePoint();
                }
            









            if (grappleRope.enabled)
                     {
                    // RotateGun(grapplePoint, false);
                    Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
                    RotateGun(mousePos, true);
                     }
                      else
                      {
                    Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
                    RotateGun(mousePos, true);
                     }

                        if (launchToPoint && grappleRope.isGrappling)
                     {
                           if (launchType == LaunchType.Transform_Launch)
                           {
                        Vector2 firePointDistnace = firePoint.position - gunHolder.localPosition;
                        Vector2 targetPos = grapplePoint - firePointDistnace;
                        gunHolder.position = Vector2.Lerp(gunHolder.position, targetPos, Time.deltaTime * launchSpeed);
                            }
                     }
                }
            }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            //grappleRope.enabled = false;
            //m_springJoint2D.enabled = false;
            //m_rigidbody.gravityScale = 1;
    
        }
        else
        {
            Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            RotateGun(mousePos, true);

        }
        }

        void RotateGun(Vector3 lookPoint, bool allowRotationOverTime)
        {
            Vector3 distanceVector = lookPoint - gunPivot.position;
            
            float angle = Mathf.Atan2(distanceVector.y + random_angle_y , distanceVector.x + random_angle_x) * Mathf.Rad2Deg;
            if (rotateOverTime && allowRotationOverTime)
            {
                gunPivot.rotation = Quaternion.Lerp(gunPivot.rotation, Quaternion.AngleAxis(angle, Vector3.forward), Time.deltaTime * rotationSpeed);
            }
            else
            {
                gunPivot.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }

        void SetGrapplePoint()
        {
        mouse_position_down = new Vector2(Input.mousePosition.x, Input.mousePosition.y - 60);
        Vector2 distanceVector3 = m_camera.ScreenToWorldPoint(mouse_position_down) - gunPivot.position;
        mouse_position_up = new Vector2(Input.mousePosition.x, Input.mousePosition.y + 60);
        Vector2 distanceVector2 = m_camera.ScreenToWorldPoint(mouse_position_up) - gunPivot.position;
        Vector2 distanceVector = m_camera.ScreenToWorldPoint(Input.mousePosition) - gunPivot.position;
        if (Physics2D.Raycast(firePoint.position, distanceVector.normalized))
            {
                RaycastHit2D _hit = Physics2D.Raycast(firePoint.position, distanceVector.normalized);
                if (_hit.transform.gameObject.layer == grappableLayerNumber || grappleToAll)
                {
                    if (Vector2.Distance(_hit.point, firePoint.position) <= maxDistnace || !hasMaxDistance)
                    {
                        grapplePoint = _hit.point;
                        grappleDistanceVector = grapplePoint - (Vector2)gunPivot.position;
                        grappleRope.enabled = true;
                    }
  
                
                }
            }
        else if (Physics2D.Raycast(firePoint.position, distanceVector2.normalized))
        {
            RaycastHit2D _hit = Physics2D.Raycast(firePoint.position, distanceVector2.normalized);
            if (_hit.transform.gameObject.layer == grappableLayerNumber || grappleToAll)
            {
                if (Vector2.Distance(_hit.point, firePoint.position) <= maxDistnace || !hasMaxDistance)
                {
                    grapplePoint = _hit.point;
                    grappleDistanceVector = grapplePoint - (Vector2)gunPivot.position;
                    grappleRope.enabled = true;
                }


            }
        }
        else if (Physics2D.Raycast(firePoint.position, distanceVector3.normalized))
        {
            RaycastHit2D _hit = Physics2D.Raycast(firePoint.position, distanceVector3.normalized);
            if (_hit.transform.gameObject.layer == grappableLayerNumber || grappleToAll)
            {
                if (Vector2.Distance(_hit.point, firePoint.position) <= maxDistnace || !hasMaxDistance)
                {
                    grapplePoint = _hit.point;
                    grappleDistanceVector = grapplePoint - (Vector2)gunPivot.position;
                    grappleRope.enabled = true;
                }


            }
        }

    }

        public void Grapple()
        {
            m_springJoint2D.autoConfigureDistance = false;
            if (!launchToPoint && !autoConfigureDistance)
            {
                m_springJoint2D.distance = targetDistance;
                m_springJoint2D.frequency = targetFrequncy;
            }
            if (!launchToPoint)
            {
                if (autoConfigureDistance)
                {
                    m_springJoint2D.autoConfigureDistance = true;
                    m_springJoint2D.frequency = 0;
                }

                m_springJoint2D.connectedAnchor = grapplePoint;
                m_springJoint2D.enabled = true;
            }
            else
            {
                switch (launchType)
                {
                    case LaunchType.Physics_Launch:
                        m_springJoint2D.connectedAnchor = grapplePoint;

                        Vector2 distanceVector = firePoint.position - gunHolder.position;

                        m_springJoint2D.distance = distanceVector.magnitude;
                        m_springJoint2D.frequency = launchSpeed;
                        m_springJoint2D.enabled = true;
                        break;
                    case LaunchType.Transform_Launch:
                        m_rigidbody.gravityScale = 0;
                        m_rigidbody.velocity = Vector2.zero;
                        break;
                }
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (firePoint != null && hasMaxDistance)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(firePoint.position, maxDistnace);
            }
        }

    

}
