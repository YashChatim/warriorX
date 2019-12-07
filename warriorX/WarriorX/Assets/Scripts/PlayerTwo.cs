using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwo : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public Slider playerTwoHealthBar;
    public Slider playerTwoSpecialAbilityBar;

    public static int Health { get; set; }
    public static int SpecialAbilityBar { get; set; }

    // Start is called before the first frame update
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Movement.isFacingLeft = true;

        Health = 100;
        SpecialAbilityBar = 0;

        playerTwoHealthBar.value = Health;
        playerTwoSpecialAbilityBar.value = SpecialAbilityBar;
    }

    // Update is called once per frame
    private void Update()
    {
        Movement.MoveHorizontalPlayerTwo(rigidBody, transform);
        Movement.JumpPlayerTwo(rigidBody);
        Movement.CheckBounds(transform);

        Damage.TakeDamagePlayerTwo(playerTwoHealthBar);
        SpecialAbility.IncreaseSpecialAbilityPlayerTwo(playerTwoSpecialAbilityBar);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collision.CollidingWithPlatform(collision, "platform");
        Collision.CollidingWithPlayer(collision, "playerOne");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "platform")
        {
            Movement.isGrounded = false;
        }

        if (collision.gameObject.name == "playerOne")
        {
            print("PlayerTwo not collides with PlayerOne");
        }
    }
}
