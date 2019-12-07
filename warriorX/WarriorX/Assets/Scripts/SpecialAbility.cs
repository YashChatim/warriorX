using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class SpecialAbility
{
    private static float SpecialAbilityPlayerOne(Slider slider)
    {
        slider.value = PlayerOne.SpecialAbilityBar += 5;
        return PlayerOne.SpecialAbilityBar;
    }

    private static float SpecialAbilityPlayerTwo(Slider slider)
    {
        slider.value = PlayerTwo.SpecialAbilityBar += 5;
        return PlayerTwo.SpecialAbilityBar;
    }

    public static void IncreaseSpecialAbilityPlayerOne(Slider slider)
    {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
        {
            SpecialAbilityPlayerOne(slider);
        }
    }

    public static void IncreaseSpecialAbilityPlayerTwo(Slider slider)
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            SpecialAbilityPlayerTwo(slider);
        }
    }
}
