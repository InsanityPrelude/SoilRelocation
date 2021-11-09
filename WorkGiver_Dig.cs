﻿using System;
using Verse;
using Verse.AI;
using RimWorld;

namespace SR
{
	public class WorkGiver_Dig : WorkGiver_ConstructAffectFloor
	{
		protected override DesignationDef DesDef
		{
			get
			{
				return DesignationDefOf.SR_Dig;
			}
		}

		public override Job JobOnCell(Pawn pawn, IntVec3 c, bool forced = false)
		{
			return JobMaker.MakeJob(JobDefOf.SR_Dig, c);
		}
	}
}
