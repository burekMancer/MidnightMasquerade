// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MidnightMasquerade : ModuleRules
{
	public MidnightMasquerade(ReadOnlyTargetRules Target) : base(Target)
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
			"MidnightMasquerade",
			"MidnightMasquerade/Variant_Horror",
			"MidnightMasquerade/Variant_Horror/UI",
			"MidnightMasquerade/Variant_Shooter",
			"MidnightMasquerade/Variant_Shooter/AI",
			"MidnightMasquerade/Variant_Shooter/UI",
			"MidnightMasquerade/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
