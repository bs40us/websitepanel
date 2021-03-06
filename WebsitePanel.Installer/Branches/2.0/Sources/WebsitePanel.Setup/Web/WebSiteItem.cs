// Copyright (c) 2011, SMB SAAS Systems Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  SMB SAAS Systems Inc.  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;

namespace WebsitePanel.Setup.Web
{
	/// <summary>
	/// Web site item.
	/// </summary>
	[Serializable]
	public sealed class WebSiteItem : WebVirtualDirectoryItem
	{
		private string siteId;
		private string siteIPAddress;
		private string logFileDirectory;
		private ServerBinding[] bindings;

		/// <summary>
		/// Initializes a new instance of the class.
		/// </summary>
		public WebSiteItem()
		{
		}

		/// <summary>
		/// Site id.
		/// </summary>
		public string SiteId
		{
			get { return siteId; }
			set { siteId = value; }
		}

		/// <summary>
		/// Site IP address.
		/// </summary>
		public string SiteIPAddress
		{
			get { return siteIPAddress; }
			set { siteIPAddress = value; }
		}

		/// <summary>
		/// Site log file directory.
		/// </summary>
		public string LogFileDirectory
		{
			get { return logFileDirectory; }
			set { logFileDirectory = value; }
		}

		/// <summary>
		/// Site bindings.
		/// </summary>
		public ServerBinding[] Bindings
		{
			get { return bindings; }
			set { bindings = value; }
		}
	}
}
