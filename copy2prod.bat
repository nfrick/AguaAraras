@echo off
set destination="D:\Agua"
robocopy "F:\Users\Nelson\Documents\Visual Studio 2017\Projects\AguaAraras\AguaAraras\bin\Debug" %destination% /XO
pause