-- DROP all constraints
declare @sql nvarchar(max) = (
    select 
        'alter table ' + quotename(schema_name(schema_id)) + '.' +
        quotename(object_name(parent_object_id)) +
        ' drop constraint '+quotename(name) + ';'
    from sys.foreign_keys
    for xml path('')
);
exec sp_executesql @sql;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roadkill_pagecontent]') AND type in (N'U'))
DROP TABLE [dbo].[roadkill_pagecontent];

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roadkill_collections]') AND type in (N'U'))
DROP TABLE [dbo].[roadkill_collections];

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roadkill_collectionpage]') AND type in (N'U'))
DROP TABLE [dbo].[roadkill_collectionpage];

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roadkill_pages]') AND type in (N'U'))
DROP TABLE [dbo].[roadkill_pages];

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roadkill_users]') AND type in (N'U'))
DROP TABLE [dbo].[roadkill_users];

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roadkill_siteconfiguration]') AND type in (N'U'))
DROP TABLE [dbo].[roadkill_siteconfiguration];