using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;



public static class Core_Assets {

    public static void Load(AssetsContext ctx) {

        {
            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "Entity";
            var ptr = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);
            var list = ptr.WaitForCompletion();
            foreach (var go in list) {
                ctx.entities.Add(go.name, go);
            }
            ctx.entityPtr = ptr;
        }
    }

    public static void UnLoad(AssetsContext ctx) {
        if (ctx.entityPtr.IsValid()) {
            Addressables.Release(ctx.entityPtr);
        }
    }

}