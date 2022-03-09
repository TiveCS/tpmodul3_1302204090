using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204090
{
	internal class DoorMachine
	{

		public enum DoorState
		{
			Terbuka,
			Terkunci
		}

		private DoorState state;

		internal DoorState State { get => state; set => state = value; }

		public DoorMachine()
		{
			this.State = DoorState.Terbuka;
		}

		public void cekStatusPintu()
		{
			switch (state)
			{
				case DoorState.Terbuka:
					Console.WriteLine("Pintu terbuka!");
					break;
				case DoorState.Terkunci:
					Console.WriteLine("Pintu terkunci!");
					break;
			}
		}

		public void kunciPintu()
		{
			if (this.State == DoorState.Terbuka)
			{
				state = DoorState.Terkunci;
				cekStatusPintu();
			}
		}

		public void bukaPintu()
		{
			if (this.State == DoorState.Terkunci)
			{
				state = DoorState.Terbuka;
				cekStatusPintu();
			}
		}
		
	}
}
