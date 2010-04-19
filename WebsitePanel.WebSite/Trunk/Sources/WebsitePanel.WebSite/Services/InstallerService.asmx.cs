﻿/* Copyright (c) 2010, SMB SAAS Systems Inc. All rights reserved.

Redistribution and use in source and binary forms, with or without modification,
are permitted provided that the following conditions are met:

- Redistributions of source code must  retain  the  above copyright notice, this
  list of conditions and the following disclaimer.

- Redistributions in binary form  must  reproduce the  above  copyright  notice,
  this list of conditions  and  the  following  disclaimer in  the documentation
  and/or other materials provided with the distribution.

- Neither  the  name  of  the  SMB SAAS Systems Inc.  nor   the   names  of  its
  contributors may be used to endorse or  promote  products  derived  from  this
  software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace WebsitePanel.WebSite.Services
{
    /// <summary>
    /// Summary description for InstallerService
    /// </summary>
    [WebService(Namespace = "http://websitepanel.net/services")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InstallerService : InstallerServiceBase
    {
        [WebMethod]
        public DataSet GetAvailableComponents()
        {
            return GetAvailableComponents(false);
        }

        [WebMethod]
        public DataSet GetLatestComponentUpdate(string componentCode)
        {
            return GetLatestComponentUpdate(componentCode, false);
        }

        [WebMethod]
        public DataSet GetComponentUpdate(string componentCode, string release)
        {
            return GetComponentUpdate(componentCode, release, false);
        }
    }
}