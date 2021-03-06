// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class ImportExportOperationsExtensions
    {
        /// <summary>
        /// Exports a Azure SQL Database to bacpac. To determine the status of
        /// the operation call GetImportExportOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to export.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for exporting a database.
        /// </param>
        /// <returns>
        /// Response Azure Sql Import/Export operations.
        /// </returns>
        public static ImportExportResponse Export(this IImportExportOperations operations, string resourceGroupName, string serverName, string databaseName, ExportRequestParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IImportExportOperations)s).ExportAsync(resourceGroupName, serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Exports a Azure SQL Database to bacpac. To determine the status of
        /// the operation call GetImportExportOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to export.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for exporting a database.
        /// </param>
        /// <returns>
        /// Response Azure Sql Import/Export operations.
        /// </returns>
        public static Task<ImportExportResponse> ExportAsync(this IImportExportOperations operations, string resourceGroupName, string serverName, string databaseName, ExportRequestParameters parameters)
        {
            return operations.ExportAsync(resourceGroupName, serverName, databaseName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Database import/export operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for Azure Sql Import/Export Status operation.
        /// </returns>
        public static ImportExportOperationStatusResponse GetImportExportOperationStatus(this IImportExportOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IImportExportOperations)s).GetImportExportOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure Sql Database import/export operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for Azure Sql Import/Export Status operation.
        /// </returns>
        public static Task<ImportExportOperationStatusResponse> GetImportExportOperationStatusAsync(this IImportExportOperations operations, string operationStatusLink)
        {
            return operations.GetImportExportOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Imports a bacpac to Azure SQL Database. To determine the status of
        /// the operation call GetImportExportOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for importing to a database.
        /// </param>
        /// <returns>
        /// Response Azure Sql Import/Export operations.
        /// </returns>
        public static ImportExportResponse Import(this IImportExportOperations operations, string resourceGroupName, string serverName, ImportRequestParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IImportExportOperations)s).ImportAsync(resourceGroupName, serverName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Imports a bacpac to Azure SQL Database. To determine the status of
        /// the operation call GetImportExportOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for importing to a database.
        /// </param>
        /// <returns>
        /// Response Azure Sql Import/Export operations.
        /// </returns>
        public static Task<ImportExportResponse> ImportAsync(this IImportExportOperations operations, string resourceGroupName, string serverName, ImportRequestParameters parameters)
        {
            return operations.ImportAsync(resourceGroupName, serverName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Imports a bacpac to an empty Azure SQL Database. To determine the
        /// status of the operation call GetImportExportOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to import to.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for importing to a database.
        /// </param>
        /// <returns>
        /// Response Azure Sql Import/Export operations.
        /// </returns>
        public static ImportExportResponse ImportToExistingDatabase(this IImportExportOperations operations, string resourceGroupName, string serverName, string databaseName, ImportExtensionRequestParameteres parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IImportExportOperations)s).ImportToExistingDatabaseAsync(resourceGroupName, serverName, databaseName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Imports a bacpac to an empty Azure SQL Database. To determine the
        /// status of the operation call GetImportExportOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IImportExportOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the database is
        /// hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Database to import to.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for importing to a database.
        /// </param>
        /// <returns>
        /// Response Azure Sql Import/Export operations.
        /// </returns>
        public static Task<ImportExportResponse> ImportToExistingDatabaseAsync(this IImportExportOperations operations, string resourceGroupName, string serverName, string databaseName, ImportExtensionRequestParameteres parameters)
        {
            return operations.ImportToExistingDatabaseAsync(resourceGroupName, serverName, databaseName, parameters, CancellationToken.None);
        }
    }
}
