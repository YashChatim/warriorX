using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOne : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public Slider playerOneHealthBar;
    public Slider playerOneSpecialAbilityBar;
    
    public static int Health { get; set; }
    public static int SpecialAbilityBar { get; set; }

    // Start is called before the first frame update
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Movement.isFacingRight = true;

        Health = 100;
        SpecialAbilityBar = 0;

        playerOneHealthBar.value = Health;
        playerOneSpecialAbilityBar.value = SpecialAbilityBar;
    }

    // Update is called once per frame
    private void Update()
    {
        Movement.MoveHorizontalPlayerOne(rigidBody, transform);
        Movement.JumpPlayerOne(rigidBody);
        Movement.CheckBounds(transform);

        Damage.TakeDamagePlayerOne(playerOneHealthBar);
        SpecialAbility.IncreaseSpecialAbilityPlayerOne(playerOneSpecialAbilityBar);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collision.CollidingWithPlatform(collision, "platform");
        Collision.CollidingWithPlayer(collision, "playerTwo");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "platform")
        {
            Movement.isGrounded = false;
        }

        if (collision.gameObject.name == "playerTwo")
        {
            print("PlayerOne not collides with PlayerTwo");
            
        }
    }
}
