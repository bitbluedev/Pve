using Pve.GameEntity.Equipment;

namespace Pve.GameEntity
{
    internal class Weapon : Item
    {
        public int BaseDamage { get; set; }
        public int ExtraDamage { get; set; }
        public int CriticalHitChance { get; set; }
    }
}