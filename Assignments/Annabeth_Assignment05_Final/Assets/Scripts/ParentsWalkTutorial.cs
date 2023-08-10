using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentsWalkTutorial : MonoBehaviour
{
    public GameObject person;
    public bool isItMom;
    public Vector3 mom = new Vector3(-17, 6.28f, 0);
    public Vector3 dad = new Vector3(-16, 5.93f, 0);
    public float speed = 2f;

    private bool move;
    private bool collided;

    //public AudioSource audioSource;
    //public AudioClip clip;
    //public float volume = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        //move = false;
    }

    // Update is called once per frame
    void Update()
    {
        collided = ( GameObject.Find("Nick_T").GetComponent<Collisions>().collided || GameObject.Find("Rick_T").GetComponent<Collisions>().collided);

        if (Input.GetKey("space") && collided)
        {
            move = true;
            //if (!audioSource.isPlaying)
            //{
            //    audioSource.PlayOneShot(clip, volume);
            //}
        }
        if (move) {
            if (isItMom)
            {
                person.transform.position = Vector3.MoveTowards(person.transform.position, mom, speed * Time.deltaTime);
            }
            else
            {
                person.transform.position = Vector3.MoveTowards(person.transform.position, dad, speed * Time.deltaTime);
            }
           
        }
    }
}
