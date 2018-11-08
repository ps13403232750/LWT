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
        public int UpdateGoods(int Id,int State)
        {
            Goods goods = new Goods();
            goods.Id = Id;
            goods.State = State;
            var reslut = SqlSugarHelper<Goods>.Update(goods);
            return Convert.ToInt32( reslut);
            //using (var db=BaseDB.GetInstance())
            //{
            //    Goods goods = new Goods();
            //    goods.Id = Id;
            //    goods.State = State;
            //   var resut= db.Updateable<Goods>(  goods );
            //    return resut;
            //}
        }
    }
}
