﻿using BBI.Game.Data;

namespace Subsystem.Patch
{
    public class WeaponAttributesPatch
    {
        public bool? ExcludeFromAutoTargetAcquisition { get; set; }
        public bool? ExcludeFromAutoFire { get; set; }
        public bool? ExcludeFromHeightAdvantage { get; set; }
        public DamageType? DamageType { get; set; }
        public bool? IsTracer { get; set; }
        public double? TracerSpeed { get; set; }
        public double? TracerLength { get; set; }
        public double? BaseDamagePerRound { get; set; }
        public double? BaseWreckDamagePerRound { get; set; }
        public float? FiringRecoil { get; set; }
        public int? WindUpTimeMS { get; set; }
        public int? RateOfFire { get; set; }
        public int? NumberOfBursts { get; set; }
        public int? DamagePacketsPerShot { get; set; }
        public int? BurstPeriodMinTimeMS { get; set; }
        public int? BurstPeriodMaxTimeMS { get; set; }
        public int? CooldownTimeMS { get; set; }
        public int? WindDownTimeMS { get; set; }
        public int? ReloadTimeMS { get; set; }
        public bool? LineOfSightRequired { get; set; }
        public TargetAimingType? LeadsTarget { get; set; }
        public bool? KillSkipsUnitDeathSequence { get; set; }
        public RevealTrigger? RevealTriggers { get; set; }
        public UnitStatusAttackingTrigger? UnitStatusAttackingTriggers { get; set; }
        public WeaponTargetStyle? TargetStyle { get; set; }
        public AOEFalloffType? AreaOfEffectFalloffType { get; set; }
        public double? AreaOfEffectRadius { get; set; }
        public bool? ExcludeWeaponOwnerFromAreaOfEffect { get; set; }
        public double? FriendlyFireDamageScalar { get; set; }
        public double? WeaponOwnerFriendlyFireDamageScalar { get; set; }
        public RangeBasedWeaponAttributesPatch RangeAttributesShort { get; set; }
        public RangeBasedWeaponAttributesPatch RangeAttributesMedium { get; set; }
        public RangeBasedWeaponAttributesPatch RangeAttributesLong { get; set; }
        public string ProjectileEntityTypeToSpawn { get; set; }
        public AbilityTargetAlignment? StatusEffectsTargetAlignment { get; set; }
        public UnitClass? StatusEffectsExcludeTargetType { get; set; }
        public int? ActiveStatusEffectsIndex { get; set; }
    }
}
