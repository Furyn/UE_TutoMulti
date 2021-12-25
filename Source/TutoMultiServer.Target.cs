// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TutoMultiServerTarget : TargetRules //Change this line according to the name of your project
{
    public TutoMultiServerTarget(TargetInfo Target) : base(Target) //Change this line according to the name of your project
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("TutoMulti"); //Change this line according to the name of your project
    }
}