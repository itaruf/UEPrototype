

using UnrealBuildTool;
using System.Collections.Generic;

public class V1PrototypeTarget : TargetRules
{
	public V1PrototypeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "V1Prototype" } );
	}
}
