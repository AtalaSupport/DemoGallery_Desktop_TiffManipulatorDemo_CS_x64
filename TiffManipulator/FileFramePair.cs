using System;
using System.IO;

namespace TiffManipulator
{
	/// <summary>
	/// Summary description for FileFramePair.
	/// </summary>
	public struct FileFramePair
	{
		private string _fileName;
		private int _frame;

		public FileFramePair(string fileName, int frame)
		{
			_fileName = fileName;
			_frame = frame;
		}

		public string FileName { get { return _fileName; } set { _fileName = value; } }
		public int Frame { get { return _frame; } set { _frame = value; } }
		public override string ToString()
		{
			return Path.GetFileName(_fileName);
		}

	}
}
