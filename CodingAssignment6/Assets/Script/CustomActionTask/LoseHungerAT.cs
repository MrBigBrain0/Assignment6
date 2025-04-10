using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class LoseHungerAT : ActionTask 
	{
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