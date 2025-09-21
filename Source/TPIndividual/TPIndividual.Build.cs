// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TPIndividual : ModuleRules
{
	public TPIndividual(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TPIndividual",
			"TPIndividual/Variant_Platforming",
			"TPIndividual/Variant_Platforming/Animation",
			"TPIndividual/Variant_Combat",
			"TPIndividual/Variant_Combat/AI",
			"TPIndividual/Variant_Combat/Animation",
			"TPIndividual/Variant_Combat/Gameplay",
			"TPIndividual/Variant_Combat/Interfaces",
			"TPIndividual/Variant_Combat/UI",
			"TPIndividual/Variant_SideScrolling",
			"TPIndividual/Variant_SideScrolling/AI",
			"TPIndividual/Variant_SideScrolling/Gameplay",
			"TPIndividual/Variant_SideScrolling/Interfaces",
			"TPIndividual/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
