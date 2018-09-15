﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTubeReport
{
	/// <summary>
	/// Directory クラスに関する汎用関数を管理するクラス
	/// </summary>
	public static class DirectoryUtils
	{
		/// <summary>
		/// 指定したパスにディレクトリが存在しない場合
		/// すべてのディレクトリとサブディレクトリを作成します
		/// </summary>
		public static DirectoryInfo SafeCreateDirectory(string path)
		{
			if (Directory.Exists(path))
			{
				return null;
			}
			return Directory.CreateDirectory(path);
		}
	}
}
