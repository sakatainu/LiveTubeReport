﻿using LiveTubeReport.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LiveTubeReport
{
	class Utils
	{
		//---------------------------------------------------------------------------
		/// <summary>
		/// 指定されたURLの画像をImage型オブジェクトとして取得する
		/// </summary>
		/// <param name="url">画像データのURL(ex: http://example.com/foo.jpg) </param>
		/// <returns>         画像データ</returns>
		//---------------------------------------------------------------------------
		public static Image loadImageFromURL(string url)
		{
			int buffSize = 65536; // 一度に読み込むサイズ
			MemoryStream imgStream = new MemoryStream();

			//------------------------
			// パラメータチェック
			//------------------------
			if (url == null || url.Trim().Length <= 0)
			{
				return null;
			}

			//----------------------------
			// Webサーバに要求を投げる
			//----------------------------
			WebRequest req = WebRequest.Create(url);
			BinaryReader reader = new BinaryReader(req.GetResponse().GetResponseStream());

			//--------------------------------------------------------
			// Webサーバからの応答データを取得し、imgStreamに保存する
			//--------------------------------------------------------
			while (true)
			{
				byte[] buff = new byte[buffSize];

				// 応答データの取得
				int readBytes = reader.Read(buff, 0, buffSize);
				if (readBytes <= 0)
				{
					// 最後まで取得した->ループを抜ける
					break;
				}

				// バッファに追加
				imgStream.Write(buff, 0, readBytes);
			}

			return new Bitmap(imgStream);
		}

		/// <summary>
		/// 任意のオブジェクトを JSON メッセージへシリアライズします。
		/// </summary>
		public static string Serialize(object graph) {
			using (var stream = new MemoryStream()) {
				var serializer = new DataContractJsonSerializer(graph.GetType());
				serializer.WriteObject(stream, graph);
				return Encoding.UTF8.GetString(stream.ToArray());
			}
		}

		public static void SaveThumnail(Thumbnail thumbnail) {
			if (!System.IO.File.Exists(thumbnail.Path)) {
				Bitmap bmp = new Bitmap(Utils.loadImageFromURL(thumbnail.Url));
				bmp.Save(thumbnail.Path, System.Drawing.Imaging.ImageFormat.Png);
			}
		}

		/// <summary>
		/// XMLのシリアライズを行う
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="savePath"></param>
		/// <param name="graph"></param>
		public static void XmlSerialize<T>(string savePath, T graph) {
			using (var sw = new StreamWriter(savePath, false, Encoding.UTF8)) {
				var ns = new XmlSerializerNamespaces();
				ns.Add(string.Empty, string.Empty);

				new XmlSerializer(typeof(T)).Serialize(sw, graph, ns);
			}
		}

		/// <summary>
		/// XMLのデシリアライズを行う
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="loadPath"></param>
		/// <returns></returns>
		public static T XmlDeserialize<T>(string loadPath) {
			using (var sr = new StreamReader(loadPath)) {
				return (T)new XmlSerializer(typeof(T)).Deserialize(sr);
			}
		}

		public static List<T> ConvertToList<T>(DataTable dt) {
			var columns = dt.Columns.Cast<DataColumn>()
			.Select(c => c.ColumnName)
			.ToList();

			var properties = typeof(T).GetProperties();

			return dt.AsEnumerable().Select(row => GetT<T>(row, columns, properties)).ToList();
		}

		public static T GetT<T>(DataRow dr, List<string> ColumnNames, PropertyInfo[] properties) {
			var ResT = Activator.CreateInstance<T>();
			foreach (var pro in properties) {
				if (ColumnNames.Contains(pro.Name))
					pro.SetValue(ResT, dr[pro.Name]);
			}
			return ResT;
		}
		/*
		public static Channel ToChannel(DataRow row) {

		}
		*/
		// ログをコンソールに出力します
		// 引数：
		//  logText : ログとして書き出すテキスト
		/*		public void writeLog(String logText)
				{
					Console.WriteLine("[" + System.DateTime.Now.ToString() + "] " + logText);
				}

				// ログをコンソールに出力します
				// 引数：
				//  logText : ログとして書き出すテキスト
				public void writeLog(String logText)
				{
					textBox_Log.SelectionStart = textBox_Log.Text.Length;
					textBox_Log.SelectionLength = 0;
					textBox_Log.SelectedText = "[" + System.DateTime.Now.ToString() + "] " + logText + "\r\n";
				}
				*/
	}

}
