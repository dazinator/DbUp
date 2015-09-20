﻿[assembly: System.CLSCompliantAttribute(true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.InteropServices.GuidAttribute("2523f9cc-42c7-48da-b873-74851c335931")]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.0", FrameworkDisplayName=".NET Framework 4")]

namespace DbUp.SqlCe
{
    
    public class SqlCeConnectionManager : DbUp.Engine.Transactions.DatabaseConnectionManager
    {
        public SqlCeConnectionManager(string connectionString) { }
        public override System.Collections.Generic.IEnumerable<string> SplitScriptIntoCommands(string scriptContents) { }
    }
    public class SqlCePreprocessor : DbUp.Engine.IScriptPreprocessor
    {
        public SqlCePreprocessor() { }
        public string Process(string contents) { }
    }
    public class SqlCeScriptExecutor : DbUp.Support.ScriptExecutor
    {
        public SqlCeScriptExecutor(System.Func<DbUp.Engine.Transactions.IConnectionManager> connectionManagerFactory, System.Func<DbUp.Engine.Output.IUpgradeLog> log, string schema, System.Func<bool> variablesEnabled, System.Collections.Generic.IEnumerable<DbUp.Engine.IScriptPreprocessor> scriptPreprocessors) { }
        protected override void ExecuteCommandsWithinExceptionHandler(int index, DbUp.Engine.SqlScript script, System.Action excuteCommand) { }
        protected override string GetVerifySchemaSql(string schema) { }
        protected override string QuoteSqlObjectName(string objectName) { }
    }
    public class SqlCeTableJournal : DbUp.Support.TableJournal
    {
        public SqlCeTableJournal(System.Func<DbUp.Engine.Transactions.IConnectionManager> connectionManager, System.Func<DbUp.Engine.Output.IUpgradeLog> logger, string schema, string table) { }
        protected override System.Data.IDbCommand GetCreateTableCommand(System.Func<System.Data.IDbCommand> dbCommandFactory, string schemaTableName) { }
        protected virtual string GetCreateTableSql(string tableName) { }
        protected virtual string GetExecutedScriptsSql(string table) { }
        protected override System.Data.IDbCommand GetInsertScriptCommand(System.Func<System.Data.IDbCommand> dbCommandFactory, DbUp.Engine.SqlScript script) { }
        protected override System.Data.IDbCommand GetSelectExecutedScriptsCommand(System.Func<System.Data.IDbCommand> dbCommandFactory, string schemaTableName) { }
        protected override string QuoteSqlObjectName(string objectName) { }
    }
}

public class static SqlCeExtensions
{
    [System.ObsoleteAttribute("Pass connection string instead, then use .WithTransaction() and .WithTransactionP" +
        "erScript() to manage connection behaviour")]
    public static DbUp.Builder.UpgradeEngineBuilder SqlCeDatabase(this DbUp.Builder.SupportedDatabases supported, System.Func<System.Data.SqlServerCe.SqlCeConnection> connectionFactory) { }
    public static DbUp.Builder.UpgradeEngineBuilder SqlCeDatabase(this DbUp.Builder.SupportedDatabases supported, string connectionString) { }
}