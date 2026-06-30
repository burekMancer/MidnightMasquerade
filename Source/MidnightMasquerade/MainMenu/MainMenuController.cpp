// Fill out your copyright notice in the Description page of Project Settings.

#include "MainMenuController.h"
#include "Blueprint/UserWidget.h"

void AMainMenuController::BeginPlay()
{
	Super::BeginPlay();

	if (!MainMenuWidgetClass)
	{
		UE_LOG(LogTemp, Warning, TEXT("MainMenuWidgetClass is not assigned KILL YOURSELF"));
		return;
	}
	
	MainMenuWidget = CreateWidget<UUserWidget>(this, MainMenuWidgetClass);

	if (MainMenuWidget)
	{
		MainMenuWidget->AddToViewport();
		
		bShowMouseCursor = true;
		
		FInputModeUIOnly InputMode;
		InputMode.SetWidgetToFocus(MainMenuWidget->TakeWidget());
		InputMode.SetLockMouseToViewportBehavior(EMouseLockMode::DoNotLock);
		SetInputMode(InputMode);
	}
}
