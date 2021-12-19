@echo off
set destination="D:\My Apps\Agua"
robocopy "D:\Users\Nelson Frick\Documents\Projects\Visual Studio\AguaAraras\AguaAraras\bin\Debug" %destination% /XO /S
pause