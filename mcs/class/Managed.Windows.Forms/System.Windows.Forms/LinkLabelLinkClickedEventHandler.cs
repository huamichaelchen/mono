//
// System.LinkLabelLinkClickEventHandler.cs
//  
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Jordi Mas i Hernandez, jordi@ximian.com
//	Dennis hayes (dennish@raytek.com)
//
//
// $Revision: 1.2 $
// $Modtime: $
// $Log: LinkLabelLinkClickedEventHandler.cs,v $
// Revision 1.2  2004/07/22 15:22:19  jordi
// link label: check link overlapping, implement events, and fixes
//
// Revision 1.1  2004/07/21 16:19:17  jordi
// LinkLabel control implementation
//
//

// COMPLETE

namespace System.Windows.Forms 
{
	[Serializable]
	public delegate void LinkLabelLinkClickedEventHandler (object sender, LinkLabelLinkClickedEventArgs e);
	
}
