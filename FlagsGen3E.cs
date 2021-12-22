﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;

namespace MissingEventFlagsCheckerPlugin
{
    static class FlagsGen3E
    {
        static Dictionary<int, string> s_flagDetails = new Dictionary<int, string>();


        public static void ExportFlags(bool[] flags, GameVersion gameVersion)
        {
            InitFlagDetails();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < flags.Length; ++i)
            {
                if (!flags[i] && s_flagDetails.ContainsKey(i))
                {
                    sb.AppendFormat("{0}\n", s_flagDetails[i]);
                }
            }

            System.IO.File.WriteAllText(string.Format("missing_events_{0}.txt", gameVersion), sb.ToString());
        }

        static void InitFlagDetails()
        {
            // Hidden Items
            s_flagDetails[0x1F4] = "FLAG_HIDDEN_ITEM_LAVARIDGE_TOWN_ICE_HEAL";
            s_flagDetails[0x1F5] = "FLAG_HIDDEN_ITEM_TRICK_HOUSE_NUGGET";
            s_flagDetails[0x1F6] = "FLAG_HIDDEN_ITEM_ROUTE_111_STARDUST";
            s_flagDetails[0x1F7] = "FLAG_HIDDEN_ITEM_ROUTE_113_ETHER";
            s_flagDetails[0x1F8] = "FLAG_HIDDEN_ITEM_ROUTE_114_CARBOS";
            s_flagDetails[0x1F9] = "FLAG_HIDDEN_ITEM_ROUTE_119_CALCIUM";
            s_flagDetails[0x1FA] = "FLAG_HIDDEN_ITEM_ROUTE_119_ULTRA_BALL";
            s_flagDetails[0x1FB] = "FLAG_HIDDEN_ITEM_ROUTE_123_SUPER_REPEL";
            s_flagDetails[0x1FC] = "FLAG_HIDDEN_ITEM_UNDERWATER_124_CARBOS";
            s_flagDetails[0x1FD] = "FLAG_HIDDEN_ITEM_UNDERWATER_124_GREEN_SHARD";
            s_flagDetails[0x1FE] = "FLAG_HIDDEN_ITEM_UNDERWATER_124_PEARL";
            s_flagDetails[0x1FF] = "FLAG_HIDDEN_ITEM_UNDERWATER_124_BIG_PEARL";
            s_flagDetails[0x200] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_BLUE_SHARD";
            s_flagDetails[0x201] = "FLAG_HIDDEN_ITEM_UNDERWATER_124_HEART_SCALE_1";
            s_flagDetails[0x202] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_HEART_SCALE";
            s_flagDetails[0x203] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_ULTRA_BALL";
            s_flagDetails[0x204] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_STARDUST";
            s_flagDetails[0x205] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_PEARL";
            s_flagDetails[0x206] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_YELLOW_SHARD";
            s_flagDetails[0x207] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_IRON";
            s_flagDetails[0x208] = "FLAG_HIDDEN_ITEM_UNDERWATER_126_BIG_PEARL";
            s_flagDetails[0x209] = "FLAG_HIDDEN_ITEM_UNDERWATER_127_STAR_PIECE";
            s_flagDetails[0x20A] = "FLAG_HIDDEN_ITEM_UNDERWATER_127_HP_UP";
            s_flagDetails[0x20B] = "FLAG_HIDDEN_ITEM_UNDERWATER_127_HEART_SCALE";
            s_flagDetails[0x20C] = "FLAG_HIDDEN_ITEM_UNDERWATER_127_RED_SHARD";
            s_flagDetails[0x20D] = "FLAG_HIDDEN_ITEM_UNDERWATER_128_PROTEIN";
            s_flagDetails[0x20E] = "FLAG_HIDDEN_ITEM_UNDERWATER_128_PEARL";
            s_flagDetails[0x20F] = "FLAG_HIDDEN_ITEM_LILYCOVE_CITY_HEART_SCALE";
            s_flagDetails[0x210] = "FLAG_HIDDEN_ITEM_FALLARBOR_TOWN_NUGGET";
            s_flagDetails[0x211] = "FLAG_HIDDEN_ITEM_MT_PYRE_EXTERIOR_ULTRA_BALL";
            s_flagDetails[0x212] = "FLAG_HIDDEN_ITEM_ROUTE_113_TM_32";
            s_flagDetails[0x213] = "FLAG_HIDDEN_ITEM_ABANDONED_SHIP_RM_1_KEY";
            s_flagDetails[0x214] = "FLAG_HIDDEN_ITEM_ABANDONED_SHIP_RM_2_KEY";
            s_flagDetails[0x215] = "FLAG_HIDDEN_ITEM_ABANDONED_SHIP_RM_4_KEY";
            s_flagDetails[0x216] = "FLAG_HIDDEN_ITEM_ABANDONED_SHIP_RM_6_KEY";
            s_flagDetails[0x217] = "FLAG_HIDDEN_ITEM_SS_TIDAL_LOWER_DECK_LEFTOVERS";
            s_flagDetails[0x218] = "FLAG_HIDDEN_ITEM_UNDERWATER_124_CALCIUM";
            s_flagDetails[0x219] = "FLAG_HIDDEN_ITEM_ROUTE_104_POTION";
            s_flagDetails[0x21A] = "FLAG_HIDDEN_ITEM_UNDERWATER_124_HEART_SCALE_2";
            s_flagDetails[0x21B] = "FLAG_HIDDEN_ITEM_ROUTE_121_HP_UP";
            s_flagDetails[0x21C] = "FLAG_HIDDEN_ITEM_ROUTE_121_NUGGET";
            s_flagDetails[0x21D] = "FLAG_HIDDEN_ITEM_ROUTE_123_REVIVE";
            s_flagDetails[0x21E] = "FLAG_HIDDEN_ITEM_ROUTE_113_REVIVE";
            s_flagDetails[0x21F] = "FLAG_HIDDEN_ITEM_LILYCOVE_CITY_PP_UP";
            s_flagDetails[0x220] = "FLAG_HIDDEN_ITEM_ROUTE_104_SUPER_POTION";
            s_flagDetails[0x221] = "FLAG_HIDDEN_ITEM_ROUTE_116_SUPER_POTION";
            s_flagDetails[0x222] = "FLAG_HIDDEN_ITEM_ROUTE_106_STARDUST";
            s_flagDetails[0x223] = "FLAG_HIDDEN_ITEM_ROUTE_106_HEART_SCALE";
            s_flagDetails[0x224] = "FLAG_HIDDEN_ITEM_GRANITE_CAVE_B2F_EVERSTONE_1";
            s_flagDetails[0x225] = "FLAG_HIDDEN_ITEM_GRANITE_CAVE_B2F_EVERSTONE_2";
            s_flagDetails[0x226] = "FLAG_HIDDEN_ITEM_ROUTE_109_REVIVE";
            s_flagDetails[0x227] = "FLAG_HIDDEN_ITEM_ROUTE_109_GREAT_BALL";
            s_flagDetails[0x228] = "FLAG_HIDDEN_ITEM_ROUTE_109_HEART_SCALE_1";
            s_flagDetails[0x229] = "FLAG_HIDDEN_ITEM_ROUTE_110_GREAT_BALL";
            s_flagDetails[0x22A] = "FLAG_HIDDEN_ITEM_ROUTE_110_REVIVE";
            s_flagDetails[0x22B] = "FLAG_HIDDEN_ITEM_ROUTE_110_FULL_HEAL";
            s_flagDetails[0x22C] = "FLAG_HIDDEN_ITEM_ROUTE_111_PROTEIN";
            s_flagDetails[0x22D] = "FLAG_HIDDEN_ITEM_ROUTE_111_RARE_CANDY";
            s_flagDetails[0x22E] = "FLAG_HIDDEN_ITEM_PETALBURG_WOODS_POTION";
            s_flagDetails[0x22F] = "FLAG_HIDDEN_ITEM_PETALBURG_WOODS_TINY_MUSHROOM_1";
            s_flagDetails[0x230] = "FLAG_HIDDEN_ITEM_PETALBURG_WOODS_TINY_MUSHROOM_2";
            s_flagDetails[0x231] = "FLAG_HIDDEN_ITEM_PETALBURG_WOODS_POKE_BALL";
            s_flagDetails[0x232] = "FLAG_HIDDEN_ITEM_ROUTE_104_POKE_BALL";
            s_flagDetails[0x233] = "FLAG_HIDDEN_ITEM_ROUTE_106_POKE_BALL";
            s_flagDetails[0x234] = "FLAG_HIDDEN_ITEM_ROUTE_109_ETHER";
            s_flagDetails[0x235] = "FLAG_HIDDEN_ITEM_ROUTE_110_POKE_BALL";
            s_flagDetails[0x236] = "FLAG_HIDDEN_ITEM_ROUTE_118_HEART_SCALE";
            s_flagDetails[0x237] = "FLAG_HIDDEN_ITEM_ROUTE_118_IRON";
            s_flagDetails[0x238] = "FLAG_HIDDEN_ITEM_ROUTE_119_FULL_HEAL";
            s_flagDetails[0x239] = "FLAG_HIDDEN_ITEM_ROUTE_120_RARE_CANDY_2";
            s_flagDetails[0x23A] = "FLAG_HIDDEN_ITEM_ROUTE_120_ZINC";
            s_flagDetails[0x23B] = "FLAG_HIDDEN_ITEM_ROUTE_120_RARE_CANDY_1";
            s_flagDetails[0x23C] = "FLAG_HIDDEN_ITEM_ROUTE_117_REPEL";
            s_flagDetails[0x23D] = "FLAG_HIDDEN_ITEM_ROUTE_121_FULL_HEAL";
            s_flagDetails[0x23E] = "FLAG_HIDDEN_ITEM_ROUTE_123_HYPER_POTION";
            s_flagDetails[0x23F] = "FLAG_HIDDEN_ITEM_LILYCOVE_CITY_POKE_BALL";
            s_flagDetails[0x240] = "FLAG_HIDDEN_ITEM_JAGGED_PASS_GREAT_BALL";
            s_flagDetails[0x241] = "FLAG_HIDDEN_ITEM_JAGGED_PASS_FULL_HEAL";
            s_flagDetails[0x242] = "FLAG_HIDDEN_ITEM_MT_PYRE_EXTERIOR_MAX_ETHER";
            s_flagDetails[0x243] = "FLAG_HIDDEN_ITEM_MT_PYRE_SUMMIT_ZINC";
            s_flagDetails[0x244] = "FLAG_HIDDEN_ITEM_MT_PYRE_SUMMIT_RARE_CANDY";
            s_flagDetails[0x245] = "FLAG_HIDDEN_ITEM_VICTORY_ROAD_1F_ULTRA_BALL";
            s_flagDetails[0x246] = "FLAG_HIDDEN_ITEM_VICTORY_ROAD_B2F_ELIXIR";
            s_flagDetails[0x247] = "FLAG_HIDDEN_ITEM_VICTORY_ROAD_B2F_MAX_REPEL";
            s_flagDetails[0x248] = "FLAG_HIDDEN_ITEM_ROUTE_120_REVIVE";
            s_flagDetails[0x249] = "FLAG_HIDDEN_ITEM_ROUTE_104_ANTIDOTE";
            s_flagDetails[0x24A] = "FLAG_HIDDEN_ITEM_ROUTE_108_RARE_CANDY";
            s_flagDetails[0x24B] = "FLAG_HIDDEN_ITEM_ROUTE_119_MAX_ETHER";
            s_flagDetails[0x24C] = "FLAG_HIDDEN_ITEM_ROUTE_104_HEART_SCALE";
            s_flagDetails[0x24D] = "FLAG_HIDDEN_ITEM_ROUTE_105_HEART_SCALE";
            s_flagDetails[0x24E] = "FLAG_HIDDEN_ITEM_ROUTE_109_HEART_SCALE_2";
            s_flagDetails[0x24F] = "FLAG_HIDDEN_ITEM_ROUTE_109_HEART_SCALE_3";
            s_flagDetails[0x250] = "FLAG_HIDDEN_ITEM_ROUTE_128_HEART_SCALE_1";
            s_flagDetails[0x251] = "FLAG_HIDDEN_ITEM_ROUTE_128_HEART_SCALE_2";
            s_flagDetails[0x252] = "FLAG_HIDDEN_ITEM_ROUTE_128_HEART_SCALE_3";
            s_flagDetails[0x253] = "FLAG_HIDDEN_ITEM_PETALBURG_CITY_RARE_CANDY";
            s_flagDetails[0x254] = "FLAG_HIDDEN_ITEM_ROUTE_116_BLACK_GLASSES";
            s_flagDetails[0x255] = "FLAG_HIDDEN_ITEM_ROUTE_115_HEART_SCALE";
            s_flagDetails[0x256] = "FLAG_HIDDEN_ITEM_ROUTE_113_NUGGET";
            s_flagDetails[0x257] = "FLAG_HIDDEN_ITEM_ROUTE_123_PP_UP";
            s_flagDetails[0x258] = "FLAG_HIDDEN_ITEM_ROUTE_121_MAX_REVIVE";
            s_flagDetails[0x259] = "FLAG_HIDDEN_ITEM_ARTISAN_CAVE_B1F_CALCIUM";
            s_flagDetails[0x25A] = "FLAG_HIDDEN_ITEM_ARTISAN_CAVE_B1F_ZINC";
            s_flagDetails[0x25B] = "FLAG_HIDDEN_ITEM_ARTISAN_CAVE_B1F_PROTEIN";
            s_flagDetails[0x25C] = "FLAG_HIDDEN_ITEM_ARTISAN_CAVE_B1F_IRON";
            s_flagDetails[0x25D] = "FLAG_HIDDEN_ITEM_SAFARI_ZONE_SOUTH_EAST_FULL_RESTORE";
            s_flagDetails[0x25E] = "FLAG_HIDDEN_ITEM_SAFARI_ZONE_NORTH_EAST_RARE_CANDY";
            s_flagDetails[0x25F] = "FLAG_HIDDEN_ITEM_SAFARI_ZONE_NORTH_EAST_ZINC";
            s_flagDetails[0x260] = "FLAG_HIDDEN_ITEM_SAFARI_ZONE_SOUTH_EAST_PP_UP";
            s_flagDetails[0x261] = "FLAG_HIDDEN_ITEM_NAVEL_ROCK_TOP_SACRED_ASH";
            s_flagDetails[0x262] = "FLAG_HIDDEN_ITEM_ROUTE_123_RARE_CANDY";
            s_flagDetails[0x263] = "FLAG_HIDDEN_ITEM_ROUTE_105_BIG_PEARL";

            // Normal items
            s_flagDetails[0x3E8] = "FLAG_ITEM_ROUTE_102_POTION";
            s_flagDetails[0x3E9] = "FLAG_ITEM_ROUTE_116_X_SPECIAL";
            s_flagDetails[0x3EA] = "FLAG_ITEM_ROUTE_104_PP_UP";
            s_flagDetails[0x3EB] = "FLAG_ITEM_ROUTE_105_IRON";
            s_flagDetails[0x3EC] = "FLAG_ITEM_ROUTE_106_PROTEIN";
            s_flagDetails[0x3ED] = "FLAG_ITEM_ROUTE_109_PP_UP";
            s_flagDetails[0x3EE] = "FLAG_ITEM_ROUTE_109_RARE_CANDY";
            s_flagDetails[0x3EF] = "FLAG_ITEM_ROUTE_110_DIRE_HIT";
            s_flagDetails[0x3F0] = "FLAG_ITEM_ROUTE_111_TM_37";
            s_flagDetails[0x3F1] = "FLAG_ITEM_ROUTE_111_STARDUST";
            s_flagDetails[0x3F2] = "FLAG_ITEM_ROUTE_111_HP_UP";
            s_flagDetails[0x3F3] = "FLAG_ITEM_ROUTE_112_NUGGET";
            s_flagDetails[0x3F4] = "FLAG_ITEM_ROUTE_113_MAX_ETHER";
            s_flagDetails[0x3F5] = "FLAG_ITEM_ROUTE_113_SUPER_REPEL";
            s_flagDetails[0x3F6] = "FLAG_ITEM_ROUTE_114_RARE_CANDY";
            s_flagDetails[0x3F7] = "FLAG_ITEM_ROUTE_114_PROTEIN";
            s_flagDetails[0x3F8] = "FLAG_ITEM_ROUTE_115_SUPER_POTION";
            s_flagDetails[0x3F9] = "FLAG_ITEM_ROUTE_115_TM_01";
            s_flagDetails[0x3FA] = "FLAG_ITEM_ROUTE_115_IRON";
            s_flagDetails[0x3FB] = "FLAG_ITEM_ROUTE_116_ETHER";
            s_flagDetails[0x3FC] = "FLAG_ITEM_ROUTE_116_REPEL";
            s_flagDetails[0x3FD] = "FLAG_ITEM_ROUTE_116_HP_UP";
            s_flagDetails[0x3FE] = "FLAG_ITEM_ROUTE_117_GREAT_BALL";
            s_flagDetails[0x3FF] = "FLAG_ITEM_ROUTE_117_REVIVE";
            s_flagDetails[0x400] = "FLAG_ITEM_ROUTE_119_SUPER_REPEL";
            s_flagDetails[0x401] = "FLAG_ITEM_ROUTE_119_ZINC";
            s_flagDetails[0x402] = "FLAG_ITEM_ROUTE_119_ELIXIR_1";
            s_flagDetails[0x403] = "FLAG_ITEM_ROUTE_119_LEAF_STONE";
            s_flagDetails[0x404] = "FLAG_ITEM_ROUTE_119_RARE_CANDY";
            s_flagDetails[0x405] = "FLAG_ITEM_ROUTE_119_HYPER_POTION_1";
            s_flagDetails[0x406] = "FLAG_ITEM_ROUTE_120_NUGGET";
            s_flagDetails[0x407] = "FLAG_ITEM_ROUTE_120_FULL_HEAL";
            s_flagDetails[0x408] = "FLAG_ITEM_ROUTE_123_CALCIUM";
            s_flagDetails[0x409] = "FLAG_ITEM_ROUTE_123_RARE_CANDY";
            s_flagDetails[0x40A] = "FLAG_ITEM_ROUTE_127_ZINC";
            s_flagDetails[0x40B] = "FLAG_ITEM_ROUTE_127_CARBOS";
            s_flagDetails[0x40C] = "FLAG_ITEM_ROUTE_132_RARE_CANDY";
            s_flagDetails[0x40D] = "FLAG_ITEM_ROUTE_133_BIG_PEARL";
            s_flagDetails[0x40E] = "FLAG_ITEM_ROUTE_133_STAR_PIECE";
            s_flagDetails[0x40F] = "FLAG_ITEM_PETALBURG_CITY_MAX_REVIVE";
            s_flagDetails[0x410] = "FLAG_ITEM_PETALBURG_CITY_ETHER";
            s_flagDetails[0x411] = "FLAG_ITEM_RUSTBORO_CITY_X_DEFEND";
            s_flagDetails[0x412] = "FLAG_ITEM_LILYCOVE_CITY_MAX_REPEL";
            s_flagDetails[0x413] = "FLAG_ITEM_MOSSDEEP_CITY_NET_BALL";
            s_flagDetails[0x414] = "FLAG_ITEM_METEOR_FALLS_1F_1R_TM_23";
            s_flagDetails[0x415] = "FLAG_ITEM_METEOR_FALLS_1F_1R_FULL_HEAL";
            s_flagDetails[0x416] = "FLAG_ITEM_METEOR_FALLS_1F_1R_MOON_STONE";
            s_flagDetails[0x417] = "FLAG_ITEM_METEOR_FALLS_1F_1R_PP_UP";
            s_flagDetails[0x418] = "FLAG_ITEM_RUSTURF_TUNNEL_POKE_BALL";
            s_flagDetails[0x419] = "FLAG_ITEM_RUSTURF_TUNNEL_MAX_ETHER";
            s_flagDetails[0x41A] = "FLAG_ITEM_GRANITE_CAVE_1F_ESCAPE_ROPE";
            s_flagDetails[0x41B] = "FLAG_ITEM_GRANITE_CAVE_B1F_POKE_BALL";
            s_flagDetails[0x41C] = "FLAG_ITEM_MT_PYRE_5F_LAX_INCENSE";
            s_flagDetails[0x41D] = "FLAG_ITEM_GRANITE_CAVE_B2F_REPEL";
            s_flagDetails[0x41E] = "FLAG_ITEM_GRANITE_CAVE_B2F_RARE_CANDY";
            s_flagDetails[0x41F] = "FLAG_ITEM_PETALBURG_WOODS_X_ATTACK";
            s_flagDetails[0x420] = "FLAG_ITEM_PETALBURG_WOODS_GREAT_BALL";
            s_flagDetails[0x421] = "FLAG_ITEM_ROUTE_104_POKE_BALL";
            s_flagDetails[0x422] = "FLAG_ITEM_PETALBURG_WOODS_ETHER";
            s_flagDetails[0x423] = "FLAG_ITEM_MAGMA_HIDEOUT_3F_3R_ECAPE_ROPE";
            s_flagDetails[0x424] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_1_ORANGE_MAIL";
            s_flagDetails[0x425] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_2_HARBOR_MAIL";
            s_flagDetails[0x426] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_2_WAVE_MAIL";
            s_flagDetails[0x427] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_3_SHADOW_MAIL";
            s_flagDetails[0x428] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_3_WOOD_MAIL";
            s_flagDetails[0x429] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_4_MECH_MAIL";
            s_flagDetails[0x42A] = "FLAG_ITEM_ROUTE_124_YELLOW_SHARD";
            s_flagDetails[0x42B] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_6_GLITTER_MAIL";
            s_flagDetails[0x42C] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_7_TROPIC_MAIL";
            s_flagDetails[0x42D] = "FLAG_ITEM_TRICK_HOUSE_PUZZLE_8_BEAD_MAIL";
            s_flagDetails[0x42E] = "FLAG_ITEM_JAGGED_PASS_BURN_HEAL";
            s_flagDetails[0x42F] = "FLAG_ITEM_AQUA_HIDEOUT_B1F_MAX_ELIXIR";
            s_flagDetails[0x430] = "FLAG_ITEM_AQUA_HIDEOUT_B2F_NEST_BALL";
            s_flagDetails[0x431] = "FLAG_ITEM_MT_PYRE_EXTERIOR_MAX_POTION";
            s_flagDetails[0x432] = "FLAG_ITEM_MT_PYRE_EXTERIOR_TM_48";
            s_flagDetails[0x433] = "FLAG_ITEM_NEW_MAUVILLE_ULTRA_BALL";
            s_flagDetails[0x434] = "FLAG_ITEM_NEW_MAUVILLE_ESCAPE_ROPE";
            s_flagDetails[0x435] = "FLAG_ITEM_ABANDONED_SHIP_HIDDEN_FLOOR_ROOM_6_LUXURY_BALL";
            s_flagDetails[0x436] = "FLAG_ITEM_ABANDONED_SHIP_HIDDEN_FLOOR_ROOM_4_SCANNER";
            s_flagDetails[0x437] = "FLAG_ITEM_SCORCHED_SLAB_TM_11";
            s_flagDetails[0x438] = "FLAG_ITEM_METEOR_FALLS_B1F_2R_TM_02";
            s_flagDetails[0x439] = "FLAG_ITEM_SHOAL_CAVE_ENTRANCE_BIG_PEARL";
            s_flagDetails[0x43A] = "FLAG_ITEM_SHOAL_CAVE_INNER_ROOM_RARE_CANDY";
            s_flagDetails[0x43B] = "FLAG_ITEM_SHOAL_CAVE_STAIRS_ROOM_ICE_HEAL";
            s_flagDetails[0x43C] = "FLAG_ITEM_VICTORY_ROAD_1F_MAX_ELIXIR";
            s_flagDetails[0x43D] = "FLAG_ITEM_VICTORY_ROAD_1F_PP_UP";
            s_flagDetails[0x43E] = "FLAG_ITEM_VICTORY_ROAD_B1F_TM_29";
            s_flagDetails[0x43F] = "FLAG_ITEM_VICTORY_ROAD_B1F_FULL_RESTORE";
            s_flagDetails[0x440] = "FLAG_ITEM_VICTORY_ROAD_B2F_FULL_HEAL";
            s_flagDetails[0x441] = "FLAG_ITEM_MT_PYRE_6F_TM_30";
            s_flagDetails[0x442] = "FLAG_ITEM_SEAFLOOR_CAVERN_ROOM_9_TM_26";
            s_flagDetails[0x443] = "FLAG_ITEM_FIERY_PATH_TM06";
            s_flagDetails[0x444] = "FLAG_ITEM_ROUTE_124_RED_SHARD";
            s_flagDetails[0x445] = "FLAG_ITEM_ROUTE_124_BLUE_SHARD";
            s_flagDetails[0x446] = "FLAG_ITEM_SAFARI_ZONE_NORTH_WEST_TM_22";
            s_flagDetails[0x447] = "FLAG_ITEM_ABANDONED_SHIP_ROOMS_1F_HARBOR_MAIL";
            s_flagDetails[0x448] = "FLAG_ITEM_ABANDONED_SHIP_ROOMS_B1F_ESCAPE_ROPE";
            s_flagDetails[0x449] = "FLAG_ITEM_ABANDONED_SHIP_ROOMS_2_B1F_DIVE_BALL";
            s_flagDetails[0x44A] = "FLAG_ITEM_ABANDONED_SHIP_ROOMS_B1F_TM_13";
            s_flagDetails[0x44B] = "FLAG_ITEM_ABANDONED_SHIP_ROOMS_2_1F_REVIVE";
            s_flagDetails[0x44C] = "FLAG_ITEM_ABANDONED_SHIP_CAPTAINS_OFFICE_STORAGE_KEY";
            s_flagDetails[0x44D] = "FLAG_ITEM_ABANDONED_SHIP_HIDDEN_FLOOR_ROOM_3_WATER_STONE";
            s_flagDetails[0x44E] = "FLAG_ITEM_ABANDONED_SHIP_HIDDEN_FLOOR_ROOM_1_TM_18";
            s_flagDetails[0x44F] = "FLAG_ITEM_ROUTE_121_CARBOS";
            s_flagDetails[0x450] = "FLAG_ITEM_ROUTE_123_ULTRA_BALL";
            s_flagDetails[0x451] = "FLAG_ITEM_ROUTE_126_GREEN_SHARD";
            s_flagDetails[0x452] = "FLAG_ITEM_ROUTE_119_HYPER_POTION_2";
            s_flagDetails[0x453] = "FLAG_ITEM_ROUTE_120_HYPER_POTION";
            s_flagDetails[0x454] = "FLAG_ITEM_ROUTE_120_NEST_BALL";
            s_flagDetails[0x455] = "FLAG_ITEM_ROUTE_123_ELIXIR";
            s_flagDetails[0x456] = "FLAG_ITEM_NEW_MAUVILLE_THUNDER_STONE";
            s_flagDetails[0x457] = "FLAG_ITEM_FIERY_PATH_FIRE_STONE";
            s_flagDetails[0x458] = "FLAG_ITEM_SHOAL_CAVE_ICE_ROOM_TM_07";
            s_flagDetails[0x459] = "FLAG_ITEM_SHOAL_CAVE_ICE_ROOM_NEVER_MELT_ICE";
            s_flagDetails[0x45A] = "FLAG_ITEM_ROUTE_103_GUARD_SPEC";
            s_flagDetails[0x45B] = "FLAG_ITEM_ROUTE_104_X_ACCURACY";
            s_flagDetails[0x45C] = "FLAG_ITEM_MAUVILLE_CITY_X_SPEED";
            s_flagDetails[0x45D] = "FLAG_ITEM_PETALBURD_WOODS_PARALYZE_HEAL";
            s_flagDetails[0x45E] = "FLAG_ITEM_ROUTE_115_GREAT_BALL";
            s_flagDetails[0x45F] = "FLAG_ITEM_SAFARI_ZONE_NORTH_CALCIUM";
            s_flagDetails[0x460] = "FLAG_ITEM_MT_PYRE_3F_SUPER_REPEL";
            s_flagDetails[0x461] = "FLAG_ITEM_ROUTE_118_HYPER_POTION";
            s_flagDetails[0x462] = "FLAG_ITEM_NEW_MAUVILLE_FULL_HEAL";
            s_flagDetails[0x463] = "FLAG_ITEM_NEW_MAUVILLE_PARALYZE_HEAL";
            s_flagDetails[0x464] = "FLAG_ITEM_AQUA_HIDEOUT_B1F_MASTER_BALL";
            s_flagDetails[0x465] = "FLAG_ITEM_OLD_MAGMA_HIDEOUT_B1F_MASTER_BALL";
            s_flagDetails[0x466] = "FLAG_ITEM_OLD_MAGMA_HIDEOUT_B1F_MAX_ELIXIR";
            s_flagDetails[0x467] = "FLAG_ITEM_OLD_MAGMA_HIDEOUT_B2F_NEST_BALL";
            //s_flagDetails[0x468] = "FLAG_UNUSED_0x468";
            s_flagDetails[0x469] = "FLAG_ITEM_MT_PYRE_2F_ULTRA_BALL";
            s_flagDetails[0x46A] = "FLAG_ITEM_MT_PYRE_4F_SEA_INCENSE";
            s_flagDetails[0x46B] = "FLAG_ITEM_SAFARI_ZONE_SOUTH_WEST_MAX_REVIVE";
            s_flagDetails[0x46C] = "FLAG_ITEM_AQUA_HIDEOUT_B1F_NUGGET";
            s_flagDetails[0x46D] = "FLAG_ITEM_MOSSDEEP_STEVENS_HOUSE_HM08";
            s_flagDetails[0x46E] = "FLAG_ITEM_ROUTE_119_NUGGET";
            s_flagDetails[0x46F] = "FLAG_ITEM_ROUTE_104_POTION";
            //s_flagDetails[0x470] = "FLAG_UNUSED_0x470";
            s_flagDetails[0x471] = "FLAG_ITEM_ROUTE_103_PP_UP";
            //s_flagDetails[0x472] = "FLAG_UNUSED_0x472";
            s_flagDetails[0x473] = "FLAG_ITEM_ROUTE_108_STAR_PIECE";
            s_flagDetails[0x474] = "FLAG_ITEM_ROUTE_109_POTION";
            s_flagDetails[0x475] = "FLAG_ITEM_ROUTE_110_ELIXIR";
            s_flagDetails[0x476] = "FLAG_ITEM_ROUTE_111_ELIXIR";
            s_flagDetails[0x477] = "FLAG_ITEM_ROUTE_113_HYPER_POTION";
            s_flagDetails[0x478] = "FLAG_ITEM_ROUTE_115_HEAL_POWDER";
            //s_flagDetails[0x479] = "FLAG_UNUSED_0x479";
            s_flagDetails[0x47A] = "FLAG_ITEM_ROUTE_116_POTION";
            s_flagDetails[0x47B] = "FLAG_ITEM_ROUTE_119_ELIXIR_2";
            s_flagDetails[0x47C] = "FLAG_ITEM_ROUTE_120_REVIVE";
            s_flagDetails[0x47D] = "FLAG_ITEM_ROUTE_121_REVIVE";
            s_flagDetails[0x47E] = "FLAG_ITEM_ROUTE_121_ZINC";
            s_flagDetails[0x47F] = "FLAG_ITEM_MAGMA_HIDEOUT_1F_RARE_CANDY";
            s_flagDetails[0x480] = "FLAG_ITEM_ROUTE_123_PP_UP";
            s_flagDetails[0x481] = "FLAG_ITEM_ROUTE_123_REVIVAL_HERB";
            s_flagDetails[0x482] = "FLAG_ITEM_ROUTE_125_BIG_PEARL";
            s_flagDetails[0x483] = "FLAG_ITEM_ROUTE_127_RARE_CANDY";
            s_flagDetails[0x484] = "FLAG_ITEM_ROUTE_132_PROTEIN";
            s_flagDetails[0x485] = "FLAG_ITEM_ROUTE_133_MAX_REVIVE";
            s_flagDetails[0x486] = "FLAG_ITEM_ROUTE_134_CARBOS";
            s_flagDetails[0x487] = "FLAG_ITEM_ROUTE_134_STAR_PIECE";
            s_flagDetails[0x488] = "FLAG_ITEM_ROUTE_114_ENERGY_POWDER";
            s_flagDetails[0x489] = "FLAG_ITEM_ROUTE_115_PP_UP";
            s_flagDetails[0x48A] = "FLAG_ITEM_ARTISAN_CAVE_B1F_HP_UP";
            s_flagDetails[0x48B] = "FLAG_ITEM_ARTISAN_CAVE_1F_CARBOS";
            s_flagDetails[0x48C] = "FLAG_ITEM_MAGMA_HIDEOUT_2F_2R_MAX_ELIXIR";
            s_flagDetails[0x48D] = "FLAG_ITEM_MAGMA_HIDEOUT_2F_2R_FULL_RESTORE";
            s_flagDetails[0x48E] = "FLAG_ITEM_MAGMA_HIDEOUT_3F_1R_NUGGET";
            s_flagDetails[0x48F] = "FLAG_ITEM_MAGMA_HIDEOUT_3F_2R_PP_MAX";
            s_flagDetails[0x490] = "FLAG_ITEM_MAGMA_HIDEOUT_4F_MAX_REVIVE";
            s_flagDetails[0x491] = "FLAG_ITEM_SAFARI_ZONE_NORTH_EAST_NUGGET";
            s_flagDetails[0x492] = "FLAG_ITEM_SAFARI_ZONE_SOUTH_EAST_BIG_PEARL";
        }

    }

}
