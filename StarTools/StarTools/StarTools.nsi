; �ýű�ʹ�� HM VNISEdit �ű��༭���򵼲���
!include x64.nsh

; ��װ�����ʼ���峣��
!define PRODUCT_NAME "StarTools"
!define PRODUCT_VERSION "0.12"
!define PRODUCT_PUBLISHER "HoshinoKun"
!define PRODUCT_WEB_SITE "https://www.346pro.club"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\StarTools.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

SetCompressor lzma

; ------ MUI �ִ����涨�� (1.67 �汾���ϼ���) ------
!include "MUI2.nsh"

; MUI Ԥ���峣��
!define MUI_ABORTWARNING
!define MUI_ICON "StarTools.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; ��ӭҳ��
!insertmacro MUI_PAGE_WELCOME
; ���ѡ��ҳ��
!insertmacro MUI_PAGE_COMPONENTS
; ��װĿ¼ѡ��ҳ��
!insertmacro MUI_PAGE_DIRECTORY
; ��װ����ҳ��
!insertmacro MUI_PAGE_INSTFILES
; ��װ���ҳ��
!define MUI_FINISHPAGE_RUN "$INSTDIR\StarTools.exe"
!insertmacro MUI_PAGE_FINISH

; ��װж�ع���ҳ��
!insertmacro MUI_UNPAGE_INSTFILES

; ��װ�����������������
!insertmacro MUI_LANGUAGE "SimpChinese"

; ��װԤ�ͷ��ļ�
;!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS
; ------ MUI �ִ����涨����� ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Setup.exe"
InstallDir "$PROGRAMFILES64\StarTools"
InstallDirRegKey HKLM "${PRODUCT_UNINST_KEY}" "UninstallString"
ShowInstDetails show
ShowUnInstDetails show

Section "��Ҫ���" SEC01
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

#-- ���� NSIS �ű��༭�������� Function ���α�������� Section ����֮���д���Ա��ⰲװ�������δ��Ԥ֪�����⡣--#

; �����������
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC01} "������������������"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC02} "Intelƽ̨Ӳ��������"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC03} "NVIDIAƽ̨Ӳ��������"
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC04} "AMDƽ̨Ӳ��������"
!insertmacro MUI_FUNCTION_DESCRIPTION_END

/******************************
 *  �����ǰ�װ�����ж�ز���  *
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

#-- ���� NSIS �ű��༭�������� Function ���α�������� Section ����֮���д���Ա��ⰲװ�������δ��Ԥ֪�����⡣--#

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "��ȷʵҪ��ȫ�Ƴ� $(^Name) ���������е������" IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) �ѳɹ��ش���ļ�����Ƴ���"
FunctionEnd
