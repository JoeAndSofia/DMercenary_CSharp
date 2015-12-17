
using System;

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
			protected int level = 0;	//current level of this skill
			protected int max = 0;		//max level this skill can reach
			protected CastType castType = None;			//determine how the skill behave
			protected ImpactType impactType = None;		//
			protected EffectType effectType = None;		//

			public Skill(){}

			public Skill(string skillName, string skillInfo)
			{
				this.name = skillName;
				this.info = skillInfo;
			}
		}

		public enum CaseType
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
			AreaMatrix,
			Area
		}

		public enum EffectType
		{
			None
		}

		public enum DemangeType{
			None,
			Heal,

		}
	}
}

