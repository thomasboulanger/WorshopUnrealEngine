using UnrealBuildTool;

public class LD_IMPLEMENTATIONTarget : TargetRules
{
	public LD_IMPLEMENTATIONTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("LD_IMPLEMENTATION");
	}
}
