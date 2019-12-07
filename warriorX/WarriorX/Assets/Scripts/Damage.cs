using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public static bool IsBlockingPlayerOne { get; set; }
    public static bool IsBlockingPlayerTwo { get; set; }

    private static float TakeBlockDamagePlayerOne(Slider slider)
    {
        slider.value = PlayerOne.Health;
        return PlayerOne.Health;
    }

    private static float TakeNormalDamagePlayerOne(Slider slider)
    {
        slider.value = PlayerOne.Health--;
        return PlayerOne.Health;
    }

    private static float TakeStrongDamagePlayerOne(Slider slider)
    {
        slider.value = PlayerOne.Health -= 2;
        return PlayerOne.Health;
    }

    private static float TakeBlockDamagePlayerTwo(Slider slider)
    {
        slider.value = PlayerTwo.Health;
        return PlayerTwo.Health;
    }

    private static float TakeNormalDamagePlayerTwo(Slider slider)
    {
        slider.value = PlayerTwo.Health--;
        return PlayerTwo.Health;
    }

    private static float TakeStrongDamagePlayerTwo(Slider slider)
    {
        slider.value = PlayerTwo.Health -= 2;
        return PlayerTwo.Health;
    }

    public static void TakeDamagePlayerOne(Slider slider)
    {
        if (Input.GetKey(KeyCode.S))
        {
            IsBlockingPlayerOne = true;
            TakeBlockDamagePlayerOne(slider);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) && IsBlockingPlayerOne == false)
        {
            TakeNormalDamagePlayerOne(slider);
        }

        if (Input.GetKeyDown(KeyCode.Keypad0) && IsBlockingPlayerOne == false)
        {
            TakeStrongDamagePlayerOne(slider);
        }

        else
        {
            IsBlockingPlayerOne = false;
        }
    }

    public static void TakeDamagePlayerTwo(Slider slider)
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            IsBlockingPlayerTwo = true;
            TakeBlockDamagePlayerTwo(slider);
        }

        if (Input.GetKeyDown(KeyCode.Z) && IsBlockingPlayerTwo == false)
        {
            TakeNormalDamagePlayerTwo(slider);
        }

        if (Input.GetKeyDown(KeyCode.X) && IsBlockingPlayerTwo == false)
        {
            TakeStrongDamagePlayerTwo(slider);
        }

        else
        {
            IsBlockingPlayerTwo = false;
        }
    }
}
