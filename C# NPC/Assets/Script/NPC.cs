using UnityEngine;

namespace Su
{
    /// <summary>
    /// NPC
    /// </summary>
    public class NPC : MonoBehaviour
    {
        #region 資料
        private int updatemission = 1;
        private int propprice = 100;
        private string Conversationcontent = "你好";
        public int missionnumber = 1;
        #endregion

        #region 方法

        #region 對話
        private void dialogue()
        {
            print($"{Conversationcontent}");
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
            return 0;
        }
        #endregion

        #region 取得任務
        public void getmission()
        {
            print($"任務編號:{missionnumber}");
        }
        #endregion

        #region 任務更新
        private int missionupdate(int numberB)
        {
            return 0;
        }
        #endregion

        #region 任務完成
        private bool missioncompleted(int numberC)
        {
            return false;
        }
        #endregion

        #endregion

        #region 事件
        private void Awake()
        {
            dialogue();
            print($"開啟商店:{openshop()}");
            print($"道具價格:{buyprops(propprice)}");
            getmission();
            print($"獲得道具數量:{missionupdate(updatemission)}");
            print($"完成任務編號:{missioncompleted(missionnumber)}");
        }
        #endregion
    }
}

