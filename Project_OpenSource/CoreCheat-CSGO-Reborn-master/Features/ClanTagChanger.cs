﻿using CoreCheat_Reborn.SDK.Entities;

namespace CoreCheat_Reborn.Features
{
    class ClanTagChanger
    {
        public static byte[] shellCode = new byte[]
{
                0x50, // push eax
                0x51, // push ecx
                0x52, // push edx
                0xB8,0x00,0x00,0x00,0x00, // mov eax, fnClantagChanged
                0xB9,0x00,0x00,0x00,0x00, // mov ecx, tagAddress
                0xBA,0x00,0x00,0x00,0x00, // mov edx, nameAddress
                0xFF,0xD0, // call eax
                0x58, // pop eax
                0x59, // pop ecx
                0x5A, // pop edx
                0xC3, // ret
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00, // tag+name,max 32 bytes
                0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00
};
        public static void ChangeClanTag(string Tag)
        {
            CLocalPlayer.SetClantag(Tag, Tag);
        }
    }
}
