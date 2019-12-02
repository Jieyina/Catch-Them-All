using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace PokemonBattele
{
    abstract class StatModifiersChangeEffect : EffectWithProbability
    {
        protected readonly int ChangeNum;
        protected readonly bool isAdd;
        public StatModifiersChangeEffect(int probability, int num, bool isAdd, bool isUseSelf) : base(probability, isUseSelf)
        {
            ChangeNum = num;
            this.isAdd = isAdd;
        }
        

    }
    abstract class StatModifiersSetEffect : EffectWithProbability
    {
        protected readonly int value;
        public StatModifiersSetEffect(int probability, int num, bool isUseSelf) : base(probability, isUseSelf)
        {
            value = num;
        }


    }
    class ChangePhysicPowerStatModifiersEffect : StatModifiersChangeEffect
    {
        public ChangePhysicPowerStatModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }

        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {

                stat.PhysicPower += ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "物攻上升", ChangeNum));


            }

            else
            {
                stat.PhysicPower -= ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "物攻下降", ChangeNum));

            }
            pokemon.StatModifiers = stat;
        }
    }

    class ChangePhysicDefenceStatModifiersEffect : StatModifiersChangeEffect
    {
        public ChangePhysicDefenceStatModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }


        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {
                stat.PhysicDefence += ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "物防上升", ChangeNum));

            }

            else
            {
                stat.PhysicDefence -= ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "物防下降", ChangeNum));


            }
            pokemon.StatModifiers = stat;
        }
    }

    class ChangeEnergyPowerStatModifiersEffect : StatModifiersChangeEffect
    {
        public ChangeEnergyPowerStatModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }


        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {
                stat.EnergyPower += ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "特攻下降", ChangeNum));


            }

            else
            {
                stat.EnergyPower -= ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "特攻下降", ChangeNum));


            }
            pokemon.StatModifiers = stat;
        }
    }

    class ChangeEnergyDefenceStatModifiersEffect : StatModifiersChangeEffect
    {
        public ChangeEnergyDefenceStatModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }


        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {
                stat.EnergyDefence += ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "特防上升", ChangeNum));


            }

            else
            {
                stat.EnergyDefence -= ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "特防下降", ChangeNum));


            }
            pokemon.StatModifiers = stat;
        }
    }

    class ChangeCriticalHitModifiersEffect : StatModifiersChangeEffect
    {
        public ChangeCriticalHitModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }



        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {
                stat.CriticalHit += ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "击中要害概率上升", ChangeNum));


            }

            else
            {
                stat.CriticalHit -= ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "击中要害概率下降", ChangeNum));


            }
            pokemon.StatModifiers = stat;
        }
    }

    class ChangeSpeedStatModifiersEffect : StatModifiersChangeEffect
    {
        public ChangeSpeedStatModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }


        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {
                stat.Speed += ChangeNum;

                DebugHelper.Log(Log(pokemon.Ename, "速度上升", ChangeNum));


            }

            else
            {
                stat.Speed -= ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "速度下降", ChangeNum));


            }
            pokemon.StatModifiers = stat;
        }
    }

    class ChangeHitRateStatModifiersEffect : StatModifiersChangeEffect
    {
        public ChangeHitRateStatModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }

        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {
                stat.HitRate += ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "命中率上升", ChangeNum));


            }

            else
            {
                stat.HitRate -= ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "命中率下降", ChangeNum));


            }
            pokemon.StatModifiers = stat;
        }
    }

    class ChangeAvoidanceRateStatModifiersEffect : StatModifiersChangeEffect
    {
        public ChangeAvoidanceRateStatModifiersEffect(int probability, int num, bool isAdd, bool isUseSelf)
            : base(probability, num, isAdd, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }


        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            if (isAdd)
            {
                stat.AvoidanceRate += ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "回避率上升", ChangeNum));


            }

            else
            {
                stat.AvoidanceRate -= ChangeNum;
                DebugHelper.Log(Log(pokemon.Ename, "回避率下降", ChangeNum));

            }
            pokemon.StatModifiers = stat;
        }
    }

    class SetPhysicPowerStatModifiersEffect : StatModifiersSetEffect
    {
        public SetPhysicPowerStatModifiersEffect(int probability, int num, bool isUseSelf)
            : base(probability, num, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }


        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            stat.PhysicPower = value;
            pokemon.StatModifiers = stat;
            DebugHelper.Log(Log(pokemon.Ename, "物攻等级变更为", value));

        }
    }
    class SetPhysicDefenceStatModifiersEffect : StatModifiersSetEffect
    {
        public SetPhysicDefenceStatModifiersEffect(int probability, int num, bool isUseSelf)
            : base(probability, num, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }

        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            stat.PhysicDefence = value;
            pokemon.StatModifiers = stat;
            DebugHelper.Log(Log(pokemon.Ename, "物防等级变更为", value));

        }
    }

    class SetEnergyPowerStatModifiersEffect : StatModifiersSetEffect
    {
        public SetEnergyPowerStatModifiersEffect(int probability, int num, bool isUseSelf)
            : base(probability, num, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }

        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            stat.EnergyPower = value;
            pokemon.StatModifiers = stat;
            DebugHelper.Log(Log(pokemon.Ename, "特攻等级变更为", value));

        }
    }
    class SetEnergyDefenceStatModifiersEffect : StatModifiersSetEffect
    {
        public SetEnergyDefenceStatModifiersEffect(int probability, int num, bool isUseSelf)
            : base(probability, num, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }

        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            stat.EnergyDefence = value;
            pokemon.StatModifiers = stat;
            DebugHelper.Log(Log(pokemon.Ename, "特防等级变更为", value));

        }
    }

    class SetSpeedStatModifiersEffect : StatModifiersSetEffect
    {
        public SetSpeedStatModifiersEffect(int probability, int num, bool isUseSelf)
            : base(probability, num, isUseSelf)
        {
        }

        public override void BattleStartEffect(BattlePokemonData pokemon, ref bool canEnd)
        {

        }

        public override void HitEffect(BattlePokemonData pokemon)
        {
            StatModifiers stat = pokemon.StatModifiers;
            stat.Speed = value;
            pokemon.StatModifiers = stat;

            DebugHelper.Log(Log(pokemon.Ename, "速度等级变更为", value));

        }
    }
}
