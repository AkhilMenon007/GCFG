﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gopal
{
    [CreateAssetMenu(menuName ="ProjectileWeapon")]
    public class ProjectileData : WeaponData
    {
        public GameObject model;
        public int damage;
        public int range;
        public int reloadTime;
        public Bullet bullet;

        public override void EquipWeapon(WeaponUser user)
        {
            throw new System.NotImplementedException();
        }

        public override void UnEquipWeapon(WeaponUser user)
        {
            throw new System.NotImplementedException();
        }

        public override void UseWeapon(WeaponUser user)
        {
            // Create a new bullet at the the instantiate point
            var obj = Instantiate(bullet,user.spawnPoint.position,user.spawnPoint.rotation);
            obj.damage = damage;
        }
    }
}
