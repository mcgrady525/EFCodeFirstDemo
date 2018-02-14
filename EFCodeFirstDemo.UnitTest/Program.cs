using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstDemo.Data;
using EFCodeFirstDemo.Entity.DO;
using EFCodeFirstDemo.Entity.BO;
using SSharing.Frameworks.Common.Extends;
using System.Data.SqlClient;

namespace EFCodeFirstDemo.UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 单条插入
            //TestInsertSingle();

            // 批量插入(EF自带)
            TestInsertBatch();

            // 查询(单表)
            //QuerySingleTable();

            // 查询(多表)
            //QueryMultiTable();

            // 更新
            //Update();

            // 单条删除
            //DeleteSingle();

            // 批量删除
            //DeleteBatch();

            // 事务
            //DoTransaction();
            //DoTransactionByExplicit();

            // 调用存储过程
            //DoStoredProcs();

            Console.ReadKey();
        }

        /// <summary>
        /// 调用存储过程
        /// </summary>
        static void DoStoredProcs()
        {
            //EF 6提供了三种方法使用原生命令
            //DbSet.SqlQuery()，执行sql命令，返回整个entity。
            //DbContext.Database.SqlQuery()，执行sql命令，返回任意自定义类型
            //DbContext.Database.ExecuteSqlCommand()，执行sql命令，处理增，删和改操作

            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                var query = ctx.Database.SqlQuery<GetFltAskOrderRS>("dbo.usp_GetAskOrderByCorpId {0}", 849).ToList();
                foreach (var item in query)
                {
                    Console.WriteLine(string.Format("AskOrderId:{0}, AskOrderNo:{1}, CorpId:{2}, FlightType:{3}, TravelType:{4}", item.AskOrderId, item.AskOrderNo, item.CorpId, item.FlightType, item.TravelType));
                }
            }
        }

        static void DoTransactionByExplicit()
        {
            // 使用DbContext.Database.BeginTransaction()显式事务
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                ctx.Database.Log = Console.Write;

                using (var tran = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        var askOrder = ctx.TFltAskOrders.Where(p => p.CorpId == 849 && p.AskOrderNo == "2018012000001").FirstOrDefault();
                        if (askOrder != null)
                        {
                            ctx.TFltAskOrders.Remove(askOrder);
                        }
                        ctx.SaveChanges();

                        throw new Exception("test transaction!");

                        var fltOrder = ctx.TFltOrders.Where(p => p.OrderNo == "2018012000001").FirstOrDefault();
                        if (fltOrder != null)
                        {
                            ctx.TFltOrders.Remove(fltOrder);
                        }
                        ctx.SaveChanges();

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        Console.WriteLine("error occurred!");
                    }
                }
            }
        }

        /// <summary>
        /// 事务
        /// </summary>
        static void DoTransaction()
        {
            // 使用SaveChanges()默认的事务
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                // 打印数据库操作命令到控制台
                ctx.Database.Log = Console.Write;

                var askOrder = ctx.TFltAskOrders.Where(p => p.CorpId == 849 && p.AskOrderNo == "2018012000001").FirstOrDefault();
                if (askOrder != null)
                {
                    ctx.TFltAskOrders.Remove(askOrder);
                }

                var fltOrder = ctx.TFltOrders.Where(p => p.OrderNo == "2018012000001").FirstOrDefault();
                if (fltOrder != null)
                {
                    ctx.TFltOrders.Remove(fltOrder);
                }

                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        static void DeleteBatch()
        {
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                var askOrders = ctx.TFltAskOrders.Where(p => p.CorpId == 850).ToList();
                if (askOrders.HasValue())
                {
                    ctx.TFltAskOrders.RemoveRange(askOrders);
                }

                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    Console.WriteLine("批量删除成功!");
                }
            }
        }

        /// <summary>
        /// 单条删除
        /// </summary>
        static void DeleteSingle()
        {
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                var askOrder = ctx.TFltAskOrders.Where(p => p.CorpId == 850 && p.AskOrderNo == "2018012000001").FirstOrDefault();
                if (askOrder != null)
                {
                    ctx.TFltAskOrders.Remove(askOrder);
                }

                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    Console.WriteLine("删除成功!");
                }
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        static void Update()
        {
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                //var fltOrder = ctx.TFltOrders.Where(p => p.OrderId == 1).FirstOrDefault();
                //if (fltOrder != null)
                //{
                //    fltOrder.Status = "Changed";
                //}
                var askOrders = ctx.TFltAskOrders.Where(p => p.CorpId == 850).ToList();
                if (askOrders.HasValue())
                {
                    askOrders.ForEach(item =>
                    {
                        item.FlightType = "D";
                    });
                }

                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    Console.WriteLine("更新成功!");
                }
            }
        }

        /// <summary>
        /// 查询(多表)
        /// </summary>
        static void QueryMultiTable()
        {
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                var query = (from order in ctx.TFltOrders
                             join askOrder in ctx.TFltAskOrders on order.AskOrderId equals askOrder.AskOrderId
                             where order.AskOrderId == 26
                             select new
                             {
                                 order.AskOrderId,
                                 order.OrderNo,
                                 order.Status,
                                 order.AirPortTaxFee,
                                 order.TicketPrice,
                                 askOrder.CorpId,
                                 askOrder.FlightType,
                                 askOrder.TravelType
                             }).ToList();
                if (query.HasValue())
                {
                    foreach (var item in query)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// 查询(单表)
        /// </summary>
        static void QuerySingleTable()
        {
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                var result = ctx.TFltAskOrders.Where(p => p.CorpId == 849).ToList();
            }
        }

        /// <summary>
        /// 单条插入
        /// </summary>
        static void TestInsertSingle()
        {
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                var askOrder = new TFltAskOrders
                {
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    AskOrderNo = "2018012000001",
                    CorpId = 849,
                    StaffId = 100,
                    Status = "110",
                    FlightType = "S",
                    TravelType = "B"
                };

                ctx.TFltAskOrders.Add(askOrder);
                ctx.SaveChanges();

                var fltOrder = new TFltOrders
                {
                    CreatedBy = -1,
                    CreationDate = DateTime.Now,
                    AskOrderId = askOrder.AskOrderId,
                    OrderNo = "2018012000001",
                    EmployeeId = -1,
                    Status = "TicketIssued",
                    AirPortTaxFee = 50,
                    TicketPrice = 1000
                };

                ctx.TFltOrders.Add(fltOrder);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 批量插入(EF自带)
        /// </summary>
        static void TestInsertBatch()
        {
            using (var ctx = new EFCodeFirstDemoDBContext())
            {
                var list = new List<TFltAskOrders>();
                for (int i = 1; i < 10; i++)
                {
                    list.Add(new TFltAskOrders
                    {
                        CreatedBy = -1,
                        CreationDate = DateTime.Now,
                        AskOrderNo = string.Format("201801200000{0}", i),
                        CorpId = 850,
                        StaffId = 110,
                        Status = "110",
                        FlightType = "S",
                        TravelType = "B"
                    });
                }

                ctx.TFltAskOrders.AddRange(list);
                var effectedRows = ctx.SaveChanges();
                if (effectedRows > 0)
                {
                    Console.WriteLine("批量插入(EF自带)成功!");
                }
            }
        }
    }
}
