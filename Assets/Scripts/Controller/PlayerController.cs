namespace Script.PlayerController
{
    using Ensign.Unity.MVC;
    using UnityEngine;
    using Script.PlayerModel;
    public class PlayerController : Controller<PlayerController, PlayerModel>
    {
        protected override void Init()
        {
            base.Init();

            this.ChangeModel(new PlayerModel
            {
                //<====Player camera====>
                rotationX       = 0f,
                rotationY       = 0f,
                sensitivity     = 2f,
                //<====Player movement====>
                speed           = 4f,

            });
        }
    }

}