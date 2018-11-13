using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using Oracle.ManagedDataAccess.Client;
using Model;
using Newtonsoft.Json; 

namespace Common
{
    public static class OraclePaging
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tName">表 名</param>
        /// <param name="strSql">查询条件</param>
        /// <param name="sortRow">排序的列</param>
        /// <param name="sortMethod">排序方式</param>
        /// <param name="curPage">当前页</param>
        /// <param name="pageSize">每页显示记录条数</param>
        /// <param name="pageCount">总页数</param>
        /// <param name="RecordCount">总记录数</param>
        /// <returns></returns>
        public static PageResult<T> QuickPage<T>(PageParams pageParams)
        {
            OracleConnection conn = new OracleConnection("Data Source=169.254.195.158/orcl;User ID=scott;Password=tiger");
            OracleCommand cmd = new OracleCommand
            {
                Connection = conn,
                CommandText = "prc_query",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("p_tableName", OracleDbType.Varchar2, 50); //表 名
            cmd.Parameters["p_tableName"].Direction = ParameterDirection.Input;
            cmd.Parameters["p_tableName"].Value = pageParams.TableName;

            cmd.Parameters.Add("p_strWhere", OracleDbType.Varchar2, 3000); //查询条件
            cmd.Parameters["p_strWhere"].Direction = ParameterDirection.Input;
            cmd.Parameters["p_strWhere"].Value = pageParams.StrWhere;

            cmd.Parameters.Add("p_orderColumn", OracleDbType.Varchar2, 3000); //排序的列
            cmd.Parameters["p_orderColumn"].Direction = ParameterDirection.Input;
            cmd.Parameters["p_orderColumn"].Value = pageParams.SortRow;

            cmd.Parameters.Add("p_orderStyle", OracleDbType.Varchar2, 3000); //排序方式
            cmd.Parameters["p_orderStyle"].Direction = ParameterDirection.Input;
            cmd.Parameters["p_orderStyle"].Value = pageParams.SortMethod; 

            cmd.Parameters.Add("p_curPage", OracleDbType.Int32); //当前页
            cmd.Parameters["p_curPage"].Direction = ParameterDirection.Input;
            cmd.Parameters["p_curPage"].Value = pageParams.CurPage;

            cmd.Parameters.Add("p_pageSize", OracleDbType.Int32); //每页显示记录条数
            cmd.Parameters["p_pageSize"].Direction = ParameterDirection.Input;
            cmd.Parameters["p_pageSize"].Value = pageParams.PageSize;

            cmd.Parameters.Add("p_totalRecords", OracleDbType.Int32); //总记录数
            cmd.Parameters["p_totalRecords"].Direction = ParameterDirection.Output;
            cmd.Parameters["p_totalRecords"].Value = 0;

            cmd.Parameters.Add("p_totalPages", OracleDbType.Int32); //总页数
            cmd.Parameters["p_totalPages"].Direction = ParameterDirection.Output;
            cmd.Parameters["p_totalPages"].Value = 0;

            cmd.Parameters.Add("v_cur", OracleDbType.RefCursor); //返回的游标
            cmd.Parameters["v_cur"].Direction = ParameterDirection.Output;

            DataSet Ds = new DataSet();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(Ds);
            conn.Close();
            PageResult<T> pageResult = new PageResult<T>
            {
                //总记录数
                TotalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(cmd.Parameters["p_totalPages"].Value.ToString()))),
                //总页数
                TotalCount = int.Parse(cmd.Parameters["p_totalRecords"].Value.ToString())
            };
            //返回的表
            DataTable dt = Ds.Tables[0];
            pageResult.DataList = JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(dt));
            //当前页码
            //curPage = int.Parse(cmd.Parameters["p_curPage"].Value.ToString());
            //TotalPages = int.Parse(cmd.Parameters["p_totalPages"].Value.ToString());
            return pageResult;
        }
    }
}
