using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    Animator anim;
    GameManager gameControllerScript;
    public GameObject[] overLays;
    GameObject player;
    GameObject playerToPoint;
    bool isOpen;
    bool isEntering;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        gameControllerScript = FindObjectOfType<GameManager>();
        player = FindObjectOfType<PlayerMove>().gameObject;
        foreach (Transform child in transform)
        {
            if (child.gameObject.name == "PlayerToPoint")
            {
                playerToPoint = child.gameObject;
            }
        }

        isOpen = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (gameControllerScript.hasGoldenKey == true && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Level 1 completed");
            anim.Play("doorOpens");
            player.transform.position = new Vector2(Mathf.Lerp(player.transform.position.x, playerToPoint.transform.position.x, 3),
                Mathf.Lerp(player.transform.position.y, playerToPoint.transform.position.y, 3));
            PlayerMove playerMoveScript = player.GetComponent<PlayerMove>();
            playerMoveScript.hasControl = false;

            isOpen = true;
            for (int i = 0; i < overLays.Length; i++)
            {
                overLays[i].SetActive(false);
            }


        }
    }

    private void Update()
    {
        bool AnimatorIsPlaying()
        {
            return anim.GetCurrentAnimatorStateInfo(0).length >
                   anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
        }
        if (!AnimatorIsPlaying() && isOpen)
        {
            anim.Play("playerEnters");
            isEntering = true;
        }
        if (!AnimatorIsPlaying() && isEntering)
        {
            gameControllerScript.LoadNextLevel();
        }
    }
}
