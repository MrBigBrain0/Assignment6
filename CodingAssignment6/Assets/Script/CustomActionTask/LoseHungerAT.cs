using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class LoseHungerAT : ActionTask 
	{
		//Public veribles that determin the wolfs hunger and a timer verribale 
		public BBParameter<float> Hunger;
		public BBParameter<float> Timer;
		protected override string OnInit() 
		{
			return null;
		}
		protected override void OnExecute() 
		{
			
		}

		protected override void OnUpdate() 
		{
			//lowers the wolf hunger and resets the timers value
			Hunger.value -= 1 * Time.deltaTime;
			Timer.value = 0;
		}

		protected override void OnStop() 
		{
			
		}
		protected override void OnPause() 
		{
			
		}
	}
}