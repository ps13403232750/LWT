using System;
using System.Collections.Generic;
using System.Text;

using Model;
using IServices;
using SqlSugar;
namespace Services
{
    public class SupplierServices : BaseDB, ISupplierServices
    {
        /// <summary>
        /// 获取商品表数据
        /// </summary>
        /// <returns></returns>
        public List<Goods> Goods()
        {
            var List = SqlSugarHelper<Goods>.FindAll();
            return List;
        }

        /// <summary>
        /// 审核商品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool UpdateGoods(int Id, int State)
        {
            //别删，我留着还有用，谢谢
            //var result = GoodsDb.Update(it => new Goods() { State = State }, it => it.Id == Id);
            //return result;
            var result = GetSimpleInstance<Goods>().Update(it => new Goods() { State = State }, it => it.Id == Id);
            return result;
        }
    }
}
