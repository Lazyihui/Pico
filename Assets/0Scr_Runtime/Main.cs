using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    GameContext ctx;

    bool isTearDown = false;
    void Awake() {
        ctx = new GameContext();

        Core_Assets.Load(ctx.assetsContext);

        RoleEntity owner = RoleDomain.Spawn(ctx);

        owner.id = ctx.gameEntity.OwnerID;

        // AudioEntity audio = AudioDomain.Spawn(ctx);
        Debug.Log("Hello World");
    }

    void Update() {

    }

    void OnDestory() {
        TearDown();
    }

    void OnApplicationQuit() {
        TearDown();
    }

    void TearDown() {
        if (isTearDown) {
            return;
        }

        isTearDown = false;

        Core_Assets.UnLoad(ctx.assetsContext);
    }
}
