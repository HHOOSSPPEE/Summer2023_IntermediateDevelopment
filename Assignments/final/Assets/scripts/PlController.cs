using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlController : MonoBehaviour
{
    public float moveSpeed;

    public int energy;
    public TextMeshProUGUI energyUI;

    private bool isMoving;

    private Vector2 input;

    private Animator animator;

    private bool keyDown;
    private bool cantMove;

    public GameObject camera;
    
    public LayerMask solidObjectsLayer;
    public LayerMask interactablesLayer;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        keyDown = false;
        energy = 20;
        energyUI.text = "ENERGY: " + energy;
    }

    private void Update()
    {
        if (!DialogueManager.GetInstance().dialogueIsPlaying && !cantMove)
        {
            if (!isMoving)
            {
                input.x = Input.GetAxisRaw("Horizontal");
                input.y = Input.GetAxisRaw("Vertical");

                if (input.x != 0) input.y = 0;

                if (input != Vector2.zero)
                {
                    if (!keyDown)
                    {
                        var targetPos = transform.position;
                        targetPos.x += input.x;
                        targetPos.y += input.y;

                        if (IsWalkable(targetPos))
                        {
                            StartCoroutine(Move(targetPos));
                        }
                        else
                        {
                            keyDown = true;
                            if (Physics2D.OverlapCircle(targetPos, 0.2f, interactablesLayer) != null)
                            {
                                GameObject NPC = Physics2D.OverlapCircle(targetPos, 0.2f, interactablesLayer).gameObject;
                                TextAsset convo = NPC.GetComponent<DialTrigger>().inkJSON;
                                DialogueManager.GetInstance().EnterDialogueMode(convo);
                            }
                        }
                    }
                }
                else
                {
                    keyDown = false;
                }
            }
        }

        animator.SetBool("isMoving", isMoving);
        Vector3 coords = transform.position;

        coords.x = transform.position.x;
        coords.y = transform.position.y;
        coords.z = -5;
        camera.transform.position = coords;
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
        energy--;
        energyUI.text = "ENERGY: " + energy;
        if (energy < 1)
        {
            cantMove = true;
            transform.Rotate(0, 0, -90);
            animator.speed = 0;
            StartCoroutine(Restart());
        }
    }

    private bool IsWalkable(Vector3 targetPos)
    {
        if(Physics2D.OverlapCircle(targetPos,0.2f,solidObjectsLayer | interactablesLayer) != null)
        {
            return false;
        }

        return true;
    }

    private IEnumerator Restart()
    {
        yield return new WaitForSeconds(.8f);

        SceneManager.LoadScene("Game");
    }

}
