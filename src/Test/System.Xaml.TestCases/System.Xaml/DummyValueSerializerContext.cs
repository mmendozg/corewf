﻿//
// Copyright (C) 2010 Novell Inc. http://novell.com
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Windows.Markup;
#if PCL
using System.Xaml;
using System.Xaml.Schema;
#else
using System.Xaml;
using System.Xaml.Schema;
#endif

namespace MonoTests.System.Xaml
{
	public class DummyValueSerializerContext : IValueSerializerContext
	{
		public DummyValueSerializerContext()
		{
		}

		public object GetService(Type serviceType)
		{
			throw new NotImplementedException();
		}
		public IContainer Container
		{
			get { throw new NotImplementedException(); }
		}
		public object Instance
		{
			get { throw new NotImplementedException(); }
		}
		public void OnComponentChanged()
		{
			throw new NotImplementedException();
		}
		public bool OnComponentChanging()
		{
			throw new NotImplementedException();
		}
		public ValueSerializer GetValueSerializerFor(Type type)
		{
			throw new NotImplementedException();
		}

#if NETSTANDARD
		public PropertyDescriptor PropertyDescriptor {
			get { throw new NotImplementedException (); }
		}
		public ValueSerializer GetValueSerializerFor (PropertyDescriptor descriptor)
		{
			throw new NotImplementedException ();
		}
#elif PCL
		public PropertyInfo PropertyDescriptor
		{
			get { throw new NotImplementedException(); }
		}
		public ValueSerializer GetValueSerializerFor(PropertyInfo descriptor)
		{
			throw new NotImplementedException();
		}
#else
		public PropertyDescriptor PropertyDescriptor {
			get { throw new NotImplementedException (); }
		}
		public ValueSerializer GetValueSerializerFor (global::System.ComponentModel.PropertyDescriptor descriptor)
		{
			throw new NotImplementedException ();
		}
#endif
	}
}
