﻿using UnityEngine;

public class PlayerCollisionController : CollisionController
{
    private const string m_ACTIONFIELD_INTERACTABLE =   "Intaractable";

    private const string m_OBJECT_ASSISTANT =            "Assistant";
    private const string m_OBJECT_WEAPON =               "Weapon";
    private const string m_OBJECT_ENEMY =                "Enemy";

    public override void HandleCollistion(Collider other)
    {
        string tag = other.tag;
        switch (tag)
        {
            case m_ACTIONFIELD_INTERACTABLE:
                other.GetComponent<iInteractable>().Interact();
                break;
            case m_OBJECT_ASSISTANT:
                AssistantController assistant = other.GetComponent<AssistantController>();   
                if (GameManager.Instance.GameState.Player.AddAssistant(assistant))
                    assistant.Interact();
                break;
            case m_OBJECT_WEAPON:
                Item_Base weapon = other.GetComponent<Item_Base>();
                if (GameManager.Instance.GameState.Player.AddWeapon(weapon))
                    weapon.Interact();
                break;
            case m_OBJECT_ENEMY:
                GetComponent<PlayerController>().DestroyPlayer(); 
                other.GetComponent<EnemyController>().TakeDamage(transform);
                break;
        }
    }
}
