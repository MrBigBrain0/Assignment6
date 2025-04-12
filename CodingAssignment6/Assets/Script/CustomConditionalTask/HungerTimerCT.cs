using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions
{
    public class HungerTimerCT : ConditionTask
    {
        //holds the hunger float 
        public BBParameter<float> Hunger;

        protected override string OnInit()
        {
            return null;
        }

        protected override bool OnCheck()
        {
            //if hunger = zero allow the condition to secceed other wise keep player in this sate
            if (Hunger.value <= 0)
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