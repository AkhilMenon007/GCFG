﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GCFG
{
    [CreateAssetMenu(menuName = "Events/CraftEvent")]
    public class CraftEvent : ScriptableGameEvent
    {
        public void InvokeWithCraftRecipe(CraftRecipe recipe) 
        {
            Invoke(recipe);
        }
    }
}