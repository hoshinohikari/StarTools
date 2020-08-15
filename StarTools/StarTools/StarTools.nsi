; 该脚本使用 HM VNISEdit 脚本编辑器向导产生
!include x64.nsh

; 安装程序初始定义常量
!define PRODUCT_NAME "StarTools"
!define PRODUCT_VERSION "0.12"
!define PRODUCT_PUBLISHER "HoshinoKun"
!define PRODUCT_WEB_SITE "https://www.346pro.club"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\StarTools.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

SetCompressor lzma

; ------ MUI 现代界面定义 (1.67 版本以上兼容) ------
!include "MUI2.nsh"

; MUI 预定义常量
!define MUI_ABORTWARNING
!define MUI_ICON "StarTools.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; 欢迎页面
!insertmacro MUI_PAGE_WELCOME
; 组件选择页面
!insertmacro MUI_PAGE_COMPONENTS
; 安装目录选择页面
!insertmacro MUI_PAGE_DIRECTORY
; 安装过程页面
!insertmacro MUI_PAGE_INSTFILES
; 安装完成页面
!define MUI_FINISHPAGE_RUN "$INSTDIR\StarTools.exe"
!insertmacro MUI_PAGE_FINISH

; 安装卸载过程页面
!insertmacro MUI_UNPAGE_INSTFILES

; 安装界面包含的语言设置
!insertmacro MUI_LANGUAGE "SimpChinese"

; 安装预释放文件
;!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS
; ------ MUI 现代界面定义结束 ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Setup.exe"
InstallDir "$PROGRAMFILES64\StarTools"
InstallDirRegKey HKLM "${PRODUCT_UNINST_KEY}" "UninstallString"
ShowInstDetails show
ShowUnInstDetails show

Section "必要组件" SEC01
  SectionIn RO
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer
  File "bin\Release\StarTools.exe"
  CreateDirectory "$SMPROGRAMS\StarTools"
  CreateShortCut "$SMPROGRAMS\StarTools\StarTools.lnk" "$INSTDIR\StarTools.exe"
  CreateShortCut "$DESKTOP\StarTools.lnk" "$INSTDIR\StarTools.exe"
  File "bin\Release\StarTools.exe.Config"
  SetOutPath "$INSTDIR\tool\ffmpeg"
  File "bin\Release\tool\ffmpeg\ffmpeg.exe"
SectionEnd

Section "Intel" SEC02
  SetOutPath "$INSTDIR\tool\HardEnc"
  File "bin\Release\tool\HardEnc\avcodec-58.dll"
  File "bin\Release\tool\HardEnc\avfilter-7.dll"
  File "bin\Release\tool\HardEnc\avformat-58.dll"
  File "bin\Release\tool\HardEnc\avutil-56.dll"
  File "bin\Release\tool\HardEnc\libass-9.dll"
  File "bin\Release\tool\HardEnc\QSVEncC64.exe"
  File "bin\Release\tool\HardEnc\swresample-3.dll"
SectionEnd

Section "Nvidia" SEC03
  SetOutPath "$INSTDIR\tool\HardEnc"
  File "bin\Release\tool\HardEnc\avcodec-58.dll"
  File "bin\Release\tool\HardEnc\avfilter-7.dll"
  File "bin\Release\tool\HardEnc\avformat-58.dll"
  File "bin\Release\tool\HardEnc\avutil-56.dll"
  File "bin\Release\tool\HardEnc\hdr10plus_gen.exe"
  File "bin\Release\tool\HardEnc\libass-9.dll"
  File "bin\Release\tool\HardEnc\NVEncC64.exe"
  File "bin\Release\tool\HardEnc\nvrtc64_101_0.dll"
  File "bin\Release\tool\HardEnc\nvrtc-builtins64_101.dll"
  File "bin\Release\tool\HardEnc\swresample-3.dll"
SectionEnd

Section "AMD" SEC04
  SetOutPath "$INSTDIR\tool\HardEnc"
  File "bin\Release\tool\HardEnc\avcodec-58.dll"
  File "bin\Release\tool\HardEnc\avfilter-7.dll"
  File "bin\Release\tool\HardEnc\avformat-58.dll"
  File "bin\Release\tool\HardEnc\avutil-56.dll"
  File "bin\Release\tool\HardEnc\swresample-3.dll"
  File "bin\Release\tool\HardEnc\VCEEncC64.exe"
SectionEnd

Section -AdditionalIcons
  SetOutPath $INSTDIR
  WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  CreateShortCut "$SMPROGRAMS\StarTools\Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
  CreateShortCut "$SMPROGRAMS\StarTools\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\StarTools.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\StarTools.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd

#-- 根据 NSIS 脚本编辑规则，所有 Function 区段必须放置在 Section 区段之后编写，以避免安装程序出现未可预知的问题。--#

; 区段组件描述
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC01} "程序运行所必须的组件"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC02} "Intel平台硬件编码器"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC03} "NVIDIA平台硬件编码器"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC04} "AMD平台硬件编码器"
!insertmacro MUI_FUNCTION_DESCRIPTION_END

/******************************
 *  以下是安装程序的卸载部分  *
 ******************************/

Section Uninstall
  Delete "$INSTDIR\${PRODUCT_NAME}.url"
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\tool\HardEnc\VCEEncC64.exe"
  Delete "$INSTDIR\tool\HardEnc\NVEncC64.exe"
  Delete "$INSTDIR\tool\HardEnc\QSVEncC64.exe"
  Delete "$INSTDIR\tool\HardEnc\avcodec-58.dll"
  Delete "$INSTDIR\tool\HardEnc\avfilter-7.dll"
  Delete "$INSTDIR\tool\HardEnc\avformat-58.dll"
  Delete "$INSTDIR\tool\HardEnc\avutil-56.dll"
  Delete "$INSTDIR\tool\HardEnc\hdr10plus_gen.exe"
  Delete "$INSTDIR\tool\HardEnc\libass-9.dll"
  Delete "$INSTDIR\tool\HardEnc\nvrtc64_101_0.dll"
  Delete "$INSTDIR\tool\HardEnc\nvrtc-builtins64_101.dll"
  Delete "$INSTDIR\tool\HardEnc\swresample-3.dll"
  Delete "$INSTDIR\tool\ffmpeg\ffmpeg.exe"
  Delete "$INSTDIR\StarTools.exe.Config"
  Delete "$INSTDIR\StarTools.exe"

  Delete "$SMPROGRAMS\StarTools\Uninstall.lnk"
  Delete "$SMPROGRAMS\StarTools\Website.lnk"
  Delete "$DESKTOP\StarTools.lnk"
  Delete "$SMPROGRAMS\StarTools\StarTools.lnk"

  RMDir "$SMPROGRAMS\StarTools"
  RMDir "$INSTDIR\tool\HardEnc"
  RMDir "$INSTDIR\tool\ffmpeg"

  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd

#-- 根据 NSIS 脚本编辑规则，所有 Function 区段必须放置在 Section 区段之后编写，以避免安装程序出现未可预知的问题。--#

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "你确实要完全移除 $(^Name) ，及其所有的组件？" IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) 已成功地从你的计算机移除。"
FunctionEnd
