using System.Collections.Generic;

namespace tpmodul3_1302204090
{

	internal class KodePos
	{

		private Dictionary<int, List<string>> kodePos = new Dictionary<int, List<string>>();

		public KodePos()
		{
			
			addKodePos(40266, new string[] { "Batununggal" });
			addKodePos(40287, new string[] { "Kujangsari", "Cijaura" });
			addKodePos(40286, new string[] { "Jatisari", "Margasari", "Sekejati"});
			addKodePos(40267, new string[] { "Mengger" });
			addKodePos(40256, new string[] { "Wates" });
			addKodePos(40272, new string[] { "Kebonwaru" });
			addKodePos(40273, new string[] { "Samoja" });
			addKodePos(40274, new string[] { "Maleer" });
		}

		public void addKodePos(int kode, string[] arrayKelurahan)
		{
			foreach (string kelurahan in arrayKelurahan)
			{
				addKodePos(kode, kelurahan);
			}
		}

		public void addKodePos(int kode, string kelurahan)
		{
			List<string> listKelurahan;
			if (kodePos.ContainsKey(kode))
			{
				listKelurahan = kodePos[kode];
			}
			else
			{
				listKelurahan = new List<string>();
				kodePos[kode] = listKelurahan;
			}

			listKelurahan.Add(kelurahan);
		}

		public List<string> getKodePos(int kode)
		{
			return kodePos.GetValueOrDefault(kode, null);
		}
	}

}