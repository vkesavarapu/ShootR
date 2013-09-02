/// <reference path="../../Scripts/endgate-0.2.0-beta1.d.ts" />
/// <reference path="../Ships/Ship.ts" />
/// <reference path="../Ships/ShipMovementController.ts" />
/// <reference path="../Server/IConfigurationDefinitions.ts" />
/////////////////// <reference path="../Abilities/Boost.ts" />
/////////////////// <reference path="../Bullet/Bullet.ts" />
/////////////////// <reference path="../HUD/Leaderboard.ts" />
/////////////////// <reference path="../HUD/DeathScreen.ts" />
/////////////////// <reference path="../Space/Map.ts" />
/// <reference path="../GameScreen.ts" />
/////////////////// <reference path="../Powerups/HealthPack.ts" />
/// <reference path="../Game.ts" />
/////////////////// <reference path="../Interfaces/IConfigurations.ts" />
/// <reference path="../../Scripts/typings/jquery/jquery.d.ts" />

module ShootR {

    export class ConfigurationManager {
        public bulletConfig: Server.IBulletConfiguration;
        public gameConfig: Server.IGameConfiguration;
        public shipConfig: Server.IShipConfiguration;
        public mapConfig: Server.IMapConfiguration;
        public screenConfig: Server.IScreenConfiguration;
        public leaderboardConfig: Server.ILeaderboardConfiguration;
        public healthPackConfig: Server.IHealthPackConfiguration;
        public abilityConfig: Server.IAbilityConfiguration;
        public shipMovementControllerConfig: Server.IShipMovementControllerConfiguration;

        constructor(configuration: Server.IConfigurationManager) {
            // Update the prototypes from the config
            Ship.SIZE = new eg.Size2d(configuration.shipConfig.WIDTH, configuration.shipConfig.HEIGHT);
            ShipMovementController.DRAG_AREA = configuration.shipMovementControllerConfig.DRAG_AREA;
            ShipMovementController.DRAG_COEFFICIENT = configuration.shipMovementControllerConfig.DRAG_COEFFICIENT;
            ShipMovementController.ENGINE_POWER = configuration.shipMovementControllerConfig.ENGINE_POWER;
            ShipMovementController.MASS = configuration.shipMovementControllerConfig.MASS;
            ShipMovementController.ROTATE_SPEED = configuration.shipMovementControllerConfig.ROTATE_SPEED * .0174532925; // Convert to radians

            //Boost.DURATION = configuration.abilityConfig.BOOST_DURATION;
            //Boost.SPEED_INCREASE = configuration.abilityConfig.BOOST_SPEED_INCREASE;

            //Bullet.BULLET_DIE_AFTER = configuration.gameConfig.BULLET_DIE_AFTER;

            Map.SIZE = new eg.Size2d(configuration.mapConfig.WIDTH, configuration.mapConfig.HEIGHT);
            Map.BARRIER_DEPRECATION = configuration.mapConfig.BARRIER_DEPRECATION;

            GameScreen.MAX_SCREEN_HEIGHT = configuration.screenConfig.MAX_SCREEN_HEIGHT;
            GameScreen.MAX_SCREEN_WIDTH = configuration.screenConfig.MAX_SCREEN_WIDTH;
            GameScreen.MIN_SCREEN_HEIGHT = configuration.screenConfig.MIN_SCREEN_HEIGHT;
            GameScreen.MIN_SCREEN_WIDTH = configuration.screenConfig.MIN_SCREEN_WIDTH;
            GameScreen.SCREEN_BUFFER_AREA = configuration.screenConfig.SCREEN_BUFFER_AREA;

/*          $.extend(Leaderboard, configuration.leaderboardConfig);
            $.extend(Bullet, configuration.bulletConfig);*/
            //$.extend(Game.prototype, configuration.gameConfig);
            //$.extend(HealthPack, configuration.healthPackConfig);

            //DeathScreen.RESPAWN_TIMER = configuration.gameConfig.RESPAWN_TIMER;

            //ShipController.REQUEST_PING_EVERY = configuration.gameConfig.REQUEST_PING_EVERY;

            $.extend(this, configuration);
        }
    }



}