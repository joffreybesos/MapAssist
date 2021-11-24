﻿/**
 *   Copyright (C) 2021 okaygo
 *
 *   https://github.com/misterokaygo/MapAssist/
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 **/

using System.Collections.Generic;
using System.Drawing;

namespace MapAssist.Types
{
    public static class ResistColors
    {
        public static Dictionary<Resist, Color> ResistColor = new Dictionary<Resist, Color>
        {
            {Resist.PHYSICAL, Color.Peru},
            {Resist.MAGIC, Color.OrangeRed},
            {Resist.FIRE, Color.Red},
            {Resist.LIGHTNING, Color.Yellow},
            {Resist.COLD, Color.CornflowerBlue},
            {Resist.POISON, Color.LimeGreen},
        };
    }

    public enum Resist
    {
        PHYSICAL = 0,
        MAGIC = 1,
        FIRE = 2,
        LIGHTNING = 3,
        COLD = 4,
        POISON = 5
    }

    public enum Stat : short
    {
        STAT_INVALID = -1,
        STAT_STRENGTH = 0, // 000
        STAT_ENERGY, // 001
        STAT_DEXTERITY, // 002
        STAT_VITALITY, // 003
        STAT_STATPTS, // 004
        STAT_SKILLPTS, // 005
        STAT_HITPOINTS, // 006
        STAT_MAXHP, // 007
        STAT_MANA, // 008
        STAT_MAXMANA, // 009
        STAT_STAMINA, // 00A
        STAT_MAXSTAMINA, // 00B
        STAT_LEVEL, // 00C
        STAT_EXPERIENCE, // 00D
        STAT_GOLD, // 00E
        STAT_GOLDBANK, // 00F
        STAT_ITEM_ARMOR_PERCENT, // 010
        STAT_ITEM_MAXDAMAGE_PERCENT, // 011
        STAT_ITEM_MINDAMAGE_PERCENT, // 012
        STAT_TOHIT,
        STAT_TOBLOCK,
        STAT_MINDAMAGE,
        STAT_MAXDAMAGE,
        STAT_SECONDARY_MINDAMAGE,
        STAT_SECONDARY_MAXDAMAGE,
        STAT_DAMAGEPERCENT,
        STAT_MANARECOVERY,
        STAT_MANARECOVERYBONUS,
        STAT_STAMINARECOVERYBONUS,
        STAT_LASTEXP,
        STAT_NEXTEXP,
        STAT_ARMORCLASS,
        STAT_ARMORCLASS_VS_MISSILE,
        STAT_ARMORCLASS_VS_HTH,
        STAT_NORMAL_DAMAGE_REDUCTION,
        STAT_MAGIC_DAMAGE_REDUCTION,
        STAT_DAMAGERESIST,
        STAT_MAGICRESIST,
        STAT_MAXMAGICRESIST,
        STAT_FIRERESIST,
        STAT_MAXFIRERESIST,
        STAT_LIGHTRESIST,
        STAT_MAXLIGHTRESIST,
        STAT_COLDRESIST,
        STAT_MAXCOLDRESIST,
        STAT_POISONRESIST,
        STAT_MAXPOISONRESIST,
        STAT_DAMAGEAURA,
        STAT_FIREMINDAM,
        STAT_FIREMAXDAM,
        STAT_LIGHTMINDAM,
        STAT_LIGHTMAXDAM,
        STAT_MAGICMINDAM,
        STAT_MAGICMAXDAM,
        STAT_COLDMINDAM,
        STAT_COLDMAXDAM,
        STAT_COLDLENGTH,
        STAT_POISONMINDAM,
        STAT_POISONMAXDAM,
        STAT_POISONLENGTH,
        STAT_LIFEDRAINMINDAM,
        STAT_LIFEDRAINMAXDAM,
        STAT_MANADRAINMINDAM,
        STAT_MANADRAINMAXDAM,
        STAT_STAMDRAINMINDAM,
        STAT_STAMDRAINMAXDAM,
        STAT_STUNLENGTH,
        STAT_VELOCITYPERCENT,
        STAT_ATTACKRATE,
        STAT_OTHER_ANIMRATE,
        STAT_QUANTITY,
        STAT_VALUE,
        STAT_DURABILITY,
        STAT_MAXDURABILITY,
        STAT_HPREGEN,
        STAT_ITEM_MAXDURABILITY_PERCENT,
        STAT_ITEM_MAXHP_PERCENT,
        STAT_ITEM_MAXMANA_PERCENT,
        STAT_ITEM_ATTACKERTAKESDAMAGE,
        STAT_ITEM_GOLDBONUS,
        STAT_ITEM_MAGICBONUS,
        STAT_ITEM_KNOCKBACK,
        STAT_ITEM_TIMEDURATION,
        STAT_ITEM_ADDCLASSSKILLS,
        STAT_UNSENTPARAM1,
        STAT_ITEM_ADDEXPERIENCE,
        STAT_ITEM_HEALAFTERKILL,
        STAT_ITEM_REDUCEDPRICES,
        STAT_ITEM_DOUBLEHERBDURATION,
        STAT_ITEM_LIGHTRADIUS,
        STAT_ITEM_LIGHTCOLOR,
        STAT_ITEM_REQ_PERCENT,
        STAT_ITEM_LEVELREQ,
        STAT_ITEM_FASTERATTACKRATE,
        STAT_ITEM_LEVELREQPCT,
        STAT_LASTBLOCKFRAME,
        STAT_ITEM_FASTERMOVEVELOCITY,
        STAT_ITEM_NONCLASSSKILL,
        STAT_STATE,
        STAT_ITEM_FASTERGETHITRATE,
        STAT_MONSTER_PLAYERCOUNT,
        STAT_SKILL_POISON_OVERRIDE_LENGTH,
        STAT_ITEM_FASTERBLOCKRATE,
        STAT_SKILL_BYPASS_UNDEAD,
        STAT_SKILL_BYPASS_DEMONS,
        STAT_ITEM_FASTERCASTRATE,
        STAT_SKILL_BYPASS_BEASTS,
        STAT_ITEM_SINGLESKILL,
        STAT_ITEM_RESTINPEACE,
        STAT_CURSE_RESISTANCE,
        STAT_ITEM_POISONLENGTHRESIST,
        STAT_ITEM_NORMALDAMAGE,
        STAT_ITEM_HOWL,
        STAT_ITEM_STUPIDITY,
        STAT_ITEM_DAMAGETOMANA,
        STAT_ITEM_IGNORETARGETAC,
        STAT_ITEM_FRACTIONALTARGETAC,
        STAT_ITEM_PREVENTHEAL,
        STAT_ITEM_HALFFREEZEDURATION,
        STAT_ITEM_TOHIT_PERCENT,
        STAT_ITEM_DAMAGETARGETAC,
        STAT_ITEM_DEMONDAMAGE_PERCENT,
        STAT_ITEM_UNDEADDAMAGE_PERCENT,
        STAT_ITEM_DEMON_TOHIT,
        STAT_ITEM_UNDEAD_TOHIT,
        STAT_ITEM_THROWABLE,
        STAT_ITEM_ELEMSKILL,
        STAT_ITEM_ALLSKILLS,
        STAT_ITEM_ATTACKERTAKESLIGHTDAMAGE,
        STAT_IRONMAIDEN_LEVEL,
        STAT_LIFETAP_LEVEL,
        STAT_THORNS_PERCENT,
        STAT_BONEARMOR,
        STAT_BONEARMORMAX,
        STAT_ITEM_FREEZE,
        STAT_ITEM_OPENWOUNDS,
        STAT_ITEM_CRUSHINGBLOW,
        STAT_ITEM_KICKDAMAGE,
        STAT_ITEM_MANAAFTERKILL,
        STAT_ITEM_HEALAFTERDEMONKILL,
        STAT_ITEM_EXTRABLOOD,
        STAT_ITEM_DEADLYSTRIKE,
        STAT_ITEM_ABSORBFIRE_PERCENT,
        STAT_ITEM_ABSORBFIRE,
        STAT_ITEM_ABSORBLIGHT_PERCENT,
        STAT_ITEM_ABSORBLIGHT,
        STAT_ITEM_ABSORBMAGIC_PERCENT,
        STAT_ITEM_ABSORBMAGIC,
        STAT_ITEM_ABSORBCOLD_PERCENT,
        STAT_ITEM_ABSORBCOLD,
        STAT_ITEM_SLOW,
        STAT_ITEM_AURA,
        STAT_ITEM_INDESCTRUCTIBLE,
        STAT_ITEM_CANNOTBEFROZEN,
        STAT_ITEM_STAMINADRAINPCT,
        STAT_ITEM_REANIMATE,
        STAT_ITEM_PIERCE,
        STAT_ITEM_MAGICARROW,
        STAT_ITEM_EXPLOSIVEARROW,
        STAT_ITEM_THROW_MINDAMAGE,
        STAT_ITEM_THROW_MAXDAMAGE,
        STAT_SKILL_HANDOFATHENA,
        STAT_SKILL_STAMINAPERCENT,
        STAT_SKILL_PASSIVE_STAMINAPERCENT,
        STAT_SKILL_CONCENTRATION,
        STAT_SKILL_ENCHANT,
        STAT_SKILL_PIERCE,
        STAT_SKILL_CONVICTION,
        STAT_SKILL_CHILLINGARMOR,
        STAT_SKILL_FRENZY,
        STAT_SKILL_DECREPIFY,
        STAT_SKILL_ARMOR_PERCENT,
        STAT_ALIGNMENT,
        STAT_TARGET0,
        STAT_TARGET1,
        STAT_GOLDLOST,
        STAT_CONVERSION_LEVEL,
        STAT_CONVERSION_MAXHP,
        STAT_UNIT_DOOVERLAY,
        STAT_ATTACK_VS_MONTYPE,
        STAT_DAMAGE_VS_MONTYPE,
        STAT_FADE,
        STAT_ARMOR_OVERRIDE_PERCENT,
        STAT_UNUSED183,
        STAT_UNUSED184,
        STAT_UNUSED185,
        STAT_UNUSED186,
        STAT_UNUSED187,
        STAT_ITEM_ADDSKILL_TAB,
        STAT_UNUSED189,
        STAT_UNUSED190,
        STAT_UNUSED191,
        STAT_UNUSED192,
        STAT_UNUSED193,
        STAT_ITEM_NUMSOCKETS,
        STAT_ITEM_SKILLONATTACK,
        STAT_ITEM_SKILLONKILL,
        STAT_ITEM_SKILLONDEATH,
        STAT_ITEM_SKILLONHIT,
        STAT_ITEM_SKILLONLEVELUP,
        STAT_UNUSED200,
        STAT_ITEM_SKILLONGETHIT,
        STAT_UNUSED202,
        STAT_UNUSED203,
        STAT_ITEM_CHARGED_SKILL,
        STAT_UNUSED204,
        STAT_UNUSED205,
        STAT_UNUSED206,
        STAT_UNUSED207,
        STAT_UNUSED208,
        STAT_UNUSED209,
        STAT_UNUSED210,
        STAT_UNUSED211,
        STAT_UNUSED212,
        STAT_ITEM_ARMOR_PERLEVEL,
        STAT_ITEM_ARMORPERCENT_PERLEVEL,
        STAT_ITEM_HP_PERLEVEL,
        STAT_ITEM_MANA_PERLEVEL,
        STAT_ITEM_MAXDAMAGE_PERLEVEL,
        STAT_ITEM_MAXDAMAGE_PERCENT_PERLEVEL,
        STAT_ITEM_STRENGTH_PERLEVEL,
        STAT_ITEM_DEXTERITY_PERLEVEL,
        STAT_ITEM_ENERGY_PERLEVEL,
        STAT_ITEM_VITALITY_PERLEVEL,
        STAT_ITEM_TOHIT_PERLEVEL,
        STAT_ITEM_TOHITPERCENT_PERLEVEL,
        STAT_ITEM_COLD_DAMAGEMAX_PERLEVEL,
        STAT_ITEM_FIRE_DAMAGEMAX_PERLEVEL,
        STAT_ITEM_LTNG_DAMAGEMAX_PERLEVEL,
        STAT_ITEM_POIS_DAMAGEMAX_PERLEVEL,
        STAT_ITEM_RESIST_COLD_PERLEVEL,
        STAT_ITEM_RESIST_FIRE_PERLEVEL,
        STAT_ITEM_RESIST_LTNG_PERLEVEL,
        STAT_ITEM_RESIST_POIS_PERLEVEL,
        STAT_ITEM_ABSORB_COLD_PERLEVEL,
        STAT_ITEM_ABSORB_FIRE_PERLEVEL,
        STAT_ITEM_ABSORB_LTNG_PERLEVEL,
        STAT_ITEM_ABSORB_POIS_PERLEVEL,
        STAT_ITEM_THORNS_PERLEVEL,
        STAT_ITEM_FIND_GOLD_PERLEVEL,
        STAT_ITEM_FIND_MAGIC_PERLEVEL,
        STAT_ITEM_REGENSTAMINA_PERLEVEL,
        STAT_ITEM_STAMINA_PERLEVEL,
        STAT_ITEM_DAMAGE_DEMON_PERLEVEL,
        STAT_ITEM_DAMAGE_UNDEAD_PERLEVEL,
        STAT_ITEM_TOHIT_DEMON_PERLEVEL,
        STAT_ITEM_TOHIT_UNDEAD_PERLEVEL,
        STAT_ITEM_CRUSHINGBLOW_PERLEVEL,
        STAT_ITEM_OPENWOUNDS_PERLEVEL,
        STAT_ITEM_KICK_DAMAGE_PERLEVEL,
        STAT_ITEM_DEADLYSTRIKE_PERLEVEL,
        STAT_ITEM_FIND_GEMS_PERLEVEL,
        STAT_ITEM_REPLENISH_DURABILITY,
        STAT_ITEM_REPLENISH_QUANTITY,
        STAT_ITEM_EXTRA_STACK,
        STAT_ITEM_FIND_ITEM,
        STAT_ITEM_SLASH_DAMAGE,
        STAT_ITEM_SLASH_DAMAGE_PERCENT,
        STAT_ITEM_CRUSH_DAMAGE,
        STAT_ITEM_CRUSH_DAMAGE_PERCENT,
        STAT_ITEM_THRUST_DAMAGE,
        STAT_ITEM_THRUST_DAMAGE_PERCENT,
        STAT_ITEM_ABSORB_SLASH,
        STAT_ITEM_ABSORB_CRUSH,
        STAT_ITEM_ABSORB_THRUST,
        STAT_ITEM_ABSORB_SLASH_PERCENT,
        STAT_ITEM_ABSORB_CRUSH_PERCENT,
        STAT_ITEM_ABSORB_THRUST_PERCENT,
        STAT_ITEM_ARMOR_BYTIME,
        STAT_ITEM_ARMORPERCENT_BYTIME,
        STAT_ITEM_HP_BYTIME,
        STAT_ITEM_MANA_BYTIME,
        STAT_ITEM_MAXDAMAGE_BYTIME,
        STAT_ITEM_MAXDAMAGE_PERCENT_BYTIME,
        STAT_ITEM_STRENGTH_BYTIME,
        STAT_ITEM_DEXTERITY_BYTIME,
        STAT_ITEM_ENERGY_BYTIME,
        STAT_ITEM_VITALITY_BYTIME,
        STAT_ITEM_TOHIT_BYTIME,
        STAT_ITEM_TOHITPERCENT_BYTIME,
        STAT_ITEM_COLD_DAMAGEMAX_BYTIME,
        STAT_ITEM_FIRE_DAMAGEMAX_BYTIME,
        STAT_ITEM_LTNG_DAMAGEMAX_BYTIME,
        STAT_ITEM_POIS_DAMAGEMAX_BYTIME,
        STAT_ITEM_RESIST_COLD_BYTIME,
        STAT_ITEM_RESIST_FIRE_BYTIME,
        STAT_ITEM_RESIST_LTNG_BYTIME,
        STAT_ITEM_RESIST_POIS_BYTIME,
        STAT_ITEM_ABSORB_COLD_BYTIME,
        STAT_ITEM_ABSORB_FIRE_BYTIME,
        STAT_ITEM_ABSORB_LTNG_BYTIME,
        STAT_ITEM_ABSORB_POIS_BYTIME,
        STAT_ITEM_FIND_GOLD_BYTIME,
        STAT_ITEM_FIND_MAGIC_BYTIME,
        STAT_ITEM_REGENSTAMINA_BYTIME,
        STAT_ITEM_STAMINA_BYTIME,
        STAT_ITEM_DAMAGE_DEMON_BYTIME,
        STAT_ITEM_DAMAGE_UNDEAD_BYTIME,
        STAT_ITEM_TOHIT_DEMON_BYTIME,
        STAT_ITEM_TOHIT_UNDEAD_BYTIME,
        STAT_ITEM_CRUSHINGBLOW_BYTIME,
        STAT_ITEM_OPENWOUNDS_BYTIME,
        STAT_ITEM_KICK_DAMAGE_BYTIME,
        STAT_ITEM_DEADLYSTRIKE_BYTIME,
        STAT_ITEM_FIND_GEMS_BYTIME,
        STAT_ITEM_PIERCE_COLD,
        STAT_ITEM_PIERCE_FIRE,
        STAT_ITEM_PIERCE_LTNG,
        STAT_ITEM_PIERCE_POIS,
        STAT_ITEM_DAMAGE_VS_MONSTER,
        STAT_ITEM_DAMAGE_PERCENT_VS_MONSTER,
        STAT_ITEM_TOHIT_VS_MONSTER,
        STAT_ITEM_TOHIT_PERCENT_VS_MONSTER,
        STAT_ITEM_AC_VS_MONSTER,
        STAT_ITEM_AC_PERCENT_VS_MONSTER,
        STAT_FIRELENGTH,
        STAT_BURNINGMIN,
        STAT_BURNINGMAX,
        STAT_PROGRESSIVE_DAMAGE,
        STAT_PROGRESSIVE_STEAL,
        STAT_PROGRESSIVE_OTHER,
        STAT_PROGRESSIVE_FIRE,
        STAT_PROGRESSIVE_COLD,
        STAT_PROGRESSIVE_LIGHTNING,
        STAT_ITEM_EXTRA_CHARGES,
        STAT_PROGRESSIVE_TOHIT,
        STAT_POISON_COUNT,
        STAT_DAMAGE_FRAMERATE,
        STAT_PIERCE_IDX,
        STAT_PASSIVE_FIRE_MASTERY,
        STAT_PASSIVE_LTNG_MASTERY,
        STAT_PASSIVE_COLD_MASTERY,
        STAT_PASSIVE_POIS_MASTERY,
        STAT_PASSIVE_FIRE_PIERCE,
        STAT_PASSIVE_LTNG_PIERCE,
        STAT_PASSIVE_COLD_PIERCE,
        STAT_PASSIVE_POIS_PIERCE,
        STAT_PASSIVE_CRITICAL_STRIKE,
        STAT_PASSIVE_DODGE,
        STAT_PASSIVE_AVOID,
        STAT_PASSIVE_EVADE,
        STAT_PASSIVE_WARMTH,
        STAT_PASSIVE_MASTERY_MELEE_TH,
        STAT_PASSIVE_MASTERY_MELEE_DMG,
        STAT_PASSIVE_MASTERY_MELEE_CRIT,
        STAT_PASSIVE_MASTERY_THROW_TH,
        STAT_PASSIVE_MASTERY_THROW_DMG,
        STAT_PASSIVE_MASTERY_THROW_CRIT,
        STAT_PASSIVE_WEAPONBLOCK,
        STAT_PASSIVE_SUMMON_RESIST,
        STAT_MODIFIERLIST_SKILL,
        STAT_MODIFIERLIST_LEVEL,
        STAT_LAST_SENT_HP_PCT,
        STAT_SOURCE_UNIT_TYPE,
        STAT_SOURCE_UNIT_ID,
        STAT_SHORTPARAM1,
        STAT_QUESTITEMDIFFICULTY,
        STAT_PASSIVE_MAG_MASTERY,
        STAT_PASSIVE_MAG_PIERCE,
    };
}