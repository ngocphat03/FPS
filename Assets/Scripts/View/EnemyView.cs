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
        [SerializeField] private Slider SliderHealth;

        private void Update()
        {
            SetHealth();
            EnemyDie();
        }

        private void EnemyDie() 
        {
            if(this.Model.health <= 0)
            {
                GameManager.Instance.GameWin();
            }
        }

        /// <summary>
        /// Change health bar
        /// </summary>
        public void SetHealth() { SliderHealth.value = this.Model.health; }

        private void OnTriggerEnter(Collider myTrigger)
        {
            if(myTrigger.gameObject.tag == "Bullet")
            {
                this.Model.damageTaken = 5f;
                this.Controller.SubtractHealth();
                Debug.Log("Enemy: " + this.Model.health);
            }
        }
    }
}