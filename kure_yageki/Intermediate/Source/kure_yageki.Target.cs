using UnrealBuildTool;

public class kure_yagekiTarget : TargetRules
{
	public kure_yagekiTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("kure_yageki");
	}
}
