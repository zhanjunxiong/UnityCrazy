﻿using UnityEngine;
using System.Collections; 

namespace SLCGame.Unity
{
    public class U3DComponent : U3DObject
    {

        //protected CharacterLook mOwner;
        protected bool isInited = true;

        public virtual void Init()
        {
            isInited = false;
        }

        protected virtual void OnInited()
        {
            isInited = true;
        }

        public virtual void DestroyThisComponent()
        {
            U3DMod.Destroy(this);
        }


    }
}