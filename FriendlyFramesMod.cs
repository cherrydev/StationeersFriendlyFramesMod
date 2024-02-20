using Assets.Scripts.Objects;
using HarmonyLib;
using BepInEx;


namespace FriendlyFramesMod
{
    [BepInPlugin("FriendlyFrames", "Friendly Frames", "0.0.1.0")]
    class FriendlyFramesMod : BaseUnityPlugin
    {
        private void Awake()
        {
            //READ THE README FIRST! 
            
            //Harmony harmony = new Harmony("FriendlyFramesMod");
            //harmony.PatchAll();
            UnityEngine.Debug.Log("FriendlyFramesMod Loaded -- Remember to recalculate rooms when you first use this mod!");
            Prefab.OnPrefabsLoaded += PatchPrefabs;
        }


        private void PatchPrefabs()
        {
            Structure.AllStructurePrefabs.ForEach(s =>
            {
                if (s.GetPrefabName().StartsWith("StructureFrame"))
                {
                    
                    if (s.BuildStates.Count == 3)
                    {
                        UnityEngine.Debug.Log("Patching " + s.GetPrefabName() + " BlockGravity");
                        s.BuildStates[1].BlockGravity = false;
                        s.BuildStates[1].Tool.ToolExit = s.BuildStates[0].Tool.ToolExit;
                        s.BuildStates[2].Tool.ToolExit = s.BuildStates[0].Tool.ToolExit;
                    }
                }
            }
            );
        }
    }
}