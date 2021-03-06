﻿using System;
using System.IO;

namespace Filebase
{
	public class FilebaseContext
	{
		internal DirectoryInfo RootDirectory { get; private set; }

		public FilebaseContext(string rootPath)
		{
			DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
			if (!rootDirectory.Exists)
			{
				rootDirectory.Create();
			}

			RootDirectory = rootDirectory;
		}
	}
}
