USE EFCodeFirstDemoDB;
GO


--创建存储过程usp_GetAskOrderByCorpId
IF OBJECT_ID('usp_GetAskOrderByCorpId', 'P') IS NOT NULL
    DROP PROC usp_GetAskOrderByCorpId;
GO

CREATE PROC usp_GetAskOrderByCorpId @CorpId AS INT
AS
BEGIN
    SELECT askOrder.ask_order_id AS AskOrderId,
        askOrder.ask_order_no AS AskOrderNo,
        askOrder.corp_id AS CorpId,
        askOrder.flight_type AS FlightType,
        askOrder.travel_type AS TravelType
    FROM dbo.t_flt_ask_orders (NOLOCK) AS askOrder
    WHERE askOrder.corp_id = @CorpId;
END;
GO