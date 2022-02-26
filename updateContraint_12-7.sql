ALTER TABLE [Bills_detail] DROP CONSTRAINT [FK_Id_bill_BillDetail]
go

ALTER TABLE [dbo].[Bills_detail]  WITH CHECK ADD  CONSTRAINT [FK_Id_bill_BillDetail] FOREIGN KEY([Id_bill])
REFERENCES [dbo].[Bills] ([Id_bill]) on delete cascade
go

ALTER TABLE [InputBillsDetaill] DROP CONSTRAINT [FK_ID_InputBills]
go

ALTER TABLE [dbo].[InputBillsDetaill]  WITH CHECK ADD  CONSTRAINT [FK_ID_InputBills] FOREIGN KEY([ID_Bill])
REFERENCES [dbo].[InputBills] ([ID_Bill]) on delete cascade