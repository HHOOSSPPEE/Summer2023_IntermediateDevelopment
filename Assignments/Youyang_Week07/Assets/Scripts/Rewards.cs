using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rewards : MonoBehaviour
{
    private GameObject _player;
    private PlayerController _playerController;

    public TextMeshProUGUI countText;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerController = _player.GetComponent<PlayerController>();

        SetCountText();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == _player)
        {
            _playerController.playerHealth += 1;
            Debug.Log(_playerController.playerHealth);

            SetCountText();

            /*if (_playerController.canTakeDamage == true)
            {
                StartCoroutine(DoDamage());
            }*/
        }
    }
    void SetCountText()
    {
        countText.text = "Score: " + _playerController.playerHealth.ToString();
    }

    /*IEnumerator DoDamage()
    {
        _playerController.canTakeDamage = false;
        _playerController.playerHealth -= 1;

        yield return new WaitForSeconds(1.5f);
        _playerController.canTakeDamage = true;
    }*/
}
