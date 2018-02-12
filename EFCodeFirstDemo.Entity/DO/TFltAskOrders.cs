using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

/// <summary>
/// 
/// </summary>
namespace EFCodeFirstDemo.Entity.DO
{
	[Table("dbo.t_flt_ask_orders")]
	public partial class TFltAskOrders
	{
		public TFltAskOrders()
		{
			
		}

		/// <summary>
		/// created_by
		/// </summary>
		[Column("created_by")] 
		public int CreatedBy { get; set; }
		
		/// <summary>
		/// creation_date
		/// </summary>
		[Column("creation_date")] 
		public DateTime CreationDate { get; set; }
		
		/// <summary>
		/// last_update_date
		/// </summary>
		[Column("last_update_date")] 
		public DateTime? LastUpdateDate { get; set; }
		
		/// <summary>
		/// last_updated_by
		/// </summary>
		[Column("last_updated_by")] 
		public int? LastUpdatedBy { get; set; }
		
		/// <summary>
		/// login_id
		/// </summary>
		[Column("login_id")] 
		public int? LoginId { get; set; }
		
		/// <summary>
		/// enabled_flag
		/// </summary>
		[Column("enabled_flag")] 
		public string EnabledFlag { get; set; }
		
		/// <summary>
		/// ask_order_id
		/// </summary>
		[Key] 
		[Column("ask_order_id")] 
		public int AskOrderId { get; set; }
		
		/// <summary>
		/// ask_order_no
		/// </summary>
		[Column("ask_order_no")] 
		public string AskOrderNo { get; set; }
		
		/// <summary>
		/// corp_id
		/// </summary>
		[Column("corp_id")] 
		public int CorpId { get; set; }
		
		/// <summary>
		/// staff_id
		/// </summary>
		[Column("staff_id")] 
		public int StaffId { get; set; }
		
		/// <summary>
		/// status
		/// </summary>
		[Column("status")] 
		public string Status { get; set; }
		
		/// <summary>
		/// flight_type
		/// </summary>
		[Column("flight_type")] 
		public string FlightType { get; set; }
		
		/// <summary>
		/// travel_type
		/// </summary>
		[Column("travel_type")] 
		public string TravelType { get; set; }
		
		/// <summary>
		/// travel_reason
		/// </summary>
		[Column("travel_reason")] 
		public string TravelReason { get; set; }
		
		/// <summary>
		/// memo
		/// </summary>
		[Column("memo")] 
		public string Memo { get; set; }
		
		/// <summary>
		/// original_ask_order_no
		/// </summary>
		[Column("original_ask_order_no")] 
		public string OriginalAskOrderNo { get; set; }

        [Column("remark1")]
        public string Remark1 { get; set; }

        [Column("remark2")]
        public string Remark2 { get; set; }

    }
}