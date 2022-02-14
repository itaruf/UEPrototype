

using UnrealBuildTool;
using System.Collections.Generic;

public class V1PrototypeEditorTarget : TargetRules
{
	public V1PrototypeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "V1Prototype" } );
	}
}
