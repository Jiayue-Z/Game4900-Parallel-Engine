using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attacking : MonoBehaviour
{
    private AttackAction input;
    private bool attackHeld;

    private void Awake() => input = new AttackAction();

    private void OnEnable()
    {
        input.Action.Enable();
        input.Action.Attack.performed += AttackPressed;
        input.Action.Attack.started += _ => attackHeld = true;
    }

    private void OnDisable()
    {
        input.Action.Attack.performed -= AttackPressed;
        input.Action.Disable();
    }


    private void AttackPressed(InputAction.CallbackContext _) => Debug.Log("Attack!!");

}
