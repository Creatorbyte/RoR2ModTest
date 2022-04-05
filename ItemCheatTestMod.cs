using BepInEx;
using R2API;
using R2API.Utils;
using RoR2;
using UnityEngine;

namespace ItemCheatTestMod
{
    //This is an example plugin that can be put in BepInEx/plugins/ExamplePlugin/ExamplePlugin.dll to test out.

    //You don't need this if you're not using R2API in your plugin, it's just to tell BepInEx to initialize R2API before this plugin so it's safe to use R2API.
    [BepInDependency("com.bepis.r2api")]

    //This attribute is required
    [BepInPlugin("com.creatorbyte.ItemCheatTestMod", "Creatorbyte Item Cheat Mod", "1.0.1")]

    //We will be using 3 modules from R2API: ItemAPI to add our item, ItemDropAPI to have our item drop ingame, and LanguageAPI to add our language tokens.
    ///[R2APISubmoduleDependency(nameof(ItemAPI),nameof(ItemDropAPI),nameof(LanguageAPI))]


    //This is the main declaration of our plugin class. BepInEx searches for all classes inheriting from BaseUnityPlugin to initialize on startup.
    //BaseUnityPlugin itself inherits from MonoBehaviour, so you can use this as a reference for what you can declare and use in your plugin class: https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
    public class ItemCheatTestMod : BaseUnityPlugin
    {

        //The Awake() method is run at the very start when the game is initialized.
        public void Awake()
        {
            Logger.LogMessage("Loaded ItemCheatTestMod!");

        }

        //The Update() method is run on every frame of the game.
        public void Update()
        {
            //This if statement checks if the player has currently pressed F3, and then proceeds into the statement:
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                //We grab a list of all available Tier 3 drops(Red Items)
                var dropList = Run.instance.availableTier3DropList;

                //Randomly get the next item from this list
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);

                //Get the player body to use its position
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;

                //And then finally create the new item pickup next to the player.
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * 20f);
            }

            //do what we did for the last if-statement for each of the available drop lists...

            if (Input.GetKeyDown(KeyCode.Keypad0))
            {
                //White items
                var dropList = Run.instance.availableTier1DropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad1))
            {   
                //Green items
                var dropList = Run.instance.availableTier2DropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * 20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                //Gold Boss Items
                var dropList = Run.instance.availableBossDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                //Orange Equipment Items
                var dropList = Run.instance.availableEquipmentDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                //Blue Lunar Items
                var dropList = Run.instance.availableLunarItemDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                //Lunar Equipment Items
                var dropList = Run.instance.availableLunarEquipmentDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                //Void Items Tier 1
                var dropList = Run.instance.availableVoidTier1DropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                //Void Items Tier 2
                var dropList = Run.instance.availableVoidTier2DropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                //Void Items Tier 3
                var dropList = Run.instance.availableVoidTier3DropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            //test
            if (Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                //Void Items Boss Tier
                var dropList = Run.instance.availableVoidBossDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }
            

            // a few additional items not found in the drop lists that I wanted to include. Specifically the pearls and captain's defensive microbot
            if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.CaptainDefenseMatrix.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Pearl.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.ShinyPearl.itemIndex), transform.position, transform.forward * 20f);
            }
        }
    }
}