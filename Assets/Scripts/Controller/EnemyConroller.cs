namespace Script.EnemyController
{
    using Ensign.Unity.MVC;
    using UnityEngine;
    using Script.EnemyModel;
    public class EnemyController : Controller<EnemyController, EnemyModel>
    {
        protected override void Init()
        {
            base.Init();

            this.ChangeModel(new EnemyModel
            {
                //<====Enemy data====>
                health          = 1000f,
            });
        }

        public void SubtractHealth() { this.Model.health--; }

    }

}
