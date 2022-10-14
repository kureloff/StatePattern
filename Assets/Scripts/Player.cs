using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Dictionary<Type, IPlayerBehavior> _behaviorsMap;
    private IPlayerBehavior _behaviorCurrent;

    private void Start()
    {
        
    }

    private void InitBehaviors()
    {
        this._behaviorsMap = new Dictionary<Type, IPlayerBehavior>(); 

    }
}
