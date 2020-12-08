using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    class MessageReciver
    {
        private SetTextCallback LogFunction = null;

        private byte[] message = null;

        public MessageReciver(SetTextCallback LogFunction)
        {
            this.LogFunction = LogFunction;
        }

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
            bool processed = false;

            if (message[MessageProtocol.PROTOCOL_HEADER] != MessageProtocol.HEADER)
            {
                LogFunction("Recived : Header Invaild!");
                return false;
            }
            if (message[MessageProtocol.PROTOCOL_TAIL] != MessageProtocol.TAIL)
            {
                LogFunction("Recived : Tail Invaild!");
                return false;
            }

            switch (message[MessageProtocol.PROTOCOL_CMD])
            {
                case MessageProtocol.CMD_PING:
                    ControlBoard.m_controlBoardConnected = true;        // 또는 콜백함수
                    LogFunction("Recived : Ping");
                    processed = true;
                    break;
                case MessageProtocol.CMD_ORDER:
                    LogFunction("Recived : Order");
                    processed = true;
                    break;
                case MessageProtocol.CMD_INFORM:
                    {
                        switch (message[MessageProtocol.PROTOCOL_CMD_SUB])
                        {
                            case MessageProtocol.CMD_INFORM_ACK:
                                LogFunction("Recived : Inform_Ack");
                                processed = true;
                                return true;
                            case MessageProtocol.CMD_INFORM_SCANNED:
                                LogFunction("Recived : Inform_scaned");
                                processed = true;
                                return true;
                            case MessageProtocol.CMD_INFORM_ERROR:
                                // 에러코드 별로 처리 필요
                                LogFunction("Recived : Inform_Error");
                                processed = true;
                                return true;
                        }
                    }
                    break;
                case MessageProtocol.CMD_WRITE:
                    LogFunction("Recived : Write");
                    processed = true;
                    break;
                case MessageProtocol.CMD_READ:
                    LogFunction("Recived : Read");
                    processed = true;
                    break;

            }

            if (processed == false)
            {
                LogFunction("Recived : CMD Invaild!");
                return false;
            }

            return true;
        }

    }
}
