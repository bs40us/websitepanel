// Copyright (c) 2010, SMB SAAS Systems Inc.
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
using System.Collections.Generic;
using System.Text;

namespace WebsitePanel.Providers.HostedSolution
{
	public class ExchangeItemStatistics
	{
		private string itemName;
		private int totalItems;
		private int totalSizeMB;
		private DateTime lastLogon;
		private DateTime lastLogoff;
		private DateTime lastAccessTime;
		private DateTime lastModificationTime;

		public string ItemName
		{
			get { return this.itemName; }
			set { this.itemName = value; }
		}

		public int TotalItems
		{
			get { return this.totalItems; }
			set { this.totalItems = value; }
		}

		public int TotalSizeMB
		{
			get { return this.totalSizeMB; }
			set { this.totalSizeMB = value; }
		}

		public DateTime LastLogon
		{
			get { return this.lastLogon; }
			set { this.lastLogon = value; }
		}

		public DateTime LastLogoff
		{
			get { return this.lastLogoff; }
			set { this.lastLogoff = value; }
		}

		public DateTime LastAccessTime
		{
			get { return lastAccessTime; }
			set { lastAccessTime = value; }
		}

		public DateTime LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
	}
}