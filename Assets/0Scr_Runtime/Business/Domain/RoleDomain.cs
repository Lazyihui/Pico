using System;
using UnityEngine;


public static class RoleDomain {
    public static RoleEntity Spawn(GameContext ctx) {

        bool has = ctx.assetsContext.entities.TryGetValue("RoleEntity", out GameObject prefab);

        if (!has) {
            Debug.LogError("no");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        RoleEntity entity = go.GetComponent<RoleEntity>();

    
        entity.Ctor();

        ctx.roleRepository.Add(entity);
        return entity;

    }
}