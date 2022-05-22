using System;

namespace JetBrains.ReSharper.Koans.Refactoring.CustomRefactoring
{
    public class RemoveOutParameterWhitExtractClass
    {

        public void Caller()
        {
           
            
            
            // 消除 out參數
            // 游標放在Compare 抽類別 命名 NumberComparer
            // 移除 compareResult 參數 ,呼叫端的變數
            // 將 compareResult 改為大寫,並Alt+Enter => Create Property
            bool compareAns =Compare(2,3,out  var result);
            Console.Write($"ans:{compareAns},result is {result}");
        }
        
        /// <summary>
        /// 比較後將結果回傳,有比較到結果回傳true,平手回傳false
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="compareResult"></param>
        /// <returns></returns>
        public bool Compare(int val1,int val2,out string compareResult)
        {
            if (val1 > val2)
            {
                compareResult = "vale1 is bigger";
                return true;
            }
                    
            if(val1<val2)
            {
                compareResult = "vale1 is bigger";
                return true;
            }

            compareResult = "Tie";
            return false;
        }
    }


    
}