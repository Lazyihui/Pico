using System;
using UnityEngine;


public class GameContext {


    public GameEntity gameEntity;

    public RoleRepository roleRepository;

    public AudioRepository audioRepository;

    // ctx
    public AssetsContext assetsContext;

    public GameContext() {
        gameEntity = new GameEntity();

        // repos
        roleRepository = new RoleRepository();
        audioRepository = new AudioRepository();

        // ctx
        assetsContext = new AssetsContext();
    }

    public void Inject() {

    }

}


