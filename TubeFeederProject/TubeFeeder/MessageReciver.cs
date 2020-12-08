using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    class MessageReciver
    {
        private byte[] message = null;
        public void setMesage(byte[] message)
        {
            this.message = message;
        }

        public bool messageProcessing(byte[] message)
        {
            setMesage(message);
            return messageProcessing();
        }

        // message를 해석함
        public bool messageProcessing()
        {
            if (message[MessageProtocol.PROTOCOL_HEADER] != MessageProtocol.HEADER)
            {
                return false;
            }
            if (message[MessageProtocol.PROTOCOL_TAIL] != MessageProtocol.TAIL)
            {
                return false;
            }

            switch (message[MessageProtocol.PROTOCOL_CMD])
            {
                case MessageProtocol.CMD_PING:
                    ControlBoard.m_controlBoardConnected = true;        // 또는 콜백함수
                    break;
                case MessageProtocol.CMD_ORDER:
                    break;
                case MessageProtocol.CMD_INFORM:
                    {
                        switch (message[MessageProtocol.PROTOCOL_CMD_SUB])
                        {
                            case MessageProtocol.CMD_INFORM_ACK:
                                return true;
                            case MessageProtocol.CMD_INFORM_ERROR:
                                // 에러코드 별로 처리 필요
                                return false;
                        }
                    }
                    break;
                case MessageProtocol.CMD_WRITE:
                    break;
                case MessageProtocol.CMD_READ:
                    break;

            }

            return true;
        }

    }
}
