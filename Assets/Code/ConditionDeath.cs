using Code;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ConditionDeath : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        CharacterPlayer();
        OrientationPlayer();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    //параметры
    public int hp;

    //действия
    private void CharacterPlayer()
    {
        bool isDeath;
        if (hp > 0)
        {
            for (int i = hp; i >= 0; i--)
            {
                if (i == 0)
                {
                    isDeath = true;
                }
                else
                {
                    isDeath = false;
                }
                Debug.LogError(isDeath);
            }
        }
        else
        {
            Debug.LogError("Ты специально?");
        }
    }

    // ориентация персонажа = OrientationPlayer, цвет персонажа = ColorPlayer - задаем программно
    // ColorPlayer = Green (серый цвет по умолчанию) - задаем в Юнити
    // Orientation может быть Enemy (Противником) или Friend (Союзником)
    // Если Orientation = Enemy, то ColorPlayer = Red
    // Если Orientation = Friend, то ColorPlayer = Blue

    //параметры
    public MeshRenderer Renderer;
    public void SetColor(Color color)
    {
        Renderer.material.color = color;
    }
    public bool Enemy;

    //дествия
    private void OrientationPlayer()
    {

        if (Enemy == true)
        {
            Renderer.material.color = Color.red;
        }
        else
        {
            Renderer.material.color = Color.blue;
        }
    }
}
