using System;
using UnityEngine;


public static class AudioDomain {
    public static AudioEntity Spawn(GameContext ctx) {

        bool has = ctx.assetsContext.entities.TryGetValue("AudioEntity", out GameObject prefab);

        if (!has) {
            Debug.LogError("no");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        AudioEntity entity = go.GetComponent<AudioEntity>();


        entity.Ctor();

        ctx.audioRepository.Add(entity);
        return entity;

    }
}