using UnityEngine;

namespace Su
{
    /// <summary>
    /// NPC
    /// </summary>
    public class NPC2 : MonoBehaviour
    {
        #region ���
        [SerializeField]
        private int missionnumber=0;
        #endregion

        #region ��k

        #region ���
        private void dialogue()
        {
            print("�A�n");
        }
        #endregion

        #region �}�Ұө�
        public bool openshop()
        {
            return true;
        }
        #endregion

        #region �ʶR���~
        public int buyprops(int numberA)
        {           
            return 100;
        }
        #endregion

        #region ���o����
        public void getmission(int numberA)
        {
            print($"���Ƚs��:{numberA}");
        }
        #endregion

        #region ���ȧ�s
        private int missionupdate(int numberB)
        {
            return 1;
        }
        #endregion

        #region ���ȧ���
        private int missioncompleted(bool numberC)
        {
            return missionnumber;
        }
        #endregion

        #endregion

        #region �ƥ�
        private void Awake()
        {
            
            dialogue();
            print($"�}�Ұө�:{openshop()}");
            print($"�D�����:{buyprops(0)}");
            getmission(missionnumber);
            print($"��o�D��ƶq:{missionupdate(0)}");
            print($"�������Ƚs��:{missioncompleted(false)}");
        }
        #endregion
    }
}