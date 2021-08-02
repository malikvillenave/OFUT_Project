// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OFUT_Project : ModuleRules
{
	public OFUT_Project(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D" });
	}
}
