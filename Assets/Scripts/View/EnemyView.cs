namespace Script.EnemyView
{
    using UnityEngine;
    using UnityEngine.UI;
    using Ensign;
    using Ensign.Unity.MVC;
    using Script.EnemyModel;
    using Script.EnemyController;

    public class EnemyView : View<EnemyController, EnemyModel>
    {
        private void OnTriggerEnter(Collider myTrigger)
        {
            if(myTrigger.gameObject.tag == "Bullet")
            {
                this.Controller.SubtractHealth();
                Debug.Log("Enemy: " + this.Model.health);
            }
        }
    }
}