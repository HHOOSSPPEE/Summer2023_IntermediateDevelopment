using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineExample : MonoBehaviour
{
    private GameObject _player;
    private PlayerController _playerController;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerController = _player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == _player)//take damage
        {
            if (_playerController.canTakeDamage == true)
            {
                StartCoroutine(DamagePlayer());
            }

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == _player)//take damage
        {
            if (_playerController.canTakeDamage == true)
            {
                StartCoroutine(DamagePlayer());
            }

        }
    }



    IEnumerator DamagePlayer()
    {
        //things you want to happen when you do take damage
        _player.GetComponent<PlayerController>().playerHealth -= 1;

        yield return new WaitForSeconds(2f);
        //things to reset after buffer

        _playerController.canTakeDamage = true;
    }
}
