using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class BitAT : ActionTask 
	{
        public BBParameter<GameObject> p;
		public BBParameter<float> Hunger;
		public BBParameter<float> timer;

		PlayerController controller;

        protected override string OnInit() 
		{
			return null;
		}


		protected override void OnExecute() 
		{
			
		}


		protected override void OnUpdate() 
		{
			Debug.Log("HI");
			Hunger.value = 20;

            if (Hunger.value >= 10)
            {
                Debug.Log("ehfsgqfffbbbbbbbbb");
                controller.gotBit();
                timer.value += 1 * Time.deltaTime;
            }

            if (timer.value >= 5)
			{
				controller.walking();
				EndAction(true);
			}


        }

		//Called when the task is disabled.
		protected override void OnStop() 
		{

        }

		//Called when the task is paused.
		protected override void OnPause() 
		{
            
        }
	}
}