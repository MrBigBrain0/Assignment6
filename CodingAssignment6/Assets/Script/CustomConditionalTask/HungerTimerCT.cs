using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions
{
    public class HungerTimerCT : ConditionTask
    {
        public BBParameter<float> Hunger;

        protected override string OnInit()
        {
            return null;
        }

        protected override bool OnCheck()
        {
            if (Hunger.value <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}