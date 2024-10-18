using System;
using UnityEngine;


public class GameContext {


    public GameEntity gameEntity;

    public RoleRepository roleRepository;

    // ctx
    public AssetsContext assetsContext;

    public GameContext() {
        gameEntity = new GameEntity();

        // repos
        roleRepository = new RoleRepository();

        // ctx
        assetsContext = new AssetsContext();
    }

    public void Inject() {

    }

}


