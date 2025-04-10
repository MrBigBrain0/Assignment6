using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class HuntBearAT : ActionTask
	{
		public BBParameter <GameObject> p;
		public BBParameter <GameObject> h;
		protected override string OnInit() 
		{
			return null;
		}

		protected override void OnExecute() 
		{
			
		}

		protected override void OnUpdate() 
		{
			p.value.transform.position = new Vector3(-0.3002234f, 1.22f, -23.92f);
			h.value.transform.position = new Vector3(20.14f, 0.44f, 4.61f);

        }


		protected override void OnStop() 
		{
			
		}


		protected override void OnPause() 
		{
			
		}
	}
}