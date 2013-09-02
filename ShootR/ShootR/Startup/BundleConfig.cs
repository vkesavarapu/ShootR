﻿using System.Web.Optimization;

namespace ShootR
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryjs")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.cookie.js")
                .Include("~/Scripts/jquery.animate-colors-min.js")
                .Include("~/Scripts/jquery-ui-{version}.js")
                .Include("~/Scripts/shortcut.js"));
            bundles.Add(new StyleBundle("~/bundles/jquerycss")
                .Include("~/Styles/jquery-ui-{version}.css"));

            bundles.Add(new ScriptBundle("~/bundles/signalr")
                .Include("~/Scripts/jquery.signalr-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs")
                .Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/bundles/bootstrapcss")
                .Include("~/Styles/bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/gamejs")
                .Include("~/Scripts/endgate-{version}.js")
                .Include("~/Client2/Utilities/UtilityFunctions.js")
                .Include("~/Client2/Server/PayloadDecompressor.js")
                .Include("~/Client2/Server/ServerConnectionManager.js")
                .Include("~/Client2/Server/ServerAdapter.js")
                .Include("~/Client2/Configuration/ConfigurationManager.js")
                .Include("~/Client2/GameScreen.js")
                .Include("~/Client2/Space/MapBoundary.js")
                .Include("~/Client2/Space/Map.js")
                .Include("~/Client2/Ships/ShipGraphic.js")
                .Include("~/Client2/Ships/ShipMovementController.js")
                .Include("~/Client2/Ships/ShipInputController.js")
                .Include("~/Client2/Ships/Ship.js")
                .Include("~/Client2/Ships/UserShipManager.js")
                .Include("~/Client2/Ships/ShipManager.js")
                .Include("~/Client2/Game.js")
                .Include("~/Client2/Main.js"));

            bundles.Add(new ScriptBundle("~/bundles/gamejs2")
                .Include("~/Client/Utilities/Vector2.js")
                .Include("~/Client/Utilities/ValueRef.js")
                .Include("~/Client/Utilities/ImageAssets.js")
                .Include("~/Client/Utilities/Size.js")
                .Include("~/Client/Managers/spritify.js")
                .Include("~/Client/Utilities/GameTime.js")
                .Include("~/Client/Managers/AnimationManager.js")
                .Include("~/Client/Space/GameScreen.js")
                .Include("~/Client/Space/AreaRenderer.js")
                .Include("~/Client/GameGlobals.js")
                .Include("~/Client/Utilities/LatencyResolver.js")
                .Include("~/Client/Utilities/UtilityFunctions.js")
                .Include("~/Client/GameController/JoyStick.js")
                .Include("~/Client/GameController/Adapters/IETouchAdapter.js")
                .Include("~/Client/GameController/Adapters/MouseAdapter.js")
                .Include("~/Client/GameController/Adapters/TouchAdapter.js")
                .Include("~/Client/GameController/TouchController.js")
                .Include("~/Client/Utilities/ClientServerTime.js")
                .Include("~/Client/Space/Map.js")
                .Include("~/Client/Space/Camera.js")
                .Include("~/Client/Space/CanvasRenderer.js")
                .Include("~/Client/Collidable/Collidable.js")
                .Include("~/Client/Collidable/MovementControllers/MovementController.js")
                .Include("~/Client/Collidable/MovementControllers/StationaryMovementController.js")
                .Include("~/Client/Powerups/Powerup.js")
                .Include("~/Client/Powerups/HealthPack.js")
                .Include("~/Client/Powerups/PowerupManager.js")
                .Include("~/Client/Bullet/BulletMovementController.js")
                .Include("~/Client/Bullet/Bullet.js")
                .Include("~/Client/Bullet/BulletManager.js")
                .Include("~/Client/Abilities/AbilityHandlers/AbilityHandler.js")
                .Include("~/Client/Abilities/AbilityHandlers/ShipAbilityHandler.js")
                .Include("~/Client/Abilities/Abstractions/Ability.js")
                .Include("~/Client/Abilities/Abstractions/MovementAbility.js")
                .Include("~/Client/Abilities/Boost.js")
                .Include("~/Client/Ship/ShipMovementController.js")
                .Include("~/Client/Ship/ShipManager.js")
                .Include("~/Client/Ship/ShipAnimationHandler.js")
                .Include("~/Client/Ship/Ship.js")
                .Include("~/Client/Ship/ShipController.js")
                .Include("~/Client/Utilities/PayloadManagement/PayloadDecompressor.js")
                .Include("~/Client/Configuration/ConfigurationManager.js")
                .Include("~/Client/Game.js")
                .Include("~/Client/HUD/NotificationManager.js")
                .Include("~/Client/HUD/EnvironmentMonitor.js")
                .Include("~/Client/HUD/ShipStatMonitor.js")
                .Include("~/Client/HUD/HealthMonitor.js")
                .Include("~/Client/HUD/DeathScreen.js")
                .Include("~/Client/HUD/MyRankings.js")
                .Include("~/Client/HUD/ExperienceMonitor.js")
                .Include("~/Client/HUD/Leaderboard.js")
                .Include("~/Client/HUD/GameDetailManager.js")
                .Include("~/Client/HUD/HUDManager.js")
                .Include("~/Client/HUD/Animation/TextAnimation.js")
                .Include("~/Client/Main.js"));
            bundles.Add(new StyleBundle("~/bundles/gamecss")
                .Include("~/Styles/game.css")
                .Include("~/Styles/gameHUD.css")
                .Include("~/Styles/popups.css"));

            bundles.Add(new ScriptBundle("~/bundles/controllerjs")
                .Include("~/Client/Utilities/Vector2.js")
                .Include("~/Client/Utilities/Size.js")
                .Include("~/Client/Space/Camera.js")
                .Include("~/Scripts/Client/Configuration/ConfigurationManager.js")
                .Include("~/Client/Utilities/UtilityFunctions.js")
                .Include("~/Client/Space/GameScreen.js")
                .Include("~/Client/GameController/ShipControllerFunctions.js")
                .Include("~/Client/GameController/JoyStick.js")
                .Include("~/Client/GameController/Adapters/IETouchAdapter.js")
                .Include("~/Client/GameController/Adapters/MouseAdapter.js")
                .Include("~/Client/GameController/Adapters/TouchAdapter.js")
                .Include("~/Client/GameController/TouchController.js")
                .Include("~/Client/Space/CanvasRenderer.js")
                .Include("~/Client/GameController/controllerMain.js"));
        }
    }
}