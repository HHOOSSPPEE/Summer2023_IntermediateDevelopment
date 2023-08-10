using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public static scene_manager instance;
    public GameObject image;
    public string sceneName;
    [SerializeField] Animator transition_anim;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextLevel()
    {
        StartCoroutine(Load_Level());
    }
    IEnumerator Load_Level()
    {

        transition_anim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        transition_anim.SetTrigger("start");

    }
}
