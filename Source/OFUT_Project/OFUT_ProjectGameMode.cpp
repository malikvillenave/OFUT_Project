// Copyright Epic Games, Inc. All Rights Reserved.

#include "OFUT_ProjectGameMode.h"
#include "OFUT_ProjectCharacter.h"

AOFUT_ProjectGameMode::AOFUT_ProjectGameMode()
{
	// Set default pawn class to our character
	DefaultPawnClass = AOFUT_ProjectCharacter::StaticClass();	
}
