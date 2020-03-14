// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ChaosTestEditorTarget : TargetRules
{
	public ChaosTestEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "ChaosTest" } );
		bCompileChaos = true;
		//Note that the following line is not needed for 4.23 or previous versions.
		bUseChaos = true;
	}
}
