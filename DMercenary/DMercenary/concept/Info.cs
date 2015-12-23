
using System;
using System.Collections.Generic;

namespace DMercenary
{
	namespace concept
	{
		public class Description
		{
			protected string name = "";
			protected string info = "";

			public Description (string name, string info)
			{
				this.name = name;
				this.info = info;
			}

			public string Name
			{
				get{return this.name;}
				set{this.name = value;}
			}

			public string Info
			{
				get{return this.info;}
				set{this.info = value;}
			}
		}

		public class Role : Description
		{
			protected Dictionary<string, Skill> skills = new Dictionary<string, Skill>();

			public Role(){}

			public Role(string roleName, string roleInfo)
			{
				this.name = roleName;
				this.info = roleInfo;
			}
		}

		public class Skill : Description
		{
			protected int level = 0;	// current level of this skill
			protected int max = 0;		// max level this skill can reach
			protected CastType castType = CastType.None;				// determine how the skill behave
			protected ImpactType impactType = ImpactType.None;			// 
			protected EffectType effectType = EffectType.None;			//
			protected ParticalType particalType = ParticalType.None;		// 
			protected DamageType damageType = DamageType.None;			//

			public Skill(){}

			public Skill(string skillName, string skillInfo)
			{
				this.name = skillName;
				this.info = skillInfo;
			}
		}

		public enum CastType
		{
			None,
			Instant,
			Progress,
			Channel
		}

		public enum ImpactType
		{
			None,
			SingleHit,
			MultiHit,
			SequentHit,
			AreaWind,
			AreaFog,
			AreaCyclone,
			AreaDrop,
			AreaMatrix
		}

		public enum ParticalType{
			None
		}

		public enum EffectType
		{
			None,
			Paralyse,
			Bleed,
			Repel,					// to knock back
			StrikeShock,			// knock to faint by close combat
			Poison,
			PlantTwine,
			Freeze,					// stop action
			IceConfined,			// into ice
			Burn,					// 
			SandTwine,				// 
			RockConfined,			// into rock
			Petrifaction,			// turn stone
			RockShock,				// knock to faint by rock...
			ElectricShock,			// knock to faint by ranging
			ElectricConfined,		// into electric
			Curse,					//
			Disease,				// 
			Weaken,					// 
			Heal,					// once
			Regain,					// gradually
			Recovery,				// from abnormal(shock, paralyse, freeze)
			Cleanze,				// from abnormal(twine, confined, poison)
			Bind,					// for bleeding
			Cure,					// disease
			Lift					// curse and petrifaction
		}

		public enum DamageType{
			None,
			Heal

		}
	}
}

