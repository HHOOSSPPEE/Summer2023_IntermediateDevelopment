using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tentacles : MonoBehaviour
{
    public int length;
    public LineRenderer lineRend;
    public Vector3[] segmentPoses;
    private Vector3[] segment_velocity;



    public Transform TargetDir;
    public float targetDist;
    public float smoothSpeed;
    public float trailspeed;

    public float wiggle_speed;
    public float wiggle_magnitude;
    public Transform wiggleDir;


    // Start is called before the first frame update
    private void Start()
    {
        lineRend.positionCount = length;
        segmentPoses = new Vector3[length];
        segment_velocity = new Vector3[length];
    }

    // Update is called once per frame
    private void Update()
    {

        wiggleDir.localRotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time * wiggle_speed) * wiggle_magnitude);
        
        segmentPoses[0] = TargetDir.position;

        for(int i = 1; i < segmentPoses.Length; i++)
        {
            segmentPoses[i] = Vector3.SmoothDamp(segmentPoses[i], segmentPoses[i - 1] + TargetDir.right * targetDist, ref segment_velocity[i], smoothSpeed+i/trailspeed);
        }
        lineRend.SetPositions(segmentPoses);
    }
}
