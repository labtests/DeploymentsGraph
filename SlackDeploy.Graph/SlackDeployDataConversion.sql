
SELECT [id],[sha],[date],DATEADD(SECOND, [date], '19700101 00:00'),[action],[engineer],[TimeStamp] FROM [dbo].[deploys]

--ALTER TABLE [dbo].[deploys] ADD [timestamp] DateTime
--UPDATE [dbo].[deploys] SET [TimeStamp] = DATEADD(SECOND, [date], '19700101 00:00')

