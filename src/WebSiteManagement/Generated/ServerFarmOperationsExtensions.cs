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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.WebSites;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Web Sites Management API provides a RESTful set of web services
    /// that interact with the Windows Azure Web Sites service to manage your
    /// web sites. The API has entities that capture the relationship between
    /// an end user and Windows Azure Web Sites service.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public static partial class ServerFarmOperationsExtensions
    {
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Server Farm operation.
        /// </param>
        /// <returns>
        /// The Create Server Farm operation response.
        /// </returns>
        public static ServerFarmCreateResponse Create(this IServerFarmOperations operations, string webSpaceName, ServerFarmCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerFarmOperations)s).CreateAsync(webSpaceName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Server Farm operation.
        /// </param>
        /// <returns>
        /// The Create Server Farm operation response.
        /// </returns>
        public static Task<ServerFarmCreateResponse> CreateAsync(this IServerFarmOperations operations, string webSpaceName, ServerFarmCreateParameters parameters)
        {
            return operations.CreateAsync(webSpaceName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IServerFarmOperations operations, string webSpaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerFarmOperations)s).DeleteAsync(webSpaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IServerFarmOperations operations, string webSpaceName)
        {
            return operations.DeleteAsync(webSpaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='serverFarmName'>
        /// Required. The name of the server farm.
        /// </param>
        /// <returns>
        /// The Get Server Farm operation response.
        /// </returns>
        public static ServerFarmGetResponse Get(this IServerFarmOperations operations, string webSpaceName, string serverFarmName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerFarmOperations)s).GetAsync(webSpaceName, serverFarmName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='serverFarmName'>
        /// Required. The name of the server farm.
        /// </param>
        /// <returns>
        /// The Get Server Farm operation response.
        /// </returns>
        public static Task<ServerFarmGetResponse> GetAsync(this IServerFarmOperations operations, string webSpaceName, string serverFarmName)
        {
            return operations.GetAsync(webSpaceName, serverFarmName, CancellationToken.None);
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <returns>
        /// The List Server Farm operation response.
        /// </returns>
        public static ServerFarmListResponse List(this IServerFarmOperations operations, string webSpaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerFarmOperations)s).ListAsync(webSpaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <returns>
        /// The List Server Farm operation response.
        /// </returns>
        public static Task<ServerFarmListResponse> ListAsync(this IServerFarmOperations operations, string webSpaceName)
        {
            return operations.ListAsync(webSpaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Server Farm operation.
        /// </param>
        /// <returns>
        /// The Update Server Farm operation response.
        /// </returns>
        public static ServerFarmUpdateResponse Update(this IServerFarmOperations operations, string webSpaceName, ServerFarmUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerFarmOperations)s).UpdateAsync(webSpaceName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// You can create a server farm by issuing an HTTP POST request. Only
        /// one server farm per webspace is permitted. You can retrieve server
        /// farm details by using HTTP GET, change server farm properties by
        /// using HTTP PUT, and delete a server farm by using HTTP DELETE. A
        /// request body is required for server farm creation (HTTP POST) and
        /// server farm update (HTTP PUT). Warning: Creating a server farm
        /// changes your webspace's Compute Mode from Shared to Dedicated. You
        /// will be charged from the moment the server farm is created, even
        /// if all your sites are still running in Free mode.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.WebSites.IServerFarmOperations.
        /// </param>
        /// <param name='webSpaceName'>
        /// Required. The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Server Farm operation.
        /// </param>
        /// <returns>
        /// The Update Server Farm operation response.
        /// </returns>
        public static Task<ServerFarmUpdateResponse> UpdateAsync(this IServerFarmOperations operations, string webSpaceName, ServerFarmUpdateParameters parameters)
        {
            return operations.UpdateAsync(webSpaceName, parameters, CancellationToken.None);
        }
    }
}
