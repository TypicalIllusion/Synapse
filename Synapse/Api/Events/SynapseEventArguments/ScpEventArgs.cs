﻿namespace Synapse.Api.Events.SynapseEventArguments
{
    public class Scp096AddTargetEventArgument : EventHandler.ISynapseEventArgs
    {
        public Player Player { get; internal set; }

        public Player Scp096 { get; internal set; }

        public PlayableScps.Scp096PlayerState RageState { get; internal set; }

        public bool Allow { get; set; }
    }

    public class Scp106ContainmentEventArgs : EventHandler.ISynapseEventArgs
    {
        public Player Player { get; internal set; }
        
        public bool Allow { get; set; }
    }

    public class PocketDimensionEnterEventArgs : EventHandler.ISynapseEventArgs
    {
        public Player Player { get; internal set; }
        
        public Player Scp106 { get; internal set; }
        
        public bool Allow { get; set; }
    }

    public class PocketDimensionLeaveEventArgs : EventHandler.ISynapseEventArgs
    {
        public Player Player { get; internal set; }
        
        public PocketDimensionTeleport.PDTeleportType TeleportType { get; set; }
        
        public bool Allow { get; set; }
    }

    public class PortalCreateEventArgs : EventHandler.ISynapseEventArgs
    {
        public Player Scp106 { get; internal set; }

        public bool Allow { get; set; }
    }
}