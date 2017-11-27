; ///////////////////////////////////////////////////////////
; // Graphical Installer for Inno Setup                    //
; // Version 3.9.01 (Radka)                                //
; // Copyright (c) 2011 - 2017 unSigned, s. r. o.          //
; // http://www.graphical-installer.com                    //
; // customers@unsigned.sk                                 //
; // All Rights Reserved.                                  //
; ///////////////////////////////////////////////////////////
 
; *********************************************
; *              Main script file.            *
; ********************************************* 
 
; Script generated with Graphical Installer Wizard.
 
; This identifier is used for compiling script as Graphical Installer powered installer. Comment it out for regular compiling.
#define GRAPHICAL_INSTALLER_PROJECT
 
#ifdef GRAPHICAL_INSTALLER_PROJECT
    ; File with setting for graphical interface
    #include "Script.graphics.iss"
#else
    ; Default UI file
    #define public GraphicalInstallerUI ""
#endif
 
[Setup]
AppName=AumaticScreenSaver
AppVersion=1.0
AppPublisher=Aumatic Sp. z o.o.
CreateAppDir=no
Compression=lzma2
SolidCompression=yes
OutputDir=Output
OutputBaseFilename=ScreenSaver_setup
WizardImageFile=background.bmp
; Directive "WizardSmallImageBackColor" was modified for purposes of Graphical Installer.
WizardSmallImageBackColor={#GraphicalInstallerUI}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "polish"; MessagesFile: "compiler:Languages\Polish.isl"

[Files]
Source: "..\AumaticScreenSaver\bin\AumaticScreenSaver.scr"; DestDir: "{win}"; Flags: ignoreversion
Source: "background.bmp"; Flags: dontcopy
 
[Code]
// Next functions are used for proper working of Graphical Installer powered installer
procedure InitializeWizard();
begin
    #ifdef GRAPHICAL_INSTALLER_PROJECT
    InitGraphicalInstaller();
    #endif
end;
 
procedure CurPageChanged(CurPageID: Integer);
begin
    #ifdef GRAPHICAL_INSTALLER_PROJECT
    PageChangedGraphicalInstaller(CurPageID);
    #endif
end;
 
procedure DeInitializeSetup();
begin
    #ifdef GRAPHICAL_INSTALLER_PROJECT
    DeInitGraphicalInstaller();
    #endif
end;
 
// End of file (EOF)
