﻿using System;
using System.Diagnostics;
using System.IO;

namespace Rasa.AuthPackets.Server
{
    using AuthData;
    using Packets;

    public class BlockedAccountWithMsgPacket : IOpcodedPacket<AuthServerOpcode>
    {
        public AuthServerOpcode Opcode { get; } = AuthServerOpcode.BlockedAccountWithMessage;
        public void Read(BinaryReader reader)
        {
            var count = reader.ReadByte();
            for (var i = 0; i < count; ++i)
            {
                Debugger.Break();
            }

            throw new NotImplementedException();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write((byte) Opcode);
            writer.Write((byte) 0); // TODO: when needed

            throw new NotImplementedException();
        }
    }
}
