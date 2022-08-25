using UnityEngine;

namespace Su
{
    /// <summary>
    /// NPC
    /// </summary>
    public class NPC2 : MonoBehaviour
    {
        #region 資料
        [SerializeField]
        private int missionnumber=0;
        #endregion

        #region 方法

        #region 對話
        private void dialogue()
        {
            print("你好");
        }
        #endregion

        #region 開啟商店
        public bool openshop()
        {
            return true;
        }
        #endregion

        #region 購買物品
        public int buyprops(int numberA)
        {           
            return 100;
        }
        #endregion

        #region 取得任務
        public void getmission(int numberA)
        {
            print($"任務編號:{numberA}");
        }
        #endregion

        #region 任務更新
        private int missionupdate(int numberB)
        {
            return 1;
        }
        #endregion

        #region 任務完成
        private int missioncompleted(bool numberC)
        {
            return missionnumber;
        }
        #endregion

        #endregion

        #region 事件
        private void Awake()
        {
            
            dialogue();
            print($"開啟商店:{openshop()}");
            print($"道具價格:{buyprops(0)}");
            getmission(missionnumber);
            print($"獲得道具數量:{missionupdate(0)}");
            print($"完成任務編號:{missioncompleted(false)}");
        }
        #endregion
    }
}