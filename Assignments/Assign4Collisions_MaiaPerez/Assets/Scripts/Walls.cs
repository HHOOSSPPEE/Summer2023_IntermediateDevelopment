using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    private GameObject _player;
    private PlayerController _playerController;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerController = _player.GetComponent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == _player)
        {
            //Debug.Log("There's the Player!!");
            if(_playerController.canTakeDamage == true)
            {
                StartCoroutine(DoDamage());
            }
        }
    }

    IEnumerator DoDamage()
    {
        _playerController.canTakeDamage = false;
        _playerController.playerHealth -= 1;

        yield return new WaitForSeconds(2.5f);

        _playerController.canTakeDamage = true;
    }
}
