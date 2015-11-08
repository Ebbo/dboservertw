using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseLib;
using BaseLib.Packets;
using BaseLib.Structs;

namespace CharServer.Packets
{
    /*
	    SERVERFARMID serverFarmId;
	    WCHAR wszGameServerFarmName[NTL_MAX_SIZE_SERVER_FARM_NAME_UNICODE + 1]; 33
	    BYTE byServerStatus;		// eDBO_SERVER_STATUS
	    // Load value is stored in percents if it's for Client.
	    // 'dwMaxLoad' should be 100.
	    // 클라이언트에서 사용할 목적으로 값을 세팅할 때는 퍼센트 단위로 저장한다.
	    // 'dwMaxLoad'는 100이 된다.
	    // by YOSHIKI(2007-01-29)
	    DWORD dwMaxLoad;
	    DWORD dwLoad;
	    WORD wUnknow;
     */
    class CU_SERVER_FARM_INFO : Packet
    {
        public CU_SERVER_FARM_INFO()
        {
            this.Opcode = (ushort)PacketOpcodes.CU_SERVER_FARM_INFO;
            this.ServerID = 0;
            this.ServerName = "";
            this.ServerStatus = 0;
            this.MaxLoad = 0;
            this.Load = 0;
        }

        public byte ServerID
        {
            get { return this.GetByte(4); }
            set { this.SetByte(4, value); }
        }

        public string ServerName
        {
            get { return this.GetString(5, 66); }
            set { this.SetString(5, value, 66); }
        }

        public byte ServerStatus
        {
            get { return this.GetByte(71); }
            set { this.SetByte(71, value); }
        }

        public uint MaxLoad
        {
            get { return this.GetInt(72); }
            set { this.SetInt(72, value); }
        }

        public uint Load
        {
            get { return this.GetInt(76); }
            set { this.SetInt(76, value); }
        }
    }
}
