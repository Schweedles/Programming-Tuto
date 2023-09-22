using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inputmanager
{
    private static Controls _controls; 

    public static void Initialise(Player meFr)
    {
        _controls = new Controls();
        
        _controls.Game.Movement.performed += ctx => 
        {
            meFr.SetMovementDirection(ctx.ReadValue<Vector3>()); 
        };

        _controls.ALLTHETIME.Enable(); 

    }

    public static void Gamemode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UImode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();
    }
}
