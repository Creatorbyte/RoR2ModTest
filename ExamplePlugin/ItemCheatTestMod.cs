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
    [BepInPlugin("com.creatorbyte.ItemCheatTestMod", "Creatorbyte Item Cheat Mod", "1.0.0")]

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
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                //We grab a list of all available Tier 3 drops:
                var dropList = Run.instance.availableTier3DropList;

                //Randomly get the next item:
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);

                //Get the player body to use a position:
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;

                //And then finally drop it infront of the player.
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * 20f);
            }


            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                var dropList = Run.instance.availableTier2DropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * 20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                var dropList = Run.instance.availableTier1DropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                var dropList = Run.instance.availableBossDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }

            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                var dropList = Run.instance.availableEquipmentDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }
            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                var dropList = Run.instance.availableLunarDropList;
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }
            if (Input.GetKeyDown(KeyCode.Keypad0))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.SprintBonus.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.ArmorPlate.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Medkit.itemIndex), transform.position, transform.forward * 20f);

            }
            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Mushroom.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Syringe.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.KeypadPeriod))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Bear.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.CritGlasses.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.KeypadMultiply))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Behemoth.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.KeypadDivide))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.CaptainDefenseMatrix.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Crowbar.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                Transform Orig = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                for (int theta = 0; theta < 100; theta++)
                {
                    int r = 20;//radius
                    float w = 3.6f;
                    transform.position.Set(Orig.position.x + r * Mathf.Sin(w * (theta * Mathf.Deg2Rad)), Orig.position.y + r * Mathf.Sin(w * (theta * Mathf.Deg2Rad)), Orig.position.z+(theta));
                    PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Mushroom.itemIndex), transform.position, transform.up * 10f);
                }

            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.Pearl.itemIndex), transform.position, transform.forward * 20f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;
                PickupDropletController.CreatePickupDroplet(PickupCatalog.FindPickupIndex(RoR2Content.Items.ShinyPearl.itemIndex), transform.position, transform.forward * 20f);
            }
        }
    }
}