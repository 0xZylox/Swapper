﻿using JuicySwapper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using JuicySwapper.IO;
using System.IO;
using JuicySwapper.Main.GUI;
using JuicySwapper.Main.Classes;
using System.ComponentModel;
using System.Globalization;

namespace JuicySwapper.Items.Skins
{
    public partial class GhoulOG : Form
    {
        bool enabled = Settings.Default.GhoulOGEnabled;
        SwapUtilities SwapUtilities = new SwapUtilities();
        string placeholder = "Ghoul Trooper";

        public GhoulOG()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ActiveControl = ActionButton;
            Text = placeholder;

            if (enabled)
                ActionButton.Image = Resources.RevertBtn;
            else
                ActionButton.Image = Resources.ConvertBtn;
        }

        string Body = "8C 0A 00 05 09 88 05 07 00 00 00 00 00 00 00 00 00 03 91 20 00 80 ED 09 40 00 00 00 71 06 B8 06 70 01 28 08 50 08 E0 08 09 04 3A 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 31 32 34 5F 42 6F 64 79 5F 46 5F 41 75 72 6F 72 61 47 6C 6F 77 00 44 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 65 72 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 55 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 72 30 31 46 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 2E 5F 43 00 77 53 6B 69 6E 73 2F 5F 2F 4D 61 74 65 72 69 61 6C 73 2F 4D 5F 46 95 2E 13 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 54 79 70 65 73 50 65 6D 69 74 74 65 64 00 0C 42 6F 6F 6C 16 62 53 75 70 70 6F 72 74 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 18 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 19 00 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 4D 46 6C 61 67 49 6E 64 65 78 00 11 65 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 64 C1 05 20 91 48 B8 6C 30 28 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 76 05 5D FB 44 B6 17 27 1B 6F 25 CD 19 42 68 99 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 91 0D EB B6 1C B2 5D 79 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 ED 09 12 00 15 01 01 FF FF FF FF FF FF FF FF FF 4B 14 7A C1 4F E4 12 53 CA BA 0B 04 00 01 00 03 06 00 06 08 02 04 04 81 02 01 02 04 03 01 02 02 01 01 00 00 00 04 02 80 05 01 08 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 AB C8 95 96 92 92 92 92 99 92 41 00 30 21 87 7C F8 F8 F8 C0 79 D8 F1 F0 D0 38 87 8E 42 79 7A F8 F8 F8 F8 D0 79 90 F9 F8 F8 F8 F8 D0 48 87 82 01 79 F8 90 7C F8 F8 F8 90 36 21 87 7F 60 81 01 79 F8 89 87 87 46 91 25 87 87 24 87 87 8C 23 8F 87 4D 87 8A 87 87 4D 49 24 32 79 D0 CF 20 20 28 79 20 32 20 40 8F 28 87 7B E8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 68 48 79 30 20 32 50 4C 37 32 7B 7C A0 FF 87 2B 50 41 40 87 64 7E 55 48 22 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 5A 59 59 79 7B 87 87 DF 20 F9 59 00 30 00 18 00 11 00 46 00 60 00 ED 00 0C 01 18 00 57 00 68 00 1F 01 67 00 21 00 8A 00 A6 02 A7 02 80 00 CF 02 79 00 97 00 15 00 BB 00 55 01 CE 03 22 00 26 00 2E 01 51 00 71 00 37 04 22 00 3E 00 B3 00 1D 00 19 00 15 00 0C 00 54 01 35 00 5B 00 26 00 64 00 4B 01 1A 00 1D 01 15 00 09 02 1D 00 13 00 3E 02 60 00 2C 01 15 00 60 00 6A 00 40 00 9F 01 78 01 3E 03 7F 03 1E 01 17 00 65 02 6D 00 21 00 31 00";
        string Body1 = "8C 06 00 04 D2 88 04 D0 00 00 00 00 00 00 00 00 00 03 86 20 00 80 ED 09 40 00 00 00 71 06 B8 06 70 01 28 08 50 08 E0 08 09 04 3A 2F 47 61 6D 65 2F 41 74 68 65 6E 61 2F 48 65 72 6F 65 73 2F 4D 65 73 68 65 73 2F 42 6F 64 69 65 73 2F 43 50 5F 31 32 34 5F 42 6F 64 79 5F 46 5F 41 75 72 6F 72 61 47 6C 6F 77 00 44 43 68 61 72 61 63 74 65 72 73 2F 50 6C 61 79 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 42 61 73 65 2F 53 4B 5F 4D 5F 5F 5F 53 6B 65 6C 65 74 6F 6E 00 5E 2E 55 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 72 5F 30 31 00 66 2E 65 5F 41 6E 69 6D 42 50 00 88 5F 43 00 77 53 6B 69 6E 45 44 5F 5A 6F 6D 62 5F 50 69 6E 6B 2F 4D 61 74 65 72 69 61 6C 00 00 95 2E 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 6F 6C 16 62 53 75 70 70 6F 72 74 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 00 0C 42 79 74 65 11 50 61 72 74 00 05 18 1B 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 24 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 3A 3A 0F 0B 49 6E 74 14 4D 61 73 74 65 72 61 6C 00 15 46 6C 61 67 49 6E 64 65 78 00 11 73 00 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 00 0C 00 12 53 6F 66 74 0E 53 74 72 75 00 64 C1 05 20 91 48 B8 6C 30 28 DA 19 08 98 2C 90 E2 24 5F C2 EF 39 15 A9 EE 22 A9 A0 93 43 48 DD 8A F1 2E 39 21 47 08 DB F2 F0 7A 50 71 39 AA 09 C4 FC 47 0F A4 67 16 5D C8 E4 76 05 5D FB 44 B6 17 27 1B 6F 25 CD 19 42 68 99 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 DE 72 84 89 5C 9A 9C B3 60 0C 7A 78 F0 F2 3A 22 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 91 0D EB B6 1C B2 5D 79 39 2A 35 BA ED A8 A8 7A 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 9F 41 C3 89 61 85 81 D4 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 90 C5 17 1C 59 DE 8A F8 79 F1 D0 49 02 33 24 9A DB 6F A3 73 A1 40 EA 11 8B 36 D1 19 A0 B3 EC 0D 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 54 7B 85 0C 2D 3A EC 7B 7E A2 42 63 10 83 7A 73 E9 71 0B B6 57 37 B4 79 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 ED 09 12 00 15 01 01 FF FF FF FF FF FF FF FF 00 FF 4B 14 FF 7A C1 4F E4 12 53 CA BA 0B 00 04 00 00 03 06 06 08 02 04 04 81 02 01 02 04 03 01 02 02 01 01 00 02 80 05 01 08 00 00 00 01 00 00 00 00 00 00 00 00 00 7E 5C 03 03 02 02 02 02 05 02 D9 D3 83 D3 C9 FF E1 38 3D D0 DB F8 FE FD 3D DC FF FC F8 FF CF 03 C7 38 CC FF D9 38 D4 DB 01 CB CB CB 43 DE DF DD CB D2 DD 38 1F C8 C8 CC F5 C8 D2 C8 D8 CF EB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 EC DC E8 D8 CE D1 E0 DF D3 D2 FA C7 38 3B D3 DC D9 D8 EB F7 E7 D4 CB D3 52 05 05 D5 D8 1B 58 D4 96 15 D9 90 D9 D8 58 57 05 E5 95 E5 DC 1E 94 E7 D4 F5 1B 00 00 56 08 04 00 09 0E 08 05 14 00 0F 00 17 0F 07 00 02 1F 04 13 01 08 2A 0D 03 15 0B 0A 0E 25 09 09 2F 03 06 0B 05 01 0D 04 1F 0D 03 0E 0C 13 08 15 0D 20 05 0B 2D 08 14 08 0D 17 0B 17 10 26 2D 16 0F 1D 05 09 09 0A 05 08 1E 00 16 08 00 0F 00 00 00 08 00 04 32 02 08 00 00 30 02 03 3A 0C 16 08 33 16 0D 44 00 44 06 54 00 01 2D 01 04 0B 00 65 13 02 0F 13 0D 1A 01 04 05 07 05 00 01 04 01 04 06 08 03 02 00 FF 05 06 0E 01 21 3E 16 58 5F 60 1A 27 B4 50 81 09 02 E8 29 61 21 86 A2 E0 00 30 E2 6D 00 00 F8 E4 04 25 3E 62 90 1D 02 E1 05 4C D5 82 18 89 C2 37 B9 C0 0E 04 0A 46";

        string Hat = "8C 02 04 3A F2 04 00 91 40 08 00 7F 17 00 20 00 80 57 07 00 00 40 00 00 00 FE 03 00 00 40 04 00 00 48 01 00 00 88 05 00 00 B0 05 00 00 40 06 00 00 68 06 30 00 3F 24 39 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 47 6C 61 73 73 65 73 2F 4D 61 74 65 72 69 61 6C 73 2F 4D 49 5F 41 75 72 6F 72 61 47 6C 6F 77 5F 20 00 F2 00 4F 26 3B 00 F1 2E 03 51 00 F1 37 08 51 00 FF 0F 65 73 68 65 73 2F 46 65 6D 61 6C 65 5F 43 6F 6D 6D 61 6E 64 6F 5F 53 68 61 64 65 73 00 4E 24 39 00 F1 2E 04 50 00 21 41 50 00 6A 43 68 61 72 61 63 74 65 72 73 0B 00 6F 04 50 61 72 74 73 2F 48 61 74 73 2F 43 50 5F 48 61 74 5F 46 56 00 60 EA 00 4F 08 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 15 00 08 46 6F 72 74 6E 69 74 65 67 00 0F 1F 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 74 61 63 68 53 6F 63 6B 65 74 4E 31 00 5F 0A 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 34 00 91 11 B0 00 00 2B 00 03 00 05 43 12 01 F2 00 1C 0A B6 00 57 16 43 75 73 74 6F 6D 3E 00 13 48 61 74 93 00 B1 13 18 00 00 56 00 22 00 1E 15 00 00 62 00 40 F0 01 18 4F 76 65 72 72 69 64 65 35 00 2A 1F 44 65 66 61 75 6C 74 5F 5F 29 00 D0 56 00 F1 1C 05 21 00 00 B5 00 03 00 13 45 26 01 20 3B 00 40 F1 00 F2 00 1B 00 15 00 7A 3A 3A 4D 65 64 69 75 6D 00 11 1D 00 D8 47 65 6E 64 65 72 00 19 13 00 22 3A 3A 0C 02 90 60 00 00 71 00 10 26 01 F1 18 00 15 00 27 3A 3A 48 61 74 00 0F 52 00 60 72 01 01 03 16 00 54 0B 49 6E 74 AA 01 C1 15 07 01 E5 46 6C 61 67 73 17 00 C7 49 6E 64 65 78 00 11 2E 00 03 73 00 0C DF 01 50 4F 00 27 04 4E 6F 6E 65 00 0E 3C 02 50 65 00 41 10 5D 00 40 6D 00 0F 04 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C F5 02 B6 00 12 53 6F 66 74 3D 00 75 0E 53 74 72 75 10 00 05 00 00 00 64 C1 42 04 0F C1 5C DF E3 35 20 0E DD BD AF 7A F0 9C 8F CC 46 4A C1 ED A0 FD 58 2B F3 AB 53 B3 C4 94 51 35 2C CB 60 AE E6 B2 99 4E 71 2B 39 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 0C 8E B1 2A 96 7E E2 ED E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 79 F1 D0 49 02 33 24 9A AD B2 19 90 1E 32 09 A2 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 57 07 00 6F 01 F2 00 0E 8E F7 00 00 0F 00 00 00 01 9C 00 13 00 40 48 00 F1 FF 99 40 48 00 40 10 00 30 37 00 32 00 65 48 00 31 38 48 00 40 50 00 40 28 00 40 88 00 40 10 00 40 88 00 FA BA D1 DD FE 42 4C 58 91 0B 00 B1 71 04 80 00 F0 C1 F1 01 BC 10 10 00 F3 03 1B 00 B9 F4 06 08 02 04 82 04 03 02 02 02 3F 00 71 03 1D 00 00 4F 00 43 80 05 01 3A 00 0C 00 00 00 00 01 00 00 00 00 00 00 00 8C 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
        string Hat1 = "8C 02 04 37 F2 04 00 91 40 08 00 7F 17 00 20 00 80 57 07 00 00 40 00 00 00 FE 03 00 00 40 04 00 00 48 01 00 00 88 05 00 00 B0 05 00 00 40 06 00 00 68 06 30 00 3F 24 39 2F 47 61 6D 65 2F 41 63 63 65 73 73 6F 72 69 65 73 2F 47 6C 61 73 73 65 73 2F 4D 61 31 65 72 69 61 6C 73 2F 4D 49 5F 41 75 72 6F 72 61 47 6C 6F 77 5F 20 00 F2 00 4F 26 3B 00 F1 2E 03 51 00 E1 37 51 00 5F 02 48 61 74 73 2F 4D 65 73 68 2F 52 61 6D 69 72 65 7A 7E 00 F0 C1 F1 4E 18 39 00 F1 2E 09 49 00 F0 99 21 41 89 00 6A 43 68 61 72 61 63 74 65 72 73 0B 00 34 50 61 72 74 97 00 7F 02 43 50 5F 48 61 74 5F 46 5F 43 6F 6D 6D 61 6E 64 6F EA 00 4F 08 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 15 00 08 46 6F 72 74 6E 69 74 65 7C 01 0F 1F 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 10 41 74 74 61 63 68 53 6F 63 6B 65 74 4E 31 00 5F 0A 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 34 00 91 11 B0 00 00 2B 00 03 00 05 43 F0 00 F2 00 1C 0A B6 00 57 16 43 75 73 74 6F 6D 3E 00 13 48 61 74 93 00 B1 13 18 00 00 56 00 22 00 1E 15 00 00 0C 00 13 4D 61 74 2B 02 18 4F 76 65 72 72 69 64 65 35 00 2A 1F 44 65 66 61 75 6C 74 5F 5F 29 00 D0 56 00 F1 1C 05 21 00 00 53 00 03 00 13 45 26 01 20 3B 00 40 F1 00 F2 00 1B 00 15 00 7A 3A 3A 4D 65 64 69 75 6D 00 11 1D 00 D8 47 65 6E 64 65 72 00 19 13 00 98 3A 3A 46 65 6D 61 6C 65 60 00 50 26 01 F1 18 00 15 00 27 3A 3A 48 61 74 00 0F 52 00 60 72 01 01 03 16 00 54 0B 49 6E 74 AA 01 C1 15 07 01 E5 46 6C 61 67 73 17 00 C7 49 6E 64 65 78 00 11 2E 00 03 73 00 0C DF 01 50 4F 00 27 04 4E 6F 6E 65 00 0E 3C 02 50 65 00 41 10 5D 00 40 6D 00 0F 04 00 07 50 61 63 6B 61 67 65 00 0C 53 6B 65 6C 65 74 61 6C F8 02 B6 00 12 53 6F 66 74 3D 00 75 0E 53 74 72 75 10 00 05 00 00 00 64 C1 F2 02 2F C1 5B DF E3 35 20 0E DD BD AF 7A F0 9C 8F CC 46 4A C1 ED A0 FD 58 2B F3 AB 53 B3 C4 94 51 35 2C CB 60 AE E6 B2 99 4E 71 2B 39 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 A8 E3 AA B3 3D 77 5A FD 68 6B D9 FC 1E 42 D2 E4 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 AC 51 26 83 EA A3 4B DB AD 2B 3A 82 6E B6 DB 6B 0C 8E B1 2A 96 7E E2 ED E6 A0 DA 03 A0 A2 77 E3 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 6F 5C AD 3E AD 7B E5 CD A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 F5 2D 88 9C CF B1 66 E1 37 D8 C6 B2 85 46 9E 6D 79 F1 D0 49 02 33 24 9A AD B2 19 90 1E 32 09 A2 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 25 4A 21 F7 13 9A 48 56 7E A2 42 63 10 83 7A 73 40 42 2D C0 79 31 F0 62 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 57 07 B9 04 F1 0E 8E F7 00 00 0F 00 00 00 01 9C 00 13 00 40 48 00 F1 FF 99 40 48 00 40 10 00 30 37 00 32 00 65 48 00 31 38 48 00 40 50 00 40 28 00 40 88 00 40 10 00 40 88 00 FA BA D1 DD FE 42 4C 58 91 0B 00 B1 71 04 80 00 F0 C1 F1 01 BC 10 10 00 F3 03 1B 00 B9 F4 06 08 02 04 82 04 03 02 02 02 2B 00 71 03 1D 00 00 10 00 43 80 05 01 3A 00 0C 00 00 00 00 01 00 00 00 00 00 00 00";

        string Head = "8C 0A 00 05 BE 88 05 BC 04 00 00 00 00 00 00 00 00 04 05 00 20 00 80 04 0C 40 00 00 00 50 08 90 08 B0 01 40 0A 68 0A F8 20 0B 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 37 53 6B 69 6E 46 5F 42 4C 4B 5F 4C 75 6E 61 00 42 2E 48 50 61 72 74 73 2F 46 65 6D 61 6C 2F 4D 65 64 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 41 75 72 6F 72 61 47 6C 6F 77 00 7B 50 6C 61 79 65 72 42 6F 64 69 65 73 2F 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 73 2F 5F 2F 4D 61 74 65 72 69 61 6C 45 44 5F 43 6D 6D 61 6E 64 6F 5F 5F 30 31 9D 2E 48 61 69 72 5F 30 65 61 64 65 61 64 64 48 49 53 5F 52 61 6D 69 72 65 7A 2F 4D 65 73 68 00 7E 2E 71 5F 41 6E 69 6D 42 50 5F 43 68 69 6C 64 00 9A 2E 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 68 54 61 72 67 65 74 73 00 05 14 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 63 61 70 48 61 74 00 0B 0F 48 61 69 74 12 0B 49 6E 74 15 4D 46 6C 61 67 73 49 6E 64 65 78 00 11 65 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 0F 12 53 6F 66 74 0E 53 74 72 75 00 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 3A 01 03 A2 47 E7 E0 D8 7A B0 66 82 04 15 58 D7 18 38 81 17 ED 0C FB AE C5 52 D1 0F 75 22 CD C7 AA 50 44 4A D8 D3 2B A0 C0 60 F1 6A DC 0E E8 89 8A 45 1B 52 25 FA F9 C7 3C EC 73 B8 D0 6E 95 B0 59 FF E3 D7 12 D7 9E 8C 69 8A 98 4B 98 87 3C 16 18 10 50 6E 45 CA 77 97 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 55 7C 0C EC CD 54 8F 6D 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 17 DF E4 09 17 45 18 8F 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 04 0C 58 00 18 06 01 FF FF FF FF FF FF FF FF 5C 49 16 3C 76 6F 82 56 F2 33 A6 0B 00 00 04 00 01 01 02 08 01 05 03 22 02 24 17 23 09 02 04 02 04 02 04 03 02 02 01 0A 00 05 08 80 05 01 06 00 00 00 00 00 00 00 00 00 00 00 03 00 00 00 00 00 00 00 00 00 CD C0 96 96 92 92 92 92 99 5A 87 87 53 87 89 87 36 7D F8 F8 E0 69 F9 F8 D0 8C 87 7D F8 F8 D0 59 F9 D8 87 8C 8C 87 25 87 87 79 90 7E 87 87 25 28 32 21 87 2A 8C 27 63 81 01 79 8E 01 83 01 F3 F0 78 B0 F9 F8 60 40 87 44 7D D8 82 01 79 D8 81 01 87 87 81 01 79 F8 C0 87 87 8E 44 91 25 87 87 24 87 87 8C 87 87 87 4E 8F 87 33 79 B0 87 87 4F 20 28 79 20 32 20 40 87 29 87 7B C8 79 70 22 30 40 7A A0 32 5A 87 79 90 32 32 50 29 3B AD 38 64 20 69 29 70 4C 7A 7D 98 FF 57 2F 50 41 40 87 92 87 21 22 60 7D 5D 23 00 30 32 99 99 39 40 87 C1 40 40 39 B9 39 40 40 40 40 87 B3 99 59 59 99 59 7D 60 B9 99 B9 59 B9 30 60 87 9C C1 38 22 D9 67 00 30 00 0B 00 17 00 3B 00 48 00 39 00 44 00 09 00 4A 00 42 00 06 01 A4 00 50 00 51 00 2D 00 3E 01 7D 00 7D 00 9F 00 1C 01 1C 01 9F 00 7A 02 71 00 52 00 1F 00 66 00 80 00 80 00 73 00 27 00 15 00 C0 00 4B 00 22 00 49 00 D2 04 4F 01 30 00 91 00 19 00 38 05 15 00 0C 00 2F 03 35 00 57 00 22 00 60 00 25 01 1A 00 F7 00 15 00 E8 01 1D 00 13 00 1D 02 10 00 49 01 D7 04 0A 00 20 01 78 06 11 00 6D 01 2A 00 14 00 9F 01 2B 01 17 00 EE 01 5E 02 65 00 2F 00 3F 00 F4 02 FA 04 D1 00 4E 00 10 00 57 08 2F 0A 08 00 10 00 48 00 10 00 6F 0A 48 00 08 00 28 00 88 00 10 00 88";
        string Head1 = "8C 06 00 05 9D 88 05 9B 04 00 00 00 00 00 00 00 00 04 09 00 20 00 80 04 0C 40 00 00 00 50 08 90 08 B0 01 40 0A 68 0A F8 20 0B 39 2F 47 61 6D 65 2F 43 68 61 72 61 63 74 65 72 73 43 6F 6C 6F 72 53 77 61 74 63 68 65 73 2F 48 61 69 72 2F 48 61 69 5F 30 31 00 46 2E 37 53 6B 69 6E 2F 46 5F 4C 52 47 5F 43 41 55 00 00 42 2E 00 48 50 61 72 74 73 2F 46 65 6D 61 6C 65 2F 4D 65 64 69 75 6D 2F 48 65 61 64 73 2F 43 50 5F 5F 46 5F 41 75 72 6F 72 61 47 6C 6F 77 00 7B 50 6C 61 79 65 72 42 6F 64 69 65 73 2F 46 5F 4D 65 64 5F 53 6F 6C 64 69 65 73 2F 5F 2F 4D 61 74 65 72 69 61 6C 45 44 5F 43 6F 6D 6D 61 6E 64 6F 5F 5F 30 31 9D 5A 62 69 65 5F 50 69 6E 6B 52 61 6D 69 72 65 7A 2E 65 61 64 2E 00 64 48 49 53 2F 4D 65 73 68 00 7E 2E 71 5F 41 6E 69 6D 42 50 5F 69 6C 64 00 9A 5F 43 00 13 2F 53 63 72 69 70 74 2F 43 6F 72 65 55 4F 62 6A 65 63 74 00 14 46 74 6E 69 74 65 00 0E 41 64 64 69 74 69 6F 6E 61 6C 44 61 74 61 00 09 43 6C 61 73 73 00 0D 41 72 72 61 79 50 72 6F 70 65 72 74 79 00 12 42 6F 64 79 54 79 70 65 73 50 65 72 6D 69 74 74 65 64 00 0C 42 79 74 65 0F 43 61 70 4D 6F 72 70 68 54 61 72 67 65 74 73 00 05 14 0C 43 75 72 6C 73 5F 48 65 6C 6D 65 74 00 17 43 75 73 74 6F 6D 13 00 1E 4F 76 65 72 72 69 64 65 20 44 65 66 61 75 6C 74 5F 5F 1C 13 45 00 1B 3A 3A 00 11 47 65 6E 64 65 72 00 19 3A 3A 00 0F 08 63 61 70 48 61 74 00 0B 0F 00 0F 48 61 74 12 0B 49 6E 74 15 46 6C 61 67 73 49 6E 64 65 78 00 11 73 00 0C 4E 61 6D 04 4E 6F 6E 65 00 0E 10 00 07 50 61 63 6B 61 67 65 53 6B 65 6C 65 74 61 6C 00 0F 12 53 6F 66 74 0E 53 74 72 75 00 64 C1 47 D3 52 89 1C 0C 88 3A A3 43 86 7C 28 A5 31 24 3A 01 03 A2 47 E7 E0 D8 7A B0 66 82 04 15 58 D7 18 38 81 17 ED 0C FB AE C5 52 D1 0F 75 22 CD C7 AA 50 44 4A D8 D3 2B A0 C0 60 F1 6A DC 0E E8 89 8A 45 1B 52 25 FA F9 C7 3C EC 73 B8 D0 6E 95 B0 59 FF E3 D7 12 D7 9E 8C 69 8A 98 4B 98 87 3C 16 18 10 50 6E 45 CA 77 97 52 10 8A 4F 34 DB 0D 04 17 86 CC 9F D3 F2 1C 6C B6 14 0A 6C 57 87 4A 28 10 9C 02 0B CE 39 F1 5A A8 E3 AA B3 3D 77 5A FD 26 57 37 90 7A D6 EB 77 EE 28 C6 A7 41 C8 CC 73 A3 60 2A 89 13 27 B6 6F AD 2B 3A 82 6E B6 DB 6B 55 7C 0C EC CD 54 8F 6D 55 8B E7 93 B2 99 18 36 AB 41 98 2A 25 3D 33 28 74 99 E8 86 03 41 76 C6 B1 8B 09 03 2C 7D 3F 37 7A 04 DE 4C 48 64 45 D7 A7 90 03 3D EA 51 7A 64 0D BA BC 12 62 E6 D7 95 19 1B 0D 1B D8 9D FA 44 D4 6B D6 C3 94 98 52 6B B9 38 10 C4 AC 41 57 93 79 F1 D0 49 02 33 24 9A BD 07 F0 A5 68 3A 53 BA D4 9C E2 19 D3 6E F6 4D 5E 21 D8 01 09 9E 88 22 EE 60 1D AE A9 E1 DF C9 27 A1 7D CF 58 1F 5D B7 49 AF D4 E6 46 CF 16 C4 DB 6F A3 73 A1 40 EA 11 54 6F 16 55 D8 C3 E6 6E BD 0A 42 79 CA 33 C1 32 72 58 EC 35 BE 1F 6E 71 DC 66 D1 F5 89 62 6E 26 C2 2D 35 A6 5B 0F 37 75 2F AE 24 92 59 19 CC 80 5D 12 34 9B 87 C5 5C 6A FA 86 1E 80 92 B9 C6 D6 83 8D 36 E9 0F ED 56 31 17 DF E4 09 17 45 18 8F 73 EB 4F 19 FC 82 6E 06 05 77 E4 97 64 11 1B 0C 9B DF F8 FA 9B 82 21 5D 7E A2 42 63 10 83 7A 73 62 6D A0 B5 CC 77 70 51 18 69 40 56 99 65 CF 69 E3 22 58 A5 6D 55 F8 70 04 0C 58 00 18 06 01 FF FF FF FF FF FF FF FF 00 5C 49 16 FF 3C 76 6F 82 56 F2 33 A6 0B 00 04 00 00 01 02 08 01 05 03 00 22 02 24 17 23 0C 00 04 09 02 04 02 04 02 04 03 02 02 0A 00 05 08 80 05 01 06 00 00 00 00 00 03 00 00 00 00 00 00 00 00 00 9D 58 03 03 02 02 02 02 05 02 DC E3 D3 FF ED 3D FF E5 E2 38 CB FF F7 CB CC D2 C9 CF CB EB 3D D0 01 FF EB CC D1 D8 38 FC C8 7C B3 38 7E D0 D0 DF D4 E3 38 FE E1 38 3D 43 FF E0 38 EC DB 01 CB CB DF D3 CD 38 DF C8 CC F5 C8 D2 C8 D8 CF DB 38 D9 38 CC CA D0 D8 C6 38 D2 E6 FF D2 D2 E0 CD D7 13 D0 DD D0 EF D1 EC DF F9 C3 38 3B E3 D3 DC D9 D8 03 CB CA E8 F7 E7 CB D3 D2 05 05 D5 D8 1B 58 D4 96 15 D5 94 D9 D8 58 D7 45 E5 55 D5 E5 17 15 E8 15 05 15 95 C8 15 55 D9 CB 15 D8 CA 25 53 00 00 68 08 03 0F 03 00 01 0B 0C 01 02 0A 0E 05 08 09 05 16 05 0F 0B 0C 06 03 07 14 10 12 04 13 09 07 0E 08 0B 08 02 0D 08 03 0A 01 2A 2C 08 09 01 20 0D 04 2D 0D 0F 0A 08 1D 04 0F 0D 21 05 0B 26 0B 11 2E 02 18 2D 3C 15 12 0C 17 13 0F 16 16 0E 07 07 25 2F 09 06 08 30 37 00 08 00 0F 00 00 08 08 08 0C 04 04 08 00 00 04 0E 00 00 3D 03 03 0E 13 02 28 17 0E 25 1A 0C 00 03 10 06 09 00 33 05 00 04 5B 79 01 15 00 02 53 53 05 02 60 16 02 0F 2B 0F 12 05 07 05 00 00 02 02 01 02 04 03 04 06 05 02 02 00 FF 05 06 02 08 01 20 43 03 D4 1A 89 86 E8 17 F0 44 2E 23 02 10 F4 E0 33 04 11 12 15 25 30 19 00 C1 00 02 11 00 00 89 38 00 82 0A 99 03 4E 80 E1 81 A8 01 53 34 41 08 17 9B 56 4E 29 F0 4E E8 69 66 40";

        private void ConvertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (SwapUtilities.CheckIfCanSwap("Nitelite"))
                return;

            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Convert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.GhoulOGEnabled = true;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body added";
            }

            bool Swap2 = HexResearcher.Convert(SwapOffsets[1], SwapPath[0], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head added";

            bool Swap3 = HexResearcher.Convert(SwapOffsets[1], SwapPath[0], Hat, Hat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat added";

            ActionButton.Image = Resources.RevertBtn;
            LogBox.Text += "\nConverted!";
        }

        private void RevertBytes_DoWork(object sender, DoWorkEventArgs e)
        {
            ActionButton.Enabled = false;

            int[] SwapOffsets = SwapUtilities.GetSwapOffset();
            string[] SwapPath = SwapUtilities.GetSwapPath();

            LogBox.Clear();
            LogBox.Text += "[LOG] Starting...";

            bool Swap1 = HexResearcher.Revert(SwapOffsets[0], SwapPath[0], Body, Body1, 0, 0, false, false);
            if (Swap1)
            {
                Settings.Default.GhoulOGEnabled = false;
                Settings.Default.Save();
                LogBox.Text += "\n[LOG] Body removed";
            }

            bool Swap2 = HexResearcher.Revert(SwapOffsets[1], SwapPath[0], Head, Head1, 0, 0, false, false);
            if (Swap2)
                LogBox.Text += "\n[LOG] Head removed";

            bool Swap3 = HexResearcher.Revert(SwapOffsets[1], SwapPath[0], Hat, Hat1, 0, 0, false, false);
            if (Swap3)
                LogBox.Text += "\n[LOG] Hat removed";

            ActionButton.Image = Resources.ConvertBtn;
            LogBox.Text += "\nReverted!";
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            string[] SwapPath = SwapUtilities.GetSwapPath();

            if (!File.Exists(SwapPath[0]))
            {
                Message FortnitePathExp = new Message(Resources.pakfileerror);
                FortnitePathExp.ShowDialog();
                return;
            }
            if (enabled)
                RevertBytes.RunWorkerAsync();
            else
                ConvertBytes.RunWorkerAsync();
        }

        private void ConvertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConvertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void RevertBytes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RevertBytes.CancelAsync();
            CloseTimer.Enabled = true;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            ActionButton.Enabled = true;
            Close();
        }
    }
}
