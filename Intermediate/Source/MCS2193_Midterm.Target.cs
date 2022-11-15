using UnrealBuildTool;

public class MCS2193_MidtermTarget : TargetRules
{
	public MCS2193_MidtermTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MCS2193_Midterm");
	}
}
