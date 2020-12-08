using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    class MessageProtocol
    {
        // | byte[0]      | byte[1]   | byte[2]   | byte[3]   | byte[4]   | byte[5]   | byte[6]
        // | HEADER(0xFA) | CMD       | CMDSub    | DATA1     | DATA2     | CheckSum  | TAIL(0xFE)

        public const byte PROTOCOL_HEADER    = 0;
        public const byte PROTOCOL_CMD       = 1;
        public const byte PROTOCOL_REG       = 2;
        public const byte PROTOCOL_DATA1     = 3;
        public const byte PROTOCOL_DATA2     = 4;
        public const byte PROTOCOL_CHECKSUM  = 5;
        public const byte PROTOCOL_TAIL      = 6;

        // HEADER
        public const byte HEADER = 0xFA;

        // TAIL
        public const byte TAIL = 0xFE;

        // CMD
        public const byte CMD_PING   = (byte)'P';    // 제어장치에게 Ping~
        public const byte CMD_ORDER  = (byte)'O';    // 제어장치에게 명령함
        public const byte CMD_WRITE  = (byte)'W';    // 제어장치에게 특정 값 저장 요청
        public const byte CMD_READ   = (byte)'R';    // 제어장치에게 특정 값 읽기 요청
        public const byte CMD_INFORM = (byte)'I';    // 제어장치에게 알림

        // REG
        public const byte CMD_ORDER_START = (byte)'S';
        public const byte CMD_ORDER_STOP = (byte)'T';

        public const byte CMD_WRITE_SPEED = (byte)'S';
        public const byte CMD_READ_SPEED = (byte)'S';    
        
        public const byte CMD_INFORM_SCANNED = (byte)'S';
        public const byte CMD_INFORM_ACK = (byte)'A';
        public const byte CMD_INFORM_ERROR = (byte)'E';

        // 에러코드
        public const Byte ERRORCODE_SOMETHING_WRONG = 0x01;
        public const Byte ERRORCODE_ANOTHER_WRONG = 0x02;

    }
}

