using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicMan : MonoBehaviour
{

    public static musicMan musManInstance;
    [SerializeField] public AudioSource snBase;
    [SerializeField] public AudioSource snFrogger;
    [SerializeField] public AudioSource snCatter;
    [SerializeField] public AudioSource snPander;
    [SerializeField] public AudioSource snClick;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (musManInstance == null)
        {
            musManInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
