using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// 
/// </summary>
namespace EFCodeFirstDemo.Entity.DO
{
	[Table("dbo.t_flt_orders")]
	public partial class TFltOrders
	{
		public TFltOrders()
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
		/// order_id
		/// </summary>
		[Key] 
		[Column("order_id")] 
		public int OrderId { get; set; }
		
		/// <summary>
		/// ask_order_id
		/// </summary>
		[Column("ask_order_id")] 
		public int? AskOrderId { get; set; }
		
		/// <summary>
		/// order_no
		/// </summary>
		[Column("order_no")] 
		public string OrderNo { get; set; }
		
		/// <summary>
		/// order_flag
		/// </summary>
		[Column("order_flag")] 
		public string OrderFlag { get; set; }
		
		/// <summary>
		/// employee_id
		/// </summary>
		[Column("employee_id")] 
		public int EmployeeId { get; set; }
		
		/// <summary>
		/// status
		/// </summary>
		[Column("status")] 
		public string Status { get; set; }
		
		/// <summary>
		/// payment_status
		/// </summary>
		[Column("payment_status")] 
		public string PaymentStatus { get; set; }
		
		/// <summary>
		/// air_port_tax_fee
		/// </summary>
		[Column("air_port_tax_fee")] 
		public double AirPortTaxFee { get; set; }
		
		/// <summary>
		/// oil_fee
		/// </summary>
		[Column("oil_fee")] 
		public double? OilFee { get; set; }
		
		/// <summary>
		/// ticket_price
		/// </summary>
		[Column("ticket_price")] 
		public double TicketPrice { get; set; }
		
		/// <summary>
		/// ticket_type
		/// </summary>
		[Column("ticket_type")] 
		public string TicketType { get; set; }
		
		/// <summary>
		/// book_type
		/// </summary>
		[Column("book_type")] 
		public string BookType { get; set; }
		
		/// <summary>
		/// is_dist_flag
		/// </summary>
		[Column("is_dist_flag")] 
		public string IsDistFlag { get; set; }
		
		/// <summary>
		/// dist_date
		/// </summary>
		[Column("dist_date")] 
		public DateTime? DistDate { get; set; }
		
		/// <summary>
		/// pnr_code
		/// </summary>
		[Column("pnr_code")] 
		public string PnrCode { get; set; }
		
		/// <summary>
		/// book_seat_emp_id
		/// </summary>
		[Column("book_seat_emp_id")] 
		public int? BookSeatEmpId { get; set; }
		
		/// <summary>
		/// book_seat_date
		/// </summary>
		[Column("book_seat_date")] 
		public DateTime? BookSeatDate { get; set; }
		
		/// <summary>
		/// ticket_no
		/// </summary>
		[Column("ticket_no")] 
		public string TicketNo { get; set; }
		
		/// <summary>
		/// ticketing_date
		/// </summary>
		[Column("ticketing_date")] 
		public DateTime? TicketingDate { get; set; }
		
		/// <summary>
		/// ticketing_emp_id
		/// </summary>
		[Column("ticketing_emp_id")] 
		public int? TicketingEmpId { get; set; }
		
		/// <summary>
		/// return_date
		/// </summary>
		[Column("return_date")] 
		public DateTime? ReturnDate { get; set; }
		
		/// <summary>
		/// return_emp_id
		/// </summary>
		[Column("return_emp_id")] 
		public string ReturnEmpId { get; set; }
		
		/// <summary>
		/// data_source
		/// </summary>
		[Column("data_source")] 
		public string DataSource { get; set; }
		
		/// <summary>
		/// src_order_id
		/// </summary>
		[Column("src_order_id")] 
		public int? SrcOrderId { get; set; }
		
		/// <summary>
		/// sign_intention
		/// </summary>
		[Column("sign_intention")] 
		public string SignIntention { get; set; }
		
		/// <summary>
		/// return_ticket_fee
		/// </summary>
		[Column("return_ticket_fee")] 
		public double? ReturnTicketFee { get; set; }
		
		/// <summary>
		/// sign_fee
		/// </summary>
		[Column("sign_fee")] 
		public double? SignFee { get; set; }
		
		/// <summary>
		/// memo
		/// </summary>
		[Column("memo")] 
		public string Memo { get; set; }
		
		/// <summary>
		/// check_status
		/// </summary>
		[Column("check_status")] 
		public string CheckStatus { get; set; }
		
		/// <summary>
		/// check_emp_id
		/// </summary>
		[Column("check_emp_id")] 
		public int? CheckEmpId { get; set; }
		
		/// <summary>
		/// check_date
		/// </summary>
		[Column("check_date")] 
		public DateTime? CheckDate { get; set; }
		
		/// <summary>
		/// profit_amt
		/// </summary>
		[Column("profit_amt")] 
		public double? ProfitAmt { get; set; }
		
		/// <summary>
		/// is_low_flag
		/// </summary>
		[Column("is_low_flag")] 
		public string IsLowFlag { get; set; }
		
		/// <summary>
		/// not_low_reason
		/// </summary>
		[Column("not_low_reason")] 
		public string NotLowReason { get; set; }
		
		/// <summary>
		/// dist_amt
		/// </summary>
		[Column("dist_amt")] 
		public double? DistAmt { get; set; }
		
		/// <summary>
		/// fact_amt
		/// </summary>
		[Column("fact_amt")] 
		public double? FactAmt { get; set; }
		
		/// <summary>
		/// payment_amt
		/// </summary>
		[Column("payment_amt")] 
		public double? PaymentAmt { get; set; }
		
		/// <summary>
		/// profit_rate
		/// </summary>
		[Column("profit_rate")] 
		public double? ProfitRate { get; set; }
		
		/// <summary>
		/// order_seq
		/// </summary>
		[Column("order_seq")] 
		public string OrderSeq { get; set; }
		
		/// <summary>
		/// insurance_fee
		/// </summary>
		[Column("insurance_fee")] 
		public double? InsuranceFee { get; set; }
		
		/// <summary>
		/// favorable_amt
		/// </summary>
		[Column("favorable_amt")] 
		public double? FavorableAmt { get; set; }
		
		/// <summary>
		/// not_low_reason_desc
		/// </summary>
		[Column("not_low_reason_desc")] 
		public string NotLowReasonDesc { get; set; }
		
		/// <summary>
		/// paid_amt
		/// </summary>
		[Column("paid_amt")] 
		public double? PaidAmt { get; set; }
		
		/// <summary>
		/// book_seat_flag
		/// </summary>
		[Column("book_seat_flag")] 
		public string BookSeatFlag { get; set; }
		
		/// <summary>
		/// ticketing_apply_flag
		/// </summary>
		[Column("ticketing_apply_flag")] 
		public string TicketingApplyFlag { get; set; }
		
		/// <summary>
		/// return_apply_date
		/// </summary>
		[Column("return_apply_date")] 
		public DateTime? ReturnApplyDate { get; set; }
		
		/// <summary>
		/// sign_apply_date
		/// </summary>
		[Column("sign_apply_date")] 
		public DateTime? SignApplyDate { get; set; }
		
		/// <summary>
		/// refund_apply_date
		/// </summary>
		[Column("refund_apply_date")] 
		public DateTime? RefundApplyDate { get; set; }
		
		/// <summary>
		/// dist_emp_id
		/// </summary>
		[Column("dist_emp_id")] 
		public int? DistEmpId { get; set; }
		
		/// <summary>
		/// payment_date
		/// </summary>
		[Column("payment_date")] 
		public DateTime? PaymentDate { get; set; }
		
		/// <summary>
		/// cancel_apply_date
		/// </summary>
		[Column("cancel_apply_date")] 
		public DateTime? CancelApplyDate { get; set; }
		
		/// <summary>
		/// cancel_date
		/// </summary>
		[Column("cancel_date")] 
		public DateTime? CancelDate { get; set; }
		
		/// <summary>
		/// sign_date
		/// </summary>
		[Column("sign_date")] 
		public DateTime? SignDate { get; set; }
		
		/// <summary>
		/// sign_proc_fee
		/// </summary>
		[Column("sign_proc_fee")] 
		public double? SignProcFee { get; set; }
		
		/// <summary>
		/// service_fee
		/// </summary>
		[Column("service_fee")] 
		public double? ServiceFee { get; set; }
		
		/// <summary>
		/// return_ticket_amt
		/// </summary>
		[Column("return_ticket_amt")] 
		public double? ReturnTicketAmt { get; set; }
		
		/// <summary>
		/// sign_proc_amt
		/// </summary>
		[Column("sign_proc_amt")] 
		public double? SignProcAmt { get; set; }
		
		/// <summary>
		/// ibe_price
		/// </summary>
		[Column("ibe_price")] 
		public double? IbePrice { get; set; }
		
		/// <summary>
		/// lower_price
		/// </summary>
		[Column("lower_price")] 
		public double? LowerPrice { get; set; }
		
		/// <summary>
		/// supplier_name
		/// </summary>
		[Column("supplier_name")] 
		public string SupplierName { get; set; }
		
		/// <summary>
		/// supplier_pay_mode
		/// </summary>
		[Column("supplier_pay_mode")] 
		public string SupplierPayMode { get; set; }
		
		/// <summary>
		/// supplier_pay_mode_others
		/// </summary>
		[Column("supplier_pay_mode_others")] 
		public string SupplierPayModeOthers { get; set; }
		
		/// <summary>
		/// sync_operations
		/// </summary>
		[Column("sync_operations")] 
		public string SyncOperations { get; set; }
		
		/// <summary>
		/// not_check_in
		/// </summary>
		[Column("not_check_in")] 
		public string NotCheckIn { get; set; }
		
		/// <summary>
		/// authorize_status
		/// </summary>
		[Column("authorize_status")] 
		public string AuthorizeStatus { get; set; }
		
		/// <summary>
		/// authorize_date
		/// </summary>
		[Column("authorize_date")] 
		public DateTime? AuthorizeDate { get; set; }
		
		/// <summary>
		/// authorize_emp_id
		/// </summary>
		[Column("authorize_emp_id")] 
		public int? AuthorizeEmpId { get; set; }
		
		/// <summary>
		/// insurance_numbers
		/// </summary>
		[Column("insurance_numbers")] 
		public string InsuranceNumbers { get; set; }
		
		/// <summary>
		/// overrun_authorize_status
		/// </summary>
		[Column("overrun_authorize_status")] 
		public string OverrunAuthorizeStatus { get; set; }
		
		/// <summary>
		/// overrun_authorize_date
		/// </summary>
		[Column("overrun_authorize_date")] 
		public DateTime? OverrunAuthorizeDate { get; set; }
		
		/// <summary>
		/// exceed_authorize_emp_id
		/// </summary>
		[Column("exceed_authorize_emp_id")] 
		public int? ExceedAuthorizeEmpId { get; set; }
		
		/// <summary>
		/// overrun_authorize_memo
		/// </summary>
		[Column("overrun_authorize_memo")] 
		public string OverrunAuthorizeMemo { get; set; }
		
		/// <summary>
		/// return_insurance
		/// </summary>
		[Column("return_insurance")] 
		public string ReturnInsurance { get; set; }
		
		/// <summary>
		/// opt_code
		/// </summary>
		[Column("opt_code")] 
		public string OptCode { get; set; }
		
		/// <summary>
		/// operating_dept_id
		/// </summary>
		[Column("operating_dept_id")] 
		public int? OperatingDeptId { get; set; }
		
		/// <summary>
		/// supplier_code
		/// </summary>
		[Column("supplier_code")] 
		public string SupplierCode { get; set; }
		
		/// <summary>
		/// book51_order_no
		/// </summary>
		[Column("book51_order_no")] 
		public string Book51OrderNo { get; set; }
		
		/// <summary>
		/// book51_policy_id
		/// </summary>
		[Column("book51_policy_id")] 
		public string Book51PolicyId { get; set; }
		
		/// <summary>
		/// book51_order_status
		/// </summary>
		[Column("book51_order_status")] 
		public int? Book51OrderStatus { get; set; }
		
		/// <summary>
		/// book51_pay_status
		/// </summary>
		[Column("book51_pay_status")] 
		public string Book51PayStatus { get; set; }
		
		/// <summary>
		/// book51_ticket_price
		/// </summary>
		[Column("book51_ticket_price")] 
		public double? Book51TicketPrice { get; set; }
		
		/// <summary>
		/// book51_creat_order_time
		/// </summary>
		[Column("book51_creat_order_time")] 
		public DateTime? Book51CreatOrderTime { get; set; }
		
		/// <summary>
		/// book51_fuel_tax
		/// </summary>
		[Column("book51_fuel_tax")] 
		public double? Book51FuelTax { get; set; }
		
		/// <summary>
		/// book51_airport_tax
		/// </summary>
		[Column("book51_airport_tax")] 
		public double? Book51AirportTax { get; set; }
		
		/// <summary>
		/// air_port_tax_fee_supplier
		/// </summary>
		[Column("air_port_tax_fee_supplier")] 
		public double? AirPortTaxFeeSupplier { get; set; }
		
		/// <summary>
		/// oil_fee_supplier
		/// </summary>
		[Column("oil_fee_supplier")] 
		public double? OilFeeSupplier { get; set; }
		
		/// <summary>
		/// booking_amt
		/// </summary>
		[Column("booking_amt")] 
		public double? BookingAmt { get; set; }
		
		/// <summary>
		/// favour_amt
		/// </summary>
		[Column("favour_amt")] 
		public double? FavourAmt { get; set; }
		
		/// <summary>
		/// protocol_favour_amt
		/// </summary>
		[Column("protocol_favour_amt")] 
		public double? ProtocolFavourAmt { get; set; }
		
		/// <summary>
		/// customer_protocol_code
		/// </summary>
		[Column("customer_protocol_code")] 
		public string CustomerProtocolCode { get; set; }
		
		/// <summary>
		/// green_channel_flag
		/// </summary>
		[Column("green_channel_flag")] 
		public string GreenChannelFlag { get; set; }
		
		/// <summary>
		/// is_auto_bookseat
		/// </summary>
		[Column("is_auto_bookseat")] 
		public string IsAutoBookseat { get; set; }
		
		/// <summary>
		/// insuracne_fee_supplier
		/// </summary>
		[Column("insuracne_fee_supplier")] 
		public double? InsuracneFeeSupplier { get; set; }
		
		/// <summary>
		/// ticketing_time_limit
		/// </summary>
		[Column("ticketing_time_limit")] 
		public DateTime? TicketingTimeLimit { get; set; }
		
		/// <summary>
		/// sign_diff_supplier
		/// </summary>
		[Column("sign_diff_supplier")] 
		public double? SignDiffSupplier { get; set; }
		
		/// <summary>
		/// sign_fee_supplier
		/// </summary>
		[Column("sign_fee_supplier")] 
		public double? SignFeeSupplier { get; set; }
		
		/// <summary>
		/// is_english
		/// </summary>
		[Column("is_english")] 
		public string IsEnglish { get; set; }
		
		/// <summary>
		/// expense_status
		/// </summary>
		[Column("expense_status")] 
		public string ExpenseStatus { get; set; }
		
		/// <summary>
		/// supplier_business_no
		/// </summary>
		[Column("supplier_business_no")] 
		public string SupplierBusinessNo { get; set; }
		
		/// <summary>
		/// rebate_rate
		/// </summary>
		[Column("rebate_rate")] 
		public double? RebateRate { get; set; }
		
		/// <summary>
		/// rule_code
		/// </summary>
		[Column("rule_code")] 
		public string RuleCode { get; set; }
		
		/// <summary>
		/// supplier_codes
		/// </summary>
		[Column("supplier_codes")] 
		public string SupplierCodes { get; set; }
		
		/// <summary>
		/// auto_ticketing_result
		/// </summary>
		[Column("auto_ticketing_result")] 
		public string AutoTicketingResult { get; set; }
		
		/// <summary>
		/// click_51book_times
		/// </summary>
		[Column("click_51book_times")] 
		public int? Click51bookTimes { get; set; }
		
		/// <summary>
		/// click_bsp_times
		/// </summary>
		[Column("click_bsp_times")] 
		public int? ClickBspTimes { get; set; }
		
		/// <summary>
		/// click_insurance_times
		/// </summary>
		[Column("click_insurance_times")] 
		public int? ClickInsuranceTimes { get; set; }
		
		/// <summary>
		/// click_yeeego_times
		/// </summary>
		[Column("click_yeeego_times")] 
		public int? ClickYeeegoTimes { get; set; }
		
		/// <summary>
		/// ticket_checking_status
		/// </summary>
		[Column("ticket_checking_status")] 
		public string TicketCheckingStatus { get; set; }
		
		/// <summary>
		/// hkws_order_no
		/// </summary>
		[Column("hkws_order_no")] 
		public string HkwsOrderNo { get; set; }
		
		/// <summary>
		/// yeego_policyid
		/// </summary>
		[Column("yeego_policyid")] 
		public string YeegoPolicyid { get; set; }
		
		/// <summary>
		/// yeego_platcode
		/// </summary>
		[Column("yeego_platcode")] 
		public string YeegoPlatcode { get; set; }
		
		/// <summary>
		/// yeego_platformtype
		/// </summary>
		[Column("yeego_platformtype")] 
		public string YeegoPlatformtype { get; set; }
		
		/// <summary>
		/// yeego_isvip
		/// </summary>
		[Column("yeego_isvip")] 
		public string YeegoIsvip { get; set; }
		
		/// <summary>
		/// yeego_balance_money
		/// </summary>
		[Column("yeego_balance_money")] 
		public double? YeegoBalanceMoney { get; set; }
		
		/// <summary>
		/// yeego_remark
		/// </summary>
		[Column("yeego_remark")] 
		public string YeegoRemark { get; set; }
		
		/// <summary>
		/// yeego_plat_orderno
		/// </summary>
		[Column("yeego_plat_orderno")] 
		public string YeegoPlatOrderno { get; set; }
		
		/// <summary>
		/// yeego_orderno
		/// </summary>
		[Column("yeego_orderno")] 
		public string YeegoOrderno { get; set; }
		
		/// <summary>
		/// office_no
		/// </summary>
		[Column("office_no")] 
		public string OfficeNo { get; set; }
		
		/// <summary>
		/// fwf_fee
		/// </summary>
		[Column("fwf_fee")] 
		public int? FwfFee { get; set; }
		
		/// <summary>
		/// opt_memo
		/// </summary>
		[Column("opt_memo")] 
		public string OptMemo { get; set; }
		
		/// <summary>
		/// is_uatp
		/// </summary>
		[Column("is_uatp")] 
		public string IsUatp { get; set; }
		
		/// <summary>
		/// uatp_code
		/// </summary>
		[Column("uatp_code")] 
		public string UatpCode { get; set; }
		
		/// <summary>
		/// checkinstatus_failcount
		/// </summary>
		[Column("checkinstatus_failcount")] 
		public int? CheckinstatusFailcount { get; set; }
		
		/// <summary>
		/// unExpected_insurance_fee
		/// </summary>
		[Column("unExpected_insurance_fee")] 
		public double? UnExpectedInsuranceFee { get; set; }
		
		/// <summary>
		/// delay_insurance_fee
		/// </summary>
		[Column("delay_insurance_fee")] 
		public double? DelayInsuranceFee { get; set; }
		
		/// <summary>
		/// is_return_unExpected_insurance
		/// </summary>
		[Column("is_return_unExpected_insurance")] 
		public string IsReturnUnExpectedInsurance { get; set; }
		
		/// <summary>
		/// is_return_delay_insurance
		/// </summary>
		[Column("is_return_delay_insurance")] 
		public string IsReturnDelayInsurance { get; set; }
		
		/// <summary>
		/// unExpected_insuranceFee_supplier
		/// </summary>
		[Column("unExpected_insuranceFee_supplier")] 
		public double? UnExpectedInsuranceFeeSupplier { get; set; }
		
		/// <summary>
		/// delay_insuranceFee_supplier
		/// </summary>
		[Column("delay_insuranceFee_supplier")] 
		public double? DelayInsuranceFeeSupplier { get; set; }
		
		/// <summary>
		/// change_delay_insurance_fee
		/// </summary>
		[Column("change_delay_insurance_fee")] 
		public double? ChangeDelayInsuranceFee { get; set; }
		
		/// <summary>
		/// book_seat_office_no
		/// </summary>
		[Column("book_seat_office_no")] 
		public string BookSeatOfficeNo { get; set; }
		
		/// <summary>
		/// click_bspplus_times
		/// </summary>
		[Column("click_bspplus_times")] 
		public int? ClickBspplusTimes { get; set; }
		
		/// <summary>
		/// click_bop_times
		/// </summary>
		[Column("click_bop_times")] 
		public int? ClickBopTimes { get; set; }
		
		/// <summary>
		/// force_insurance_fee
		/// </summary>
		[Column("force_insurance_fee")] 
		public double? ForceInsuranceFee { get; set; }
		
		/// <summary>
		/// transaction_id
		/// </summary>
		[Column("transaction_id")] 
		public string TransactionId { get; set; }
		
		/// <summary>
		/// discount_over
		/// </summary>
		[Column("discount_over")] 
		public int? DiscountOver { get; set; }
		
		/// <summary>
		/// arrival_city
		/// </summary>
		[Column("arrival_city")] 
		public string ArrivalCity { get; set; }
		
		/// <summary>
		/// discount
		/// </summary>
		[Column("discount")] 
		public decimal? Discount { get; set; }
		
		/// <summary>
		/// travel_reason
		/// </summary>
		[Column("travel_reason")] 
		public string TravelReason { get; set; }
		
		/// <summary>
		/// is_return_force_insurance
		/// </summary>
		[Column("is_return_force_insurance")] 
		public string IsReturnForceInsurance { get; set; }
		
		/// <summary>
		/// authorize_type
		/// </summary>
		[Column("authorize_type")] 
		public string AuthorizeType { get; set; }
		
		/// <summary>
		/// overrun_authorize_type
		/// </summary>
		[Column("overrun_authorize_type")] 
		public string OverrunAuthorizeType { get; set; }
		
	}
}