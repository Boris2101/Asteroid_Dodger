using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventMagager : MonoBehaviour
{
    
    public static event Action PickedUp;

    public static void OnPickedUp()
    {
        PickedUp?.Invoke();
    }
}
