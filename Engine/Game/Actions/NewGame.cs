﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Merlin2d.Game.Actions
{
    public class NewGame : Action<GameWorld>
    {
        private Factory factory;
        private Scenario scenario;
        private IPhysics physics;
        private string mapPath = "";

        public void SetFactory(Factory factory)
        {
            this.factory = factory;
        }

        public void SetScenario(Scenario scenario)
        {
            this.scenario = scenario;
        }
        public void SetPhysics(IPhysics physics)
        {
            this.physics = physics;
        }
        public void SetMap(String path)
        {
            mapPath = path;
        }


        public void Execute(GameWorld t)
        {
            throw new NotImplementedException();
            //World gameWorld = new GameWorld();
            

            //gameWorld.SetFactory(factory);
            //gameWorld.SetScenario(scenario);
            //gameWorld.SetPhysics(physics);
            //gameWorld.SetMap(mapPath);
            //stateBasedGame.enterState(x);
        }

        public string GetActionName()
        {
            return "new game";
        }
    }
}
