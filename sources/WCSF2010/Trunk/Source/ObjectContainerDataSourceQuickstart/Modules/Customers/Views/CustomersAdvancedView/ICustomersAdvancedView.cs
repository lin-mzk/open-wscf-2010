//===============================================================================
// Microsoft patterns & practices
// Web Client Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
using ObjectContainerDataSourceQuickstart.Modules.Customers.BusinessEntities;
using System.Collections.Generic;

namespace ObjectContainerDataSourceQuickstart.Modules.Customers.Views.CustomersAdvancedView
{
    public interface ICustomersAdvancedView
    {
        IList<Customer> Customers { set; }
        int TotalCustomersCount { set; }
    }
}
