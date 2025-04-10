using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class BitAT : ActionTask 
	{
		//black board varribles that are for the player, the hunger value ofthe wolf and a timer for inbetween bitting
        public BBParameter<GameObject> player;
		public BBParameter<float> Hunger;
		public BBParameter<float> timer;

		//calls the scrit of player controller and ther values
		PlayerController controller;

        protected override string OnInit() 
		{
			//controller = GetComponent<PlayerController>();
			return null;
		}


		protected override void OnExecute() 
		{
				controller.gotBit();
			
		}


		protected override void OnUpdate() 
		{
			Debug.Log("HI");

			//when the wolf gets hungy enough it will increase the timer value and call gotBit to set the players speed to zero
            if (Hunger.value <= 10)
            {
                Debug.Log("ehfsgqfffbbbbbbbbb");
                timer.value += 1 * Time.deltaTime;

            }

            if (timer.value >= 5)
			{
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