@echo off

set xsdpath="C:\Program Files\Microsoft SDKs\Windows\v7.0A\Bin\xsd.exe"
if exist "C:\Program Files (x86)\" goto :x64

if exist "C:\Program Files\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\xsd.exe" (
	set xsdpath="C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\xsd.exe"
)
goto :run

:x64
set xsdpath="C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\x64\xsd.exe"
if exist "C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\x64\xsd.exe" (
	set xsdpath="C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\x64\xsd.exe"
)

:run
REM for /f "delims=" %%a in ('dir *.xsd /b /s') do %xsdpath% %%~nxa /c /eld /l:cs /n:Aliencube.FeedSchemata
%xsdpath% %1 /c /eld /l:cs /n:Aliencube.FeedSchemata.%2
