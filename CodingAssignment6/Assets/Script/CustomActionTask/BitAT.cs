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

            if (Hunger.value <= 10)
            {
                Debug.Log("ehfsgqfffbbbbbbbbb");
                timer.value += 1 * Time.deltaTime;
                //controller.gotBit();
                
            }

            if (timer.value >= 5)
			{
				//controller.walking();
                Hunger.value = 20;
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