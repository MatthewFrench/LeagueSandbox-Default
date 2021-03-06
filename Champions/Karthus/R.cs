using System.Linq;
using LeagueSandbox.GameServer.Logic.GameObjects;
using LeagueSandbox.GameServer.Logic.API;

namespace Karthus
{
    public class R
    {
        public static void onStartCasting(Champion owner, Spell spell, Unit target)
        {
            foreach (var enemyTarget in ApiFunctionManager.GetChampionsInRange(owner, 20000, true).Where(enemyTarget => enemyTarget.Team != owner.Team))
            {
                ApiFunctionManager.AddParticleTarget(owner, "KarthusFallenOne", enemyTarget);
            }
        }

        public static void onFinishCasting(Champion owner, Spell spell, Unit target)
        {
            var AP = owner.GetStats().AbilityPower.Total;
            var damage = 100 + spell.Level * 150 + AP * 0.6f;
            foreach (var enemyTarget in ApiFunctionManager.GetChampionsInRange(owner, 20000, true).Where(enemyTarget => enemyTarget.Team != owner.Team))
            {
                owner.DealDamageTo(enemyTarget, damage, DamageType.DAMAGE_TYPE_MAGICAL, DamageSource.DAMAGE_SOURCE_SPELL, false);
            }

        }

        public static void applyEffects(Champion owner, Unit target, Spell spell, Projectile projectile)
        {

        }

        public static void onUpdate(double diff)
        {

        }
    }
}