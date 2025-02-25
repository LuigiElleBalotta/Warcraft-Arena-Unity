﻿namespace Common
{
    public enum GameEvents
    {
        GameMapLoaded,
        DisconnectedFromHost,
        DisconnectedFromMaster,
        SessionListUpdated,
        WorldStateChanged,

        ClientControlStateChanged,
        ClientSpellFailed,

        SpellLaunched,
        SpellHit,
        SpellDamageDone,
        SpellHealingDone,
        SpellMissDone,

        ServerPlayerSpeedChanged,
        ServerPlayerRootChanged,
        ServerPlayerMovementControlChanged,
        ServerSpellLaunch,
        ServerSpellHit,
        ServerSpellCooldown,
        ServerPlayerTeleport,
        ServerDamageDone,
        ServerHealingDone,
        ServerMapLoaded,
        ServerLaunched,
        ServerVisibilityChanged,

        UnitChat,
        UnitAttributeChanged,
        UnitTargetChanged,
        UnitFactionChanged,
        UnitClassChanged,
        UnitVisualsChanged,
        UnitModelChanged,
        UnitScaleChanged,
        UnitDisplayPowerChanged,

        HotkeyStateChanged,
        HotkeyBindingChanged,
        LobbyClassChanged,
        GameOptionChanged,
        EntityPooled
    }
}
