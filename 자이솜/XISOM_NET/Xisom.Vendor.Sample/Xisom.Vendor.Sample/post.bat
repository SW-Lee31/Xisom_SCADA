@ECHO OFF

SET XSCADA_DIR=C:\Xisom\X-SCADA
REM 현재 출력 위치에 있다.
SET OUTPUT_DIR=.

REM ========================================================
REM 자동으로 복사되지 않는 필요한 파일을 복사
REM ========================================================
COPY /Y "%XSCADA_DIR%\license4.hpo" "%OUTPUT_DIR%"
COPY /Y "%XSCADA_DIR%\NAudio.dll" "%OUTPUT_DIR%"
COPY /Y "%XSCADA_DIR%\Xisom.*.dll" "%OUTPUT_DIR%"
DEL  /Q "%OUTPUT_DIR%\Xisom.*.DevEX.dll"
COPY /Y "%XSCADA_DIR%\DocumentFormat.OpenXml.dll" "%OUTPUT_DIR%"
COPY /Y "%XSCADA_DIR%\apidsp_windows.dll" "%OUTPUT_DIR%"
COPY /Y "%XSCADA_DIR%\apidsp_windows_x64.dll" "%OUTPUT_DIR%"
COPY /Y "%XSCADA_DIR%\hasp_net_windows.dll" "%OUTPUT_DIR%"
COPY /Y "%XSCADA_DIR%\hasp_windows_25108.dll" "%OUTPUT_DIR%"
COPY /Y "%XSCADA_DIR%\hasp_windows_x64_25108.dll" "%OUTPUT_DIR%"

IF NOT EXIST "%OUTPUT_DIR%\Drivers"   MKDIR "%OUTPUT_DIR%\Drivers"
XCOPY /S /E /Y "%XSCADA_DIR%\Drivers\*.*"   "%OUTPUT_DIR%\Drivers"

IF NOT EXIST "%OUTPUT_DIR%\Protocols" MKDIR "%OUTPUT_DIR%\Protocols"
XCOPY /S /E /Y "%XSCADA_DIR%\Protocols\*.*" "%OUTPUT_DIR%\Protocols"

IF NOT EXIST "%OUTPUT_DIR%\Views"     MKDIR "%OUTPUT_DIR%\Views"
XCOPY /S /E /Y "%XSCADA_DIR%\Views\*.*"     "%OUTPUT_DIR%\Views"

IF NOT EXIST "%OUTPUT_DIR%\Licenses"   MKDIR "%OUTPUT_DIR%\Licenses"
XCOPY /S /E /Y "%XSCADA_DIR%\Licenses\*.*"   "%OUTPUT_DIR%\Licenses"

