using System;
using UnityEngine;


public class GameContext {

    public RoleRepository roleRepository;


    public GameContext() {
        roleRepository = new RoleRepository();
    }

    public void Inject() {

    }

}


