using UnityEngine;

namespace Su
{
    /// <summary>
    /// NPC
    /// </summary>
    public class NPC : MonoBehaviour
    {
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
            numberA = 100;
            return numberA;
        }
        #endregion

        #region ���o����
        public void getmission()
        {
            print("���Ƚs��:1");
        }
        #endregion

        #region ���ȧ�s
        private int missionupdate(int numberB)
        {
            numberB = 1;
            return numberB;
        }
        #endregion

        #region ���ȧ���
        private int missioncompleted(bool numberC)
        {
            return 1;
        }
        #endregion

        #endregion

        #region �ƥ�
        private void Awake()
        {
            dialogue();
            print($"�}�Ұө�:{openshop()}");
            print($"�D�����:{buyprops(0)}");
            getmission();
            print($"��o�D��ƶq:{missionupdate(0)}");
            print($"�������Ƚs��:{missioncompleted(false)}");
        }
        #endregion
    }
}

